using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo1553.Class;
using Be.Windows.Forms;

namespace Demo1553
{
    public partial class FrmBM : DevExpress.XtraEditors.XtraForm
    {
        BM BoundBM;
        public FrmBM()
        {
            InitializeComponent();
        }
        public FrmBM(BM bm)
        {
            InitializeComponent();
            BoundBM = bm;
            this.gridControl2.DataSource = BoundBM.MonitorMsgList;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
        }

        private void FrmBM_Load(object sender, EventArgs e)
        {
            byte[] array = new byte[64];
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }
    }
}
