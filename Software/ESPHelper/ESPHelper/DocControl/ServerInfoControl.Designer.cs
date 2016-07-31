namespace ESPHelper.DocControl
{
    partial class ServerInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerInfoControl));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRouterPreView = new DevExpress.XtraEditors.SimpleButton();
            this.btnInitPreView = new DevExpress.XtraEditors.SimpleButton();
            this.btnRouter = new DevExpress.XtraEditors.SimpleButton();
            this.textEditrouterPath = new DevExpress.XtraEditors.TextEdit();
            this.btnInit = new DevExpress.XtraEditors.SimpleButton();
            this.textEditInitPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textXml = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditrouterPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInitPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textXml.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRouterPreView);
            this.groupControl2.Controls.Add(this.btnInitPreView);
            this.groupControl2.Controls.Add(this.btnRouter);
            this.groupControl2.Controls.Add(this.textEditrouterPath);
            this.groupControl2.Controls.Add(this.btnInit);
            this.groupControl2.Controls.Add(this.textEditInitPath);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(676, 115);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "配置文件路径";
            // 
            // btnRouterPreView
            // 
            this.btnRouterPreView.Image = ((System.Drawing.Image)(resources.GetObject("btnRouterPreView.Image")));
            this.btnRouterPreView.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRouterPreView.Location = new System.Drawing.Point(568, 63);
            this.btnRouterPreView.Name = "btnRouterPreView";
            this.btnRouterPreView.Size = new System.Drawing.Size(75, 23);
            this.btnRouterPreView.TabIndex = 15;
            this.btnRouterPreView.Text = "查看";
            this.btnRouterPreView.Click += new System.EventHandler(this.btnRouterPreView_Click);
            // 
            // btnInitPreView
            // 
            this.btnInitPreView.Image = ((System.Drawing.Image)(resources.GetObject("btnInitPreView.Image")));
            this.btnInitPreView.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnInitPreView.Location = new System.Drawing.Point(568, 34);
            this.btnInitPreView.Name = "btnInitPreView";
            this.btnInitPreView.Size = new System.Drawing.Size(75, 23);
            this.btnInitPreView.TabIndex = 14;
            this.btnInitPreView.Text = "查看";
            this.btnInitPreView.Click += new System.EventHandler(this.btnInitPreView_Click);
            // 
            // btnRouter
            // 
            this.btnRouter.Image = ((System.Drawing.Image)(resources.GetObject("btnRouter.Image")));
            this.btnRouter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRouter.Location = new System.Drawing.Point(487, 63);
            this.btnRouter.Name = "btnRouter";
            this.btnRouter.Size = new System.Drawing.Size(75, 23);
            this.btnRouter.TabIndex = 13;
            this.btnRouter.Text = "浏览...";
            this.btnRouter.Click += new System.EventHandler(this.btnRouter_Click);
            // 
            // textEditrouterPath
            // 
            this.textEditrouterPath.Location = new System.Drawing.Point(117, 64);
            this.textEditrouterPath.Name = "textEditrouterPath";
            this.textEditrouterPath.Size = new System.Drawing.Size(352, 20);
            this.textEditrouterPath.TabIndex = 12;
            // 
            // btnInit
            // 
            this.btnInit.Image = ((System.Drawing.Image)(resources.GetObject("btnInit.Image")));
            this.btnInit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnInit.Location = new System.Drawing.Point(487, 34);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 11;
            this.btnInit.Text = "浏览...";
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // textEditInitPath
            // 
            this.textEditInitPath.Location = new System.Drawing.Point(117, 35);
            this.textEditInitPath.Name = "textEditInitPath";
            this.textEditInitPath.Size = new System.Drawing.Size(352, 20);
            this.textEditInitPath.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "路由表路径";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "初始化表路径";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textXml);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 115);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 334);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "文件预览";
            // 
            // textXml
            // 
            this.textXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textXml.EditValue = "点击查看按钮预览文件内容...";
            this.textXml.Location = new System.Drawing.Point(2, 21);
            this.textXml.Name = "textXml";
            this.textXml.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textXml.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textXml.Properties.Appearance.Options.UseFont = true;
            this.textXml.Properties.Appearance.Options.UseForeColor = true;
            this.textXml.Size = new System.Drawing.Size(672, 311);
            this.textXml.TabIndex = 10;
            // 
            // ServerInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "ServerInfoControl";
            this.Size = new System.Drawing.Size(676, 449);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditrouterPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInitPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textXml.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRouterPreView;
        private DevExpress.XtraEditors.SimpleButton btnInitPreView;
        private DevExpress.XtraEditors.SimpleButton btnRouter;
        private DevExpress.XtraEditors.TextEdit textEditrouterPath;
        private DevExpress.XtraEditors.SimpleButton btnInit;
        private DevExpress.XtraEditors.TextEdit textEditInitPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit textXml;

    }
}
