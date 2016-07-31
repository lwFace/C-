namespace WinDriverDemo.Modules
{
    partial class OptionsFrm
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
            this.tabOptions = new DevExpress.XtraTab.XtraTabControl();
            this.tabRegTest = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.checkEditAutoInc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textNumBytes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditOffset = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboTransType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboTransMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabboardScan = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Vendor = new DevExpress.XtraEditors.LabelControl();
            this.editVendor = new DevExpress.XtraEditors.TextEdit();
            this.editDeviceId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabBoardConfig = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).BeginInit();
            this.tabOptions.SuspendLayout();
            this.tabRegTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAutoInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOffset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransMode.Properties)).BeginInit();
            this.tabboardScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDeviceId.Properties)).BeginInit();
            this.tabBoardConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.tabOptions.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabOptions.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedTabPage = this.tabRegTest;
            this.tabOptions.Size = new System.Drawing.Size(479, 302);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabRegTest,
            this.tabboardScan,
            this.tabBoardConfig});
            // 
            // tabRegTest
            // 
            this.tabRegTest.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.tabRegTest.Appearance.Header.Options.UseBackColor = true;
            this.tabRegTest.Controls.Add(this.groupControl2);
            this.tabRegTest.Name = "tabRegTest";
            this.tabRegTest.Size = new System.Drawing.Size(386, 296);
            this.tabRegTest.Text = "Register Test";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.checkEditAutoInc);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textNumBytes);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.textEditOffset);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.comboTransType);
            this.groupControl2.Controls.Add(this.comboTransMode);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(386, 296);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Default Value";
            // 
            // checkEditAutoInc
            // 
            this.checkEditAutoInc.Location = new System.Drawing.Point(46, 171);
            this.checkEditAutoInc.Name = "checkEditAutoInc";
            this.checkEditAutoInc.Properties.Caption = "Auto-Increment Address";
            this.checkEditAutoInc.Size = new System.Drawing.Size(167, 19);
            this.checkEditAutoInc.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 14);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Number of Bytes";
            // 
            // textNumBytes
            // 
            this.textNumBytes.EditValue = "4";
            this.textNumBytes.Location = new System.Drawing.Point(106, 136);
            this.textNumBytes.Name = "textNumBytes";
            this.textNumBytes.Size = new System.Drawing.Size(100, 20);
            this.textNumBytes.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Offset       0x";
            // 
            // textEditOffset
            // 
            this.textEditOffset.EditValue = "0";
            this.textEditOffset.Location = new System.Drawing.Point(105, 103);
            this.textEditOffset.Name = "textEditOffset";
            this.textEditOffset.Size = new System.Drawing.Size(100, 20);
            this.textEditOffset.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Transfer Type";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 14);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Transfer Mode";
            // 
            // comboTransType
            // 
            this.comboTransType.Location = new System.Drawing.Point(105, 68);
            this.comboTransType.Name = "comboTransType";
            this.comboTransType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransType.Size = new System.Drawing.Size(100, 20);
            this.comboTransType.TabIndex = 18;
            // 
            // comboTransMode
            // 
            this.comboTransMode.Location = new System.Drawing.Point(105, 33);
            this.comboTransMode.Name = "comboTransMode";
            this.comboTransMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransMode.Size = new System.Drawing.Size(100, 20);
            this.comboTransMode.TabIndex = 17;
            // 
            // tabboardScan
            // 
            this.tabboardScan.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.tabboardScan.Appearance.Header.Options.UseBackColor = true;
            this.tabboardScan.Controls.Add(this.groupControl1);
            this.tabboardScan.Name = "tabboardScan";
            this.tabboardScan.Size = new System.Drawing.Size(384, 294);
            this.tabboardScan.Text = "BoardScan";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Vendor);
            this.groupControl1.Controls.Add(this.editVendor);
            this.groupControl1.Controls.Add(this.editDeviceId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 294);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Default Value";
            // 
            // Vendor
            // 
            this.Vendor.Location = new System.Drawing.Point(22, 36);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(73, 14);
            this.Vendor.TabIndex = 6;
            this.Vendor.Text = "Vendor ID 0x";
            // 
            // editVendor
            // 
            this.editVendor.EditValue = "0";
            this.editVendor.Location = new System.Drawing.Point(98, 33);
            this.editVendor.Name = "editVendor";
            this.editVendor.Size = new System.Drawing.Size(100, 20);
            this.editVendor.TabIndex = 5;
            // 
            // editDeviceId
            // 
            this.editDeviceId.EditValue = "0";
            this.editDeviceId.Location = new System.Drawing.Point(98, 67);
            this.editDeviceId.Name = "editDeviceId";
            this.editDeviceId.Size = new System.Drawing.Size(100, 20);
            this.editDeviceId.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Device  ID 0x";
            // 
            // tabBoardConfig
            // 
            this.tabBoardConfig.Controls.Add(this.groupControl3);
            this.tabBoardConfig.Name = "tabBoardConfig";
            this.tabBoardConfig.Size = new System.Drawing.Size(386, 296);
            this.tabBoardConfig.Text = "BoardConfig";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl3.Controls.Add(this.checkEdit1);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.textEdit4);
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.textEdit3);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.comboBoxEdit1);
            this.groupControl3.Controls.Add(this.comboBoxEdit2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(386, 296);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Default Value";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(50, 227);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Auto-Increment Address";
            this.checkEdit1.Size = new System.Drawing.Size(167, 19);
            this.checkEdit1.TabIndex = 32;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(21, 66);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 14);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Register Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 203);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 14);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Number of Bytes";
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "4";
            this.textEdit4.Location = new System.Drawing.Point(110, 63);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 30;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "4";
            this.textEdit1.Location = new System.Drawing.Point(109, 200);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 30;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(32, 33);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 14);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Group Name";
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "0";
            this.textEdit3.Location = new System.Drawing.Point(110, 30);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 24;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(25, 170);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 14);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Offset       0x";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "0";
            this.textEdit2.Location = new System.Drawing.Point(109, 167);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(25, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 14);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Transfer Type";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(25, 100);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 14);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Transfer Mode";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(109, 132);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 27;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(109, 97);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit2.TabIndex = 26;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 268);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(479, 34);
            this.panelControl1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(295, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // OptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 302);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tabOptions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tabRegTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAutoInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumBytes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOffset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransMode.Properties)).EndInit();
            this.tabboardScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDeviceId.Properties)).EndInit();
            this.tabBoardConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabOptions;
        private DevExpress.XtraTab.XtraTabPage tabRegTest;
        private DevExpress.XtraTab.XtraTabPage tabboardScan;
        private DevExpress.XtraTab.XtraTabPage tabBoardConfig;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl Vendor;
        private DevExpress.XtraEditors.TextEdit editVendor;
        private DevExpress.XtraEditors.TextEdit editDeviceId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditOffset;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboTransType;
        private DevExpress.XtraEditors.ComboBoxEdit comboTransMode;
        private DevExpress.XtraEditors.CheckEdit checkEditAutoInc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textNumBytes;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
    }
}