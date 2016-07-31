using System;
using System.Collections.Generic;
using DDS;
using datarouter;

namespace com.hirain.avionics.healthmanager
{
	public class DDSEventControler
	{

	  private const string HMCONF_PROPERTIES_FILE = "hmconf.properties";

	  private const string PROP_PARTITION = "Partition";

	  private const string PROP_DOMAIN = "Domain";

	  private static int domainID = 0;

	  private static string partition = "Event";

	  private static com.hirain.avionics.dds.EventInc eventInc;

	  // private static ReaderListener eventListener;
	  // private static int fStartFlag;

	  private static Dictionary<int?, IEventListener> listenerMap = new Dictionary<int?, IEventListener>();

	  // private static Thread fListenThread;

	  static DDSEventControler()
	  {
		readXML();
	  }

      

	  private static void readXML()
	  {
       
	  }

	  private static void writeXML()
	  {
		
	  }

	  private static com.hirain.avionics.dds.EventInc EventInc
	  {
		  get
		  {
			// readXML();
			if (eventInc == null)
			{
			  eventInc = new com.hirain.avionics.dds.EventInc(domainID, partition);
			}
			return eventInc;
		  }
	  }

	  internal static void init()
	  {
		
	  }

	  internal static void addListener(IEventListener listener)
	  {
		listenerMap[listener.ID] = listener;
	  }

	  internal static void removeListener(int id)
	  {
		listenerMap.Remove(id);
	  }

        internal class EventReaderListener : DDS.DataReaderListener
        {
             public override void OnDataAvailable(IDataReader entityInterface)
        {
            if (entityInterface is datarouter.EVENT_msgDataReader)
            {                
          		  try
          		  {
          			EVENT_msgDataReader dataReader = entityInterface as EVENT_msgDataReader;;
          			EVENT_msg[]  receivedData =null;
          			SampleInfo[] infoSeq = null;
          			ReturnCode rtcode = dataReader.Take(ref receivedData,ref infoSeq,  Length.Unlimited,
                     DDS.SampleStateKind.Any, DDS.ViewStateKind.Any, DDS.InstanceStateKind.Any);
          			if (rtcode == ReturnCode.Ok)
          			{
          			  for (int i = 0; i < receivedData.Length; i++)
		                {
		                  datarouter.EVENT_msg msg = receivedData[i];

		                  if (infoSeq[i].InstanceState == DDS.InstanceStateKind.Alive )
		                  {
                               if (listenerMap.ContainsKey((int)msg.event_id))
                               {
                                   IEventListener listener = listenerMap[(int)msg.event_id];
                                   if (listener != null)
                                   {
                                       listener.handleMsgs(msg);
                                   }
                               }			                
		                  }
		                }
          			}
          			else if (rtcode ==ReturnCode.NoData)
          			{
          
          			}
          			else
          			{
          			  Console.WriteLine("DDS take error!" + rtcode);
          			}
          			dataReader.ReturnLoan(ref receivedData,ref infoSeq);
          		  }
          		  catch (Exception e)
          		  {
                      Console.WriteLine(e.Message);
          			  throw e;
          		  }
                
            }
        }
       
        }
	  internal static int startMonitor()
	  {
		try
		{
		  EventInc.start();

          DDS.Duration dt = new DDS.Duration(5, 0);
		  datarouter.EVENT_msgDataReader dataReader = EventInc.M_EventReader;
		  dataReader.WaitForHistoricalData(dt);
          dataReader.SetListener(new EventReaderListener(),StatusKind.DataAvailable);
//            fStartFlag = 1;
//            fListenThread = new Thread(new Runnable() {
//           
//            @Override
//            public void run() {
//            while (fStartFlag > 0) {
//            try {
//            EVENT_msgDataReader dataReader = getEventInc()
//            .getM_EventReader();
//            EVENT_msgSeqHolder receivedData = new EVENT_msgSeqHolder();
//            SampleInfoSeqHolder infoSeq = new SampleInfoSeqHolder();
//            int rtcode = dataReader.take(receivedData, infoSeq,
//            LENGTH_UNLIMITED.value,
//            ANY_SAMPLE_STATE.value,
//            ANY_VIEW_STATE.value,
//            ALIVE_INSTANCE_STATE.value);
//            if (rtcode == DDS.RETCODE_OK.value) {
//            EVENT_msg[] eventMsgs = receivedData.value;
//            SampleInfo[] samples = infoSeq.value;
//            parseStatus(eventMsgs, samples);
//            } else if (rtcode == DDS.RETCODE_NO_DATA.value) {
//            try {
//            Thread.sleep(1000);
//            } catch (InterruptedException e) {
//            // do nothing
//            }
//            } else {
//            fStartFlag = 0;
//            }
//            dataReader.return_loan(receivedData, infoSeq);
//            } catch (WrapperException e) {
//            e.printStackTrace();
//            fStartFlag = 0;
//            }
//            }
//            }
//            });
          
        //   fListenThread.start();
		  return (int)ReturnCode.Ok;

		}
		catch (com.hirain.avionics.dds.WrapperException e)
		{
		  // e.printStackTrace();
		  return (int)ReturnCode.Ok;
		}
	  }

	  internal static void stopMonitor()
	  {
		try
		{
		  // fStartFlag = 0;
		  // try {
		  // fListenThread.join();
		  // } catch (InterruptedException e) {
		  // e.printStackTrace();
		  // }
		  EventInc.stop();
		  eventInc = null;
		}
		catch (com.hirain.avionics.dds.WrapperException e)
		{
		  Console.WriteLine(e.ToString());
		  Console.Write(e.StackTrace);
		}
	  }

	  internal static int write(datarouter.EVENT_msg msg)
	  {
		try
		{
		  return EventInc.writeEvent(msg);
		}
		catch (com.hirain.avionics.dds.WrapperException e)
		{
		  Console.WriteLine(e.ToString());
		  Console.Write(e.StackTrace);
		  return (int)ReturnCode.Ok;
		}
	  }

	  private static void parseStatus(datarouter.EVENT_msg[] eventMsgs, DDS.SampleInfo[] samples)
	  {
		for (int i = 0; i < eventMsgs.Length; i++)
		{
		  datarouter.EVENT_msg msg = eventMsgs[i];

		  // if (current_time.value.sec - samples[i].source_timestamp.sec > 5)
		  // {
		  // System.out.println("get a overdue message.");
		  // continue;
		  // }
		  if (samples[i].InstanceState == DDS.InstanceStateKind.Alive )
		  {
			IEventListener listener = listenerMap[(int)msg.event_id];
			if (listener != null)
			{
			  listener.handleMsgs(msg);
			}
		  }
		}
	  }

	  internal static datarouter.EVENT_msgDataReader EventReader
	  {
		  get
		  {
			try
			{
			  return EventInc.M_EventReader;
			}
			catch (com.hirain.avionics.dds.WrapperException e)
			{
			  Console.WriteLine(e.ToString());
			  Console.Write(e.StackTrace);
			  return null;
			}
		  }
	  }
	}
    
}