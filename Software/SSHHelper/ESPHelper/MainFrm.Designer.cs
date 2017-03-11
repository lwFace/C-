namespace ESPHelper
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barLoginBtn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLogoutBtn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barMonitorBtn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.statusConnect = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.logControl = new outputControl.outputControl();
            this.centerPannel = new DevExpress.XtraEditors.PanelControl();
            this.monitorView = new ESPHelper.Monitor.MonitorControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPannel)).BeginInit();
            this.centerPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMonitorBtn,
            this.barLoginBtn,
            this.barLogoutBtn,
            this.statusConnect,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLoginBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLogoutBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMonitorBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barLoginBtn
            // 
            this.barLoginBtn.Caption = "  Login  ";
            this.barLoginBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barLoginBtn.Glyph")));
            this.barLoginBtn.Id = 1;
            this.barLoginBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLoginBtn.LargeGlyph")));
            this.barLoginBtn.Name = "barLoginBtn";
            this.barLoginBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLoginBtn_ItemClick);
            // 
            // barLogoutBtn
            // 
            this.barLogoutBtn.Caption = "  Logout  ";
            this.barLogoutBtn.Enabled = false;
            this.barLogoutBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barLogoutBtn.Glyph")));
            this.barLogoutBtn.Id = 2;
            this.barLogoutBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLogoutBtn.LargeGlyph")));
            this.barLogoutBtn.Name = "barLogoutBtn";
            this.barLogoutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLogoutBtn_ItemClick);
            // 
            // barMonitorBtn
            // 
            this.barMonitorBtn.Caption = "  Monitor  ";
            this.barMonitorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barMonitorBtn.Glyph")));
            this.barMonitorBtn.Id = 0;
            this.barMonitorBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMonitorBtn.LargeGlyph")));
            this.barMonitorBtn.Name = "barMonitorBtn";
            this.barMonitorBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMonitorBtn_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "   About  ";
            this.barLargeButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.Glyph")));
            this.barLargeButtonItem1.Id = 5;
            this.barLargeButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.LargeGlyph")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "   Exit    ";
            this.barLargeButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.Glyph")));
            this.barLargeButtonItem2.Id = 6;
            this.barLargeButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.LargeGlyph")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statusConnect)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // statusConnect
            // 
            this.statusConnect.Caption = "Disconnected";
            this.statusConnect.Id = 4;
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1010, 89);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Size = new System.Drawing.Size(1010, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 89);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1010, 89);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 582);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("907487a3-4458-451a-9a60-719470c8cad5");
            this.dockPanel1.Location = new System.Drawing.Point(0, 542);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 129);
            this.dockPanel1.Size = new System.Drawing.Size(1010, 129);
            this.dockPanel1.Text = "OutPut";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.logControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1002, 102);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // logControl
            // 
            this.logControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logControl.Location = new System.Drawing.Point(0, 0);
            this.logControl.Name = "logControl";
            this.logControl.Size = new System.Drawing.Size(1002, 102);
            this.logControl.TabIndex = 0;
            // 
            // centerPannel
            // 
            this.centerPannel.Controls.Add(this.monitorView);
            this.centerPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPannel.Location = new System.Drawing.Point(0, 89);
            this.centerPannel.Name = "centerPannel";
            this.centerPannel.Size = new System.Drawing.Size(1010, 453);
            this.centerPannel.TabIndex = 4;
            // 
            // monitorView
            // 
            this.monitorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorView.Location = new System.Drawing.Point(2, 2);
            this.monitorView.Name = "monitorView";
            this.monitorView.Size = new System.Drawing.Size(1006, 449);
            this.monitorView.TabIndex = 0;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 698);
            this.Controls.Add(this.centerPannel);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainFrm";
            this.Text = "ESPHelper - Not login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPannel)).EndInit();
            this.centerPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barMonitorBtn;
        private DevExpress.XtraEditors.PanelControl centerPannel;
        private DevExpress.XtraBars.BarLargeButtonItem barLoginBtn;
        private DevExpress.XtraBars.BarLargeButtonItem barLogoutBtn;
        private DevExpress.XtraBars.BarStaticItem statusConnect;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private outputControl.outputControl logControl;
        private Monitor.MonitorControl monitorView;
    }
}

