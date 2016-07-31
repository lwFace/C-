using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using Be.Windows.Forms;
using datarouter;
using DevExpress.XtraTreeList.Nodes;

namespace ESPHelper.DocControl
{
    public partial class StiPackControl : DevExpress.XtraEditors.XtraUserControl
    {
        PacInfo pac;
        public TreeListNode treeNode;
        public StiPackControl(PacInfo pac)
        {
            InitializeComponent();
            this.textDDSKey.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditVal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditVal.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.textEditVal.Properties.DisplayFormat.FormatString = "#######0.00#";
            this.textEditVal.Properties.Mask.EditMask = "#######0.00#";
            this.textPacLen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textDDSKey.Properties.Mask.EditMask = "########";
            this.textPacLen.Properties.Mask.EditMask = "######";
            this.textDDSKey.Text = pac.DDSKey.ToString();
            this.labelVal.Visible = true;
            this.radioGroupVal.Visible = false;
            this.textEditVal.Visible = true;
            this.pac = pac;
            this.textPacName.Text = pac.Name;
            this.textEditVal.Text = pac.Analog.ToString();
            this.radioGroupVal.SelectedIndex = pac.Discrete;
            this.textPacLen.Text = pac.Length.ToString();
            SwitchPacType((byte)pac.Type);   
            
        }
        private void SwitchPacType(int type)
        {
            switch (type)
            {
                case 0:
                    {
                        this.radioGroupPacType.SelectedIndex = 0;
                        pac.Type = PacType.模拟量;
                        this.labelVal.Visible = true;
                        this.radioGroupVal.Visible = false;
                        this.textEditVal.Visible = true;
                        this.textPacLen.ReadOnly = true;
                        this.hexBox.ReadOnly = true;
                        this.textPacLen.Text = "8";
                       
                        DynamicByteProvider provider = new DynamicByteProvider(BitConverter.GetBytes(pac.Analog));
                        this.textPacLen.Text = pac.Payload.Length.ToString();
                        this.textEditVal.Text = pac.Analog.ToString();
                        this.hexBox.ByteProvider = provider;                        
                    }
                    break;
                case 1:
                    {
                        this.radioGroupPacType.SelectedIndex = 1;
                        pac.Type = PacType.离散量;
                        this.labelVal.Visible = true;
                        this.radioGroupVal.Visible = true;
                        this.textEditVal.Visible = false;
                        this.textPacLen.ReadOnly = true;
                        this.hexBox.ReadOnly = true;
                        this.textPacLen.Text = "1";
                        byte[] val = new byte[1];
                        val[0] = pac.Discrete;
                        DynamicByteProvider provider = new DynamicByteProvider(val);
                        this.textPacLen.Text = pac.Payload.Length.ToString();
                        this.hexBox.ByteProvider = provider;
                    }
                    break;
                case 2:
                    {
                        this.radioGroupPacType.SelectedIndex =2;
                        pac.Type = PacType.数据块;
                        this.labelVal.Visible = false;
                        this.radioGroupVal.Visible = false;
                        this.textEditVal.Visible = false;
                        this.hexBox.ReadOnly = false;
                        this.textPacLen.ReadOnly = false;         
                        DynamicByteProvider provider = new DynamicByteProvider(pac.Payload);
                        this.textPacLen.Text = pac.Payload.Length.ToString();
                        this.hexBox.ByteProvider = provider;
                    }
                    break;
                default:
                    break;
            }
            if (treeNode!=null)
            {
                treeNode.ImageIndex = 5+radioGroupPacType.SelectedIndex;
                treeNode.SelectImageIndex = 5 + radioGroupPacType.SelectedIndex;
            }
           
        }
        private void radioGroupPacType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.radioGroupPacType.Text;
            int type = int.Parse(str);
            SwitchPacType(type);
        }
        /// <summary>
        /// 数据块更改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hexBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.hexBox.ByteProvider != null)
            {
                this.textPacLen.Text = this.hexBox.ByteProvider.Length.ToString();
                pac.Payload = new byte[hexBox.ByteProvider.Length];
                for (int i = 0; i < this.hexBox.ByteProvider.Length; i++)
                {
                    pac.Payload[i] = hexBox.ByteProvider.ReadByte(i);
                }                
            } 
        }

        /// <summary>
        /// 离散量更改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioGroupVal_SelectedIndexChanged(object sender, EventArgs e)
        {
            pac.Discrete = (byte)this.radioGroupVal.SelectedIndex;
            byte[] val = new byte[1];
            val[0] = pac.Discrete;
            DynamicByteProvider provider = new DynamicByteProvider(val);
            this.textPacLen.Text = pac.Payload.Length.ToString();
            this.hexBox.ByteProvider = provider;
        }
        /// <summary>
        /// 模拟量更改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditVal_EditValueChanged(object sender, EventArgs e)
        {
            if (textEditVal.Text=="")
            {
                return;
            }            
            pac.Analog = float.Parse(this.textEditVal.Text);
            DynamicByteProvider provider = new DynamicByteProvider(BitConverter.GetBytes(pac.Analog));
            this.hexBox.ByteProvider = provider;
        }
       
        /// <summary>
        /// 更改数据长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textPacLen_Validated(object sender, EventArgs e)
        {
            if (this.textPacLen.Text=="")
            {
                return;
            }
            int len = int.Parse(this.textPacLen.Text);
            byte[] newPayload = new byte[len];
            if (len > pac.Payload.Length)
            {
                Array.Copy(pac.Payload, newPayload, pac.Payload.Length);
            }
            else
            {
                Array.Copy(pac.Payload, newPayload, len);
            }
            this.hexBox.ByteProvider = new DynamicByteProvider(newPayload);
            pac.Payload = new byte[len];
            for (int i = 0; i < len; i++)
            {
                pac.Payload[i] = newPayload[i];
            }
        }
        /// <summary>
        /// 更改DDSKey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textDDSKey_EditValueChanged(object sender, EventArgs e)
        {
            if (pac!=null)
            {
                if (this.textDDSKey.Text == "" || this.textDDSKey.Text == "-")
                {
                    pac.DDSKey = 0;
                }
                else
                {
                    pac.DDSKey = int.Parse(this.textDDSKey.Text);
                }               
            }
        }

        private void btnSendOnce_Click(object sender, EventArgs e)
        {
            HIL_msg msg = new HIL_msg();
            msg.id = (uint)pac.DDSKey;
            if (pac.Type==PacType.模拟量)
            {
                msg.length = 8;
                msg.payload = new Payload[msg.length];
                byte[] analog = BitConverter.GetBytes(pac.Analog);
                for (int i = 0; i < 8; i++)
                {
                    msg.payload[i] = new Payload();
                    msg.payload[i]._value = analog[i];
                }
            }
            else if (pac.Type == PacType.离散量)
            {
                msg.length = 1;
                msg.payload = new Payload[msg.length];
                msg.payload[0] = new Payload();
                msg.payload[0]._value = pac.Discrete;
            }
            else if (pac.Type == PacType.数据块)
            {
                msg.length = (uint)pac.Payload.Length;
                msg.payload = new Payload[msg.length];
                for (int i = 0; i < msg.length; i++)
                {
                    msg.payload[i] = new Payload();
                    msg.payload[i]._value = pac.Payload[i];
                }
            }
            
            Program.mainFrm.hilHandle.writeHIL(msg);
        }

        private void textPacName_Leave(object sender, EventArgs e)
        {
            if (this.textPacName.Text!=pac.Name)
            {
                if (Program.mainFrm.pacList.ContainsKey(this.textPacName.Text))
                {
                    MessageBox.Show("报文名称重复，请重新命名！");
                    this.textPacName.Text = pac.Name;
                }
                else
                {
                    pac.Name = this.textPacName.Text;
                    Program.mainFrm.pacList.Remove(pac.Name);
                    Program.mainFrm.pacList.Add(pac.Name, pac);
                    treeNode.SetValue(0, pac.Name);
                }
            }
        }

        

        
    }
}
