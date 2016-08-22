using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Be.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;
using DevExpress.Utils;

namespace Demo1553
{
    public partial class FrmBC : DevExpress.XtraEditors.XtraForm
    {
        BC BoundBC;
        public FrmBC()
        {
            InitializeComponent();
        }

        public FrmBC(BC bc)
        {
            InitializeComponent();
            BoundBC = bc;
            this.gridControlConfig.DataSource = BoundBC.ScheduMsgList;
            this.gridControlMonitor.DataSource = BoundBC.MonitorMsgList;
            this.gridViewMonitor.OptionsBehavior.Editable = false;
            this.gridViewMonitor.OptionsBehavior.ReadOnly = true;
        }

        private void FrmBC_Load(object sender, EventArgs e)
        {
            InitGridView();
            BoundBC.IsRunning = true;
        }
        /// <summary>
        /// 初始化GridView
        /// </summary>
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
            #region 配置列表
            this.gridViewConfig.Columns["Payload"].Visible = false;            
            this.gridViewConfig.Columns["Tag"].Visible = false;
            this.gridViewConfig.Columns["Cmd1"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewConfig.Columns["Cmd1"].DisplayFormat.FormatString = "X4";
            this.gridViewConfig.Columns["Cmd2"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridViewConfig.Columns["Cmd2"].DisplayFormat.FormatString = "X4";
            this.gridViewConfig.Columns["NetId"].Caption = "ID";
            this.gridViewConfig.Columns["Cmd2"].Caption = "命令字2";
            this.gridViewConfig.Columns["Cmd1"].Caption = "命令字1";
            this.gridViewConfig.Columns["SrcRTAddr"].Caption = "源RT地址";
            this.gridViewConfig.Columns["SrcSubRTAddr"].Caption = "源RT子地址";
            this.gridViewConfig.Columns["DstRTAddr"].Caption = "目的RT地址";
            this.gridViewConfig.Columns["DstSubRTAddr"].Caption = "目的RT子地址";
            this.gridViewConfig.Columns["Period"].Caption = "周期(ms)";
            this.gridViewConfig.Columns["WordSize"].Caption = "数据字长度";
            this.gridViewConfig.Columns["MsgType"].Caption = "消息类型";
            #endregion
        }
        /// <summary>
        /// 设置新建数据初始值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewConfig_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int count = BoundBC.ScheduMsgList.Count;
            BoundBC.ScheduMsgList[count - 1].WordSize = 1;
            BoundBC.ScheduMsgList[count - 1].SrcSubRTAddr = 1;
            BoundBC.ScheduMsgList[count - 1].DstRTAddr = 1;
            BoundBC.ScheduMsgList[count - 1].SrcRTAddr = 1;
            BoundBC.ScheduMsgList[count - 1].DstSubRTAddr = 1;
            FrmAddMsg frm = new FrmAddMsg(BoundBC.ScheduMsgList[count-1]);
            frm.ShowDialog();
            gridControlConfig.RefreshDataSource();
        }
        /// <summary>
        /// 单击监控列表，查看监控数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 单击配置列表，查看消息配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewConfig_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int wordSize = (int)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["WordSize"]);
            int dataLength = wordSize * 2;
            byte[] array = new byte[dataLength];
            byte[] recvData = (byte[])this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Payload"]);
            Buffer.BlockCopy(recvData, 0, array, 0, dataLength);
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;  
        }
        /// <summary>
        /// 双击配置列表，编辑消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewConfig_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridViewConfig.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内 
                if (hInfo.InRow)
                {
                    BoundMessage msg = (BoundMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
                    FrmAddMsg frm = new FrmAddMsg(msg);
                    frm.ShowDialog();
                }
            }
        }

        #region 配置列表菜单
        /// <summary>
        /// 右键菜单条件使能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewConfig_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            itemEdit.Enabled = false;         
            itemDelete.Enabled = false;
            //获取选择的行数
            int select = gridViewConfig.SelectedRowsCount;
            if (select == 1)
            {
                itemEdit.Enabled = true;
            }
            if (select > 0)
            {
                itemDelete.Enabled = true;
                itemTrasmit.Enabled = true;
            }
        }
        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemAdd_Click(object sender, EventArgs e)
        {
            gridViewConfig.AddNewRow();
        }
        /// <summary>
        /// 编辑消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemEdit_Click(object sender, EventArgs e)
        {
            BoundMessage msg = (BoundMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
            FrmAddMsg frm = new FrmAddMsg(msg);
            frm.ShowDialog();
        }
        /// <summary>
        /// 删除选中消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定删除选中消息？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
            {
                while (gridViewConfig.SelectedRowsCount > 0)
                {
                    int handle = gridViewConfig.GetSelectedRows()[0];
                     gridViewConfig.DeleteRow(handle);
                }
            }
        }
        /// <summary>
        /// 清空消息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemClear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定清空消息列表？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
            {
                BoundBC.ScheduMsgList.Clear();
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemTrasmit_Click(object sender, EventArgs e)
        {
            foreach (var handle in gridViewConfig.GetSelectedRows())
            {
                BoundMessage msg = (BoundMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
                IntPtr ptr;
                ptr = Marshal.AllocHGlobal(msg.WordSize*2);
                Marshal.StructureToPtr(msg.Payload, ptr, false);
                CardManager.WriteMsg(msg.NetId, ptr, msg.WordSize);
            }
        }
        #endregion

        private void FrmBC_FormClosing(object sender, FormClosingEventArgs e)
        {
            BoundBC.IsRunning = false;
        } 

    }
}