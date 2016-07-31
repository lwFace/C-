using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Xml;
using DevExpress.XtraTreeList.Nodes;
namespace WinDriverDemo.Options
{
    public partial class ShortCutFrm : DevExpress.XtraEditors.XtraForm
    {
        public DataTable _shortConfigTable;
        public DevExpress.XtraTreeList.TreeList treeShortCmdConfig = Program._mainFrm.GetShortCmdList();
   //     private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxMode;
        public ShortCutFrm()
        {
            InitializeComponent();
            _shortConfigTable = new DataTable();
            _shortConfigTable.TableName = "ShortConfig";
            _shortConfigTable.Columns.Add("组别", typeof(string));
            _shortConfigTable.Columns.Add("名称", typeof(string));
            _shortConfigTable.Columns.Add("数据", typeof(string));
        //    _shortConfigTable.Columns.Add("发送方式", typeof(string));
            this.gridControlShortCut.DataSource = _shortConfigTable;
        //    repositoryItemComboBoxMode = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
        //    repositoryItemComboBoxMode.Items.AddRange(new object[] {"字符","十六进制"});
       //     this.gridViewRegTest.Columns["发送方式"].ColumnEdit = repositoryItemComboBoxMode;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog.FileName;

                DataTableToXML(this._shortConfigTable, fName);
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
                _shortConfigTable.Clear();
                _shortConfigTable.ReadXml(reader);
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
                treeShortCmdConfig.ClearNodes();
                //  TreeListNode rootNode = treeRegConfig.AppendNode(new object[] { "REGConfigure" }, -1);

                bool flag = false;
                foreach (DataRow row in _shortConfigTable.Rows)
                {
                    //foreach (TreeListNode node in rootNode.Nodes)
                    foreach (TreeListNode node in treeShortCmdConfig.Nodes)
                    {
                        if (node.GetValue(0).ToString() == row["组别"].ToString())
                        {
                            TreeListNode regNode = node.Nodes.Add(new object[] { row["名称"].ToString() });
                            regNode.Tag = SetNodeTag(row);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        //TreeListNode node = rootNode.Nodes.Add(new object[] { row["组别"].ToString() });
                        TreeListNode node = treeShortCmdConfig.AppendNode(new object[] { row["组别"].ToString() }, -1);
                        TreeListNode regNode = node.Nodes.Add(new object[] { row["名称"].ToString() });
                        regNode.Tag = SetNodeTag(row);
                    }
                    flag = false;
                }
                treeShortCmdConfig.ExpandAll();
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
        private shortConfig SetNodeTag(DataRow row)
        {
            try
            {
                shortConfig config = new shortConfig();
                config.data = (string)row["数据"];
             //   config.type = 
                return config;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定删除所有条目?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                _shortConfigTable.Clear();
                treeShortCmdConfig.ClearNodes();
            }
        }

        private void ShortCutFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            InitConfigTree();
            this.Hide();
        }

        private void gridViewRegTest_DataSourceChanged(object sender, EventArgs e)
        {
            InitConfigTree();
        }

        private void gridViewRegTest_ColumnChanged(object sender, EventArgs e)
        {
            InitConfigTree();
        }

        private void gridViewRegTest_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            try
            {
                DataRow row = gridViewRegTest.GetDataRow(e.RowHandle);
                row["组别"] = "常用指令";
                row["名称"] = "命令";
              //  row["发送方式"] = "十六进制";
                row["数据"] = ""; 
                row.EndEdit();
                this.gridViewRegTest.UpdateCurrentRow();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void gridViewRegTest_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

    }
    public class shortConfig
    {
        public string data;
  //      public SendDataType type;
    }
}