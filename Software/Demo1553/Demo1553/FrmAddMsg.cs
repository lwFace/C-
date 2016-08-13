using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Demo1553
{
    public partial class FrmAddMsg : DevExpress.XtraEditors.XtraForm
    {
        XtraForm frm;
        Button btnn;
        TextEdit[] textEditGroup;
        private BoundMessage boundMessage;

        #region load
        public FrmAddMsg()
        {
            InitializeComponent();
        }

        public FrmAddMsg(BoundMessage boundMessage)
        {
            // TODO: Complete member initialization        
            InitializeComponent();
            this.boundMessage = boundMessage;
            //UpdateUI();
        }

        private void FrmAddMsg_Load(object sender, EventArgs e)
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
            #endregion
     
            comboBoxMsgType_SelectedValueChanged(comboBoxMsgType, null);
        }
        #endregion

        #region 更新界面
        /// <summary>
        /// 获取界面中的有效数据
        /// </summary>
        private byte[] GetPayload()
        {
            int wSize = int.Parse(textBoxWC1.Text);
            byte[] payload = new byte[wSize * 2];
            try
            {
                for (int i = 0; i < wSize; i++)
                {
                    string pStr = textEditGroup[i].Text.Trim();
                    for (int j = 0; j < pStr.Length/2; j++)
                    {
                        payload[i*2 + 1 - j] = Convert.ToByte(pStr.Substring(j * 2, 2), 16);
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
                for(int j=0;j<2;j++)
                {
                   sb.Append(payload[i * 2 + j].ToString("X2")) ;
                }
                textEditGroup[i].Text = sb.ToString();
            }
        }
        private void UpdateUI()
        {
            try
            {
                textBoxWC1.DataBindings.Clear();
                textBoxSA1.DataBindings.Clear();
                textBoxSA2.DataBindings.Clear();
                textBoxHEX1.DataBindings.Clear();
                textBoxRT1.DataBindings.Clear();
                textBoxRT2.DataBindings.Clear();

                switch (boundMessage.MsgType)
                {
                    case MessageType.BC_RT:
                        comboBoxMsgType.SelectedIndex = 0;
                        //此处如果使用Text赋值，则校验插件工作异常
                       // textBoxWC1.Text = boundMessage.WordSize.ToString();
                       // textBoxRT1.Text = boundMessage.DstRTAddr.ToString();
                       // textBoxSA1.Text =boundMessage.DstSubRTAddr.ToString();
                        //需要进行以下设置，否则异常this.textBoxSA1.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
                        textBoxWC1.DataBindings.Add("EditValue", boundMessage, "WordSize");
                        textBoxRT1.DataBindings.Add("EditValue", boundMessage, "DstRTAddr");
                        textBoxSA1.DataBindings.Add("EditValue", boundMessage, "DstSubRTAddr");
                        textBoxHEX1.DataBindings.Add("EditValue", boundMessage, "Cmd1");
                        SetPayload(boundMessage.Payload);
                        break;
                    case MessageType.RT_BC:
                        comboBoxMsgType.SelectedIndex = 1;
                        //textBoxWC1.Text = boundMessage.WordSize.ToString();
                        //textBoxRT1.Text = boundMessage.SrcRTAddr.ToString();
                        //textBoxSA1.Text =boundMessage.SrcSubRTAddr.ToString();  
                        textBoxWC1.DataBindings.Add("EditValue", boundMessage, "WordSize");
                        textBoxRT1.DataBindings.Add("EditValue", boundMessage, "SrcRTAddr");
                        textBoxSA1.DataBindings.Add("EditValue", boundMessage, "SrcSubRTAddr");
                        textBoxHEX1.DataBindings.Add("EditValue", boundMessage, "Cmd1");
                        break;
                    case MessageType.RT_RT:
                        comboBoxMsgType.SelectedIndex = 2;
                        //textBoxWC1.Text = boundMessage.WordSize.ToString();
                        //textBoxRT1.Text = boundMessage.DstRTAddr.ToString();
                        //textBoxSA1.Text =boundMessage.DstSubRTAddr.ToString(); 
                        //textBoxRT2.Text = boundMessage.SrcRTAddr.ToString();
                        //textBoxSA2.Text =boundMessage.SrcSubRTAddr.ToString();  
                        textBoxWC1.DataBindings.Add("EditValue", boundMessage, "WordSize");
                        textBoxRT1.DataBindings.Add("EditValue", boundMessage, "DstRTAddr");
                        textBoxSA1.DataBindings.Add("EditValue", boundMessage, "DstSubRTAddr");
                        textBoxRT2.DataBindings.Add("EditValue", boundMessage, "SrcRTAddr");
                        textBoxSA2.DataBindings.Add("EditValue", boundMessage, "SrcSubRTAddr");
                        textBoxHEX1.DataBindings.Add("EditValue", boundMessage, "Cmd1");
                        textBoxHEX2.DataBindings.Add("EditValue", boundMessage, "Cmd2");
                        break;
                    default:
                        break;
                }               
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(FrmAddMsg), ex);
            }
        }
        private void UpdateMsg()
        {
            switch (comboBoxMsgType.EditValue.ToString())
            {
                case "BC_RT":
                    {
                        boundMessage.MsgType = MessageType.BC_RT;
                        boundMessage.WordSize = int.Parse(textBoxWC1.Text);
                        boundMessage.DstRTAddr = byte.Parse(textBoxRT1.Text);
                        boundMessage.DstSubRTAddr = byte.Parse(textBoxSA1.Text);
                        boundMessage.SrcRTAddr = 0xff;
                        boundMessage.SrcSubRTAddr = 0xff;
                        boundMessage.Payload = GetPayload();
                    }
                    break;
                case "RT_BC":
                    {
                        boundMessage.MsgType = MessageType.RT_BC;
                        boundMessage.WordSize = int.Parse(textBoxWC1.Text);
                        boundMessage.SrcRTAddr = byte.Parse(textBoxRT1.Text);
                        boundMessage.SrcSubRTAddr = byte.Parse(textBoxSA1.Text);
                        boundMessage.DstRTAddr = 0xff;
                        boundMessage.DstSubRTAddr = 0xff;
                    }
                    break;
                case "RT_RT":
                    {
                        boundMessage.MsgType = MessageType.RT_RT;
                        boundMessage.WordSize = int.Parse(textBoxWC1.Text);
                        boundMessage.DstRTAddr = byte.Parse(textBoxRT1.Text);
                        boundMessage.DstSubRTAddr = byte.Parse(textBoxSA1.Text);
                        boundMessage.SrcRTAddr = byte.Parse(textBoxRT2.Text);
                        boundMessage.SrcSubRTAddr = byte.Parse(textBoxSA2.Text);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        /// <summary>
        /// 动态生成按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void CreateButton(Form sender, int a, int b)
        {
            int row = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 6 == 0 && i != 0)
                {
                    row++;
                }
                Button btn = new Button();
                btn.Name = "MyButton" + i.ToString();
                btn.Height = 50 / 2;
                btn.Width = 50 / 2;
                btn.Text = i.ToString();
                btn.Font = new Font("", 6);
                btn.Location = new Point((i % 6 * 55 + 5) / 2, (row * 55 + 5) / 2);
                sender.Controls.Add(btn);
                btn.Click += new System.EventHandler(btn_Click);
            }
            Button btncancel = new Button();
            btncancel.Name = "ButtonCancel";
            btncancel.Height = 50 / 2;
            btncancel.Width = 75;
            btncancel.Text = "Cancel";
            btncancel.Location = new Point((33 % 6 * 55 + 5) / 2, (5 * 55 + 5) / 2);
            sender.Controls.Add(btncancel);
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Text;
            if (btn.Text == "Cancel")
                frm.Close();
            else
                setRT1(number);
        }
        #region 获取按钮坐标
        //获得各个AddMessageButtonCreate的位置
        public int getbuttonRT1x()
        {
            return buttonRT1.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        public int getbuttonRT1y()
        {
            return buttonRT1.Location.Y + this.Location.Y + groupBoxCmdConfig.Location.Y + 50;
        }

        public int getbuttonRT2x()
        {
            return buttonRT2.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        public int getbuttonRT2y()
        {
            return buttonRT2.Location.Y + this.Location.Y + groupBoxCmdConfig.Location.Y + 50;
        }

        public int getbuttonSA1x()
        {
            return buttonSA1.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        public int getbuttonSA1y()
        {
            return buttonSA1.Location.Y + this.Location.Y + groupBoxCmdConfig.Location.Y + 50;
        }

        public int getbuttonSA2x()
        {
            return buttonSA2.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        public int getbuttonSA2y()
        {
            return buttonSA2.Location.Y + this.Location.Y + groupBoxCmdConfig.Location.Y + 50;
        }

        public int getbuttonWC1x()
        {
            return buttonWC1.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        public int getbuttonWC1y()
        {
            return buttonWC1.Location.Y + this.Location.Y + groupBoxCmdConfig.Location.Y + 50;
        }

        public int getbuttonWC2x()
        {
            return buttonRT2.Location.X + this.Location.X + groupBoxCmdConfig.Location.X;
        }
        
        #endregion

      
        private void buttonRT1_Click(object sender, EventArgs e)
        {
            frm = new XtraForm();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int a = getbuttonRT1x();
            int b = getbuttonRT1y();
           
            frm.Width = 335 / 2;
            frm.Height = 335 / 2;
            CreateButton(frm, 0, 31);
            btnn = (Button)sender;
            frm.Location = new Point(a, b);
            frm.Show();
        }

        private void buttonSA1_Click(object sender, EventArgs e)
        {
            frm = new XtraForm();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int a = getbuttonSA1x();
            int b = getbuttonSA1y();
            frm.Location = new Point(a, b);
            frm.Width = 335 / 2;
            frm.Height = 335 / 2;
            CreateButton(frm, 1, 30);
            btnn = (Button)sender;
            frm.Show();
        }

        private void buttonWC1_Click(object sender, EventArgs e)
        {
            frm = new XtraForm();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int a = getbuttonWC1x();
            int b = getbuttonWC1y();
            frm.Location = new Point(a, b);
            frm.Width = 335 / 2;
            frm.Height = 335 / 2;
            CreateButton(frm, 1, 32);
            btnn = (Button)sender;
            frm.Show();
        }

        private void buttonRT2_Click(object sender, EventArgs e)
        {
            frm = new XtraForm();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int a = getbuttonRT2x();
            int b = getbuttonRT2y();
            frm.Location = new Point(a, b);
            frm.Width = 335 / 2;
            frm.Height = 335 / 2;
            CreateButton(frm, 0, 31);
            btnn = (Button)sender;
            frm.Show();
        }

        private void buttonSA2_Click(object sender, EventArgs e)
        {
            frm = new XtraForm();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int a = getbuttonSA2x();
            int b = getbuttonSA2y();
            frm.Location = new Point(a, b);
            frm.Width = 335 / 2;
            frm.Height = 335 / 2;
            CreateButton(frm, 1, 30);
            btnn = (Button)sender;
            frm.Show();
        }
      
        //设置对应的textbox值为相应按键数值
        public void setRT1(string str)
        {
            switch (btnn.Text)
            {
                case "...RT1":
                    this.textBoxRT1.Text = str;
                    frm.Close();
                    break;
                case "...SA1":
                    this.textBoxSA1.Text = str;
                    frm.Close();
                    break;
                case "...WC1":
                    this.textBoxWC1.Text = str;
                    frm.Close();
                    break;
                case "...WC2":
                    this.textBoxWC2.Text = str;
                    frm.Close();
                    break;
                case "...RT2":
                    this.textBoxRT2.Text = str;
                    frm.Close();
                    break;
                case "...SA2":
                    this.textBoxSA2.Text = str;
                    frm.Close();
                    break;
                default:                   
                    break;
            }
        }
        private void textBoxWC1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxMsgType.EditValue.ToString().Equals("BC_RT"))
            {
                int wc = int.Parse(textBoxWC1.Text);
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
            textBoxWC2.Text = textBoxWC1.Text;
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

        
        #region 更换消息类型
        private void comboBoxMsgType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cEdit = sender as ComboBoxEdit;
            switch(cEdit.EditValue.ToString())
            {
                case "BC_RT":
                    {
                        boundMessage.MsgType = MessageType.BC_RT;
                        HidePayload(false, true);
                        labelRT2.Visible = false;
                        labelSA2.Visible = false;
                        labelWC2.Visible = false;
                        labelHEX2.Visible = false;
                        textBoxRT2.Visible = false;
                        textBoxSA2.Visible = false;
                        textBoxWC2.Visible = false;
                        textBoxHEX2.Visible = false;
                        buttonRT2.Visible = false;
                        buttonSA2.Visible = false;
                        labelCWD2.Visible = false;
                        UpdateUI();
                    }
                    break;
                case "RT_BC":
                    {
                        boundMessage.MsgType = MessageType.RT_BC;
                        HidePayload(true, true);
                        labelRT2.Visible = false;
                        labelSA2.Visible = false;
                        labelWC2.Visible = false;
                        labelHEX2.Visible = false;
                        textBoxRT2.Visible = false;
                        textBoxSA2.Visible = false;
                        textBoxWC2.Visible = false;
                        textBoxHEX2.Visible = false;
                        buttonRT2.Visible = false;
                        buttonSA2.Visible = false;
                        labelCWD2.Visible = false;
                        UpdateUI();
                    }                  
                    break;
                case "RT_RT":
                    {
                        boundMessage.MsgType = MessageType.RT_RT;
                        HidePayload(true, false);
                        labelRT2.Visible = true;
                        labelSA2.Visible = true;
                        labelWC2.Visible = true;
                        labelHEX2.Visible = true;
                        textBoxRT2.Visible = true;
                        textBoxSA2.Visible = true;
                        textBoxWC2.Visible = true;
                        textBoxHEX2.Visible = true;
//                         buttonRT2.Visible = true;
//                         buttonSA2.Visible = true;
                        labelCWD2.Visible = true;
                        UpdateUI();
                    }
                    break;
                default:
                    break;
            }
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
        #endregion

        private void textBoxRT1_EditValueChanged(object sender, EventArgs e)
        {
          //  UpdateMsg();
        }

       


    }
}