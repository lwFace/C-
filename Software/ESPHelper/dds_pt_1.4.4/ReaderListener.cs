using DDS;
using DDS.OpenSplice;
using System;
using datarouter;

namespace com.hirain.avionics.dds
{
    /// <summary>
    /// Reader Listener适配类，应用程序可继承此类并实现方法{@code on_data_available(IDataReader)}用于监听DDS数据�?
    /// </summary>
    /// <seealso cref= IDataReaderListener#on_data_available(IDataReader)
    /// @author jialun.liu </seealso>
    public class ReaderListener : DDS.DataReaderListener
    {
        public override void OnDataAvailable(IDataReader entityInterface)
        {
            if (entityInterface is datarouter.HIL_msgDataReader)
            {
                HIL_msg[] received_data = null; ;
                SampleInfo[] info_seq = null;
                HIL_msgDataReader reader = entityInterface as HIL_msgDataReader;
                reader.Take(ref received_data, ref info_seq, Length.Unlimited,
                 DDS.SampleStateKind.Any, DDS.ViewStateKind.Any, DDS.InstanceStateKind.Any);
                Console.WriteLine("Reveived Hil msg");
            }           
        }
        public override void OnLivelinessChanged(DDS.IDataReader arg0, DDS.LivelinessChangedStatus arg1)
        {

        }

        public override  void OnRequestedDeadlineMissed(DDS.IDataReader arg0, DDS.RequestedDeadlineMissedStatus arg1)
        {

        }

        public override void OnRequestedIncompatibleQos(DDS.IDataReader arg0, DDS.RequestedIncompatibleQosStatus arg1)
        {

        }

        public void OnSampleLost(DDS.IDataReader arg0, DDS.SampleLostStatus arg1)
        {

        }

        public void OnSampleRejected(DDS.IDataReader arg0, DDS.SampleRejectedStatus arg1)
        {

        }

        public void OnSubscriptionMatched(DDS.IDataReader arg0, DDS.SubscriptionMatchedStatus arg1)
        {

        }

    }

}