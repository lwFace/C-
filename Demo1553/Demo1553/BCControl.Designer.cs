namespace Demo1553
{
    partial class BCControl
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageConfig = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageMonitor = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlPayload = new DevExpress.XtraEditors.GroupControl();
            this.hexBoxBcPayload = new Be.Windows.Forms.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).BeginInit();
            this.groupControlPayload.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageConfig;
            this.xtraTabControl1.Size = new System.Drawing.Size(640, 236);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageConfig,
            this.xtraTabPageMonitor});
            // 
            // xtraTabPageConfig
            // 
            this.xtraTabPageConfig.Controls.Add(this.gridControl1);
            this.xtraTabPageConfig.Name = "xtraTabPageConfig";
            this.xtraTabPageConfig.Size = new System.Drawing.Size(634, 207);
            this.xtraTabPageConfig.Text = "Configurate";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(634, 207);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPageMonitor
            // 
            this.xtraTabPageMonitor.Name = "xtraTabPageMonitor";
            this.xtraTabPageMonitor.Size = new System.Drawing.Size(634, 349);
            this.xtraTabPageMonitor.Text = "Monitor";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControlPayload);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(640, 378);
            this.splitContainerControl1.SplitterPosition = 236;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControlPayload
            // 
            this.groupControlPayload.Controls.Add(this.hexBoxBcPayload);
            this.groupControlPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPayload.Location = new System.Drawing.Point(0, 0);
            this.groupControlPayload.Name = "groupControlPayload";
            this.groupControlPayload.Size = new System.Drawing.Size(640, 137);
            this.groupControlPayload.TabIndex = 0;
            this.groupControlPayload.Text = "原始报文信息";
            // 
            // hexBoxBcPayload
            // 
            this.hexBoxBcPayload.BodyOffset = 0;
            this.hexBoxBcPayload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexBoxBcPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBoxBcPayload.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBoxBcPayload.HeaderColor = System.Drawing.Color.Maroon;
            this.hexBoxBcPayload.LineInfoVisible = true;
            this.hexBoxBcPayload.Location = new System.Drawing.Point(2, 21);
            this.hexBoxBcPayload.Name = "hexBoxBcPayload";
            this.hexBoxBcPayload.SelectionLength = ((long)(0));
            this.hexBoxBcPayload.SelectionStart = ((long)(-1));
            this.hexBoxBcPayload.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxBcPayload.Size = new System.Drawing.Size(636, 114);
            this.hexBoxBcPayload.StringViewVisible = true;
            this.hexBoxBcPayload.TabIndex = 0;
            this.hexBoxBcPayload.UseFixedBytesPerLine = true;
            // 
            // BCControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "BCControl";
            this.Size = new System.Drawing.Size(640, 378);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).EndInit();
            this.groupControlPayload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageConfig;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonitor;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControlPayload;
        private Be.Windows.Forms.HexBox hexBoxBcPayload;
    }
}
