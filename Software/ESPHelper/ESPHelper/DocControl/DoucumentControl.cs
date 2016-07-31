using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Be.Windows.Forms;

namespace ESPHelper.DocControl
{
    public partial class DoucumentControl : DevExpress.XtraEditors.XtraUserControl
    {
//         delegate void WatchPayload(object sender, EventArgs e,object param);
//         public event WatchPayload OnWatchPayload;
        public DoucumentControl()
        {
            InitializeComponent();
        }
        public void SetDataSource(object table)
        {
            this.gridControl1.DataSource = table;
            gridDDSData.Columns["Payload"].Visible = false;
            gridDDSData.Columns["Payload"].UnboundType = DevExpress.Data.UnboundColumnType.Object;
            gridDDSData.Columns["DTime"].Caption = "△T(ms)";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridDDSData.Columns)
            {
                col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            object ojb = gridDDSData.GetRowCellValue(gridDDSData.FocusedRowHandle, "Payload");
            if (ojb != null )
            {
                byte[] data = ojb as byte[];
                DynamicByteProvider provider = new DynamicByteProvider(data);
                Program.mainFrm.Hexbox.ByteProvider = provider;
            }
        }


        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

       
    }
}
