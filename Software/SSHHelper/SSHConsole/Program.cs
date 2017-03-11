using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSHHelper;

namespace SSHConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start to connect to " + args[0]);
          
          
            try
            {
                SSHShell ssh = new SSHShell(args[0], args[1], args[2]);
                ssh.Connect();
                while (ssh.ShellOpened)
                {
                    System.Threading.Thread.Sleep(500);
                }

                ssh.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
