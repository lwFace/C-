using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraTreeList.Nodes;
using ESPHelper.SSH;

namespace ESPHelper.Monitor
{
    public enum SIZE_TYPE{B,KB,MB,GB,TB};
    public partial class MonitorControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ArrayList pInfoList = new ArrayList();
        public readonly int  BASIC_ID = 1;
        public readonly int MEMORY_ID = 500;
        public readonly int DISK_ID = 1000;
        public readonly int CPU_ID = 1500;
        public readonly int ETH_ID = 2000;
        public readonly int CHILD_ID_UNIT = 10;
        public MonitorControl()
        {
            InitializeComponent();
        }

        private void MonitorControl_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.treeBasicInfo.BeginUnboundLoad();
            pInfoList.Clear();
            int parentID = BASIC_ID;
            int id = parentID;
#region Basic Info
            //Basic info 
            MonitorInfo basicInfo = new MonitorInfo();
            basicInfo.Name = "Basic";
            basicInfo.Info = "";
            basicInfo.ID = parentID;
            pInfoList.Add(basicInfo);

            MonitorInfo typeInfo = new MonitorInfo();
            typeInfo.Name = "System Type";
            typeInfo.Info = "Unknown";
            typeInfo.ID = ++id;
            typeInfo.ParentID = parentID;
            pInfoList.Add(typeInfo);

            MonitorInfo nameInfo = new MonitorInfo();
            nameInfo.Name = "System Name";
            nameInfo.Info = "Unknown";
            nameInfo.ID = ++id;
            nameInfo.ParentID = parentID;
            pInfoList.Add(nameInfo);

            MonitorInfo architecture = new MonitorInfo();
            architecture.Name = "Architecture";
            architecture.Info = "Unknown";
            architecture.ID = ++id;
            architecture.ParentID = parentID;
            pInfoList.Add(architecture);

            MonitorInfo kernelRelease = new MonitorInfo();
            kernelRelease.Name = "Kernel Release";
            kernelRelease.Info = "Unknown";
            kernelRelease.ID = ++id;
            kernelRelease.ParentID = parentID;
            pInfoList.Add(kernelRelease);

            MonitorInfo hostName = new MonitorInfo();
            hostName.Name = "Host Name";
            hostName.Info = "Unknown";
            hostName.ID = ++id;
            hostName.ParentID = parentID;
            pInfoList.Add(hostName);
#endregion
            
#region Memory
            //Memory Info
            parentID = MEMORY_ID;
            id = parentID;
            MonitorInfo memInfo = new MonitorInfo();
            memInfo.Name = "Memory";
            memInfo.Info = "";
            memInfo.ID = parentID;
            pInfoList.Add(memInfo);

            MonitorInfo memoryInfo = new MonitorInfo();
            memoryInfo.Name = "Memory";
            memoryInfo.ParentID = parentID;
            memoryInfo.ID = ++id;
            pInfoList.Add(memoryInfo);
            int memInfoID = memoryInfo.ID;

            MonitorInfo swapInfo = new MonitorInfo();
            swapInfo.Name = "Swap";
            swapInfo.ParentID = parentID;
            swapInfo.ID = ++id;
            pInfoList.Add(swapInfo);
            int swapInfoID = swapInfo.ID;

            //swap
            MonitorInfo totalSwapInfo = new MonitorInfo();
            totalSwapInfo.Name = "Total";
            totalSwapInfo.ParentID = swapInfoID;
            totalSwapInfo.ID = ++id;
            pInfoList.Add(totalSwapInfo);

            MonitorInfo usedSwapInfo = new MonitorInfo();
            usedSwapInfo.Name = "Used";
            usedSwapInfo.Info = "Unknown";
            usedSwapInfo.ParentID = swapInfoID;
            pInfoList.Add(usedSwapInfo);
            usedSwapInfo.ID = ++id;

            MonitorInfo usedSwapRateInfo = new MonitorInfo();
            usedSwapRateInfo.Name = "UsedRate";
            usedSwapRateInfo.Info = "Unknown";
            usedSwapRateInfo.ParentID = swapInfoID;
            usedSwapRateInfo.ID = ++id;
            pInfoList.Add(usedSwapRateInfo);

            //memory
            MonitorInfo totalMemInfo = new MonitorInfo();
            totalMemInfo.Name = "Total";
            totalMemInfo.Info = "Unknown";
            totalMemInfo.ParentID = memInfoID;
            totalMemInfo.ID = ++id;
            pInfoList.Add(totalMemInfo);

            MonitorInfo usedMemInfo = new MonitorInfo();
            usedMemInfo.Name = "Used";
            usedMemInfo.Info = "Unknown";
            usedMemInfo.ParentID = memInfoID;
            usedMemInfo.ID = ++id;
            pInfoList.Add(usedMemInfo);

