namespace ESPHelper.DocControl
{
    partial class CardInfoControl
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditCardType = new DevExpress.XtraEditors.TextEdit();
            this.textEditDevId = new DevExpress.XtraEditors.TextEdit();
            this.textEditCardName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCardProp = new DevExpress.XtraGrid.GridControl();
            this.gridViewCardProp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlChannelProp = new DevExpress.XtraGrid.GridControl();
            this.gridViewChannelProp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDevId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCardProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCardProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChannelProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChannelProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditCardType);
            this.groupControl1.Controls.Add(this.textEditDevId);
            this.groupControl1.Controls.Add(this.textEditCardName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(533, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "基本信息";
            // 
            // textEditCardType
            // 
            this.textEditCardType.Location = new System.Drawing.Point(101, 67);
            this.textEditCardType.Name = "textEditCardType";
            this.textEditCardType.Properties.ReadOnly = true;
            this.textEditCardType.Size = new System.Drawing.Size(148, 20);
            this.textEditCardType.TabIndex = 1;
            // 
            // textEditDevId
            // 
            this.textEditDevId.Location = new System.Drawing.Point(374, 33);
            this.textEditDevId.Name = "textEditDevId";
            this.textEditDevId.Properties.ReadOnly = true;
            this.textEditDevId.Size = new System.Drawing.Size(148, 20);
            this.textEditDevId.TabIndex = 1;
            // 
            // textEditCardName
            // 
            this.textEditCardName.Location = new System.Drawing.Point(101, 34);
            this.textEditCardName.Name = "textEditCardName";
            this.textEditCardName.Properties.ReadOnly = true;
            this.textEditCardName.Size = new System.Drawing.Size(148, 20);
            this.textEditCardName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(307, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "设备编号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "板卡类型";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "板卡名称";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlCardProp);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(533, 139);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "板卡参数";
            // 
            // gridControlCardProp
            // 
            this.gridControlCardProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCardProp.Location = new System.Drawing.Point(2, 21);
            this.gridControlCardProp.MainView = this.gridViewCardProp;
            this.gridControlCardProp.Name = "gridControlCardProp";
            this.gridControlCardProp.Size = new System.Drawing.Size(529, 116);
            this.gridControlCardProp.TabIndex = 1;
            this.gridControlCardProp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCardProp});
            // 
            // gridViewCardProp
            // 
            this.gridViewCardProp.GridControl = this.gridControlCardProp;
            this.gridViewCardProp.Name = "gridViewCardProp";
            this.gridViewCardProp.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridViewCardProp.OptionsBehavior.ReadOnly = true;
            this.gridViewCardProp.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlChannelProp);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(533, 153);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "通道参数";
            // 
            // gridControlChannelProp
            // 
            this.gridControlChannelProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChannelProp.Location = new System.Drawing.Point(2, 21);
            this.gridControlChannelProp.MainView = this.gridViewChannelProp;
            this.gridControlChannelProp.Name = "gridControlChannelProp";
            this.gridControlChannelProp.Size = new System.Drawing.Size(529, 130);
            this.gridControlChannelProp.TabIndex = 0;
            this.gridControlChannelProp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChannelProp});
            // 
            // gridViewChannelProp
            // 
            this.gridViewChannelProp.GridControl = this.gridControlChannelProp;
            this.gridViewChannelProp.Name = "gridViewChannelProp";
            this.gridViewChannelProp.OptionsBehavior.Editable = false;
            this.gridViewChannelProp.OptionsBehavior.ReadOnly = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 100);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(533, 297);
            this.splitContainerControl1.SplitterPosition = 139;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // CardInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "CardInfoControl";
            this.Size = new System.Drawing.Size(533, 397);
            this.Load += new System.EventHandler(this.CardInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDevId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCardProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCardProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChannelProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChannelProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlChannelProp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChannelProp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditCardName;
        private DevExpress.XtraEditors.TextEdit textEditCardType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlCardProp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCardProp;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit textEditDevId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
