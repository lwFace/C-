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
    public class HIL
    {
        public static BindingList<HilMsg> gridDataList = new BindingList<HilMsg>();
        private int m_domain;
        private string m_partition;
        HILInc m_handle;
        public static object Lock = new object();
        public HIL(int domain,string partition)
        {
            m_domain = domain;
            m_partition = partition;
            m_handle = new HILInc(domain, m_partition);
        }

        static public void Clear()
        {
            gridDataList.Clear();
        }

        public void Start()
        {
            m_handle.start();
            m_handle.setReaderListener(new HIL.DataListener());
        }

        public void Stop()
        {
            m_handle.stop();
        }
        internal class DataListener: DDS.DataReaderListener
        {
            public override void OnDataAvailable(IDataReader entityInterface)
            {
                if (entityInterface is datarouter.HIL_msgDataReader)
                {
                    HIL_msg[] recvData = null; ;
                    SampleInfo[] info_seq = null;
                    HIL_msgDataReader reader = entityInterface as HIL_msgDataReader;
                    reader.Take(ref recvData, ref info_seq, Length.Unlimited,
                     DDS.SampleStateKind.Any, DDS.ViewStateKind.Any, DDS.InstanceStateKind.Any);
                    
                    foreach (HIL_msg msg in recvData)
                    {
                        HilMsg hMsg = new HilMsg(msg);
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
                    reader.ReturnLoan(ref recvData, ref info_seq);
                }
            }
        }//end internal class
    }
}
