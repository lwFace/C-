using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.hirain.avionics.healthmanager.dds.service;
using com.hirain.avionics.healthmanager;
using System.Threading;
namespace HealthManager1
{
    class Program
    {
        static void Main(string[] args)
        {

            com.hirain.avionics.healthmanager.HealthManager hm = new com.hirain.avionics.healthmanager.HealthManager(com.hirain.avionics.healthmanager.HealthManager.NEW_STYLE_CARD_CONTROL);
            hm.startDDS();
            int c = 1;
            while (c > 0)
            {
                com.hirain.avionics.healthmanager.dds.IDDSData[] ddsData = hm.getDDSData(com.hirain.avionics.healthmanager.HealthManager.NEW_STYLE_CARD_CONTROL);
                if (ddsData.Length == 0)
                {
                    Console.WriteLine("no server.");
                }
                foreach (com.hirain.avionics.healthmanager.dds.IDDSData data in ddsData)
                {
                    ServiceDDSData sdd = (ServiceDDSData)data;
                    Console.WriteLine("id:" + sdd.Id);
                    Console.WriteLine("name:" + sdd.Name);
                    Console.WriteLine("type:" + sdd.Type);
                    Console.WriteLine("time:" + sdd.Time);
                    Console.WriteLine("status:" + sdd.Status);
                    Console.WriteLine("statusMsg:" + sdd.StatusMsg);
                    Console.WriteLine("version:" + sdd.Version);
                    Console.WriteLine("IOR:" + sdd.Ior);
                    foreach (string config in sdd.Configs)
                    {
                        Console.WriteLine("config:" + config);
                    }
                    for (int i = 0; i < sdd.FaultDevices.Length; i++)
                    {
                        Console.WriteLine("fault dev:" + sdd.FaultDevices[i]);
                    }
                    foreach (DeviceDDSData dev in sdd.Devices)
                    {
                        Console.WriteLine("Device=============1");
                        Console.WriteLine("id:" + dev.Id);
                        Console.WriteLine("type:" + dev.Type);
                        Console.WriteLine("status:" + dev.Status);
                        Console.WriteLine("statusMsg:" + dev.StatusMsg);
                        // for (Object port : dev.getPorts()) {
                        // System.out.println("Port+++++++++++++++1");
                        // PortInfo_A429Collector p = (PortInfo_A429Collector) port;
                        // System.out.println("id:" + p.getId());
                        // System.out.println("onoff:" + p.isOnoff());
                        // System.out.println("count:" + p.getCount());
                        // System.out.println("aams:" + p.isAams());
                        // System.out.println("sil:" + p.isSil());
                        // System.out.println("Port+++++++++++++++2");
                        // }
                        // for (Object port : dev.getPorts()) {
                        // PortInfo_AFDXCollector p = (PortInfo_AFDXCollector) port;
                        // System.out.println("id:" + p.getId());
                        // System.out.println("connect:" + p.isConnect());
                        // System.out.println("onoff:" + p.isOnoff());
                        // System.out.println("count:" + p.getCount());
                        // }
                        Console.WriteLine("Device=============2");
                    }
                }
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.Write(e.StackTrace);
                }
            }
            hm.stopDDS();
        }
    }

}
