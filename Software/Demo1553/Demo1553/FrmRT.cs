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
using System.Runtime.InteropServices;
using DevExpress.Utils;

namespace Demo1553
{
    public partial class FrmRT : DevExpress.XtraEditors.XtraForm
    {
        RT BoundRT;
        
        public FrmRT()
        {
            InitializeComponent();
        }
        public FrmRT(RT rt)
        {
            InitializeComponent();
            InitializeStatusBtn();
            BoundRT = rt;
            this.gridControlConfig.DataSource = BoundRT.RTMsgList;
            this.gridControlMonitor.DataSource = BoundRT.MonitorMsgList;
            this.gridViewMonitor.OptionsBehavior.Editable = false;
            this.gridViewMonitor.OptionsBehavior.ReadOnly = true;
        }
        #region 初始化状态按钮
        private void InitializeStatusBtn()
        {
            checkButtonRTr = new DevExpress.XtraEditors.CheckButton[30];
            checkButtonRTr[0] = this.checkButton1;
            checkButtonRTr[1] = this.checkButton2;
            checkButtonRTr[2] = this.checkButton3;
            checkButtonRTr[3] = this.checkButton4;
            checkButtonRTr[4] = this.checkButton5;
            checkButtonRTr[5] = this.checkButton6;
            checkButtonRTr[6] = this.checkButton7;
            checkButtonRTr[7] = this.checkButton8;
            checkButtonRTr[8] = this.checkButton9;
            checkButtonRTr[9] = this.checkButton10;
            checkButtonRTr[10] = this.checkButton11;
            checkButtonRTr[11] = this.checkButton12;
            checkButtonRTr[12] = this.checkButton13;
            checkButtonRTr[13] = this.checkButton14;
            checkButtonRTr[14] = this.checkButton15;
            checkButtonRTr[15] = this.checkButton16;
            checkButtonRTr[16] = this.checkButton17;
            checkButtonRTr[17] = this.checkButton18;
            checkButtonRTr[18] = this.checkButton19;
            checkButtonRTr[19] = this.checkButton20;
            checkButtonRTr[20] = this.checkButton21;
            checkButtonRTr[21] = this.checkButton22;
            checkButtonRTr[22] = this.checkButton23;
            checkButtonRTr[23] = this.checkButton24;
            checkButtonRTr[24] = this.checkButton25;
            checkButtonRTr[25] = this.checkButton26;
            checkButtonRTr[26] = this.checkButton27;
            checkButtonRTr[27] = this.checkButton28;
            checkButtonRTr[28] = this.checkButton29;
            checkButtonRTr[29] = this.checkButton30;
        }
        #endregion
        private void FrmRT_Load(object sender, EventArgs e)
        {
            InitGridView();
            BoundRT.IsRunning = true;
            bool[] rtStatus = BoundRT.GetRTStatus();
            for (int i = 0; i < rtStatus.Length; i++)
            {
                checkButtonRTr[i].Checked = !rtStatus[i];
            }
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
            this.gridViewMonitor.Columns["WordSize"].Caption = "数据字长度";
            this.gridViewMonitor.Columns["dt"].Caption = "△T";
            #endregion
            #region 配置列表
            this.gridViewConfig.Columns["Name"].Visible = false;
            this.gridViewConfig.Columns["Tag"].Visible = false;
            this.gridViewConfig.Columns["Payload"].Visible = false;
            this.gridViewConfig.Columns["NetId"].Caption = "ID";
            this.gridViewConfig.Columns["Name"].Caption = "Name";
            this.gridViewConfig.Columns["RTAddr"].Caption = "RT地址";
            this.gridViewConfig.Columns["SubRTAddr"].Caption = "RT子地址";
            this.gridViewConfig.Columns["Length"].Caption = "数据长度";
            #endregion
        }

        private void checkButtonRTr_Click(object sender, EventArgs e)
        {
            CheckButton chbtn = sender as CheckButton;
            int rtAddr = int.Parse(chbtn.Text);
            BoundRT.SetRTStatus(rtAddr, !chbtn.Checked);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            SimpleButton cBtn = sender as SimpleButton;
            if (cBtn.Text.Equals("全选"))
            {
                isChecked = true;
            }
            for (int rtAddr = 1; rtAddr < 31; rtAddr++)
            {
                BoundRT.SetRTStatus(rtAddr, isChecked);
                checkButtonRTr[rtAddr-1].Checked = !isChecked;
            }           
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
            uint length = (uint)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Length"]);
            uint dataLength = length * 2;
            byte[] array = new byte[dataLength];
            byte[] recvData = (byte[])this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Payload"]);
            Buffer.BlockCopy(recvData, 0, array, 0, (int)dataLength);
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }

        /// <summary>
        /// 设置新建数据初始值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewConfig_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int count = BoundRT.RTMsgList.Count;
            BoundRT.RTMsgList[count - 1].Length = 1;
            BoundRT.RTMsgList[count - 1].RTAddr = 1;
            BoundRT.RTMsgList[count - 1].SubRTAddr = 1;
            FrmAddRTMsg frm = new FrmAddRTMsg(BoundRT.RTMsgList[count - 1]);
            frm.ShowDialog();
            gridControlConfig.RefreshDataSource();
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
                    BoundRTMessage msg = (BoundRTMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
                    FrmAddRTMsg frm = new FrmAddRTMsg(msg);
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
            BoundRTMessage msg = (BoundRTMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
            FrmAddRTMsg frm = new FrmAddRTMsg(msg);
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
                BoundRT.RTMsgList.Clear();
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
                BoundRTMessage msg = (BoundRTMessage)this.gridViewConfig.GetRowCellValue(this.gridViewConfig.FocusedRowHandle, this.gridViewConfig.Columns["Tag"]);
                IntPtr ptr;
                ptr = Marshal.AllocHGlobal((int)msg.Length);
                Marshal.StructureToPtr(msg.Payload, ptr, false);
                CardManager.WriteMsg(msg.NetId, ptr, (int)msg.Length);
            }
        }
        #endregion

        private void FrmRT_FormClosing(object sender, FormClosingEventArgs e)
        {
            BoundRT.IsRunning = false;
        }

    }
}