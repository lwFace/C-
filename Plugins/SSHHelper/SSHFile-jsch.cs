using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;
using Tamir.SharpSsh.jsch;
using System.Collections;

namespace SSHHelper
{
    enum SSH_PROTOCAL
    {
        SCP = "SCP", SFTP = "SFTP"
    }
    enum SSH_TRANS_DIRECTION
    {
        TX, RX
    }
    class SSHFile
    {
        private string m_host;
        private string m_user;
        private string m_password;
        private Session m_session;
        private Channel m_channel;
        private ChannelSftp m_sftp;

        public SSH_TRANS_DIRECTION Direction;
        public SSH_PROTOCAL Protocal;

       
        public bool Connected
        {
            get
            {
                return m_session.isConnected();
            }
        }
        public string FileRemote;
        public string FileLocal;

        public SSHFile(string host, string user, string password)
        {
            m_host = host;
            m_user = user;
            m_password = password;

            string[] arr = host.Split(':');
            string ip = arr[0];
            int port = 22;
            JSch jsch = new JSch();
            m_session = jsch.getSession(m_user, m_host, port);
        }

        /// <summary>
        /// 指令执行链接
        /// </summary>
        public void Connect()
        {
            try
            {
                if (!Connected)
                {
                    m_session.connect();
                    m_channel = m_session.openChannel("sftp");
                    m_channel.connect();
                    m_sftp = (ChannelSftp)m_channel;
                }

            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        //SFTP存放文件
        public bool Put(string localPath, string remotePath)
        {
            try
            {
                Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(localPath);
                Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(remotePath);
                m_sftp.put(src, dst);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //SFTP获取文件
        public bool Get(string remotePath, string localPath)
        {
            try
            {
                Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(remotePath);
                Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(localPath);
                m_sftp.get(src, dst);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //删除SFTP文件
        public bool Delete(string remoteFile)
        {
            try
            {
                m_sftp.rm(remoteFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //获取SFTP文件列表
        public ArrayList GetFileList(string remotePath, string fileType)
        {
            try
            {
                Tamir.SharpSsh.java.util.Vector vvv = m_sftp.ls(remotePath);
                ArrayList objList = new ArrayList();
                foreach (Tamir.SharpSsh.jsch.ChannelSftp.LsEntry qqq in vvv)
                {
                    string sss = qqq.getFilename();
                    if (sss.Length > (fileType.Length + 1) && fileType == sss.Substring(sss.Length - fileType.Length))
                    { objList.Add(sss); }
                    else { continue; }
                }

                return objList;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 指令执行关闭
        /// </summary>
        public void Close()
        {
            try
            {
                if (Connected)
                {
                    m_channel.disconnect();
                    m_session.disconnect();
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
      
    }
}
