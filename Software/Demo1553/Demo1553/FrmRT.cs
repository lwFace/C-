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
            _BoundRT = rt;
            this.gridControl1.DataSource = _BoundRT.RTMsgList;
        }
        private void FrmRT_Load(object sender, EventArgs e)
        {
           bool []rtStatus = _BoundRT.GetRTStatus();
           for (int i = 0; i < rtStatus.Length; i++)
           {
               checkButtonRTr[i].Checked = !rtStatus[i];
           }
            // this.gridControl1.DataSource = RTMsgList;
            this.gridView1.Columns["UUID"].Visible = false;
            this.gridView1.Columns["Payload"].Visible = false;

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

    }
}