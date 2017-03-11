using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;

namespace SSHHelper
{
    public class SSHShell
    {
            private SshShell m_shell;
            private string m_host;
            private string m_user;
            private string m_password;
            public bool ShellOpened
            {
                get{return m_shell.ShellOpened;}
            }
            public bool Connected
            {
                get
                {
                    return m_shell.Connected;
                }
            }

            public SSHShell(string host, string user, string password)
            {
                m_host = host;
                m_user = user;
                m_password = password;
                m_shell = new SshShell(host, user);
                m_shell.Password = m_password;
                m_shell.ExpectPattern = "#";
                m_shell.RemoveTerminalEmulationCharacters = true;
            }
            /// <summary>
            /// 指令执行链接
            /// </summary>
            public void Connect()
            {
                try
                {
                    m_shell.RedirectToConsole();
                    m_shell.Connect();
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
                    m_shell.Close();
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
    }
}
