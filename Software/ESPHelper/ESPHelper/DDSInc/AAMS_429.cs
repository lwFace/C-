using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datarouter;
using com.hirain.avionics.dds;
using System.ComponentModel;
using DDS;

namespace ESPHelper.DDSInc
{
    public class AAMS_429
    {
        public static Dictionary<uint, BindingList<AAMS429Msg>> gridDataDictionary = new Dictionary<uint, BindingList<AAMS429Msg>>();
        private int m_domain;
        private string m_partition;
        AAMS_429_Inc m_handle;
        public static object Lock = new object();
        public AAMS_429(int domain, string partition)
        {
            m_domain = domain;
            m_partition = partition;
            m_handle = new AAMS_429_Inc(domain, m_partition);
            
        }

        static public void Clear(uint chnSN)
        {
            if (gridDataDictionary.ContainsKey(chnSN))
            {
                gridDataDictionary[chnSN].Clear();
            }
        }

        public void Start()
        {
            m_handle.start();
            m_handle.setReaderListener(new DataListener());
        }

        public void Stop()
        {
            m_handle.stop();
        }
        public static void AddChannel(uint sn)
        {
            if (!gridDataDictionary.ContainsKey(sn))
            {
                BindingList<AAMS429Msg> list = new BindingList<AAMS429Msg>();
                gridDataDictionary.Add(sn, list);
            }
        }
        internal class DataListener: DDS.DataReaderListener
        {
            public override void OnDataAvailable(IDataReader entityInterface)
            {
                if (entityInterface is datarouter.AAMS_429_ChannelDataReader)
                {
                    AAMS_429_Channel[] recvData = null; ;
                    SampleInfo[] info_seq = null;
                    AAMS_429_ChannelDataReader reader = entityInterface as AAMS_429_ChannelDataReader;
                    reader.Take(ref recvData, ref info_seq, Length.Unlimited,
                     DDS.SampleStateKind.Any, DDS.ViewStateKind.Any, DDS.InstanceStateKind.Any);

                    foreach (AAMS_429_Channel chnMsg in recvData)
                    {
                        AddChannel(chnMsg.id);
                        BindingList<AAMS429Msg> gridDataList = gridDataDictionary[chnMsg.id];
                        foreach (AAMS_429_msg msg in chnMsg.msgs)
                        {
                            AAMS429Msg hMsg = new AAMS429Msg(msg);
                            hMsg.SN = chnMsg.id;
                            hMsg.Time = DateTime.Now.TimeOfDay;
                             if (gridDataList.Count == 0)
                             {
                                 hMsg.DTime = 0;
                             }
                             else
                             {
                                 hMsg.DTime = (int)((TimeSpan)hMsg.Time.Subtract(gridDataList[gridDataList.Count - 1].Time)).TotalMilliseconds; ;
                             }

                             lock (Lock)
                             {
                                 gridDataList.Add(hMsg);
                             }
                        }
                       
                    }
                    reader.ReturnLoan(ref recvData, ref info_seq);
                }
            }
        }//end internal class
    }
}
