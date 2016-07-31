using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using com.hirain.avionics.dds.igmp;

namespace com.hirain.avionics.healthmanager.igmp
{
    public class IGMPManager
    {
        private const string DLL_NAME = "IgmpDll_x86";//Environment.Is64BitOperatingSystem ? "IgmpDll_x86_64" : "IgmpDll_x86";
        private static Timer timer;

        private static IList<IGMPAddr> groups = new List<IGMPAddr>();

        [DllImport(DLL_NAME,CallingConvention=CallingConvention.Cdecl)]
        public static extern int join_group(string localAddr, string groupAddr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int leave_group(string localAddr, string groupAddr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dispose_igmp();

        static IGMPManager()
        {
            //DLL_NAME = Environment.Is64BitOperatingSystem ? "IgmpDll_x86_64" : "IgmpDll_x86";
        }

        public static int joinGroup(string localAddr, string groupAddr)
        {
            IGMPAddr addr = new IGMPAddr();
            addr.localAddr = localAddr;
            addr.groupAddr = groupAddr;
            if (!groups.Contains(addr))
            {
                groups.Add(addr);
            }
            return join_group(localAddr, groupAddr);
        }

        public static int leaveGroup(string localAddr, string groupAddr)
        {
            IGMPAddr addr = new IGMPAddr();
            addr.localAddr = localAddr;
            addr.groupAddr = groupAddr;
            groups.Remove(addr);
            return 0;
        }
        static void Excute(object obj)
        {
            foreach (IGMPAddr addr in groups)
            {
                int ret = joinGroup(addr.localAddr, addr.groupAddr);
                if (ret != 0)
                {
                    Console.WriteLine("join group error.");
                    int cc = 0;
                    while (cc++ < 100)
                    {
                        try
                        {
                            ret = joinGroup(addr.localAddr, addr.groupAddr);
                            if (ret != 0)
                            {
                                Console.WriteLine("join group error.");
                            }
                            else
                            {
                                break;
                            }
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }


        }
        public static void start()
        {
            if (timer == null)
            {
                timer = new System.Threading.Timer(Excute, null, 0, 200000);
            }
        }

        public static void stop()
        {
            if (timer != null)
            {
                timer.Dispose();
                timer = null;
            }
            dispose_igmp();
        }
    }

}