            MonitorInfo usedMemRateInfo = new MonitorInfo();
            usedMemRateInfo.Name = "UsedRate";
            usedMemRateInfo.Info = "Unknown";
            usedMemRateInfo.ParentID = memInfoID;
            usedMemRateInfo.ID = ++id;
            pInfoList.Add(usedMemRateInfo);
#endregion
#region Disk
            //Disk Info
            parentID = DISK_ID;
            id = parentID;
            MonitorInfo diskInfo = new MonitorInfo();
            diskInfo.Name = "Disk";
            diskInfo.Info = "";
            diskInfo.ID = parentID;
            pInfoList.Add(diskInfo);
#endregion

#region Cpu
            //Cpu Info
            parentID = CPU_ID;
            id = parentID;
            MonitorInfo cpuInfo = new MonitorInfo();
            cpuInfo.Name = "CPU";
            cpuInfo.Info = "";
            cpuInfo.ID = parentID;
            pInfoList.Add(cpuInfo);

            MonitorInfo coreNumInfo = new MonitorInfo();
            coreNumInfo.Name = "Core Number";
            coreNumInfo.Info = "Unknown";
            coreNumInfo.ID = ++id;
            coreNumInfo.ParentID = parentID;
            pInfoList.Add(coreNumInfo);

            MonitorInfo coreNameInfo = new MonitorInfo();
            coreNameInfo.Name = "Name";
            coreNameInfo.Info = "Unknown";
            coreNameInfo.ID = ++id;
            coreNameInfo.ParentID = parentID;
            pInfoList.Add(coreNameInfo);
#endregion

#region ETH
            //Eth Info
            parentID = ETH_ID;
            id = parentID;
            MonitorInfo ethInfo = new MonitorInfo();
            ethInfo.Name = "Ethernet";
            ethInfo.Info = "";
            ethInfo.ID = parentID;
            pInfoList.Add(ethInfo);
#endregion
            treeBasicInfo.DataSource = pInfoList;
            this.treeBasicInfo.EndUnboundLoad();
            treeBasicInfo.ExpandAll();
        }

