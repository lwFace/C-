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

namespace Demo1553
{
    public partial class RTControl : DevExpress.XtraEditors.XtraUserControl
    {
        BindingList<BoundRTMessage> msgList = new BindingList<BoundRTMessage>(); 
        public RTControl()
        {
            InitializeComponent();
            this.gridControl1.DataSource = msgList;
            this.gridView1.Columns["UUID"].Visible = false;
            this.gridView1.Columns["Payload"].Visible = false;

            byte[] array = new byte[64];
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxBcPayload.ByteProvider = provider;
        }
    }
}
