namespace ESPHelper.DocControl
{
    partial class StiPackControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StiPackControl));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroupVal = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupPacType = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelVal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textPacLen = new DevExpress.XtraEditors.TextEdit();
            this.textEditVal = new DevExpress.XtraEditors.TextEdit();
            this.textDDSKey = new DevExpress.XtraEditors.TextEdit();
            this.textPacName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnSendOnce = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupPacType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPacLen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDDSKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPacName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroupVal);
            this.groupControl1.Controls.Add(this.radioGroupPacType);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelVal);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textPacLen);
            this.groupControl1.Controls.Add(this.textEditVal);
            this.groupControl1.Controls.Add(this.textDDSKey);
            this.groupControl1.Controls.Add(this.textPacName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(548, 152);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "报文基本信息";
            // 
            // radioGroupVal
            // 
            this.radioGroupVal.EditValue = ((byte)(0));
            this.radioGroupVal.Location = new System.Drawing.Point(335, 71);
            this.radioGroupVal.Name = "radioGroupVal";
            this.radioGroupVal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupVal.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupVal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupVal.Properties.Columns = 2;
            this.radioGroupVal.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "1")});
            this.radioGroupVal.Size = new System.Drawing.Size(100, 24);
            this.radioGroupVal.TabIndex = 3;
            this.radioGroupVal.SelectedIndexChanged += new System.EventHandler(this.radioGroupVal_SelectedIndexChanged);
            // 
            // radioGroupPacType
            // 
            this.radioGroupPacType.EditValue = ((byte)(0));
            this.radioGroupPacType.Location = new System.Drawing.Point(335, 31);
            this.radioGroupPacType.Name = "radioGroupPacType";
            this.radioGroupPacType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupPacType.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupPacType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupPacType.Properties.Columns = 3;
            this.radioGroupPacType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "模拟量", true, "模拟量"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "离散量", true, "离散量"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(2)), "数据块", true, "数据块")});
            this.radioGroupPacType.Size = new System.Drawing.Size(208, 28);
            this.radioGroupPacType.TabIndex = 2;
            this.radioGroupPacType.ToolTip = "选择一种数据 类型";
            this.radioGroupPacType.SelectedIndexChanged += new System.EventHandler(this.radioGroupPacType_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "报文长度";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "DDSKey";
            // 
            // labelVal
            // 
            this.labelVal.Location = new System.Drawing.Point(293, 75);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(36, 14);
            this.labelVal.TabIndex = 1;
            this.labelVal.Text = "报文值";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(281, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "报文类型";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "报文名称";
            // 
            // textPacLen
            // 
            this.textPacLen.Location = new System.Drawing.Point(85, 72);
            this.textPacLen.Name = "textPacLen";
            this.textPacLen.Size = new System.Drawing.Size(130, 20);
            this.textPacLen.TabIndex = 0;
            this.textPacLen.Validated += new System.EventHandler(this.textPacLen_Validated);
            // 
            // textEditVal
            // 
            this.textEditVal.Location = new System.Drawing.Point(340, 71);
            this.textEditVal.Name = "textEditVal";
            this.textEditVal.Size = new System.Drawing.Size(130, 20);
            this.textEditVal.TabIndex = 0;
            this.textEditVal.EditValueChanged += new System.EventHandler(this.textEditVal_EditValueChanged);
            // 
            // textDDSKey
            // 
            this.textDDSKey.Location = new System.Drawing.Point(85, 111);
            this.textDDSKey.Name = "textDDSKey";
            this.textDDSKey.Size = new System.Drawing.Size(130, 20);
            this.textDDSKey.TabIndex = 0;
            this.textDDSKey.EditValueChanged += new System.EventHandler(this.textDDSKey_EditValueChanged);
            // 
            // textPacName
            // 
            this.textPacName.Location = new System.Drawing.Point(85, 34);
            this.textPacName.Name = "textPacName";
            this.textPacName.Size = new System.Drawing.Size(130, 20);
            this.textPacName.TabIndex = 0;
            this.textPacName.Leave += new System.EventHandler(this.textPacName_Leave);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.hexBox);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 152);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(548, 212);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "报文内容";
            // 
            // hexBox
            // 
            this.hexBox.BodyOffset = 0;
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.ForeColor = System.Drawing.Color.Blue;
            this.hexBox.HeaderColor = System.Drawing.Color.Brown;
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(2, 21);
            this.hexBox.Name = "hexBox";
            this.hexBox.SelectionLength = ((long)(0));
            this.hexBox.SelectionStart = ((long)(-1));
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(544, 189);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 10;
            this.hexBox.UseFixedBytesPerLine = true;
            this.hexBox.VScrollBarVisible = true;
            this.hexBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hexBox_KeyUp);
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.btnSendOnce);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 364);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(548, 40);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "操作";
            // 
            // btnSendOnce
            // 
            this.btnSendOnce.Image = ((System.Drawing.Image)(resources.GetObject("btnSendOnce.Image")));
            this.btnSendOnce.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSendOnce.Location = new System.Drawing.Point(210, 6);
            this.btnSendOnce.Name = "btnSendOnce";
            this.btnSendOnce.Size = new System.Drawing.Size(75, 23);
            this.btnSendOnce.TabIndex = 0;
            this.btnSendOnce.Text = "发送";
            this.btnSendOnce.Click += new System.EventHandler(this.btnSendOnce_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chart_up_16px_512816_easyicon.net.ico");
            this.imageList1.Images.SetKeyName(1, "chart_16px_35686_easyicon.net.ico");
            this.imageList1.Images.SetKeyName(2, "chart_pie_16px_33866_easyicon.net.ico");
            // 
            // StiPackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "StiPackControl";
            this.Size = new System.Drawing.Size(548, 404);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupPacType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPacLen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDDSKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPacName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textPacName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textDDSKey;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPacLen;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Be.Windows.Forms.HexBox hexBox;
        private DevExpress.XtraEditors.SimpleButton btnSendOnce;
        private DevExpress.XtraEditors.RadioGroup radioGroupPacType;
        private DevExpress.XtraEditors.RadioGroup radioGroupVal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelVal;
        private DevExpress.XtraEditors.TextEdit textEditVal;
        private System.Windows.Forms.ImageList imageList1;
    }
}
