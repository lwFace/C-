using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using Ch.Elca.Iiop;
using Ch.Elca.Iiop.Services;
using omg.org.CosNaming;
using io;
using com.hirain.avionics.dds;
using System.Threading;
using com.hirain.avionics.healthmanager.dds.service;
using DevExpress.XtraBars.Docking2010.Views;
using ESPHelper.DDSInc;
using ESPHelper.DocControl;
using DevExpress.XtraEditors;
using Be.Windows.Forms;
using LogHelper;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils;

namespace ESPHelper
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        public HILInc hilHandle = new HILInc(0,"STIMULATE");
        public static bool RunFlag = true;
        /// <summary>
        /// DDS监控页面Doc
        /// </summary>
        Dictionary<string, BaseDocument> controlListDDS = new Dictionary<string, BaseDocument>();
        /// <summary>
        /// 板卡服务、通道页面Doc
        /// </summary>
        Dictionary<string, BaseDocument> controlListServer = new Dictionary<string, BaseDocument>();

        /// <summary>
        /// 报文激励页面Doc
        /// </summary>
        Dictionary<string, BaseDocument> docListStimulate = new Dictionary<string, BaseDocument>();
        /// <summary>
        /// 激励报文Map，key值为报文名称
        /// </summary>
       public Dictionary<string, PacInfo> pacList = new Dictionary<string, PacInfo>();

        HIL HilList = new HIL(0, "*");
        SIL SilList = new SIL(0, "*");
        Event EventList = new Event(0, "*");
        public AAMS_422 AAMS422List = new AAMS_422(0, "AAMS_422");
        public AAMS_429 AAMS429List = new AAMS_429(0, "AAMS_429");
        public AAMS_Nobus AMSNobusList = new AAMS_Nobus(0, "AAMS_NOBUS");
        Thread threadGetEventInfo;

        public HexBox Hexbox
        {
            get{return this.hexBox;}
        }
        public MainFrm()
        {
            InitializeComponent();
            hilHandle.start();
            Projects projects = InitData();
            DataBinding(projects);
            this.treeListProject.SelectImageList = this.imageList1;
            this.treeListProject.ExpandAll();
            this.treeListProject.DataSource = ServerManager.Project.Projects;
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
            this.tabbedView1.DocumentClosing += tabbedView1_DocumentClosing;
            this.treeListStimulate.SelectImageList = this.imageList1;

            StartDDS("");
           // LogHelper.LogHelper.Write(LOG_LEVEL.DEBUG, typeof(MainFrm),"Test");
        }
      
        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                startHealthManager();
                Projects projects = InitData();
                DataBinding(projects);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Projects InitData()
        {
            Projects projects = new Projects();
            projects.Add(new Project("DDS"));
            projects[0].Projects.Add(new Project("HIL"));
            projects[0].Projects.Add(new Project("SIL"));
            projects[0].Projects.Add(new Project("Event"));

            return projects;
        }
        void DataBinding(Projects projects)
        {
            treeListDDS.DataSource = projects;
            treeListDDS.ExpandAll();
        }

        void StartDDS(string type)
        {
            AAMS422List.Start();
            AMSNobusList.Start();
            AAMS429List.Start();
        }
#region Log
        public void LogInfo(string log)
        {
            this.outputControl1.LogInfo(log);
        }
        public void LogError(string log)
        {
            this.outputControl1.LogError(log);
        }
#endregion
#region HealthManager
        void getEventInfo()
        {
            com.hirain.avionics.healthmanager.HealthManager hm = new com.hirain.avionics.healthmanager.HealthManager(com.hirain.avionics.healthmanager.HealthManager.NEW_STYLE_CARD_CONTROL);
            hm.startDDS();
            while (RunFlag)
            {
                try
                {
                    com.hirain.avionics.healthmanager.dds.IDDSData[] ddsData = hm.getDDSData(com.hirain.avionics.healthmanager.HealthManager.NEW_STYLE_CARD_CONTROL);
                    if (ddsData.Length == 0)
                    {
                        foreach (Project prj in ServerManager.Project.Projects)
                        {
                            if (!prj.Status.Equals("offline"))
                            {
                                this.outputControl1.LogInfo(string.Format("{0} ServerId={1} StatusMsg=offline Msg=timeout", prj.Name, prj.No));
                                ServerManager.SetServerOffline(prj.No);
                            }
                            
                        }
                    }
                    foreach (com.hirain.avionics.healthmanager.dds.IDDSData data in ddsData)
                    {
                        ServiceDDSData sdd = (ServiceDDSData)data;
                        if (!ServerManager.IOAll.ContainsKey(sdd.Id))
                        {
                            this.outputControl1.LogInfo(string.Format("{0} ServerId={1} StatusMsg={2} Msg={3}", sdd.Name, sdd.Id, sdd.StatusMsg, sdd.Status));
                        }
                        ServerManager.ParseDDSData(data);
                        ServerManager.UpdateServerStatus();
                    }
               
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.Write(e.StackTrace);
                }
             }
            hm.stopDDS();
        }
        void startHealthManager()
        {            
            threadGetEventInfo  = new Thread(new ThreadStart(getEventInfo));
            threadGetEventInfo.Start();
        }
