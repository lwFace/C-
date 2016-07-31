namespace WinDriverDemo.Modules
{
    partial class BoardConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardConfig));
            this.gridControlRegTest = new DevExpress.XtraGrid.GridControl();
            this.gridViewRegTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tabRegConfig = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabRegRW = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnWrite = new DevExpress.XtraEditors.SimpleButton();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.editData = new DevExpress.XtraEditors.MemoEdit();
            this.treeRegConfig = new DevExpress.XtraTreeList.TreeList();
            this.treeColumREG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraTabAddRegs = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRegConfig)).BeginInit();
            this.tabRegConfig.SuspendLayout();
            this.xtraTabRegRW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeRegConfig)).BeginInit();
            this.xtraTabAddRegs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlRegTest
            // 
            this.gridControlRegTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRegTest.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlRegTest_EmbeddedNavigator_ButtonClick);
            this.gridControlRegTest.Location = new System.Drawing.Point(0, 0);
            this.gridControlRegTest.MainView = this.gridViewRegTest;
            this.gridControlRegTest.Name = "gridControlRegTest";
            this.gridControlRegTest.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemComboBox4,
            this.repositoryItemComboBox5});
            this.gridControlRegTest.Size = new System.Drawing.Size(659, 304);
            this.gridControlRegTest.TabIndex = 1;
            this.gridControlRegTest.UseEmbeddedNavigator = true;
            this.gridControlRegTest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegTest});
            // 
            // gridViewRegTest
            // 
            this.gridViewRegTest.GridControl = this.gridControlRegTest;
            this.gridViewRegTest.IndicatorWidth = 40;
            this.gridViewRegTest.Name = "gridViewRegTest";
            this.gridViewRegTest.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRegTest.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRegTest.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewRegTest.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewRegTest.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewRegTest.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewRegTest.OptionsView.ShowGroupPanel = false;
            this.gridViewRegTest.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewRegTest_CustomDrawRowIndicator);
            this.gridViewRegTest.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewRegTest_InitNewRow);
            this.gridViewRegTest.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewRegTest_ValidateRow);
            this.gridViewRegTest.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewRegTest_ValidatingEditor);
            this.gridViewRegTest.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gridViewRegTest_InvalidValueException);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
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
            this.tabRegConfig.Size = new System.Drawing.Size(666, 332);
            this.tabRegConfig.TabIndex = 0;
            this.tabRegConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabAddRegs,
            this.xtraTabRegRW});
            this.tabRegConfig.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabRegConfig_SelectedPageChanged);
            // 
            // xtraTabRegRW
            // 
            this.xtraTabRegRW.Controls.Add(this.panelControl2);
            this.xtraTabRegRW.Controls.Add(this.editData);
            this.xtraTabRegRW.Controls.Add(this.treeRegConfig);
            this.xtraTabRegRW.Name = "xtraTabRegRW";
            this.xtraTabRegRW.Size = new System.Drawing.Size(659, 304);
            this.xtraTabRegRW.Text = "Read/Write REG";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnWrite);
            this.panelControl2.Controls.Add(this.btnRead);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(120, 244);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(539, 60);
            this.panelControl2.TabIndex = 23;
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWrite.Location = new System.Drawing.Point(298, 16);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 21;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.Location = new System.Drawing.Point(139, 16);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // editData
            // 
            this.editData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editData.Location = new System.Drawing.Point(142, 17);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(496, 218);
            this.editData.TabIndex = 20;
            this.editData.UseOptimizedRendering = true;
            // 
            // treeRegConfig
            // 
            this.treeRegConfig.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeColumREG});
            this.treeRegConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeRegConfig.Location = new System.Drawing.Point(0, 0);
            this.treeRegConfig.Name = "treeRegConfig";
            this.treeRegConfig.OptionsBehavior.Editable = false;
            this.treeRegConfig.OptionsView.ShowHorzLines = false;
            this.treeRegConfig.OptionsView.ShowIndicator = false;
            this.treeRegConfig.Size = new System.Drawing.Size(120, 304);
            this.treeRegConfig.TabIndex = 0;
            this.treeRegConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeRegConfig_MouseClick);
            // 
            // treeColumREG
            // 
            this.treeColumREG.Caption = "REGs";
            this.treeColumREG.FieldName = "REGs";
            this.treeColumREG.Name = "treeColumREG";
            this.treeColumREG.Visible = true;
            this.treeColumREG.VisibleIndex = 0;
            // 
            // xtraTabAddRegs
            // 
            this.xtraTabAddRegs.Controls.Add(this.gridControlRegTest);
            this.xtraTabAddRegs.Name = "xtraTabAddRegs";
            this.xtraTabAddRegs.Size = new System.Drawing.Size(659, 304);
            this.xtraTabAddRegs.Text = "Add REGs";
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
            this.panelControl1.Size = new System.Drawing.Size(670, 394);
            this.panelControl1.TabIndex = 3;
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
            // BoardConfig
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "BoardConfig";
            this.Size = new System.Drawing.Size(670, 394);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRegConfig)).EndInit();
            this.tabRegConfig.ResumeLayout(false);
            this.xtraTabRegRW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeRegConfig)).EndInit();
            this.xtraTabAddRegs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRegTest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegTest;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxTransType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxTransMode;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraTab.XtraTabControl tabRegConfig;
        private DevExpress.XtraTab.XtraTabPage xtraTabRegRW;
        private DevExpress.XtraTab.XtraTabPage xtraTabAddRegs;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraTreeList.TreeList treeRegConfig;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColumREG;
        private DevExpress.XtraEditors.SimpleButton btnWrite;
        private DevExpress.XtraEditors.SimpleButton btnRead;
        private DevExpress.XtraEditors.MemoEdit editData;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}