#region 数据更新
        public void UpdateData(SYS_BASE_INFO basic, SYS_MEM_INFO mem, SYS_ETH_INFO[] eth, SYS_DISK_INFO[] disk, SYS_CPU_INFO cpu,uint[] cpuRates)
        {
            this.treeBasicInfo.BeginUnboundLoad();
            
            pInfoList.Clear();            
            int parentID = BASIC_ID;
            int id = parentID;
            #region Basic Info
            //Basic info 
            MonitorInfo basicInfo = new MonitorInfo();
            basicInfo.Name = "Basic";
            basicInfo.Info = "";
            basicInfo.ID = parentID;
            pInfoList.Add(basicInfo);

            MonitorInfo typeInfo = new MonitorInfo();
            typeInfo.Name = "System Type";
            typeInfo.Info = basic.sysType;
            typeInfo.ID = ++id;
            typeInfo.ParentID = parentID;
            pInfoList.Add(typeInfo);

            MonitorInfo nameInfo = new MonitorInfo();
            nameInfo.Name = "System Name";
            nameInfo.Info = basic.osName;
            nameInfo.ID = ++id;
            nameInfo.ParentID = parentID;
            pInfoList.Add(nameInfo);

            MonitorInfo architecture = new MonitorInfo();
            architecture.Name = "Architecture";
            architecture.Info = basic.architecture;
            architecture.ID = ++id;
            architecture.ParentID = parentID;
            pInfoList.Add(architecture);

            MonitorInfo kernelRelease = new MonitorInfo();
            kernelRelease.Name = "Kernel Release";
            kernelRelease.Info = basic.kernalRelease;
            kernelRelease.ID = ++id;
            kernelRelease.ParentID = parentID;
            pInfoList.Add(kernelRelease);

            MonitorInfo hostName = new MonitorInfo();
            hostName.Name = "Host Name";
            hostName.Info = basic.hostName;
            hostName.ID = ++id;
            hostName.ParentID = parentID;
            pInfoList.Add(hostName);
            #endregion

            #region Memory
            //Memory Info
            parentID = MEMORY_ID;
            id = parentID;
            MonitorInfo memInfo = new MonitorInfo();
            memInfo.Name = "Memory";
            memInfo.Info = "";
            memInfo.ID = parentID;
            pInfoList.Add(memInfo);

            MonitorInfo memoryInfo = new MonitorInfo();
            memoryInfo.Name = "Memory";
            memoryInfo.ParentID = parentID;
            memoryInfo.ID = ++id;
            pInfoList.Add(memoryInfo);
            int memInfoID = memoryInfo.ID;

            MonitorInfo swapInfo = new MonitorInfo();
            swapInfo.Name = "Swap";
            swapInfo.ParentID = parentID;
            swapInfo.ID = ++id;
            pInfoList.Add(swapInfo);
            int swapInfoID = swapInfo.ID;

            //swap
            MonitorInfo totalSwapInfo = new MonitorInfo();
            totalSwapInfo.Name = "Total";
            totalSwapInfo.ParentID = swapInfoID;
            totalSwapInfo.Info = Size2String(mem.swapTotal,SIZE_TYPE.KB);
            totalSwapInfo.ID = ++id;
            pInfoList.Add(totalSwapInfo);

            MonitorInfo usedSwapInfo = new MonitorInfo();
            usedSwapInfo.Name = "Used";
            usedSwapInfo.Info = Size2String(mem.swapUsed, SIZE_TYPE.KB);
            usedSwapInfo.ParentID = swapInfoID;
            pInfoList.Add(usedSwapInfo);
            usedSwapInfo.ID = ++id;

            MonitorInfo usedSwapRateInfo = new MonitorInfo();
            usedSwapRateInfo.Name = "UsedRate";
            usedSwapRateInfo.Info = ((double)mem.swapUsed / mem.swapTotal * 100).ToString("f2") + "%";
            usedSwapRateInfo.ParentID = swapInfoID;
            usedSwapRateInfo.ID = ++id;
            pInfoList.Add(usedSwapRateInfo);

            //memory
            MonitorInfo totalMemInfo = new MonitorInfo();
            totalMemInfo.Name = "Total";
            totalMemInfo.Info = Size2String(mem.memTotal, SIZE_TYPE.KB);
            totalMemInfo.ParentID = memInfoID;
            totalMemInfo.ID = ++id;
            pInfoList.Add(totalMemInfo);

            MonitorInfo usedMemInfo = new MonitorInfo();
            usedMemInfo.Name = "Used";
            usedMemInfo.Info = Size2String(mem.memUsed, SIZE_TYPE.KB);
            usedMemInfo.ParentID = memInfoID;
            usedMemInfo.ID = ++id;
            pInfoList.Add(usedMemInfo);

            MonitorInfo usedMemRateInfo = new MonitorInfo();
            usedMemRateInfo.Name = "UsedRate";
            usedMemRateInfo.Info = ((double)mem.memUsed / mem.memTotal * 100).ToString("f2") + "%";
            usedMemRateInfo.ParentID = memInfoID;
            usedMemRateInfo.ID = ++id;
            pInfoList.Add(usedMemRateInfo);
            #endregion
            #region Disk
            //Disk Info
            parentID = DISK_ID;
            id = parentID;
            MonitorInfo diskInfo = new MonitorInfo();
            diskInfo.Name = "Disk";
            diskInfo.Info = "";
            diskInfo.ID = parentID;
            pInfoList.Add(diskInfo);

            foreach (SYS_DISK_INFO i in disk)
            {
                MonitorInfo dInfo = new MonitorInfo();
                dInfo.Name = i.diskName;
                dInfo.ParentID = parentID;
                dInfo.ID = ++id;
                pInfoList.Add(dInfo);
               
                int nodeId = id;

                MonitorInfo dTotal = new MonitorInfo();
                dTotal.Name = "Total Size";
                dTotal.Info = Size2String(i.totalSize,SIZE_TYPE.KB);
                dTotal.ParentID = nodeId;
                dTotal.ID = ++id;
                pInfoList.Add(dTotal);

                MonitorInfo dUsed = new MonitorInfo();
                dUsed.Name = "Remain Size";
                dUsed.Info = Size2String(i.usedSize, SIZE_TYPE.KB);
                dUsed.ParentID = nodeId;
                dUsed.ID = ++id;
                pInfoList.Add(dUsed);

                MonitorInfo dRates = new MonitorInfo();
                dRates.Name = "Rates";
                dRates.Info = ((double)i.usedSize / i.totalSize * 100).ToString("f2") + "%";
                dRates.ParentID = nodeId;
                dRates.ID = ++id;
                pInfoList.Add(dRates);
            }
            #endregion
            #region ETH
            //Eth Info
            parentID = ETH_ID;
            id = parentID;
            MonitorInfo ethInfo = new MonitorInfo();
            ethInfo.Name = "Ethernet";
            ethInfo.Info = "";
            ethInfo.ID = parentID;
            pInfoList.Add(ethInfo);

            foreach (SYS_ETH_INFO i in eth)
            {
                MonitorInfo dInfo = new MonitorInfo();
                dInfo.Name = i.ethName;
                dInfo.ParentID = parentID;
                dInfo.ID = ++id;
                pInfoList.Add(dInfo);

                int nodeId = id;

                MonitorInfo dTotal = new MonitorInfo();
                dTotal.Name = "IP Adress";
                dTotal.Info = i.ethIp;
                dTotal.ParentID = nodeId;
                dTotal.ID = ++id;
                pInfoList.Add(dTotal);

                MonitorInfo dUsed = new MonitorInfo();
                dUsed.Name = "Connect";
                dUsed.Info = i.linked ? "Connected" : "Disconnected";
                dUsed.ParentID = nodeId;
                dUsed.ID = ++id;
                pInfoList.Add(dUsed);
            }
            #endregion
            #region Cpu
            //Cpu Info
            parentID = CPU_ID;
            id = parentID;
            MonitorInfo cpuInfo = new MonitorInfo();
            cpuInfo.Name = "CPU";
            cpuInfo.Info = "";
            cpuInfo.ID = parentID;
            pInfoList.Add(cpuInfo);

//             MonitorInfo coreNumInfo = new MonitorInfo();
//             coreNumInfo.Name = "Core Number";
//             coreNumInfo.Info = cpu.coreNum.ToString();
//             coreNumInfo.ID = ++id;
//             coreNumInfo.ParentID = parentID;
//             pInfoList.Add(coreNumInfo);
// 
//             MonitorInfo coreNameInfo = new MonitorInfo();
//             coreNameInfo.Name = "Name";
//             coreNameInfo.Info = cpu.name;
//             coreNameInfo.ID = ++id;
//             coreNameInfo.ParentID = parentID;
//             pInfoList.Add(coreNameInfo);

            //cpuRates
            int index = 0;
            foreach (uint i in cpuRates)
            {               
                MonitorInfo dInfo = new MonitorInfo();
                dInfo.Name = "CPU" + (index++);
                dInfo.ParentID = parentID;
                dInfo.ID = ++id;
                pInfoList.Add(dInfo);

                int nodeId = id;

                MonitorInfo dTotal = new MonitorInfo();
                dTotal.Name = "Core";
                dTotal.Info = cpu.name;
                dTotal.ParentID = nodeId;
                dTotal.ID = ++id;
                pInfoList.Add(dTotal);

                MonitorInfo dUsed = new MonitorInfo();
                dUsed.Name = "Payload";
                dUsed.Info = i + "%";
                dUsed.ParentID = nodeId;
                dUsed.ID = ++id;
                pInfoList.Add(dUsed);
            }
            #endregion

           
            treeBasicInfo.DataSource = pInfoList;
            this.treeBasicInfo.EndUnboundLoad();
            treeBasicInfo.ExpandAll();
        }
