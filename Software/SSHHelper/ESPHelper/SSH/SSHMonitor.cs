using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSHHelper;
using System.IO;
namespace ESPHelper.SSH
{    
    public class SSHMonitor
    {
        private SSHExecHelper m_session;
        private string m_host;
        private string m_user;
        private string m_password;

        public SSHMonitor(string host, string user, string password)
        {
            m_host = host;
            m_user = user;
            m_password = password;

            m_session = new SSHExecHelper(host, user, password);
        }
        public bool Connected
        {
            get
            {
                return m_session.Connected;
            }
        }
        /// <summary>
        /// 链接SSH
        /// </summary>
        public void Connect()
        {
            try
            {
                m_session.Connect();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 断开SSH
        /// </summary>
        public void Close()
        {
            try
            {
                m_session.Close();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 获取系统基本信息
        /// </summary>
        /// <returns>返回系统基本信息，包括类型、名称、处理器、内核版本、主机名称</returns>
        public SYS_BASE_INFO GetSysBaseInfo()
        {
            SYS_BASE_INFO info = new SYS_BASE_INFO();
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {
                info.sysType = m_session.RunCmd("uname -o | grep -v \"You\"");
                info.osName = m_session.RunCmd("cat /etc/issue|grep -v \"Kernel\"");
                info.architecture = m_session.RunCmd("uname -m");
                info.kernalRelease = m_session.RunCmd("uname -r");
                info.hostName = m_session.RunCmd("uname -n");
                return info;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 获取网卡信息
        /// </summary>
        /// <returns>返回网卡信息，包括网卡名称、IP和链接状态</returns>
        public SYS_ETH_INFO[] GetEthInfo()
        {            
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {
                string allEth = m_session.RunCmd("ifconfig -a|grep \"eth\\|em\" | awk '{printf $1\"|\"}'");
                string[] ethStr = allEth.Split(new char[] { '|' });
                int ethNum = ethStr.Length-1;
                SYS_ETH_INFO[] info = new SYS_ETH_INFO[ethNum];
                for (int i = 0; i < ethNum;i++ )
                {
                    info[i] = new SYS_ETH_INFO();
                    info[i].ethName = ethStr[i];
                    string cmd = "ifconfig " + info[i].ethName + "|grep \"inet addr\"|awk '{printf $2}'|cut -d \":\" -f 2";
                    info[i].ethIp = m_session.RunCmd(cmd);
                    cmd = "ethtool " + info[i].ethName + "|grep \"Link\"|cut -d \":\" -f 2";
                    string linkStatus = m_session.RunCmd(cmd);
                    if (linkStatus.Contains("yes"))
                    {
                        info[i].linked = true;
                    }
                    else
                    {
                        info[i].linked = false;
                    }
                    if (info[i].ethIp.Length==0)
                    {
                        info[i].ethIp = "None";
                    }
                }             
                return info;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取内存信息
        /// </summary>
        /// <returns>系统的内存信息</returns>
        public SYS_MEM_INFO GetMemInfo()
        {
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {
                SYS_MEM_INFO info = new SYS_MEM_INFO();
                string cmd = "free|grep -v cache|awk '{printf $1$2\":\"$3\"|\"}'";
                string res = m_session.RunCmd(cmd);
                
                foreach(string i in res.Split(new char[] { '|' }))
                {                    
                    if (i.Length==0)
                    {
                        continue;
                    }
                    string []tmp = i.Split(new char[] { ':' });

                    if (i.Contains("Mem"))
                    {
                        info.memTotal = uint.Parse(tmp[1]);
                        info.memUsed = uint.Parse(tmp[2]);
                    }
                    else if (i.Contains("Swap"))
                    {
                        info.swapTotal = uint.Parse(tmp[1]);
                        info.swapUsed = uint.Parse(tmp[2]);
                    }
                }
                
                return info;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public SYS_DISK_INFO[] GetDiskInfo()
        {
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {                
                string cmd = "df -P|grep -vE 'Filesystem|tmpfs'|awk '{printf $1\":\"$2\":\"$3\"|\"}'";
                string res = m_session.RunCmd(cmd);
                string []diskStr = res.Split(new char[] { '|' });
                SYS_DISK_INFO[] info = new SYS_DISK_INFO[diskStr.Length-1];
                for (int i=0;i<diskStr.Length-1;i++)
                {
                    info[i] = new SYS_DISK_INFO();
                    string[] tmp = diskStr[i].Split(new char[] { ':' });
                    info[i].diskName = tmp[0];
                    info[i].totalSize = uint.Parse(tmp[1]);
                    info[i].usedSize = uint.Parse(tmp[2]);
                }

                return info;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取CPU信息
        /// </summary>
        /// <returns></returns>
        public SYS_CPU_INFO GetCPUInfo()
        {
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {
                SYS_CPU_INFO info = new SYS_CPU_INFO();
                string res = m_session.RunCmd("cat /proc/cpuinfo|grep 'model name'|awk 'BEGIN{FS=\":\"}{printf $2\"|\"}'");
                string []name = res.Split('|');
                info.name = name[0];
                info.coreNum = (uint)name.Length-1;
                return info;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取各个CPU使用率
        /// </summary>
        /// <returns>CPU各核使用率，最后一个为平均使用率</returns>
        public uint[] GetCPUPayload()
        {
            if (!m_session.Connected)
            {
                throw new Exception("SSH is not connected.");
            }
            try
            {
                StreamReader sr = new StreamReader(".\\shell\\cpuInfo.sh", System.Text.Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd().ToString();
                sr.Close();
                string res = m_session.RunCmd(content);
                string[] str = res.Split('%');
                uint[] rates = new uint[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    rates[i] = uint.Parse(str[i]);
                }
                return rates;
            }
            catch (System.Exception ex)
            {
                throw;
            }
           
        }
    }
}
