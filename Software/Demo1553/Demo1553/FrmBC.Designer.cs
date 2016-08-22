namespace Demo1553
{
    partial class FrmBC
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
            this.components = new System.ComponentModel.Container();
            this.groupControlPayload = new DevExpress.XtraEditors.GroupControl();
            this.hexBoxBcPayload = new Be.Windows.Forms.HexBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageConfig = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlConfig = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTrasmit = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageMonitor = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMonitor = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonitor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).BeginInit();
            this.groupControlPayload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConfig)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConfig)).BeginInit();
            this.xtraTabPageMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlPayload
            // 
            this.groupControlPayload.Controls.Add(this.hexBoxBcPayload);
            this.groupControlPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPayload.Location = new System.Drawing.Point(0, 0);
            this.groupControlPayload.Name = "groupControlPayload";
            this.groupControlPayload.Size = new System.Drawing.Size(583, 79);
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
            this.hexBoxBcPayload.ReadOnly = true;
            this.hexBoxBcPayload.SelectionLength = ((long)(0));
            this.hexBoxBcPayload.SelectionStart = ((long)(-1));
            this.hexBoxBcPayload.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxBcPayload.Size = new System.Drawing.Size(579, 56);
            this.hexBoxBcPayload.StringViewVisible = true;
            this.hexBoxBcPayload.TabIndex = 0;
            this.hexBoxBcPayload.UseFixedBytesPerLine = true;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(583, 354);
            this.splitContainerControl1.SplitterPosition = 270;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageConfig;
            this.xtraTabControl1.Size = new System.Drawing.Size(583, 270);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageConfig,
            this.xtraTabPageMonitor});
            // 
            // xtraTabPageConfig
            // 
            this.xtraTabPageConfig.Controls.Add(this.gridControlConfig);
            this.xtraTabPageConfig.Name = "xtraTabPageConfig";
            this.xtraTabPageConfig.Size = new System.Drawing.Size(577, 241);
            this.xtraTabPageConfig.Text = "配置";
            // 
            // gridControlConfig
            // 
            this.gridControlConfig.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConfig.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlConfig.Location = new System.Drawing.Point(0, 0);
            this.gridControlConfig.MainView = this.gridViewConfig;
            this.gridControlConfig.Name = "gridControlConfig";
            this.gridControlConfig.Size = new System.Drawing.Size(577, 241);
            this.gridControlConfig.TabIndex = 0;
            this.gridControlConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConfig});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdd,
            this.itemEdit,
            this.toolStripSeparator1,
            this.itemDelete,
            this.itemClear,
            this.toolStripSeparator2,
            this.itemTrasmit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 148);
            // 
            // itemAdd
            // 
            this.itemAdd.Image = global::Demo1553.Properties.Resources.cog_add;
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(152, 22);
            this.itemAdd.Text = "新建...";
            this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Image = global::Demo1553.Properties.Resources.cog_edit;
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(152, 22);
            this.itemEdit.Text = "编辑";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // itemDelete
            // 
            this.itemDelete.Image = global::Demo1553.Properties.Resources.cog_delete;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(152, 22);
            this.itemDelete.Text = "删除";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // itemClear
            // 
            this.itemClear.Image = global::Demo1553.Properties.Resources.cog;
            this.itemClear.Name = "itemClear";
            this.itemClear.Size = new System.Drawing.Size(152, 22);
            this.itemClear.Text = "清空";
            this.itemClear.Click += new System.EventHandler(this.itemClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // itemTrasmit
            // 
            this.itemTrasmit.Image = global::Demo1553.Properties.Resources.cog_go;
            this.itemTrasmit.Name = "itemTrasmit";
            this.itemTrasmit.Size = new System.Drawing.Size(152, 22);
            this.itemTrasmit.Text = "发送";
            this.itemTrasmit.Click += new System.EventHandler(this.itemTrasmit_Click);
            // 
            // gridViewConfig
            // 
            this.gridViewConfig.GridControl = this.gridControlConfig;
            this.gridViewConfig.Name = "gridViewConfig";
            this.gridViewConfig.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewConfig.OptionsBehavior.Editable = false;
            this.gridViewConfig.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewConfig.OptionsBehavior.ReadOnly = true;
            this.gridViewConfig.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewConfig.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewConfig.OptionsSelection.MultiSelect = true;
            this.gridViewConfig.OptionsSelection.UseIndicatorForSelection = false;
            this.gridViewConfig.OptionsView.ShowGroupPanel = false;
            this.gridViewConfig.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewConfig_RowCellClick);
            this.gridViewConfig.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewConfig_PopupMenuShowing);
            this.gridViewConfig.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewConfig_InitNewRow);
            this.gridViewConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewConfig_MouseDown);
            // 
            // xtraTabPageMonitor
            // 
            this.xtraTabPageMonitor.Controls.Add(this.gridControlMonitor);
            this.xtraTabPageMonitor.Name = "xtraTabPageMonitor";
            this.xtraTabPageMonitor.Size = new System.Drawing.Size(577, 241);
            this.xtraTabPageMonitor.Text = "监控";
            // 
            // gridControlMonitor
            // 
            this.gridControlMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMonitor.Location = new System.Drawing.Point(0, 0);
            this.gridControlMonitor.MainView = this.gridViewMonitor;
            this.gridControlMonitor.Name = "gridControlMonitor";
            this.gridControlMonitor.Size = new System.Drawing.Size(577, 241);
            this.gridControlMonitor.TabIndex = 2;
            this.gridControlMonitor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonitor});
            // 
            // gridViewMonitor
            // 
            this.gridViewMonitor.GridControl = this.gridControlMonitor;
            this.gridViewMonitor.Name = "gridViewMonitor";
            this.gridViewMonitor.OptionsView.ShowGroupPanel = false;
            this.gridViewMonitor.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewMonitor_RowCellClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "新建...";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "编辑";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "删除";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "清空";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(583, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 354);
            this.barDockControlBottom.Size = new System.Drawing.Size(583, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 354);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(583, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 354);
            // 
            // FrmBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 354);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBC";
            this.Text = "FrmBC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBC_FormClosing);
            this.Load += new System.EventHandler(this.FrmBC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPayload)).EndInit();
            this.groupControlPayload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConfig)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConfig)).EndInit();
            this.xtraTabPageMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlPayload;
        private Be.Windows.Forms.HexBox hexBoxBcPayload;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageConfig;
        private DevExpress.XtraGrid.GridControl gridControlConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConfig;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonitor;
        private DevExpress.XtraGrid.GridControl gridControlMonitor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonitor;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemAdd;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemClear;
        private System.Windows.Forms.ToolStripMenuItem itemTrasmit;
    }
}