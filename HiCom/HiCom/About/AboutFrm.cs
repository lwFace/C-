using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinDriverDemo.About
{
    public partial class AboutFrm : DevExpress.XtraEditors.XtraForm
    {
        public AboutFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutFrm_Load(object sender, EventArgs e)
        {
            this.Text = "About";
            
        }

    }
}