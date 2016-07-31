using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinDriverDemo.Options
{
    public partial class OptionsFrm : DevExpress.XtraEditors.XtraForm
    {
        public OptionsFrm()
        {
            InitializeComponent();
            defaultSetting();
        }

        private void OptionsFrm_Load(object sender, EventArgs e)
        {

        }
        private void defaultSetting()
        {
            //默认波特率
            this.baudRateComboBox.SelectedItem = "9600";
            //默认不校验
            this.parityComboBox.SelectedIndex = 0;
            //默认数据位设置为8位
            this.dataBitsComboBox.SelectedIndex = 0;
            //默认停止位设置为1位
            this.stopBitsComboBox.SelectedIndex = 0;
            comboHexRecvType.Properties.Items.AddRange(new object[] { "单字节发送", "双字节发送", "四字节发送" });
            comboHexSendType.Properties.Items.AddRange(new object[] { "单字节发送", "双字节发送", "四字节发送" });
            comboHexRecvType.SelectedIndex = 0;
            comboHexSendType.SelectedIndex = 0;
            //checkEditClearRecv.Checked = true;
            checkEditClearSend.Checked = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
#region 高级设置
        public bool GetAuotClearSend()
        {
            return this.checkEditClearSend.Checked;
        }
        public bool GetAuotClearRecv()
        {
            return this.checkEditClearRecv.Checked;
        }
        public string GetSendMode()
        {
            return comboHexSendType.SelectedItem as string;
        }
        public string GetRecvMode()
        {
            return comboHexRecvType.SelectedItem as string;
        }
#endregion
    }
}