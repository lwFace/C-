namespace SFTPTest
{
    partial class Form1
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
            this.sftpControl1 = new SFTPControl.SFTPControl();
            this.SuspendLayout();
            // 
            // sftpControl1
            // 
            this.sftpControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sftpControl1.Location = new System.Drawing.Point(0, 0);
            this.sftpControl1.Name = "sftpControl1";
            this.sftpControl1.Size = new System.Drawing.Size(688, 342);
            this.sftpControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 342);
            this.Controls.Add(this.sftpControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SFTPControl.SFTPControl sftpControl1;
    }
}

