using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.hirain.avionics.dds;
using datarouter;
using DDS;
/*
namespace dds_pt
{
    class Program
    {
        static void Main(string[] args)
        {
            AAMS_429_Inc aams_429 = new AAMS_429_Inc(0, "AAMS_429");
            aams_429.start();
            aams_429.setReaderListener(new com.hirain.avionics.dds.ReaderListener());
            AAMS_429_msg msg429 = new AAMS_429_msg();
            msg429.id = 999;
            msg429.payload = new Payload[1];
            msg429.payload[0] = new Payload();
            msg429.payload[0]._value = 99;
            aams_429.writeAAMS_429(msg429);

            HILInc hilc1 = new HILInc(0, "STIMULATE");
                hilc1.start();
                hilc1.setReaderListener(new com.hirain.avionics.dds.ReaderListener());
                HIL_msg msg = new HIL_msg();
                msg.id = 10;
                msg.length = 1;
                msg.payload = new Payload[1];
                msg.payload[0] = new Payload();
                msg.payload[0]._value = 0;
                while ('q'!=Console.Read())
                {
                    hilc1.writeHIL(msg);
                    HIL_msg[] received_data = null; ;
                    SampleInfo[] info_seq = null;
                    hilc1.M_HILReader.Take(ref received_data, ref info_seq, Length.Unlimited,
                     DDS.SampleStateKind.Any, DDS.ViewStateKind.Any, DDS.InstanceStateKind.Any);
                    if (received_data.Length!=0)
                    {
                        Console.WriteLine("receive: {0} {1}", received_data[0].id, received_data.Length);
                        foreach(Payload payload in received_data[0].payload)
                        {
                            Console.Write("{0} ", payload._value);
                        }
                        Console.WriteLine("");
                    }
                   
                }
                
                hilc1.stop();
        }
    }
}
*/