namespace ESPHelper
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editRemoteIP = new DevExpress.XtraEditors.TextEdit();
            this.editUserName = new DevExpress.XtraEditors.TextEdit();
            this.editPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.editRemoteIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // editRemoteIP
            // 
            this.editRemoteIP.EditValue = "192.168.1.100";
            this.editRemoteIP.Location = new System.Drawing.Point(148, 22);
            this.editRemoteIP.Name = "editRemoteIP";
            this.editRemoteIP.Properties.Mask.EditMask = "(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(" +
    "25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
            this.editRemoteIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.editRemoteIP.Size = new System.Drawing.Size(147, 20);
            this.editRemoteIP.TabIndex = 0;
            // 
            // editUserName
            // 
            this.editUserName.EditValue = "root";
            this.editUserName.Location = new System.Drawing.Point(148, 55);
            this.editUserName.Name = "editUserName";
            this.editUserName.Size = new System.Drawing.Size(147, 20);
            this.editUserName.TabIndex = 1;
            // 
            // editPassword
            // 
            this.editPassword.EditValue = "123456";
            this.editPassword.Location = new System.Drawing.Point(148, 88);
            this.editPassword.Name = "editPassword";
            this.editPassword.Properties.UseSystemPasswordChar = true;
            this.editPassword.Size = new System.Drawing.Size(147, 20);
            this.editPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(134, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Remote IP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "User Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Password";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 176);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.editUserName);
            this.Controls.Add(this.editRemoteIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.editRemoteIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit editRemoteIP;
        private DevExpress.XtraEditors.TextEdit editUserName;
        private DevExpress.XtraEditors.TextEdit editPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}