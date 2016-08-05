using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraTreeList.Nodes;
using System.Xml;
using Demo1553.Class;

namespace Demo1553
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        DocumentManager docManager;
        /// <summary>
        /// 硬件资源侧边栏绑定数据信息
        /// </summary>
        private BindingList<BoundResourceBase> listResource = new BindingList<BoundResourceBase>();

        public MainFrm()
        {
            InitializeComponent();
            docManager = new DocumentManager();
            docManager.MdiParent = this;
            docManager.View = new TabbedView();
        }
        
        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadResource();
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrm), ex);
                outputControl1.LogError(ex.Message);
            }
            
            treeListResource.DataSource = listResource;
            treeListResource.ExpandAll();
            treeListResource.Columns["Tag"].Visible = false;

            //checkButton1.Checked = true;
        }
        /// <summary>
        /// 载入xml文件，获取板卡资源信息，更新到左侧边栏
        /// </summary>
        private void LoadResource()
        {
            try
            {
                /*解析xml文件，更新listResource，更新cardManager*/
                XmlDocument doc = new XmlDocument();
                doc.Load("CardResource.xml");
                XmlNode rootNode = doc.SelectSingleNode("Target");//得到根节点Target

                BoundResourceBase resPrj = new BoundResourceProj();
                resPrj.ID = 0;
                resPrj.Name = "Project";
                listResource.Add(resPrj);

                int CardNodeBaseId = 1;
                int ChannelNodeBaseId = 10;
                int NodeNodeBaseId = 100;

                /*解析card节点*/
                foreach (XmlNode cardNode in rootNode.ChildNodes)
                {
                    XmlElement cardElement = (XmlElement)cardNode;
                    int cardId = int.Parse(cardElement.GetAttribute("Id"));
                    string cardName = cardElement.GetAttribute("Name");
                    int cardNum=int.Parse(cardElement.GetAttribute("Num"));
                    BoundResourceBase rescard = new BoundResourceCard();
                    rescard.Name = cardName;
                    rescard.ID = CardNodeBaseId++;
                    rescard.ParentID = resPrj.ID;
                    rescard.Tag = rescard;
                    listResource.Add(rescard);
                    Card card = new Card();
                    card.Id = cardId;
                    card.Name = cardName;
                    card.Num = cardNum;
                    
                    /*解析channel节点*/
                    foreach (XmlNode chnNode in cardNode.ChildNodes)
                    {
                        XmlElement chnElement = (XmlElement)chnNode;
                        int channelId = int.Parse(chnElement.GetAttribute("Id"));
                        string channelName = chnElement.GetAttribute("Name");
                        BoundResourceBase reschannel = new BoundResourceChannel(); 
                        reschannel.Name = channelName;
                        reschannel.ID = ChannelNodeBaseId++;
                        reschannel.ParentID = rescard.ID;
                        reschannel.Tag = reschannel;
                        listResource.Add(reschannel);
                        Channel channel = new Channel();
                        channel.Name=channelName;
                        channel.Id = channelId;                       

                        /*解析node节点*/
                        foreach (XmlNode ndNode in chnNode.ChildNodes)
                        {
                            XmlElement ndElement = (XmlElement)ndNode;
                            string nodeName = ndElement.GetAttribute("Name");
                            BoundResourceBase resnode = new BoundResourceNode();
                            resnode.Name = nodeName;
                            resnode.ParentID = reschannel.ID;
                            resnode.ID = NodeNodeBaseId++;
                            ((BoundResourceNode)resnode).SetNodeType(resnode.Name);
                            resnode.Tag = resnode;
                            listResource.Add(resnode);

                            Node node;
                            switch (nodeName)
                            {
                                case "BC":
                                    node = new BC();                                    
                                    break;
                                case "RT":
                                    node = new RT();
                                    break;
                                case "BM":
                                    node = new BM();
                                    break;
                                default:
                                    throw new Exception("错误的节点类型："+nodeName);
                            }                           
                            node.Name = nodeName;
                            channel.AddNode(node);
                        }//end node

                        card.AddChannle(channel.Id, channel);
                    }// end channel

                    CardManager.AddCard(card.Id, card);
                }//end foreach card
            }
            catch (Exception ex)
            {
                
                throw new Exception("获取资源信息失败！请检查资源配置文件。");
            }
        }

        /// <summary>
        /// 双击资源列表事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListResource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BoundResourceBase res = treeListResource.FocusedNode["Tag"] as BoundResourceBase;
            string nodeName = GetNodeName(this.treeListResource.FocusedNode);
            switch (res.GetResourceType())
            {
                case ResourceType.Card:
                    break;
                case ResourceType.Channel:
                    break;
                case ResourceType.Node:
                    {
                        BoundResourceNode node = (BoundResourceNode)res;
                        CreateFrm(nodeName, node.GetNodeType());                       
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取节点名称
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetNodeName(TreeListNode node)
        {
            string caption = node["Name"].ToString();
            int level = node.Level;
            TreeListNode n = node.ParentNode;
            while (level-- >0)
            {                
                caption = n["Name"].ToString() + "/" + caption;
                n = n.ParentNode;
            }
            return caption;
        }
        private void CreateFrm(string caption,NodeType type)
        {
            XtraForm newFrm;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Text == caption)
                {
                    frm.Activate();
                    return;
                }
            }
            /*获取cardManager下的BC对象*/
            BC bc = CardManager.GetCard(0).GetChannle(0).GetBC();
            RT rt = CardManager.GetCard(0).GetChannle(0).GetRT();
           // BC bc = new BC();
            //RT rt = new RT();
            switch (type)
            {
                case NodeType.BC:
                    newFrm = new FrmBC(bc);
                    break;
                case NodeType.RT:
                    newFrm = new FrmRT(rt);
                    break;
                case NodeType.BM:
                    newFrm = new XtraForm();
                    break;
                default:
                    newFrm = new XtraForm();
                    break;
            }
            newFrm.Text = caption;
            newFrm.MdiParent = this;
            newFrm.Show();

        }

        private void barBtnInit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CardManager.Init();
        }
    }

}