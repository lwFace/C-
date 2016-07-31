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
                string t = DateTime.Now.ToLongTimeString().ToString();
                outputStr.Text += "  " + t + "\t   " + msg;
                outputStr.Text += "\r\n";
                outputStr.SelectionStart = outputStr.Text.Length;
                outputStr.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LogError(string msg)
        {
            string t = DateTime.Now.ToLongTimeString().ToString();
            outputStr.Text += "  " + t + "\t   Error:\t" + msg;
            outputStr.Text += "\r\n";
            outputStr.SelectionStart = outputStr.Text.Length;
            outputStr.ScrollToCaret();
        }

        private void btnClearInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }
    }
}
