using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Demo1553
{
    public partial class FrmAddRTMsg : DevExpress.XtraEditors.XtraForm
    {
        XtraForm frm;
        Button btnn;
        TextEdit[] textEditGroup;
        private BoundRTMessage boundRTMessage;

        public FrmAddRTMsg()
        {
            InitializeComponent();
        }

        public FrmAddRTMsg(BoundRTMessage boundRTMessage)
        {
            // TODO: Complete member initialization        
            InitializeComponent();
            this.boundRTMessage = boundRTMessage;
            //UpdateUI();
        }

        private void FrmAddRTMsg_Load(object sender, EventArgs e)
        {
            #region TextEdit 数组
            textEditGroup = new TextEdit[32];
            textEditGroup[0] = textEdit1;
            textEditGroup[1] = textEdit2;
            textEditGroup[2] = textEdit3;
            textEditGroup[3] = textEdit4;
            textEditGroup[4] = textEdit5;
            textEditGroup[5] = textEdit6;
            textEditGroup[6] = textEdit7;
            textEditGroup[7] = textEdit8;
            textEditGroup[8] = textEdit9;
            textEditGroup[9] = textEdit10;
            textEditGroup[10] = textEdit11;
            textEditGroup[11] = textEdit12;
            textEditGroup[12] = textEdit13;
            textEditGroup[13] = textEdit14;
            textEditGroup[14] = textEdit15;
            textEditGroup[15] = textEdit16;
            textEditGroup[16] = textEdit17;
            textEditGroup[17] = textEdit18;
            textEditGroup[18] = textEdit19;
            textEditGroup[19] = textEdit20;
            textEditGroup[20] = textEdit21;
            textEditGroup[21] = textEdit22;
            textEditGroup[22] = textEdit23;
            textEditGroup[23] = textEdit24;
            textEditGroup[24] = textEdit25;
            textEditGroup[25] = textEdit26;
            textEditGroup[26] = textEdit27;
            textEditGroup[27] = textEdit28;
            textEditGroup[28] = textEdit29;
            textEditGroup[29] = textEdit30;
            textEditGroup[30] = textEdit31;
            textEditGroup[31] = textEdit32;
            foreach (var tEdit in textEditGroup)
            {
                tEdit.Properties.Mask.EditMask = "[0-9A-F]{1,4}";
                tEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                //   tEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            UpdateUI();
            #endregion
        }
        /// <summary>
        /// 获取界面中的有效数据
        /// </summary>
        private byte[] GetPayload()
        {
            int wSize = int.Parse(textBoxLen.Text);
            byte[] payload = new byte[wSize * 2];
            try
            {
                for (int i = 0; i < wSize; i++)
                {
                    string pStr = textEditGroup[i].Text.Trim();
                    for (int j = 0; j < pStr.Length / 2; j++)
                    {
                        payload[i * 2 + 1 - j] = Convert.ToByte(pStr.Substring(j * 2, 2), 16);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FrmBC), ex);
            }
            return payload;    
        }
        /// <summary>
        /// 将消息中的Payload数据更新到界面
        /// </summary>
        /// <param name="payload"></param>
        private void SetPayload(byte[] payload)
        {
            int wordSize = payload.Length / 2;
            for (int i = 0; i < wordSize; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < 2; j++)
                {
                    sb.Append(payload[i * 2 + 1-j].ToString("X2"));
                }
                textEditGroup[i].Text = sb.ToString();
            }
        }
        private void UpdateUI()
        {
            try
            {
                textBoxLen.DataBindings.Clear();
                textBoxSA.DataBindings.Clear();
                textBoxRT.DataBindings.Clear();
                textBoxLen.DataBindings.Add("EditValue", boundRTMessage, "Length");
                textBoxRT.DataBindings.Add("EditValue", boundRTMessage, "RTAddr");
                textBoxSA.DataBindings.Add("EditValue", boundRTMessage, "SubRTAddr");
                SetPayload(boundRTMessage.Payload);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FrmAddRTMsg), ex);
            }
        }

        private void UpdateMsg()
        {
            boundRTMessage.Length = uint.Parse(textBoxLen.Text);
            boundRTMessage.RTAddr = byte.Parse(textBoxRT.Text);
            boundRTMessage.SubRTAddr = byte.Parse(textBoxSA.Text);
            boundRTMessage.Payload = GetPayload();
        }

        private void textBoxLen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int wc = int.Parse(textBoxLen.Text);
                if (wc > 32)
                {
                    wc = 32;
                }
                for (int i = 0; i < wc; i++)
                {
                    textEditGroup[i].Enabled = true;
                }
                for (int i = 0; i < 32 - wc; i++)
                {
                    textEditGroup[31 - i].Enabled = false;
                }  
            }
              catch(Exception ex)
            {

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UpdateMsg();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HidePayload(bool bHidePayload, bool bHideCmd2)
        {
            const int CMD2Height = 28;
            const int groupBoxCmdConfigHeight = 215 - CMD2Height;
            const int groupBoxCmdConfigLocationY = 77 - CMD2Height;
            const int FrmHeight = 381 - CMD2Height;
            groupPayload.Top = groupBoxCmdConfigLocationY;
            if (bHidePayload)
            {
                groupPayload.Visible = false;
                if (bHideCmd2)
                {
                    groupBoxCmdConfig.Height = groupBoxCmdConfigHeight - 132;
                    this.Height = FrmHeight - 132;
                }
                else
                {
                    groupBoxCmdConfig.Height = groupBoxCmdConfigHeight - 132 + CMD2Height;
                    this.Height = FrmHeight - 132 + CMD2Height;
                }
            }
            else
            {
                groupPayload.Visible = true;
                groupBoxCmdConfig.Height = groupBoxCmdConfigHeight;
                this.Height = FrmHeight;
            }

        }

    }
}
