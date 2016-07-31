namespace ESPHelper
{
    partial class AddServer
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
            this.gridControlServer = new DevExpress.XtraGrid.GridControl();
            this.serverView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectall = new DevExpress.XtraEditors.SimpleButton();
            this.btnDisselectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlServer
            // 
            this.gridControlServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlServer.Location = new System.Drawing.Point(0, 0);
            this.gridControlServer.MainView = this.serverView;
            this.gridControlServer.Name = "gridControlServer";
            this.gridControlServer.Size = new System.Drawing.Size(635, 210);
            this.gridControlServer.TabIndex = 0;
            this.gridControlServer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.serverView});
            // 
            // serverView
            // 
            this.serverView.GridControl = this.gridControlServer;
            this.serverView.Name = "serverView";
            this.serverView.OptionsView.ShowGroupPanel = false;
            this.serverView.OptionsView.ShowIndicator = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(133, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelectall
            // 
            this.btnSelectall.Location = new System.Drawing.Point(237, 226);
            this.btnSelectall.Name = "btnSelectall";
            this.btnSelectall.Size = new System.Drawing.Size(75, 23);
            this.btnSelectall.TabIndex = 1;
            this.btnSelectall.Text = "全部选择";
            this.btnSelectall.Click += new System.EventHandler(this.btnSelectall_Click);
            // 
            // btnDisselectAll
            // 
            this.btnDisselectAll.Location = new System.Drawing.Point(341, 226);
            this.btnDisselectAll.Name = "btnDisselectAll";
            this.btnDisselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisselectAll.TabIndex = 1;
            this.btnDisselectAll.Text = "全部取消";
            this.btnDisselectAll.Click += new System.EventHandler(this.btnDisselectAll_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(445, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 261);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDisselectAll);
            this.Controls.Add(this.btnSelectall);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridControlServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "服务添加";
            this.Load += new System.EventHandler(this.AddServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlServer;
        private DevExpress.XtraGrid.Views.Grid.GridView serverView;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnSelectall;
        private DevExpress.XtraEditors.SimpleButton btnDisselectAll;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}