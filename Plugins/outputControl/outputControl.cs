using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace outputControl
{
    public partial class outputControl : DevExpress.XtraEditors.XtraUserControl
    {
        public outputControl()
        {
            InitializeComponent();
            outputStr.ForeColor = System.Drawing.Color.Blue;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Clear()
        {
            outputStr.Text = "";
        }

        public void LogInfo(string msg)
        {
            try
            {
                this.outputStr.ForeColor = Color.Blue;
                string t = DateTime.Now.ToLongTimeString().ToString();
                this.outputStr.AppendText(t);
                this.outputStr.AppendText("\t   " + msg + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LogError(string msg)
        {
            this.outputStr.SelectionColor = Color.Red;
            string t = DateTime.Now.ToLongTimeString().ToString();
            this.outputStr.AppendText(t);
            this.outputStr.AppendText("\t   " + msg + "\r\n");
        }

        private void btnClearInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }
    }
}
