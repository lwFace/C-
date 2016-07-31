namespace WinDriverDemo.Modules
{
    partial class RegTest
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEditAutoInc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textNumBytes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditOffset = new DevExpress.XtraEditors.TextEdit();
            this.btnWrite = new DevExpress.XtraEditors.SimpleButton();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.editDataWrite = new DevExpress.XtraEditors.MemoEdit();
            this.editDataRead = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelAddrBar = new DevExpress.XtraEditors.LabelControl();
            this.comboTransType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboTransMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBaseAddr = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAutoInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOffset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataWrite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataRead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBaseAddr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.textEditOffset);
            this.groupControl2.Controls.Add(this.btnWrite);
            this.groupControl2.Controls.Add(this.btnRead);
            this.groupControl2.Controls.Add(this.editDataWrite);
            this.groupControl2.Controls.Add(this.editDataRead);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelAddrBar);
            this.groupControl2.Controls.Add(this.comboTransType);
            this.groupControl2.Controls.Add(this.comboTransMode);
            this.groupControl2.Controls.Add(this.comboBaseAddr);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(690, 423);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Register Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEditAutoInc);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.textNumBytes);
            this.groupBox1.Location = new System.Drawing.Point(447, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 98);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BlockTransfer";
            // 
            // checkEditAutoInc
            // 
            this.checkEditAutoInc.Location = new System.Drawing.Point(44, 62);
            this.checkEditAutoInc.Name = "checkEditAutoInc";
            this.checkEditAutoInc.Properties.Caption = "Auto-Increment Address";
            this.checkEditAutoInc.Size = new System.Drawing.Size(167, 19);
            this.checkEditAutoInc.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Number of Bytes";
            // 
            // textNumBytes
            // 
            this.textNumBytes.EditValue = "4";
            this.textNumBytes.Location = new System.Drawing.Point(104, 27);
            this.textNumBytes.Name = "textNumBytes";
            this.textNumBytes.Size = new System.Drawing.Size(100, 20);
            this.textNumBytes.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(260, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Offset 0x";
            // 
            // textEditOffset
            // 
            this.textEditOffset.EditValue = "0";
            this.textEditOffset.Location = new System.Drawing.Point(315, 88);
            this.textEditOffset.Name = "textEditOffset";
            this.textEditOffset.Size = new System.Drawing.Size(100, 20);
            this.textEditOffset.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(470, 358);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 17;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(156, 358);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // editDataWrite
            // 
            this.editDataWrite.Location = new System.Drawing.Point(359, 162);
            this.editDataWrite.Name = "editDataWrite";
            this.editDataWrite.Size = new System.Drawing.Size(305, 187);
            this.editDataWrite.TabIndex = 16;
            this.editDataWrite.UseOptimizedRendering = true;
            // 
            // editDataRead
            // 
            this.editDataRead.Location = new System.Drawing.Point(25, 162);
            this.editDataRead.Name = "editDataRead";
            this.editDataRead.Size = new System.Drawing.Size(328, 187);
            this.editDataRead.TabIndex = 16;
            this.editDataRead.UseOptimizedRendering = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Transfer Type";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Transfer Mode";
            // 
            // labelAddrBar
            // 
            this.labelAddrBar.Location = new System.Drawing.Point(29, 52);
            this.labelAddrBar.Name = "labelAddrBar";
            this.labelAddrBar.Size = new System.Drawing.Size(70, 14);
            this.labelAddrBar.TabIndex = 12;
            this.labelAddrBar.Text = "Address BAR";
            // 
            // comboTransType
            // 
            this.comboTransType.Location = new System.Drawing.Point(104, 123);
            this.comboTransType.Name = "comboTransType";
            this.comboTransType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransType.Size = new System.Drawing.Size(100, 20);
            this.comboTransType.TabIndex = 11;
            this.comboTransType.SelectedIndexChanged += new System.EventHandler(this.comboTransType_SelectedIndexChanged);
            // 
            // comboTransMode
            // 
            this.comboTransMode.Location = new System.Drawing.Point(104, 88);
            this.comboTransMode.Name = "comboTransMode";
            this.comboTransMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransMode.Size = new System.Drawing.Size(100, 20);
            this.comboTransMode.TabIndex = 10;
            // 
            // comboBaseAddr
            // 
            this.comboBaseAddr.Location = new System.Drawing.Point(104, 49);
            this.comboBaseAddr.Name = "comboBaseAddr";
            this.comboBaseAddr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBaseAddr.Size = new System.Drawing.Size(311, 20);
            this.comboBaseAddr.TabIndex = 9;
            // 
            // RegTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.Name = "RegTest";
            this.Size = new System.Drawing.Size(690, 423);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAutoInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumBytes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOffset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataWrite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataRead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBaseAddr.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnWrite;
        private DevExpress.XtraEditors.SimpleButton btnRead;
        private DevExpress.XtraEditors.MemoEdit editDataRead;
        private DevExpress.XtraEditors.CheckEdit checkEditAutoInc;
        private DevExpress.XtraEditors.TextEdit textNumBytes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelAddrBar;
        private DevExpress.XtraEditors.ComboBoxEdit comboTransType;
        private DevExpress.XtraEditors.ComboBoxEdit comboTransMode;
        private DevExpress.XtraEditors.ComboBoxEdit comboBaseAddr;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditOffset;
        private DevExpress.XtraEditors.MemoEdit editDataWrite;
    }
}