#endregion

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RunFlag = false;
            threadGetEventInfo.Join();
        }
        
        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
//             if (e.Document == doucumentControlDocument)
//             {
//                 e.Control = new ESPHelper.DocControl.DoucumentControl();
//             }
//             if (e.Document == cardInfoControlDocument)
//             {
//                 e.Control = new ESPHelper.DocControl.CardInfoControl();
//             }
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
        private void tabbedView1_DocumentClosing(object sender, DocumentCancelEventArgs e)
        {
            switch (e.Document.Caption)
            {
                case "HIL":
                    if (controlListDDS.ContainsKey("HIL"))
                    {
                //        controlListDDS.Remove("HIL");
                    }
                    HilList.Stop();
                    break;
                case "SIL":
                    if (controlListDDS.ContainsKey("SIL"))
                    {
                        controlListDDS.Remove("SIL");
                    }
                    SilList.Stop();
                    break;
                case "Event":
                    if (controlListDDS.ContainsKey("Event"))
                    {
                        controlListDDS.Remove("Event");
                    }
                    EventList.Stop();
                    break;
                default:
                    if (docListStimulate.ContainsKey(e.Document.Caption))
                    {
                        docListStimulate.Remove(e.Document.Caption);
                    }
                    else if (controlListServer.ContainsKey(e.Document.Caption))
                    {
                        controlListServer.Remove(e.Document.Caption);
                    }
                    break;
            }

        }
