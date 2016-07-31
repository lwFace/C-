using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.IO;
using DevExpress.XtraTreeList.Nodes;
using WDCLibrary;
using Jungo.wdapi_dotnet;

using WDC_DRV_OPEN_OPTIONS = System.UInt32;
using UINT64 = System.UInt64;
using DWORD = System.UInt32;
using UINT32 = System.UInt32;
using WORD = System.UInt16;
using BYTE = System.Byte;
using BOOL = System.Boolean;
namespace WinDriverDemo.Modules
{   
    public partial class BoardConfig :DevExpress.XtraEditors.XtraUserControl
    {
        private HR_Device m_device;
       
        private RW m_direction;
        private byte[] m_bData;
        private WORD[] m_wData;
        private UINT32[] m_u32Data;
        private UINT64[] m_u64Data;
        private object[] m_obj;
        private DataTable _regConfigTable;
        RegConfig _regConfig;
        public BoardConfig()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Hide();
            this.Name = "Configuration";
            this.btnRead.Enabled = false;
            this.btnWrite.Enabled = false;
            repositoryItemComboBoxTransType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemComboBoxTransMode = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemComboBoxBar = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            #region 设置Grid列表
            try
            {
                this.repositoryItemComboBoxTransMode.Items.AddRange(new object[] { "8 bits", "16 bits", "32 bits", "64 bits" });
                this.repositoryItemComboBoxTransType.Items.AddRange(new object[] { "block", "non-block" });
                SetPosition();
                _regConfigTable = new DataTable();
                _regConfigTable.TableName = "RegConfig";
                _regConfigTable.Columns.Add("Group", typeof(string));
                _regConfigTable.Columns.Add("RegName", typeof(string));
                _regConfigTable.Columns.Add("BAR", typeof(string));
                _regConfigTable.Columns.Add("Offset(0x)", typeof(string));
                _regConfigTable.Columns.Add("TransType", typeof(string));
                _regConfigTable.Columns.Add("TransMode", typeof(string));
                _regConfigTable.Columns.Add("BytesNum", typeof(UInt32));
                _regConfigTable.Columns.Add("AutoInc", typeof(bool));
                gridControlRegTest.DataSource = _regConfigTable;
                this.gridViewRegTest.Columns["BAR"].ColumnEdit = repositoryItemComboBoxBar;
                this.gridViewRegTest.Columns["TransType"].ColumnEdit = repositoryItemComboBoxTransType;
                this.gridViewRegTest.Columns["TransMode"].ColumnEdit = repositoryItemComboBoxTransMode;
                this.gridViewRegTest.Columns["AutoInc"].ColumnEdit = repositoryItemCheckEdit1;
                UpdateComboBAR();
                //this.gridViewRegTest.Columns["BytesNum"].ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in this.gridViewRegTest.Columns)
                {
                    if (col.Caption == "RegName")
                    {
                        continue;
                    }
                    col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }
            }
           catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            #endregion
        }
        /// <summary>
        /// 将BAR空间更新到BAR列的编辑器内
        /// </summary>
        public void UpdateComboBAR()
        {
            m_device = Program._mainFrm._scanFrm._selectDevice;
            this.repositoryItemComboBoxBar.Items.Clear();
            if (m_device == null)
            {
                this.repositoryItemComboBoxBar.Items.Add("----- -----");
                return;
            }
            if (m_device.Handle != IntPtr.Zero)
            {
                string[] sBars = m_device.AddrDescToString(false);
                for (int i = 0; i < sBars.Length; ++i)
                {
                    this.repositoryItemComboBoxBar.Items.Add(sBars[i]);
                }
            }
            else
            {
                this.repositoryItemComboBoxBar.Items.Add("----- -----");
            }           
        }
        #region AddNewRow
        void SetPosition()
        {
            if (gridViewRegTest.OptionsView.NewItemRowPosition == DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom && gridViewRegTest.SortInfo.GroupCount == 0)
            {
                gridViewRegTest.FocusedRowHandle = gridViewRegTest.RowCount - 2;
                gridViewRegTest.MakeRowVisible(gridViewRegTest.FocusedRowHandle, false);
            }
        }

