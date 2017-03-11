namespace ESPHelper.Monitor
{
    partial class MonitorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorControl));
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarBasic = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMemory = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDisk = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCpu = new DevExpress.XtraNavBar.NavBarItem();
            this.infoTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabBasic = new DevExpress.XtraTab.XtraTabPage();
            this.treeBasicInfo = new DevExpress.XtraTreeList.TreeList();
            this.nameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.infoCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabMemory = new DevExpress.XtraTab.XtraTabPage();
            this.navBarEth = new DevExpress.XtraNavBar.NavBarItem();
            this.tabDisk = new DevExpress.XtraTab.XtraTabPage();
            this.tabCpu = new DevExpress.XtraTab.XtraTabPage();
            this.tabEth = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTabControl)).BeginInit();
            this.infoTabControl.SuspendLayout();
            this.tabBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeBasicInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.navBarGroup1;
            this.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarBasic,
            this.navBarMemory,
            this.navBarDisk,
            this.navBarCpu,
            this.navBarEth});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 167;
            this.navBar.Size = new System.Drawing.Size(167, 423);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "navBar";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "System Information";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarBasic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMemory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDisk),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCpu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEth)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // navBarBasic
            // 
            this.navBarBasic.Caption = "Basic";
            this.navBarBasic.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarBasic.LargeImage")));
            this.navBarBasic.Name = "navBarBasic";
            this.navBarBasic.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarBasic_LinkClicked);
            // 
            // navBarMemory
            // 
            this.navBarMemory.Caption = "Memory";
            this.navBarMemory.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarMemory.LargeImage")));
            this.navBarMemory.Name = "navBarMemory";
            this.navBarMemory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMemory_LinkClicked);
            // 
            // navBarDisk
            // 
            this.navBarDisk.Caption = "Disk";
            this.navBarDisk.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarDisk.LargeImage")));
            this.navBarDisk.Name = "navBarDisk";
            this.navBarDisk.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDisk_LinkClicked);
            // 
            // navBarCpu
            // 
            this.navBarCpu.Caption = "CPU";
            this.navBarCpu.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarCpu.LargeImage")));
            this.navBarCpu.Name = "navBarCpu";
            this.navBarCpu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCpu_LinkClicked);
            // 
            // infoTabControl
            // 
            this.infoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTabControl.Location = new System.Drawing.Point(167, 0);
            this.infoTabControl.Name = "infoTabControl";
            this.infoTabControl.SelectedTabPage = this.tabBasic;
            this.infoTabControl.Size = new System.Drawing.Size(460, 423);
            this.infoTabControl.TabIndex = 1;
            this.infoTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabBasic,
            this.tabMemory,
            this.tabDisk,
            this.tabCpu,
            this.tabEth});
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.treeBasicInfo);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Size = new System.Drawing.Size(454, 394);
            this.tabBasic.Text = "Basic";
            // 
            // treeBasicInfo
            // 
            this.treeBasicInfo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.Empty.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.treeBasicInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.treeBasicInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeBasicInfo.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.treeBasicInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeBasicInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeBasicInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treeBasicInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeBasicInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeBasicInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treeBasicInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeBasicInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeBasicInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treeBasicInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeBasicInfo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.treeBasicInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeBasicInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeBasicInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treeBasicInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.treeBasicInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.treeBasicInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.treeBasicInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.treeBasicInfo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.treeBasicInfo.Appearance.Preview.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.Preview.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.treeBasicInfo.Appearance.Row.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.Row.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.treeBasicInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.treeBasicInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeBasicInfo.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.treeBasicInfo.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeBasicInfo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.treeBasicInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.treeBasicInfo.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.nameCol,
            this.infoCol});
            this.treeBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.treeBasicInfo.Name = "treeBasicInfo";
            this.treeBasicInfo.OptionsBehavior.Editable = false;
            this.treeBasicInfo.OptionsLayout.AddNewColumns = false;
            this.treeBasicInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeBasicInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.treeBasicInfo.OptionsView.EnableAppearanceOddRow = true;
            this.treeBasicInfo.OptionsView.ShowIndentAsRowStyle = true;
            this.treeBasicInfo.OptionsView.ShowIndicator = false;
            this.treeBasicInfo.Size = new System.Drawing.Size(454, 394);
            this.treeBasicInfo.TabIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Name";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // infoCol
            // 
            this.infoCol.Caption = "Info";
            this.infoCol.FieldName = "Info";
            this.infoCol.Name = "infoCol";
            this.infoCol.Visible = true;
            this.infoCol.VisibleIndex = 1;
            // 
            // tabMemory
            // 
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Size = new System.Drawing.Size(454, 417);
            this.tabMemory.Text = "Memory";
            // 
            // navBarEth
            // 
            this.navBarEth.Caption = "Ethernet";
            this.navBarEth.Name = "navBarEth";
            this.navBarEth.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEth_LinkClicked);
            // 
            // tabDisk
            // 
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Size = new System.Drawing.Size(454, 394);
            this.tabDisk.Text = "Disk";
            // 
            // tabCpu
            // 
            this.tabCpu.Name = "tabCpu";
            this.tabCpu.Size = new System.Drawing.Size(454, 394);
            this.tabCpu.Text = "CPU";
            // 
            // tabEth
            // 
            this.tabEth.Name = "tabEth";
            this.tabEth.Size = new System.Drawing.Size(454, 394);
            this.tabEth.Text = "Ethernet";
            // 
            // MonitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoTabControl);
            this.Controls.Add(this.navBar);
            this.Name = "MonitorControl";
            this.Size = new System.Drawing.Size(627, 423);
            this.Load += new System.EventHandler(this.MonitorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTabControl)).EndInit();
            this.infoTabControl.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeBasicInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarBasic;
        private DevExpress.XtraNavBar.NavBarItem navBarMemory;
        private DevExpress.XtraNavBar.NavBarItem navBarDisk;
        private DevExpress.XtraNavBar.NavBarItem navBarCpu;
        private DevExpress.XtraTab.XtraTabControl infoTabControl;
        private DevExpress.XtraTab.XtraTabPage tabBasic;
        private DevExpress.XtraTab.XtraTabPage tabMemory;
        private DevExpress.XtraTreeList.TreeList treeBasicInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn nameCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn infoCol;
        private DevExpress.XtraNavBar.NavBarItem navBarEth;
        private DevExpress.XtraTab.XtraTabPage tabDisk;
        private DevExpress.XtraTab.XtraTabPage tabCpu;
        private DevExpress.XtraTab.XtraTabPage tabEth;
    }
}
