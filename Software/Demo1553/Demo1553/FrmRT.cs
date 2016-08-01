using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Be.Windows.Forms;

namespace Demo1553
{
    public partial class FrmRT : DevExpress.XtraEditors.XtraForm
    {
        public BindingList<BoundMessage> MsgList = new BindingList<BoundMessage>();
        public FrmRT()
        {
            InitializeComponent();
        }

        private void FrmRT_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = MsgList;
            this.gridView1.Columns["UUID"].Visible = false;
            this.gridView1.Columns["Payload"].Visible = false;

            byte[] array = new byte[64];
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }
    }
}