using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraTreeList;
using io;

namespace ESPHelper
{    
    public class Project
    {
        string name;//cardname servername
        string status;
        Projects owner;
        Projects projects;
        
        bool isTask;
        public parameter[] parameters;
        public string type;
        public int StatusId;
        public string Version;
        public short No;//Cardno channelNo
        public short Mode;//channel mode
        public short Direction;//channel direction
        public int channelSn;
        public int devId;

        public string initXml="";
        public string routerXml="";
        /// <summary>
        /// 子节点映射表
        /// </summary>
        public Dictionary<int, Project> ChildNode = new Dictionary<int, Project>();
        public Project()
        {
            this.owner = null;
            this.name = "";
            this.status = "";
            this.projects = new Projects();
        }
        public Project(string name)
        {
            this.name = name;
            this.projects = new Projects();
        }
        public Project(Projects projects, string name)
            : this(name)
        {
            this.projects = projects;
        }
        [Browsable(false)]
        public Projects Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public string Status
        {
            get { return status; }
            set
            {
                if (Status == value) return;
                status = value;
                OnChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (Name == value) return;
                name = value;
                OnChanged();
            }
        }
         public Project Detail
        {
            get { return this; }
        }
//         public short NdID
//         {
//             get{return No;}
//             set { No = value; OnChanged(); }
//             
//         }
        [Browsable(false)]
        public Projects Projects { get { return projects; } }

       
        void OnChanged()
        {
            if (owner == null) return;
            int index = owner.IndexOf(this);
            owner.ResetItem(index);
        }
    }
    public class Projects : BindingList<Project>, TreeList.IVirtualTreeListData
    {
        void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info)
        {
            Project obj = info.Node as Project;
            info.Children = obj.Projects;
        }
        protected override void InsertItem(int index, Project item)
        {
            item.Owner = this;
            base.InsertItem(index, item);
        }
        void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info)
        {
            Project obj = info.Node as Project;
            switch (info.Column.Caption)
            {
                case "Name":
                    info.CellData = obj.Name;
                    break;
                case "Status":
                    info.CellData = obj.Status;
                    break;
                case "NdID":
                    info.CellData = obj.No;
                    break;
                case "Detail":
                    info.CellData = obj.Detail;
                    break;
            }
        }
        void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info)
        {
            Project obj = info.Node as Project;
            switch (info.Column.Caption)
            {
                case "Name":
                    obj.Name = (string)info.NewCellData;
                    break;
                case "Status":
                    obj.Status = (string)info.NewCellData;
                    break;
                case "NdID":
                    obj.No = (short)info.NewCellData;
                    break;
            }
        }
    }
}