#region DDS监控
        /// <summary>
        /// DDS监控列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListDDS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode node = this.treeListDDS.FocusedNode;
                if (node != null)
                {
                    string name = node.GetValue("Name").ToString();
                    if (controlListDDS.ContainsKey(name))
                    {
                        //激活页面
                        tabbedView1.Controller.Activate(controlListDDS[name]);
                    }
                    else
                    {
                        //增加页面
                        DoucumentControl control = new DoucumentControl();
                        control.Name = name;
                        switch (name)
                        {
                            case "HIL":
                                HIL.Clear();
                                HilList.Start();
                                control.SetDataSource(HIL.gridDataList);
                                break;
                            case "SIL":
                                SIL.Clear();
                                SilList.Start();
                                control.SetDataSource(SIL.gridDataList);
                                break;
                            case "Event":
                                Event.Clear();
                                EventList.Start();
                                control.SetDataSource(Event.gridDataList);
                                break;
                            default:
                                control = null;
                                break;
                        }
                        if (control != null)
                        {
                            BaseDocument doc = this.tabbedView1.AddDocument(control);
                            doc.Caption = name;
                            controlListDDS.Add(name, doc);
                            this.tabbedView1.ActivateDocument(control);
                        }
                    }

                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
#endregion
      
#region 服务列表

        private void treeListProject_CustomDrawNodeImages(object sender, DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs e)
        {
            try
            {
                switch (e.Node.Level)
                {
                    case 0:
                        e.SelectImageIndex = 0;
                        break;
                    case 1:
                        e.SelectImageIndex = 1;
                        break;
                    case 2:
                        e.SelectImageIndex = 2;
                        break;
                    default:
                        break;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }

        }
        private void treeListProject_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode node = this.treeListProject.FocusedNode;
            if (node != null)
            {
                string name = node.GetValue("Name").ToString();
                string controlName = name;

                //增加页面
                XtraUserControl control = null;
                switch (node.Level)
                {
                    //server
                    case 0:
                        if (controlListServer.ContainsKey(controlName))
                        {
                            //激活页面
                            tabbedView1.Controller.Activate(controlListServer[controlName]);
                        }
                        else
                        {
                            Project prj = node.GetValue("Detail") as Project;
                            if (prj != null)
                            {
                                control = new ServerInfoControl(prj);
                            }
                        }
                        break;
                    //card
                    case 1:
                        {
                            string serverName = node.ParentNode.GetDisplayText(0);
                            controlName = serverName + "/" + name;
                            if (controlListServer.ContainsKey(controlName))
                            {
                                //激活页面
                                tabbedView1.Controller.Activate(controlListServer[controlName]);
                            }
                            else
                            {
                                Project prj = node.GetValue("Detail") as Project;
                                if (prj != null)
                                {
                                    control = new CardInfoControl(prj);
                                }
                            }

                        }
                        break;
                    //channel
                    case 2:
                        {
                            string serverName = node.ParentNode.ParentNode.GetDisplayText(0);
                            string cardName = node.ParentNode.GetDisplayText(0);
                            controlName = serverName + "/" + cardName + "/" + name;
                            if (controlListServer.ContainsKey(controlName))
                            {
                                //激活页面
                                tabbedView1.Controller.Activate(controlListServer[controlName]);
                            }
                            else
                            {
                                Project prj = node.GetValue("Detail") as Project;
                                if (prj != null)
                                {
                                    control = new DoucumentControl();
                                    uint sn = (uint)prj.channelSn;
                                    string type = prj.type;
#region DDS类型判断
                                    switch (type)
                                    {
                                        case "422":
                                             AAMS_422.AddChannel(sn);
                                              AAMS_422.gridDataDictionary[sn].Clear();
                                             ((DoucumentControl)control).SetDataSource(AAMS_422.gridDataDictionary[sn]);
                                            break;
                                        case "discrete":
                                        case "analog":
                                            AAMS_Nobus.AddChannel(sn);
                                            AAMS_Nobus.gridDataDictionary[sn].Clear();
                                            ((DoucumentControl)control).SetDataSource(AAMS_Nobus.gridDataDictionary[sn]);
                                            break;
                                        case "429":
                                            AAMS_429.AddChannel(sn);
                                            AAMS_429.gridDataDictionary[sn].Clear();
                                            ((DoucumentControl)control).SetDataSource(AAMS_429.gridDataDictionary[sn]);
                                            break;
                                        default:
                                            break;
                                    }
#endregion
                                    
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (control != null)
                {
                    control.Name = controlName;
                    BaseDocument doc = this.tabbedView1.AddDocument(control);
                    doc.Caption = controlName;
                    controlListServer.Add(controlName, doc);
                    this.tabbedView1.ActivateDocument(control);
                }
            }
        }

        private void treeListProject_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode node = this.treeListProject.FocusedNode;
            if (node != null && node.Level == 2)
            {
                Project prj = node.GetValue("Detail") as Project;
                if (prj != null)
                {
                    uint sn = (uint)prj.channelSn;
                    this.barStatus.Caption = "ChannelSN: 0x" + sn.ToString("X8");
                }
            }
        }
#endregion
      
#region 激励
        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListStimulate_MouseClick(object sender, MouseEventArgs e)
        {

            TreeList tree = sender as TreeList;
            if (e.Button == MouseButtons.Right
                    && ModifierKeys == Keys.None
                    && treeListStimulate.State == TreeListState.Regular)
            {
                Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
                TreeListHitInfo hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == HitInfoType.Cell)
                {
                    tree.SetFocusedNode(hitInfo.Node);
                }

                if (tree.FocusedNode != null)
                {
                    barButtonItemNew.Enabled = true;
                    barButtonItemDel.Enabled = true;
                    barButtonItemCp.Enabled = true;
                    barButtonItemPa.Enabled = true;
                }
                else
                {
                    barButtonItemNew.Enabled = true;
                    barButtonItemDel.Enabled = false;
                    barButtonItemCp.Enabled = false;
                    barButtonItemPa.Enabled = false;
                }
                popupMenuSti.ShowPopup(p);
            }
        }
        void AddStiPac(PacInfo pac)
        {
            pacList.Add(pac.Name, pac);
           TreeListNode node = this.treeListStimulate.AppendNode(new object[] { pac.Name },-1);
           node.Tag = pac;
           node.ImageIndex = 5;
           node.SelectImageIndex = 5;
        }
        
        /// <summary>
        /// 新建报文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (NewPacForm frm = new NewPacForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PacInfo pac = new PacInfo(frm.name);
                    pac.DDSKey = 900001;                    
                    AddStiPac(pac); 
                }
                else
                {
                    barButtonItemNew_ItemClick(sender, e);
                }
            }
        }
        /// <summary>
        /// 删除报文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PacInfo pac = this.treeListStimulate.FocusedNode.Tag as PacInfo;
            if (pacList.ContainsKey(pac.Name))
            {
                pacList.Remove(pac.Name);
            }
            this.treeListStimulate.DeleteNode(this.treeListStimulate.FocusedNode);
        }
        private void treeListStimulate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.treeListStimulate.FocusedNode != null)
            {
                PacInfo pac = this.treeListStimulate.FocusedNode.Tag as PacInfo;
                if (pac != null)
                {
                    if (docListStimulate.ContainsKey(pac.Name))
                    {
                        //激活页面
                        tabbedView1.Controller.Activate(docListStimulate[pac.Name]);
                    }                   
                    else
                    {
                        StiPackControl control = new StiPackControl(pac);
                        control.treeNode = this.treeListStimulate.FocusedNode;
                        control.Name = pac.Name;
                        BaseDocument doc = this.tabbedView1.AddDocument(control);
                        doc.Caption = control.Name;
                        docListStimulate.Add(control.Name, doc);
                        this.tabbedView1.ActivateDocument(control);
                    }
                }
            }

        }
