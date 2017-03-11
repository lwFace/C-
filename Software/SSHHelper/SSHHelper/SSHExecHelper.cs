using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;

namespace SSHHelper
{
    public class SSHExecHelper
    {
        private string m_host;
        private string m_user;
        private string m_password;
        SshExec m_exec;
        public bool Connected
        {
            get
            {
                return m_exec.Connected;
            }
        }
       public SSHExecHelper(string host, string user, string password)
        {
            m_host = host;
            m_user = user;
            m_password = password;

            m_exec = new SshExec(host, user);
            m_exec.Password = m_password;            
        }
        /// <summary>
        /// 指令执行链接
        /// </summary>
        public void Connect()
        {
            try
            {
                m_exec.Connect();                
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 运行指令
        /// </summary>
        /// <param name="cmd">要运行的指令</param>
        /// <returns></returns>
        public string RunCmd(string cmd)
        {
            try
            {
                return m_exec.RunCommand(cmd);
            }
            catch (System.Exception ex)
            {
                throw;
            }

        }
        /// <summary>
        /// 指令执行关闭
        /// </summary>
        public void Close()
        {
            try
            {
                m_exec.Close();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

    }
}
