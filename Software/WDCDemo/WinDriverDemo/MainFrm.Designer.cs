namespace WinDriverDemo
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinMenu = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.versionInfo = new DevExpress.XtraBars.BarStaticItem();
            this.btnHome = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLib = new DevExpress.XtraBars.BarButtonItem();
            this.btnDispose = new DevExpress.XtraBars.BarButtonItem();
            this.drvStatus = new DevExpress.XtraBars.BarStaticItem();
            this.deviceStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btnDeviceOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnGroupHome = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDriverLibrary = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupDeviceControl = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Appearance = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGroupInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dlgItem = new DevExpress.XtraNavBar.NavBarControl();
            this.boardGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.boardInitItem = new DevExpress.XtraNavBar.NavBarItem();
            this.boardConfigItem = new DevExpress.XtraNavBar.NavBarItem();
            this.wdcGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.regTestItem = new DevExpress.XtraNavBar.NavBarItem();
            this.leftPannel = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.centerPannel = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPannel)).BeginInit();
            this.leftPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPannel)).BeginInit();
            this.centerPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinMenu,
            this.btnClose,
            this.btnAbout,
            this.versionInfo,
            this.btnHome,
            this.btnLoadLib,
            this.btnDispose,
            this.drvStatus,
            this.deviceStatus,
            this.btnDeviceOpen,
            this.btnSetting});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(877, 149);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // skinMenu
            // 
            this.skinMenu.Caption = "skinMenu";
            this.skinMenu.Id = 3;
            this.skinMenu.Name = "skinMenu";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 4;
            this.btnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClose.LargeGlyph")));
            this.btnClose.Name = "btnClose";
            this.btnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.Glyph")));
            this.btnAbout.Id = 6;
            this.btnAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.LargeGlyph")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // versionInfo
            // 
            this.versionInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.versionInfo.Caption = "Version 1.0";
            this.versionInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.versionInfo.Id = 7;
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnHome
            // 
            this.btnHome.Caption = "Home";
            this.btnHome.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnHome.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHome.Glyph")));
            this.btnHome.Id = 8;
            this.btnHome.Name = "btnHome";
            this.btnHome.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // btnLoadLib
            // 
            this.btnLoadLib.Caption = "Load";
            this.btnLoadLib.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLoadLib.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoadLib.Glyph")));
            this.btnLoadLib.Id = 9;
            this.btnLoadLib.Name = "btnLoadLib";
            this.btnLoadLib.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoadLib_ItemClick);
            // 
            // btnDispose
            // 
            this.btnDispose.Caption = "Dispose";
            this.btnDispose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnDispose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDispose.Glyph")));
            this.btnDispose.Id = 10;
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDispose_ItemClick);
            // 
            // drvStatus
            // 
            this.drvStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.drvStatus.Caption = "drvStatus";
            this.drvStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.drvStatus.Id = 11;
            this.drvStatus.Name = "drvStatus";
            this.drvStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // deviceStatus
            // 
            this.deviceStatus.Caption = "deviceStatus";
            this.deviceStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.deviceStatus.Id = 12;
            this.deviceStatus.Name = "deviceStatus";
            this.deviceStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDeviceOpen
            // 
            this.btnDeviceOpen.Caption = "Open";
            this.btnDeviceOpen.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnDeviceOpen.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeviceOpen.Glyph")));
            this.btnDeviceOpen.Id = 14;
            this.btnDeviceOpen.Name = "btnDeviceOpen";
            this.btnDeviceOpen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeviceOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeviceOpen_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "Options";
            this.btnSetting.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSetting.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSetting.Glyph")));
            this.btnSetting.Id = 17;
            this.btnSetting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSetting.LargeGlyph")));
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.btnGroupHome,
            this.btnDriverLibrary,
            this.groupDeviceControl,
            this.Appearance,
            this.btnGroupInfo,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // btnGroupHome
            // 
            this.btnGroupHome.AllowTextClipping = false;
            this.btnGroupHome.ItemLinks.Add(this.btnHome);
            this.btnGroupHome.Name = "btnGroupHome";
            this.btnGroupHome.ShowCaptionButton = false;
            this.btnGroupHome.Text = "Home";
            // 
            // btnDriverLibrary
            // 
            this.btnDriverLibrary.AllowTextClipping = false;
            this.btnDriverLibrary.ItemLinks.Add(this.btnLoadLib);
            this.btnDriverLibrary.ItemLinks.Add(this.btnDispose);
            this.btnDriverLibrary.Name = "btnDriverLibrary";
            this.btnDriverLibrary.ShowCaptionButton = false;
            this.btnDriverLibrary.Text = "DriverLibrary";
            // 
            // groupDeviceControl
            // 
            this.groupDeviceControl.AllowTextClipping = false;
            this.groupDeviceControl.ItemLinks.Add(this.btnDeviceOpen);
            this.groupDeviceControl.Name = "groupDeviceControl";
            this.groupDeviceControl.ShowCaptionButton = false;
            this.groupDeviceControl.Text = "DeviceControl";
            // 
            // Appearance
            // 
            this.Appearance.AllowTextClipping = false;
            this.Appearance.ItemLinks.Add(this.skinMenu);
            this.Appearance.Name = "Appearance";
            this.Appearance.Text = "Appearance";
            // 
            // btnGroupInfo
            // 
            this.btnGroupInfo.AllowTextClipping = false;
            this.btnGroupInfo.ItemLinks.Add(this.btnAbout);
            this.btnGroupInfo.Name = "btnGroupInfo";
            this.btnGroupInfo.ShowCaptionButton = false;
            this.btnGroupInfo.Text = "Info";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Settings";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.drvStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.deviceStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.versionInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 549);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(877, 23);
            // 
            // dlgItem
            // 
            this.dlgItem.ActiveGroup = this.boardGroup;
            this.dlgItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlgItem.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.boardGroup,
            this.wdcGroup});
            this.dlgItem.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.boardInitItem,
            this.regTestItem,
            this.boardConfigItem});
            this.dlgItem.Location = new System.Drawing.Point(2, 2);
            this.dlgItem.Name = "dlgItem";
            this.dlgItem.OptionsNavPane.ExpandedWidth = 196;
            this.dlgItem.Size = new System.Drawing.Size(196, 391);
            this.dlgItem.TabIndex = 2;
            this.dlgItem.Text = "navBarControl1";
            this.dlgItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.dlgItem_LinkClicked);
            // 
            // boardGroup
            // 
            this.boardGroup.Caption = "Board Control";
            this.boardGroup.Expanded = true;
            this.boardGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.boardInitItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.boardConfigItem)});
            this.boardGroup.Name = "boardGroup";
            // 
            // boardInitItem
            // 
            this.boardInitItem.Caption = "Scan";
            this.boardInitItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("boardInitItem.LargeImage")));
            this.boardInitItem.Name = "boardInitItem";
            this.boardInitItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("boardInitItem.SmallImage")));
            // 
            // boardConfigItem
            // 
            this.boardConfigItem.Caption = "Configuration";
            this.boardConfigItem.LargeImage = ((System.Drawing.Image)(resources.GetObject("boardConfigItem.LargeImage")));
            this.boardConfigItem.Name = "boardConfigItem";
            this.boardConfigItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("boardConfigItem.SmallImage")));
            // 
            // wdcGroup
            // 
            this.wdcGroup.Caption = "WDC Control";
            this.wdcGroup.Expanded = true;
            this.wdcGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.regTestItem)});
            this.wdcGroup.Name = "wdcGroup";
            // 
            // regTestItem
            // 
            this.regTestItem.Caption = "Register Test";
            this.regTestItem.Name = "regTestItem";
            this.regTestItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("regTestItem.SmallImage")));
            // 
            // leftPannel
            // 
            this.leftPannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPannel.Controls.Add(this.dlgItem);
            this.leftPannel.Location = new System.Drawing.Point(0, 150);
            this.leftPannel.Name = "leftPannel";
            this.leftPannel.Size = new System.Drawing.Size(200, 395);
            this.leftPannel.TabIndex = 4;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // centerPannel
            // 
            this.centerPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerPannel.Controls.Add(this.pictureEdit1);
            this.centerPannel.Controls.Add(this.labelControl2);
            this.centerPannel.Controls.Add(this.labelControl1);
            this.centerPannel.Location = new System.Drawing.Point(196, 150);
            this.centerPannel.Name = "centerPannel";
            this.centerPannel.Size = new System.Drawing.Size(681, 395);
            this.centerPannel.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::WinDriverDemo.Properties.Resources.software;
            this.pictureEdit1.Location = new System.Drawing.Point(117, 51);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(412, 268);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(265, 341);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Copyright©2014 HirainTech";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(280, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HiDriverTester";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = -1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 572);
            this.Controls.Add(this.leftPannel);
            this.Controls.Add(this.centerPannel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HiDriverTester";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPannel)).EndInit();
            this.leftPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPannel)).EndInit();
            this.centerPannel.ResumeLayout(false);
            this.centerPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl dlgItem;
        private DevExpress.XtraEditors.PanelControl leftPannel;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.RibbonGalleryBarItem skinMenu;
       // private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Appearance;
        private DevExpress.XtraNavBar.NavBarItem boardInitItem;
        private DevExpress.XtraNavBar.NavBarItem regTestItem;
        private DevExpress.XtraNavBar.NavBarGroup wdcGroup;
        private DevExpress.XtraNavBar.NavBarGroup boardGroup;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnGroupInfo;
        private DevExpress.XtraNavBar.NavBarItem boardConfigItem;
        private DevExpress.XtraBars.BarStaticItem versionInfo;
        private DevExpress.XtraEditors.PanelControl centerPannel;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnGroupHome;
        private DevExpress.XtraBars.BarButtonItem btnLoadLib;
        private DevExpress.XtraBars.BarButtonItem btnDispose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnDriverLibrary;
        private DevExpress.XtraBars.BarStaticItem drvStatus;
        private DevExpress.XtraBars.BarStaticItem deviceStatus;
        private DevExpress.XtraBars.BarButtonItem btnDeviceOpen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupDeviceControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}