#endregion
     
#region 工具栏按钮
        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                using (AddServer frm = new AddServer())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        using (WaitDialogForm waitFrm = new WaitDialogForm("CORBA链接中......", "提示"))
                        {

                            foreach (var item in ServerManager.IOAll)
                            {
                                if (item.Value.Selected)
                                {
                                    waitFrm.SetCaption("正在链接" + item.Value.Name + "...");
                                    ServerManager.AddServer(item.Value);
                                }
                            }
                            waitFrm.Close();
                        }
                    }
                }

                this.treeListProject.ExpandAll();
                this.treeListProject.BestFitColumns(true);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        /// <summary>
        /// 服务初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnInit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (var item in ServerManager.IOMap)
                {
                    Project server = ServerManager.Project.ChildNode[item.Key];
                    using (WaitDialogForm waitFrm = new WaitDialogForm(server.Name + "服务正在初始化......", "提示"))
                    {
                        string initStr;
                        string routerStr;
                        if (System.IO.File.Exists(server.initXml))
                        {
                            initStr = System.IO.File.ReadAllText(server.initXml);
                        }
                        else
                        {
                            LogError(string.Format("{0}({1}): 初始化表{2}不存在。", server.Name, server.No, server.initXml));
                            continue;
                        }
                        if (System.IO.File.Exists(server.routerXml))
                        {
                            routerStr = System.IO.File.ReadAllText(server.routerXml);
                        }
                        else
                        {
                            LogError(string.Format("{0}({1}): 路由表{2}不存在。", server.Name, server.No, server.routerXml));
                            continue;
                        }

                        core.ReturnInfo ret = item.Value.setRouter(routerStr);
                        if (ret.status != 0)
                        {
                            LogError(string.Format("{0}({1}): 路由设置失败！(ret={2})", server.Name, server.No, ret.status));
                            return;
                        }
                        LogInfo(string.Format("{0}({1}): 路由设置成功！", server.Name, server.No, ret.status));
                        core.HiProperty[] prop = new core.HiProperty[2];
                        prop[0] = new core.HiProperty();
                        prop[0].name = "data";
                        prop[0].value = initStr;
                        prop[1] = new core.HiProperty();
                        prop[1].name = "isSaveConfig";
                        prop[1].value = "true";
                        ret = item.Value.init(prop);
                        if (ret.status != 0)
                        {
                            LogError(string.Format("{0}({1}): 服务初始化失败！(ret={2})", server.Name, server.No, ret.status));
                            return;
                        }
                        LogInfo(string.Format("{0}({1}): 服务初始化成功！", server.Name, server.No, ret.status));
                    }
                }
            }
            catch (System.Exception ex)
            {
                LogHelper.LogHelper.WriteLog(typeof(MainFrm), ex);
            }
            
        }
        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (var item in ServerManager.IOMap)
                {

                    Project server = ServerManager.Project.ChildNode[item.Key];
                    using (WaitDialogForm waitFrm = new WaitDialogForm(server.Name+"服务正在启动......", "提示"))
                    {
                        core.ReturnInfo ret = item.Value.start();
                        if (ret.status != 0)
                        {
                            LogError(string.Format("{0}({1}): 服务启动失败！(ret={2})", server.Name, server.No, ret.status));
                            return;
                        }
                        LogInfo(string.Format("{0}({1}): 服务启动成功！", server.Name, server.No, ret.status));
                    }
                }
            }
            catch (System.Exception ex)
            {
                LogHelper.LogHelper.WriteLog(typeof(MainFrm), ex);
            }
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (var item in ServerManager.IOMap)
                {
                  Project server = ServerManager.Project.ChildNode[item.Key];
                  using (WaitDialogForm waitFrm = new WaitDialogForm(server.Name + "服务正在停止......", "提示"))
                  {
                      core.ReturnInfo ret = item.Value._stop();
                      if (ret.status != 0)
                      {
                          LogError(string.Format("{0}({1}): 服务停止失败！(ret={2})", server.Name, server.No, ret.status));
                          return;
                      }
                      LogInfo(string.Format("{0}({1}): 服务停止成功！", server.Name, server.No));
                  }
                }
            }
            catch (System.Exception ex)
            {
                LogHelper.LogHelper.WriteLog(typeof(MainFrm), ex);
            }
        }
        /// <summary>
        /// DDS状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnDDSStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DDSStatusFrm frm = new DDSStatusFrm();
            frm.Show();
        }
#endregion             

      

    }
}
