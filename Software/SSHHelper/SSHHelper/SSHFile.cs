using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;

namespace SSHHelper
{
    public enum SSH_PROTOCAL{
        SCP,SFTP
    }
    public enum SSH_TRANS_DIRECTION
    {
        TX,RX
    }
    public class SSHFile
    {
        SshTransferProtocolBase m_exec;
        private string m_host;
        private string m_user;
        private string m_password;


        public SSH_TRANS_DIRECTION Direction;
        public SSH_PROTOCAL Protocal;

        public FileTransferEvent OnTransferStart
        {
            set
            {
                m_exec.OnTransferStart += value;
            }
        }
        public FileTransferEvent OnTransferProgress
        {
            set
            {
                m_exec.OnTransferProgress += value;
            }
        }
        public FileTransferEvent OnTransferEnd
        {
            set
            {
                m_exec.OnTransferEnd += value;
            }
        }
        public bool Connected
        {
            get
            {
                return m_exec.Connected;
            }
         }
        public string FileRemote;
        public string FileLocal;

        public SSHFile(string host, string user, string password)
        {
            m_host = host;
            m_user = user;
            m_password = password;      
        }
       
        /// <summary>
        /// 指令执行链接
        /// </summary>
        public void Connect()
        {
            try
            {
                if (Protocal == SSH_PROTOCAL.SCP)
                {
                    m_exec = new Scp(m_host, m_user);
                }
                else
                {
                    m_exec = new Sftp(m_host, m_user);
                }
                m_exec.Password = m_password;
                m_exec.Connect();                
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        public void StartTransfer(string lfile,string rfile)
        {
            if (Direction==SSH_TRANS_DIRECTION.TX)
            {
                m_exec.Put(lfile, rfile);
            }
            else
            {
                m_exec.Get(rfile,lfile);
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
