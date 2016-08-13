namespace Demo1553
{
    partial class FrmBM
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMonitor = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlPayload = new DevExpress.XtraEditors.GroupControl();
            this.hexBoxBcPayload = new Be.Windows.Forms.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).BeginInit();
            this.groupControlPayload.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(794, 491);
            this.splitContainerControl1.SplitterPosition = 236;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageMonitor;
            this.xtraTabControl1.Size = new System.Drawing.Size(794, 236);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMonitor});
            // 
            // xtraTabPageMonitor
            // 
            this.xtraTabPageMonitor.Controls.Add(this.gridControl2);
            this.xtraTabPageMonitor.Name = "xtraTabPageMonitor";
            this.xtraTabPageMonitor.Size = new System.Drawing.Size(788, 207);
            this.xtraTabPageMonitor.Text = "Monitor";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(788, 207);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControlPayload
            // 
            this.groupControlPayload.Controls.Add(this.hexBoxBcPayload);
            this.groupControlPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPayload.Location = new System.Drawing.Point(0, 0);
            this.groupControlPayload.Name = "groupControlPayload";
            this.groupControlPayload.Size = new System.Drawing.Size(794, 250);
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
            this.hexBoxBcPayload.Size = new System.Drawing.Size(790, 227);
            this.hexBoxBcPayload.StringViewVisible = true;
            this.hexBoxBcPayload.TabIndex = 0;
            this.hexBoxBcPayload.UseFixedBytesPerLine = true;
            // 
            // FrmBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBM";
            this.Text = "FrmBM";
            this.Load += new System.EventHandler(this.FrmBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).EndInit();
            this.groupControlPayload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonitor;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControlPayload;
        private Be.Windows.Forms.HexBox hexBoxBcPayload;

    }
}