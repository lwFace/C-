using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESPHelper.SSH;
using ESPHelper.Plugin;
using DevExpress.Utils;
using SSHHelper;
using System.Diagnostics;

namespace ESPHelper
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        private string m_userName;
        private string m_ipAddr;
        private string m_password;
        public SSHMonitor m_monitor;
        public LoginFrm m_loginFrm = new LoginFrm();
        System.Timers.Timer m_monitorTimer = null; 
        public MainFrm()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            m_monitorTimer = new System.Timers.Timer(1000);
            m_monitorTimer.Elapsed += new System.Timers.ElapsedEventHandler(ThreadMonitor);//到达时间的时候执行事件
            m_monitorTimer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)
        }
        /// <summary>
        /// 监控视图按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barMonitorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string binStr = "SSHConsole.exe";
            string cmdStr = string.Format("{0} {1} {2}", m_ipAddr, m_userName, m_password);
            Process exep = new Process();
            exep.StartInfo.FileName = binStr;
            exep.StartInfo.Arguments = cmdStr;
            exep.StartInfo.CreateNoWindow = false;
            exep.StartInfo.UseShellExecute = false;
            exep.Start();
           // exep.WaitForExit();//关键，等待外部程序退出后才能往下执行
           /* if (m_monitor==null||!m_monitor.Connected)
            {             
            
                return;
            }
            try
            {
                monitorView.Show();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            
        }

        /// <summary>
        /// 登陆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLoginBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.OK == m_loginFrm.ShowDialog())
            {                
                this.m_userName = m_loginFrm.userName;
                this.m_password = m_loginFrm.password;
                this.m_ipAddr = m_loginFrm.ipAddr;
                logControl.LogInfo("Connect to " + m_ipAddr + "...");
                try
                {
                    m_monitor = new SSHMonitor(m_ipAddr, m_userName, m_password);
                    using(new WaitDialogForm("Connecting to "+m_ipAddr+" ...", "Wait......"))
                    {
                        m_monitor.Connect();
                    }
                    
                }
                catch (System.Exception ex)
                {
                    m_monitor = null;                  
                    LogHelper.WriteLog(typeof(MainFrm), ex);
                    logControl.LogError("Connect to " + m_ipAddr + " failed.");
                    return;
                }
                logControl.LogInfo("Connect to " + m_ipAddr + " success.");
                barLoginBtn.Enabled = false;
                barLogoutBtn.Enabled = true;
                this.Text = "ESPHelper - " + m_ipAddr;
                this.statusConnect.Caption = "Connected : " + m_ipAddr;
                LogHelper.WriteLog(typeof(MainFrm), "User in success.IP:"+m_ipAddr);

                try
                {
                    GetSystemBasicInfo();

                    m_monitorTimer.Enabled = true;
                    
                }
                catch (System.Exception ex)
                {
                    logControl.LogInfo("Get system information failed.");
                    LogHelper.WriteLog(typeof(MainFrm), ex);
                }
               
            }
        }
        /// <summary>
        /// 获取下位机系统信息，并更新到树控件
        /// </summary>
        public void GetSystemBasicInfo()
        {
            try
            {
                SYS_BASE_INFO baseInfo = m_monitor.GetSysBaseInfo();
                SYS_ETH_INFO[] ethInfo = m_monitor.GetEthInfo();
                SYS_MEM_INFO memInfo = m_monitor.GetMemInfo();
                SYS_DISK_INFO[] diskInfo = m_monitor.GetDiskInfo();
                SYS_CPU_INFO cpuInfo = m_monitor.GetCPUInfo();
                uint[] cpuRates = m_monitor.GetCPUPayload();
                monitorView.UpdateData(baseInfo, memInfo, ethInfo, diskInfo, cpuInfo, cpuRates);
            }
            catch (Exception ex)
            {
                logControl.LogError("Get system information failed.");
                LogHelper.WriteLog(typeof(MainFrm), ex);
            }
        }

        /// <summary>
        /// 登出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barLogoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_monitorTimer.Enabled = false;//关闭定时器
            m_monitor.Close();
            barLoginBtn.Enabled = true;
            barLogoutBtn.Enabled = false;
            this.Text = "ESPHelper - Not login" ;
            this.statusConnect.Caption = "Disconnected";
            logControl.LogInfo("User logout sucess.");
            LogHelper.WriteLog(typeof(MainFrm),"User logout success.");
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_monitor!=null && m_monitor.Connected)
            {
                m_monitor.Close();
            }
        }

        /// <summary>
        /// 系统监控线程
        /// </summary>
        /// <param name="obj"></param>
        public void ThreadMonitor(object source, System.Timers.ElapsedEventArgs e)
        {
           // logControl.LogInfo("Timer.");
        }
    }
}
