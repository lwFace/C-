using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using DevExpress.XtraGrid.Columns;


namespace ReadTest
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private int _page = 0;
        private DataSet _dataSource = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView1_CalcRowHeight);
        }
        private void gridView1_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            //e.RowHeight = 50;//(int)gridView1.GetDataRow(e.RowHandle)["RowHeight"];
        }
        private void barButtonItemOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel文件(*.xls)|*.xls|所有文件(*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string Name = dlg.FileName;
                  //  this.gridControl1.DataSource = ToDataTable(Name).Tables[0];
                    
                    _dataSource = TestExcelRead(Name);
                    this.gridControl1.DataSource = _dataSource.Tables[_page];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        static void PrintData(DataTable data)
        {
            if (data == null) return;
            for (int i = 0; i < data.Rows.Count; ++i)
            {
                for (int j = 0; j < data.Columns.Count; ++j)
                    Console.Write("{0} ", data.Rows[i][j]);
                Console.Write("\n");
            }
        }

        static DataSet TestExcelRead(string file)
        {
            try
            {
                ExcelHelper excelHelper = new ExcelHelper(file);
                return excelHelper.ExcelToDataTable( true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 读取Excel文件到DataSet中
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>

        public static DataSet ToDataTable(string fileName)
        {

            string connStr = "";
            string fileType = System.IO.Path.GetExtension(fileName);
            if (string.IsNullOrEmpty(fileType)) return null;

            if (fileType == ".xls")
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
            string sql_F = "Select * FROM [{0}]";
            OleDbConnection conn = null;
            OleDbDataAdapter da = null;
            DataTable dtSheetName = null;
            DataSet ds = new DataSet();
            try
            {
                // 初始化连接，并打开
                conn = new OleDbConnection(connStr);
                conn.Open();
                // 获取数据源的表定义元数据                        
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                // 初始化适配器

                da = new OleDbDataAdapter();
                for (int i = 0; i < dtSheetName.Rows.Count; i++)
                {
                    SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];
                    Console.WriteLine(SheetName);
                    if (SheetName.Contains("$") && !SheetName.Replace("'", "").EndsWith("$"))
                    {
                        continue;
                    }

                    da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
                    DataSet dsItem = new DataSet();
                    da.Fill(dsItem, SheetName);
                    ds.Tables.Add(dsItem.Tables[0].Copy());
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                // 关闭连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    da.Dispose();
                    conn.Dispose();
                }
            }
            return ds;
        }

        private void barButtonNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _page++;
            if (_page == _dataSource.Tables.Count)
            {
                _page = 0;
            }
            gridControl1.DataSource = _dataSource.Tables[_page];
            foreach (var col in gridView1.Columns)
            {
                ((GridColumn)col).ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            }
            gridView1.LayoutChanged();
        }
    }
}
