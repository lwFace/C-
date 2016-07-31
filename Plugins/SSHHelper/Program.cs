using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSHHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "192.168.1.100";
            string user = "root";
            string password = "123456";
           // SSHExecHelper ssh = new SSHExecHelper(host, user, password);
            SSHShell ssh = new SSHShell(host, user, password);
            try
            {
                ssh.Connect();
                while (ssh.ShellOpened)
                {
                    System.Threading.Thread.Sleep(500);
                }

                //string res = ssh.RunCmd("df -h");
               // Console.WriteLine(res);
                ssh.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
