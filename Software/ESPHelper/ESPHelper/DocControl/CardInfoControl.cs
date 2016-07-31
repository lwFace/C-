using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;

namespace ESPHelper.DocControl
{
    
    public partial class CardInfoControl : DevExpress.XtraEditors.XtraUserControl
    {
        Project m_serverInfo = null;
        
        public CardInfoControl(Project prj)
        {
            this.m_serverInfo = prj;
            InitializeComponent();
        }
     
        public Project ServerInfo
        {
            get { return m_serverInfo; }
            set { m_serverInfo = value; }
        }
        private void CardInfoControl_Load(object sender, EventArgs e)
        {
            try
            {
                //server
                if (this.m_serverInfo == null)
                {
                    return;
                }
                this.textEditCardName.Text = m_serverInfo.Name;
                this.textEditCardType.Text = m_serverInfo.type;
                this.textEditDevId.Text = m_serverInfo.devId.ToString();
                //card     
                BindingList<CardParam> cardParam = new BindingList<CardParam>();
                foreach (var prop in m_serverInfo.parameters)
                {
                    CardParam param = new CardParam();
                    param.ParameterName = prop.parameterName;
                    param.DefaultValue = prop.defaultValue;
                    param.Value = prop.value;
                    param.ParameterID = prop.parameterID;
                    cardParam.Add(param);
                }
                this.gridControlCardProp.DataSource = cardParam;

                //channel
                BindingList<ChannelParam> chnParam = new BindingList<ChannelParam>();
                foreach (Project channelPrj in m_serverInfo.Projects)
                {
                    foreach (var prop in channelPrj.parameters)
                    {
                        ChannelParam param = new ChannelParam();
                        param.ChannelID = channelPrj.No;
                        param.ParameterName = prop.parameterName;
                        param.DefaultValue = prop.defaultValue;
                        param.Value = prop.value;
                        param.ParameterID = prop.parameterID;
                        chnParam.Add(param);
                    }
                }
                this.gridControlChannelProp.DataSource = chnParam;
            }
            catch (System.Exception ex)
            {
                    Console.WriteLine(ex.StackTrace.ToString());	
            }

        }
    }
    public class CardParam
    {
        public short ParameterID { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public string DefaultValue { get; set; }
    }
    public class ChannelParam
    {
        public short ChannelID { get; set; }
        public short ParameterID { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public string DefaultValue { get; set; }
    }
}