#endregion
       

        /// <summary>
        /// 动态创建TreeList 字段属性值 Node节点
        /// </summary>
        /// <param name="name">Name列的值</param>
        /// <param name="value">Info列的值</param>
        /// <param name="ID">父节点ID</param>
        /// <returns>新创建的节点</returns>
        public TreeListNode CreatChildNode(string name, string value, int ID)
        {
            TreeListNode node;
            this.treeBasicInfo.BeginUnboundLoad();
            node = this.treeBasicInfo.AppendNode(new object[] { name, value }, ID);
            this.treeBasicInfo.EndUnboundLoad();
            return node;
        }


        public string Size2String(uint size,SIZE_TYPE type)
        {
            double sizeKb = size;
            double sizeMb = size;
            double sizeGb = size;
            double sizeTb =size;

            if (type == SIZE_TYPE.B)
            {
                if (size<1024)
                {
                    return size.ToString() + "B";
                }
                sizeKb = size / 1024.0;
            }
            
            if (sizeKb < 1024)
            {
                return sizeKb.ToString("f2") + "KB";
            }
            sizeMb = sizeKb / 1024.0;
            if (sizeMb < 1024)
            {
                return sizeMb.ToString("f2") + "MB";
            }
            sizeGb = sizeMb / 1024.0;
            if (sizeGb < 1024)
            {
                return sizeGb.ToString("f2") + "GB";
            }
            sizeTb = sizeGb / 1024.0;
            return sizeTb.ToString("f2") + "TB";
        }

#region NavBar
        /// <summary>
        /// Basic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarBasic_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.infoTabControl.SelectedTabPage = tabBasic;
        }
        /// <summary>
        /// Memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarMemory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.infoTabControl.SelectedTabPage = tabMemory;
        }
        /// <summary>
        /// Disk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarDisk_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.infoTabControl.SelectedTabPage = tabDisk;
        }
        /// <summary>
        /// CPU
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarCpu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.infoTabControl.SelectedTabPage = tabCpu;
        }
        /// <summary>
        /// Ethernet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarEth_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.infoTabControl.SelectedTabPage = tabEth;
        }
#endregion

       
        

    }


}
