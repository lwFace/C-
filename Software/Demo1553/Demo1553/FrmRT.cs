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

namespace Demo1553
{
    public partial class FrmRT : DevExpress.XtraEditors.XtraForm
    {
        RT _BoundRT;
        
        public FrmRT()
        {
            InitializeComponent();
        }
        public FrmRT(RT rt)
        {
            InitializeComponent();
            InitializeStatusBtn();
            _BoundRT = rt;
            this.gridControl1.DataSource = _BoundRT.RTMsgList;
            this.gridControl2.DataSource = _BoundRT.moniMsgList;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
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
            bool[] rtStatus = _BoundRT.GetRTStatus();
            for (int i = 0; i < rtStatus.Length; i++)
            {
                checkButtonRTr[i].Checked = !rtStatus[i];
            }
            // this.gridControl1.DataSource = RTMsgList;
            //  this.gridView1.Columns["UUID"].Visible = false;
            //this.gridView1.Columns["Payload"].Visible = false;

            byte[] array = new byte[8];
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }


        private void checkButtonRTr_Click(object sender, EventArgs e)
        {
            CheckButton chbtn = sender as CheckButton;
            int rtAddr = int.Parse(chbtn.Text);
            _BoundRT.SetRTStatus(rtAddr, !chbtn.Checked);
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
                _BoundRT.SetRTStatus(rtAddr, isChecked);
                checkButtonRTr[rtAddr-1].Checked = !isChecked;
            }           
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Console.Write(_BoundRT.RTMsgList);
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Console.Write(_BoundRT.moniMsgList);
        }

    }
}