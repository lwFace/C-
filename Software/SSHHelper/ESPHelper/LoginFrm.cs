using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ESPHelper
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public string userName;
        public string ipAddr;
        public string password;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = this.editUserName.Text;
            ipAddr = this.editRemoteIP.Text;
            password = this.editPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}