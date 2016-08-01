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
            

            /*For test*/

          
            /* Temp code */
            BoundResourceBase resPrj = new BoundResourceProj();
            resPrj.ID = 0;
            resPrj.Name = "Project";
            listResource.Add(resPrj);
            for (int i = 0; i < 2; i++)
            {
                BoundResourceBase resCard = new BoundResourceCard();
                resCard.ID = i+1;
                resCard.Name = "CPCI1553_" + i.ToString();
                resCard.ParentID = 0;
                listResource.Add(resCard);
                for (int j = 0; j < 2; j++)
                {
                    BoundResourceBase resChn = new BoundResourceChannel();
                    resChn.ID = 10 * (j + 1) + i;
                    resChn.ParentID = i+1;
                    resChn.Name = "Chn_" + j.ToString();
                    resChn.Tag = resChn;
                    listResource.Add(resChn);
                    BoundResourceBase resNode = new BoundResourceNode();
                    resNode.ID = 100 * (j + 1) + (i+1)*10;
                    resNode.ParentID = resChn.ID;
                    resNode.Name = "BC";
                    ((BoundResourceNode)resNode).SetNodeType(NodeType.BC);
                    resNode.Tag = resNode;
                    listResource.Add(resNode);
                    BoundResourceBase resNode1 = new BoundResourceNode();
                    resNode1.ID = 100 * (j + 1) + (i + 1) * 10+1;
                    resNode1.ParentID = resChn.ID;
                    resNode1.Name = "RT";
                    resNode1.Tag = resNode1;
                    ((BoundResourceNode)resNode1).SetNodeType(NodeType.RT);
                    listResource.Add(resNode1);
                    BoundResourceBase resNode2 = new BoundResourceNode();
                    resNode2.ID = 100 * (j + 1) + (i + 1) * 10+2;
                    resNode2.ParentID = resChn.ID;
                    resNode2.Name = "BM";
                    resNode2.Tag = resNode2;
                    ((BoundResourceNode)resNode2).SetNodeType(NodeType.BM);
                    listResource.Add(resNode2);
                }
            }
            treeListResource.DataSource = listResource;
            treeListResource.ExpandAll();
            treeListResource.Columns["Tag"].Visible = false;

            this.outputControl1.LogInfo("板卡打开成功！");
            //Interface1553.init("Hello");
            CardManager.Init();

           // string error = Interface1553.getLastErr();
          //  System.Console.WriteLine(error);
           
        }
        /// <summary>
        /// 载入xml文件，获取板卡资源信息，更新到左侧边栏
        /// </summary>
        private void LoadResource()
        {
            try
            {
                /*解析xml文件，更新listResource，更新cardManager*/
            }
            catch (Exception ex)
            {
                
                throw new Exception("获取资源信息失败！请检查资源配置文件。");
            }
        }

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
            switch (type)
            {
                case NodeType.BC:
                    newFrm = new FrmBC();
                    break;
                case NodeType.RT:
                    newFrm = new FrmRT();
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
    }

}