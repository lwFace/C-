using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System; 
using System.Runtime.Remoting; 
using System.Runtime.Remoting.Channels; 
using Ch.Elca.Iiop; 
using Ch.Elca.Iiop.Services; 
using omg.org.CosNaming;
using aams.store; 

namespace Test.example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 建立并注册IIOP通道，与服务器corba进行通信 
                IiopClientChannel channel = new IiopClientChannel();
                ChannelServices.RegisterChannel(channel, false);
                //本地corba初始化 
                CorbaInit init = CorbaInit.GetInit();
                string iorFilePath = @"D:\Hirain\HRP1467\02_Code\HiStorage_Win\bin\ior.txt";
                if(System.IO.File.Exists(iorFilePath))
                {
                    //ior文件中内容，也可从ior文件中读取 
                    string ior = System.IO.File.ReadAllText(iorFilePath);
                    //string ior = "IOR:010000001300000049444c3a546573742f48656c6c6f3a312e300000030000000000000050000000010102000f0000003136392e3235342e3136302e34370000562500001b00000014010f0052535470ec525653e70d00000000000100000001000000000100000000000000080000000100c900004f4154000000004c000000010102000e0000003136392e3235342e332e3235310056251b00000014010f0052535470ec525653e70d00000000000100000001000000010100000000000000080000000100c900004f4154000000004c000000010102000d00000031302e31302e31372e323338000056251b00000014010f0052535470ec525653e70d00000000000100000001000000010100000000000000080000000100c900004f4154";
                    //根据ior字符串获取对方服务 
                    try
                    {
                        Storage mz = (Storage)RemotingServices.Connect(typeof(Storage), ior);
                        core.StatusInfo info = new core.StatusInfo();
                        mz.getServerStatus(out info);
                        System.Console.WriteLine(info.targetStatus.statusMsg);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("exception: " + e);
                    }                    
                }
                else
                {

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("exception: " + e);
            }
        }
    }
} 
