namespace WinDriverDemo.Options
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
            this.tabAdvanced = new DevExpress.XtraTab.XtraTabPage();
            this.高级选项设置 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboHexRecvType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboHexSendType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditClearRecv = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditClearSend = new DevExpress.XtraEditors.CheckEdit();
            this.tabDefaultVal = new DevExpress.XtraTab.XtraTabPage();
            this.DefaultValue = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopBitsComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dataBitsComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.parityComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.baudRateComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sendHexRadioButton = new System.Windows.Forms.RadioButton();
            this.sendCharRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.acceptHexRadioButton = new System.Windows.Forms.RadioButton();
            this.acceptCharRadioButton = new System.Windows.Forms.RadioButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).BeginInit();
            this.tabOptions.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.高级选项设置)).BeginInit();
            this.高级选项设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboHexRecvType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboHexSendType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditClearRecv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditClearSend.Properties)).BeginInit();
            this.tabDefaultVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultValue)).BeginInit();
            this.DefaultValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBitsComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parityComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateComboBox.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tabOptions.SelectedTabPage = this.tabAdvanced;
            this.tabOptions.Size = new System.Drawing.Size(479, 302);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDefaultVal,
            this.tabAdvanced});
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.tabAdvanced.Appearance.Header.Options.UseBackColor = true;
            this.tabAdvanced.Controls.Add(this.高级选项设置);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(414, 297);
            this.tabAdvanced.Text = "高级选项";
            // 
            // 高级选项设置
            // 
            this.高级选项设置.Controls.Add(this.labelControl6);
            this.高级选项设置.Controls.Add(this.labelControl5);
            this.高级选项设置.Controls.Add(this.comboHexRecvType);
            this.高级选项设置.Controls.Add(this.comboHexSendType);
            this.高级选项设置.Controls.Add(this.checkEditClearRecv);
            this.高级选项设置.Controls.Add(this.checkEditClearSend);
            this.高级选项设置.Dock = System.Windows.Forms.DockStyle.Fill;
            this.高级选项设置.Location = new System.Drawing.Point(0, 0);
            this.高级选项设置.Name = "高级选项设置";
            this.高级选项设置.Size = new System.Drawing.Size(414, 297);
            this.高级选项设置.TabIndex = 8;
            this.高级选项设置.Text = "高级选项设置";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(183, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 14);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "十六进制接收设置";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(183, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 14);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "十六进制发送设置";
            // 
            // comboHexRecvType
            // 
            this.comboHexRecvType.Enabled = false;
            this.comboHexRecvType.Location = new System.Drawing.Point(285, 60);
            this.comboHexRecvType.Name = "comboHexRecvType";
            this.comboHexRecvType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboHexRecvType.Size = new System.Drawing.Size(100, 20);
            this.comboHexRecvType.TabIndex = 1;
            // 
            // comboHexSendType
            // 
            this.comboHexSendType.Enabled = false;
            this.comboHexSendType.Location = new System.Drawing.Point(285, 36);
            this.comboHexSendType.Name = "comboHexSendType";
            this.comboHexSendType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboHexSendType.Size = new System.Drawing.Size(100, 20);
            this.comboHexSendType.TabIndex = 1;
            // 
            // checkEditClearRecv
            // 
            this.checkEditClearRecv.Location = new System.Drawing.Point(15, 60);
            this.checkEditClearRecv.Name = "checkEditClearRecv";
            this.checkEditClearRecv.Properties.Caption = "自动清空接收数据";
            this.checkEditClearRecv.Size = new System.Drawing.Size(123, 19);
            this.checkEditClearRecv.TabIndex = 0;
            // 
            // checkEditClearSend
            // 
            this.checkEditClearSend.Location = new System.Drawing.Point(15, 35);
            this.checkEditClearSend.Name = "checkEditClearSend";
            this.checkEditClearSend.Properties.Caption = "自动清空发送数据";
            this.checkEditClearSend.Size = new System.Drawing.Size(123, 19);
            this.checkEditClearSend.TabIndex = 0;
            // 
            // tabDefaultVal
            // 
            this.tabDefaultVal.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.tabDefaultVal.Appearance.Header.Options.UseBackColor = true;
            this.tabDefaultVal.Controls.Add(this.DefaultValue);
            this.tabDefaultVal.Name = "tabDefaultVal";
            this.tabDefaultVal.Size = new System.Drawing.Size(414, 297);
            this.tabDefaultVal.Text = "默认值";
            // 
            // DefaultValue
            // 
            this.DefaultValue.Controls.Add(this.groupBox1);
            this.DefaultValue.Controls.Add(this.groupBox5);
            this.DefaultValue.Controls.Add(this.groupBox4);
            this.DefaultValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultValue.Location = new System.Drawing.Point(0, 0);
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.Size = new System.Drawing.Size(414, 297);
            this.DefaultValue.TabIndex = 0;
            this.DefaultValue.Text = "初始值设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopBitsComboBox);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.dataBitsComboBox);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.parityComboBox);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.baudRateComboBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.Location = new System.Drawing.Point(87, 138);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stopBitsComboBox.Properties.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsComboBox.Size = new System.Drawing.Size(100, 20);
            this.stopBitsComboBox.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 14);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "停止位:";
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.Location = new System.Drawing.Point(87, 103);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataBitsComboBox.Properties.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.dataBitsComboBox.Size = new System.Drawing.Size(100, 20);
            this.dataBitsComboBox.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "数据位:";
            // 
            // parityComboBox
            // 
            this.parityComboBox.Location = new System.Drawing.Point(87, 68);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parityComboBox.Properties.Items.AddRange(new object[] {
            "无校验(None)",
            "偶校验(Even)",
            "奇校验(Odd)",
            "保留为0(Space)",
            "保留为1(Mark)"});
            this.parityComboBox.Size = new System.Drawing.Size(100, 20);
            this.parityComboBox.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "波特率:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "校验位:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Location = new System.Drawing.Point(87, 33);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baudRateComboBox.Properties.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "128000",
            "256000"});
            this.baudRateComboBox.Size = new System.Drawing.Size(100, 20);
            this.baudRateComboBox.TabIndex = 27;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sendHexRadioButton);
            this.groupBox5.Controls.Add(this.sendCharRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(234, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 82);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送方式";
            // 
            // sendHexRadioButton
            // 
            this.sendHexRadioButton.AutoSize = true;
            this.sendHexRadioButton.Location = new System.Drawing.Point(38, 50);
            this.sendHexRadioButton.Name = "sendHexRadioButton";
            this.sendHexRadioButton.Size = new System.Drawing.Size(73, 18);
            this.sendHexRadioButton.TabIndex = 3;
            this.sendHexRadioButton.Text = "十六进制";
            this.sendHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendCharRadioButton
            // 
            this.sendCharRadioButton.AutoSize = true;
            this.sendCharRadioButton.Checked = true;
            this.sendCharRadioButton.Location = new System.Drawing.Point(38, 23);
            this.sendCharRadioButton.Name = "sendCharRadioButton";
            this.sendCharRadioButton.Size = new System.Drawing.Size(49, 18);
            this.sendCharRadioButton.TabIndex = 2;
            this.sendCharRadioButton.TabStop = true;
            this.sendCharRadioButton.Text = "字符";
            this.sendCharRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.acceptHexRadioButton);
            this.groupBox4.Controls.Add(this.acceptCharRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(234, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 82);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收方式";
            // 
            // acceptHexRadioButton
            // 
            this.acceptHexRadioButton.AutoSize = true;
            this.acceptHexRadioButton.Location = new System.Drawing.Point(38, 50);
            this.acceptHexRadioButton.Name = "acceptHexRadioButton";
            this.acceptHexRadioButton.Size = new System.Drawing.Size(73, 18);
            this.acceptHexRadioButton.TabIndex = 3;
            this.acceptHexRadioButton.Text = "十六进制";
            this.acceptHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // acceptCharRadioButton
            // 
            this.acceptCharRadioButton.AutoSize = true;
            this.acceptCharRadioButton.Checked = true;
            this.acceptCharRadioButton.Location = new System.Drawing.Point(38, 23);
            this.acceptCharRadioButton.Name = "acceptCharRadioButton";
            this.acceptCharRadioButton.Size = new System.Drawing.Size(49, 18);
            this.acceptCharRadioButton.TabIndex = 2;
            this.acceptCharRadioButton.TabStop = true;
            this.acceptCharRadioButton.Text = "字符";
            this.acceptCharRadioButton.UseVisualStyleBackColor = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsFrm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.高级选项设置)).EndInit();
            this.高级选项设置.ResumeLayout(false);
            this.高级选项设置.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboHexRecvType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboHexSendType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditClearRecv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditClearSend.Properties)).EndInit();
            this.tabDefaultVal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DefaultValue)).EndInit();
            this.DefaultValue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBitsComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBitsComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parityComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateComboBox.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabOptions;
        private DevExpress.XtraTab.XtraTabPage tabDefaultVal;
        private DevExpress.XtraTab.XtraTabPage tabAdvanced;
        private DevExpress.XtraEditors.GroupControl 高级选项设置;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.GroupControl DefaultValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit stopBitsComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit dataBitsComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit parityComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit baudRateComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton sendHexRadioButton;
        private System.Windows.Forms.RadioButton sendCharRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton acceptHexRadioButton;
        private System.Windows.Forms.RadioButton acceptCharRadioButton;
        private DevExpress.XtraEditors.CheckEdit checkEditClearSend;
        private DevExpress.XtraEditors.CheckEdit checkEditClearRecv;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboHexSendType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit comboHexRecvType;
    }
}