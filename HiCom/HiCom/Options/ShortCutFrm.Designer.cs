namespace WinDriverDemo.Options
{
    partial class ShortCutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortCutFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.tabRegConfig = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabRegRW = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnWrite = new DevExpress.XtraEditors.SimpleButton();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.editData = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabAddRegs = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlShortCut = new DevExpress.XtraGrid.GridControl();
            this.gridViewRegTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabRegConfig)).BeginInit();
            this.tabRegConfig.SuspendLayout();
            this.xtraTabRegRW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editData.Properties)).BeginInit();
            this.xtraTabAddRegs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlShortCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteAll);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.tabRegConfig);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(656, 387);
            this.panelControl1.TabIndex = 4;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(420, 22);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(291, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(157, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tabRegConfig
            // 
            this.tabRegConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRegConfig.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tabRegConfig.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tabRegConfig.Location = new System.Drawing.Point(1, 59);
            this.tabRegConfig.Name = "tabRegConfig";
            this.tabRegConfig.SelectedTabPage = this.xtraTabRegRW;
            this.tabRegConfig.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tabRegConfig.Size = new System.Drawing.Size(652, 0);
            this.tabRegConfig.TabIndex = 0;
            this.tabRegConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabAddRegs,
            this.xtraTabRegRW});
            // 
            // xtraTabRegRW
            // 
            this.xtraTabRegRW.Controls.Add(this.panelControl2);
            this.xtraTabRegRW.Controls.Add(this.editData);
            this.xtraTabRegRW.Name = "xtraTabRegRW";
            this.xtraTabRegRW.Size = new System.Drawing.Size(644, 0);
            this.xtraTabRegRW.Text = "Read/Write REG";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnWrite);
            this.panelControl2.Controls.Add(this.btnRead);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, -60);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(644, 60);
            this.panelControl2.TabIndex = 23;
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWrite.Location = new System.Drawing.Point(351, 16);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 21;
            this.btnWrite.Text = "Write";
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.Location = new System.Drawing.Point(192, 16);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "Read";
            // 
            // editData
            // 
            this.editData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editData.Location = new System.Drawing.Point(142, 17);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(482, 0);
            this.editData.TabIndex = 20;
            // 
            // xtraTabAddRegs
            // 
            this.xtraTabAddRegs.Controls.Add(this.gridControl1);
            this.xtraTabAddRegs.Name = "xtraTabAddRegs";
            this.xtraTabAddRegs.Size = new System.Drawing.Size(644, 0);
            this.xtraTabAddRegs.Text = "Add REGs";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(644, 0);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlShortCut
            // 
            this.gridControlShortCut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlShortCut.Location = new System.Drawing.Point(0, 62);
            this.gridControlShortCut.MainView = this.gridViewRegTest;
            this.gridControlShortCut.Name = "gridControlShortCut";
            this.gridControlShortCut.Size = new System.Drawing.Size(656, 325);
            this.gridControlShortCut.TabIndex = 5;
            this.gridControlShortCut.UseEmbeddedNavigator = true;
            this.gridControlShortCut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegTest});
            // 
            // gridViewRegTest
            // 
            this.gridViewRegTest.GridControl = this.gridControlShortCut;
            this.gridViewRegTest.IndicatorWidth = 40;
            this.gridViewRegTest.Name = "gridViewRegTest";
            this.gridViewRegTest.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRegTest.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewRegTest.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewRegTest.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewRegTest.OptionsView.ShowGroupPanel = false;
            this.gridViewRegTest.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewRegTest_CustomDrawRowIndicator);
            this.gridViewRegTest.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewRegTest_InitNewRow);
            this.gridViewRegTest.ColumnChanged += new System.EventHandler(this.gridViewRegTest_ColumnChanged);
            this.gridViewRegTest.DataSourceChanged += new System.EventHandler(this.gridViewRegTest_DataSourceChanged);
            // 
            // ShortCutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 387);
            this.Controls.Add(this.gridControlShortCut);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortCutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortCutFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShortCutFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabRegConfig)).EndInit();
            this.tabRegConfig.ResumeLayout(false);
            this.xtraTabRegRW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editData.Properties)).EndInit();
            this.xtraTabAddRegs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlShortCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraTab.XtraTabControl tabRegConfig;
        private DevExpress.XtraTab.XtraTabPage xtraTabRegRW;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnWrite;
        private DevExpress.XtraEditors.SimpleButton btnRead;
        private DevExpress.XtraEditors.MemoEdit editData;
        private DevExpress.XtraTab.XtraTabPage xtraTabAddRegs;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlShortCut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegTest;


    }
}