        private void gridViewRegTest_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            try 
            {
                DataRow row = gridViewRegTest.GetDataRow(e.RowHandle);
                row["Group"] = "Group0";
                row["RegName"] = "REG0";
                row["BAR"] = "----- -----";
                row["Offset(0x)"] = (0).ToString("X8");
                row["TransType"] = "block";
                row["TransMode"] = "16 bits"; 
                row["BytesNum"] = 8;
                row["AutoInc"] = true;
                row.EndEdit();
                

                this.gridViewRegTest.UpdateCurrentRow();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void gridControlRegTest_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                gridViewRegTest.AddNewRow();
                //if (EditRecord())
                    gridViewRegTest.UpdateCurrentRow();
               // else 
               //     gridViewRegTest.CancelUpdateCurrentRow();
                e.Handled = true;
            }
        }

        private void gridViewRegTest_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        #endregion

       
        #region 文件导入导出
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog.FileName;

                DataTableToXML(this._regConfigTable, fName);
            }
        }
        public bool DataTableToXML(DataTable dtTable, string strXMLPath)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            StreamWriter sw = null;
            try
            {
                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                dtTable.WriteXml(writer, XmlWriteMode.WriteSchema);
                int nCount = (int)stream.Length;
                byte[] arr = new byte[nCount];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, nCount);
                UTF8Encoding utf = new UTF8Encoding();
                string strContent = utf.GetString(arr).Trim();
                sw = new StreamWriter(strXMLPath);
                sw.Write(strContent);

                return true;
            }
            catch (System.Exception vErr)
            {
                MessageBox.Show(vErr.Message);
                return false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Xml文件|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                
                using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("Waiting", " Loading file..."))
                {
                    XMLToDataTable(path);
                }                
            }
        }
        public void XMLToDataTable(string strXMLPath)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            StreamReader sr = null;
            try
            {
                if (strXMLPath.Length <= 0)
                {
                    return; 
                }
                sr = new StreamReader(strXMLPath);
                string strXmlContent = sr.ReadToEnd();
                stream = new StringReader(strXmlContent);
                reader = new XmlTextReader(stream);
                _regConfigTable.Clear();
                _regConfigTable.ReadXml(reader);
                InitConfigTree();
            }
            catch (System.Exception vErr)
            {
                MessageBox.Show(vErr.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (reader != null)
                    reader.Close();
            }
        }
        /// <summary>
        /// 根据配置初始化树列表
        /// </summary>
        private void InitConfigTree()
        {
            try
            {
                treeRegConfig.ClearNodes();
              //  TreeListNode rootNode = treeRegConfig.AppendNode(new object[] { "REGConfigure" }, -1);
                
                bool flag = false;
                foreach (DataRow row in _regConfigTable.Rows)
                {
                    //foreach (TreeListNode node in rootNode.Nodes)
                    foreach (TreeListNode node in treeRegConfig.Nodes)
                    {
                        if (node.GetValue(0).ToString() == row["Group"].ToString())
                        {
                            TreeListNode regNode = node.Nodes.Add(new object[] { row["RegName"].ToString() });
                            regNode.Tag = SetNodeTag(row);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        //TreeListNode node = rootNode.Nodes.Add(new object[] { row["Group"].ToString() });
                        TreeListNode node = treeRegConfig.AppendNode(new object[] { row["Group"].ToString() }, -1);
                        TreeListNode regNode = node.Nodes.Add(new object[] { row["RegName"].ToString() });
                        regNode.Tag = SetNodeTag(row);
                    }
                    flag = false;
                }
                treeRegConfig.ExpandAll();
            }
            catch (Exception e)
            {
                throw e;                
            }
            
        }

        /// <summary>
        /// 解析DataTable，设置节点Tag
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private RegConfig SetNodeTag(DataRow row )
        {
            try
            {
                RegConfig config = new RegConfig();
                config.m_bAutoInc = (bool)row["AutoInc"];             
                config.m_dwOffset = Convert.ToUInt32(row["Offset(0x)"].ToString(),16);
                int index = this.repositoryItemComboBoxBar.Items.IndexOf(row["BAR"].ToString());
                if(index < 0)
                {
                    Exception m_excp = new Exception(String.Format("Invalid bar: {0}",row["BAR"].ToString()));
                    throw m_excp;                    
                }
                config.m_dwBar = (uint)index;
                index = this.repositoryItemComboBoxTransMode.Items.IndexOf(row["TransMode"].ToString());
                 config.m_mode = (index == 0) ? WDC_ADDR_MODE.WDC_MODE_8 :
               (index == 1) ? WDC_ADDR_MODE.WDC_MODE_16 :
               (index == 2) ? WDC_ADDR_MODE.WDC_MODE_32 : WDC_ADDR_MODE.WDC_MODE_64;
                 index = this.repositoryItemComboBoxTransType.Items.IndexOf(row["TransType"].ToString());
                 config.m_type = (index == 0) ?
               TRANSFER_TYPE.BLOCK : TRANSFER_TYPE.NONBLOCK;

                 if (config.m_type == TRANSFER_TYPE.BLOCK)
                 {
                     config.m_dwBytes = (UInt32)row["BytesNum"];
                 }
                 else
                 {
                     config.m_dwBytes = (DWORD)((config.m_mode == WDC_ADDR_MODE.WDC_MODE_8) ? 1 :
                         ((config.m_mode == WDC_ADDR_MODE.WDC_MODE_16) ? 2 :
                         ((config.m_mode == WDC_ADDR_MODE.WDC_MODE_32) ? 4 : 8)));
                 }
               
                return config;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to delete all the items?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                _regConfigTable.Clear();
                treeRegConfig.ClearNodes();
            }
        }
        #endregion


        #region 错误检测
        
        private void gridViewRegTest_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

        }

        private void gridViewRegTest_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            
        }
        private void gridViewRegTest_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow row = gridViewRegTest.GetDataRow(e.RowHandle);
            row.ClearErrors();
            if (row["RegName"].ToString()=="")
            {
                row.SetColumnError(_regConfigTable.Columns["RegName"], "Error data");                
            }
            try
            {
                UInt32 data = Convert.ToUInt32(row["Offset(0x)"].ToString(),16);
                row["Offset(0x)"] = data.ToString("X8");
            }
            catch(Exception exc)
            {
                row.SetColumnError(_regConfigTable.Columns["Offset(0x)"], "Invalided hex number.");
            }
            try
            {
                Convert.ToUInt32(row["BytesNum"].ToString(),10);
               
            }
            catch(Exception exc)
            {
                row.SetColumnError(_regConfigTable.Columns["BytesNum"], "Invalided number.");
            }
            //ValidateData();
        }
        #endregion


        private void tabRegConfig_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try 
            {
                if (e.Page.Name == "xtraTabRegRW")
                {
                    InitConfigTree();
                }
                else if (e.Page.Name == "xtraTabAddRegs")
                {
                    UpdateComboBAR();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            
        }
        #region 寄存器读写操作
        /// <summary>
        /// 单击树列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeRegConfig_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.treeRegConfig.FocusedNode.Tag != null)
            {
                RegConfig config = this.treeRegConfig.FocusedNode.Tag as RegConfig;
                editData.Text = String.Format("Selected node info:\r\nBAR:\t\t{0} \r\nOffset:\t\t{1} \r\nMODE:\t\t{2} \r\nTYPE:\t\t{3} \r\nAUTO-INC:\t{4}",
                    this.repositoryItemComboBoxBar.Items[(int)config.m_dwBar].ToString(),
                    config.m_dwOffset, config.m_mode, config.m_type, config.m_bAutoInc);
                _regConfig = config;
                this.btnRead.Enabled = true;
                this.btnWrite.Enabled = true;
            }
            else
            {
                editData.Text = "Invalid node selected.";
                this.btnRead.Enabled = false;
                this.btnWrite.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            m_direction = RW.READ;
            m_bData = new byte[_regConfig.m_dwBytes];
            m_wData = new WORD[_regConfig.m_dwBytes / 2];
            m_u32Data = new UINT32[_regConfig.m_dwBytes / 4];
            m_u64Data = new UINT64[_regConfig.m_dwBytes / 8];
            ReadWriteAddrSpace();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string str = "";
            m_direction = RW.READ;
            m_bData = new byte[_regConfig.m_dwBytes];
            m_wData = new WORD[_regConfig.m_dwBytes / 2];
            m_u32Data = new UINT32[_regConfig.m_dwBytes / 4];
            m_u64Data = new UINT64[_regConfig.m_dwBytes / 8];
            m_direction = RW.WRITE;
            switch (_regConfig.m_mode)
            {
                case WDC_ADDR_MODE.WDC_MODE_8:
                    {
                        m_bData = new byte[_regConfig.m_dwBytes];

                       
                            str = editData.Text;
                            for (int i = 0, j = 0; i < str.Length && j < _regConfig.m_dwBytes; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_bData[j] = Convert.ToByte(str.Substring(i, 2), 16);
                                i += 2;
                            }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_16:
                    {
                        m_wData = new WORD[_regConfig.m_dwBytes / 2];

                            str = editData.Text;
                            for (int i = 0, j = 0; i < str.Length && j < _regConfig.m_dwBytes / 2; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_wData[j] = Convert.ToUInt16(str.Substring(i, 4), 16);
                                i += 4;
                            }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_32:
                    {
                        m_u32Data = new UINT32[_regConfig.m_dwBytes / 4];

                            str = editData.Text;
                            for (int i = 0, j = 0; i < str.Length && j < _regConfig.m_dwBytes / 4; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_u32Data[j] = Convert.ToUInt32(str.Substring(i, 8),
                                    16);
                                i += 8;
                            }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_64:
                    {
                        m_u64Data = new UINT64[_regConfig.m_dwBytes / 8];
                        
                            str = editData.Text;
                            for (int i = 0, j = 0; i < str.Length && j < _regConfig.m_dwBytes / 8; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_u64Data[j] = Convert.ToUInt64(str.Substring(i, 2),
                                    16);
                                i += 16;
                            }
                        break;
                    }
            }
            ReadWriteAddrSpace();
        }
        private void ReadWriteAddrSpace()
        {
            m_obj = new object[1];
            DWORD dwStatus = 0;
            BOOL bIsBlock = (_regConfig.m_type == TRANSFER_TYPE.BLOCK);
            BOOL bIsRead = (m_direction == RW.READ);
            WDC_ADDR_RW_OPTIONS dwOptions = (_regConfig.m_bAutoInc ?
                WDC_ADDR_RW_OPTIONS.WDC_ADDR_RW_DEFAULT :
                WDC_ADDR_RW_OPTIONS.WDC_ADDR_RW_NO_AUTOINC);
            DWORD dwFloorBytes = ((DWORD)(_regConfig.m_dwBytes / (DWORD)_regConfig.m_mode)) *
                (DWORD)_regConfig.m_mode;

            switch (_regConfig.m_mode)
            {
                case WDC_ADDR_MODE.WDC_MODE_8:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, _regConfig.m_dwBytes, m_bData,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr8(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, ref m_bData[0]);
                            m_obj[0] = m_bData;
                            UpdateReadControl(m_obj, dwFloorBytes, _regConfig.m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_bData,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr8(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, m_bData[0]);
                        }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_16:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_wData,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr16(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, ref m_wData[0]);
                            m_obj[0] = m_wData;
                            UpdateReadControl(m_obj, dwFloorBytes, _regConfig.m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_wData,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr16(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, m_wData[0]);
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_32:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_u32Data,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr32(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, ref m_u32Data[0]);
                            m_obj[0] = m_u32Data;
                            UpdateReadControl(m_obj, dwFloorBytes, _regConfig.m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_u32Data,
                                   _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr32(m_device.Handle,
                                   _regConfig.m_dwBar, _regConfig.m_dwOffset, m_u32Data[0]);
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_64:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                   _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_u64Data,
                                   _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr64(m_device.Handle,
                                   _regConfig.m_dwBar, _regConfig.m_dwOffset, ref m_u64Data[0]);
                            m_obj[0] = m_u64Data;
                            UpdateReadControl(m_obj, dwFloorBytes, _regConfig.m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, dwFloorBytes, m_u64Data,
                                    _regConfig.m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr64(m_device.Handle,
                                    _regConfig.m_dwBar, _regConfig.m_dwOffset, m_u64Data[0]);
                        }

                        break;
                    }
            }
        }
        private void UpdateReadControl(object[] obj, DWORD dwBuffSize,
    WDC_ADDR_MODE mode)
        {
            editData.Text = RegTest.DisplayHexBuffer(obj, dwBuffSize, mode);
        }
        #endregion

    }
    public class RegConfig
    {
        public bool m_bAutoInc;
        public DWORD m_dwOffset;
        public UINT32 m_dwBytes;
        public TRANSFER_TYPE m_type;
        public WDC_ADDR_MODE m_mode;
        public DWORD m_dwBar;
    }
}
