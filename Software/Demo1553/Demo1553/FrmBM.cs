using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo1553.Class;
using Be.Windows.Forms;
using DevExpress.Utils;

namespace Demo1553
{
    public partial class FrmBM : DevExpress.XtraEditors.XtraForm
    {
        BM BoundBM;
        public FrmBM()
        {
            InitializeComponent();
        }
        public FrmBM(BM bm)
        {
            InitializeComponent();
            BoundBM = bm;
            this.gridControl2.DataSource = BoundBM.MonitorMsgList;
            this.gridViewMonitor.OptionsBehavior.Editable = false;
            this.gridViewMonitor.OptionsBehavior.ReadOnly = true;
        }

        private void FrmBM_Load(object sender, EventArgs e)
        {
            InitGridView();
            BoundBM.IsRunning = true;
        }

        private void InitGridView()
        {
            #region 监控列表
            this.gridViewMonitor.Columns["Payload"].Visible = false;
            this.gridViewMonitor.Columns["src"].Visible = false;
            this.gridViewMonitor.Columns["cmd1"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewMonitor.Columns["cmd1"].DisplayFormat.FormatString = "X4";
            this.gridViewMonitor.Columns["cmd2"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewMonitor.Columns["cmd2"].DisplayFormat.FormatString = "X4";
            this.gridViewMonitor.Columns["status1"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewMonitor.Columns["status1"].DisplayFormat.FormatString = "X4";
            this.gridViewMonitor.Columns["status2"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewMonitor.Columns["status2"].DisplayFormat.FormatString = "X4";
            //this.gridViewMonitor.Columns["src"].Caption = "物理地址信息";
            this.gridViewMonitor.Columns["msgId"].Caption = "ID";
            this.gridViewMonitor.Columns["cmd2"].Caption = "命令字2";
            this.gridViewMonitor.Columns["cmd1"].Caption = "命令字1";
            this.gridViewMonitor.Columns["status2"].Caption = "状态2";
            this.gridViewMonitor.Columns["status1"].Caption = "状态1";
            this.gridViewMonitor.Columns["srcAddr"].Caption = "源地址";
            this.gridViewMonitor.Columns["subSrcAddr"].Caption = "源子地址";
            this.gridViewMonitor.Columns["dstAddr"].Caption = "目标地址";
            this.gridViewMonitor.Columns["subDstAddr"].Caption = "目标子地址";
            this.gridViewMonitor.Columns["Time"].Caption = "时间戳";
            this.gridViewMonitor.Columns["Time"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridViewMonitor.Columns["Time"].DisplayFormat.FormatString = "HH:mm:ss.ffffff";
            this.gridViewMonitor.Columns["dt"].Caption = "△T";
            this.gridViewMonitor.Columns["WordSize"].Caption = "数据字长度";
            #endregion
        }

        private void gridViewMonitor_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int wordSize = (int)this.gridViewMonitor.GetRowCellValue(this.gridViewMonitor.FocusedRowHandle, this.gridViewMonitor.Columns["WordSize"]);
            int dataLength = wordSize * 2;
            byte[] array = new byte[dataLength];
            byte[] recvData = (byte[])this.gridViewMonitor.GetRowCellValue(this.gridViewMonitor.FocusedRowHandle, this.gridViewMonitor.Columns["Payload"]);
            Buffer.BlockCopy(recvData, 0, array, 0, dataLength);
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }

        private void FrmBM_FormClosing(object sender, FormClosingEventArgs e)
        {
            BoundBM.IsRunning = false;
        }
    }
}
