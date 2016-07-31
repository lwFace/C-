using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ESPHelper.DocControl
{
    public partial class NewPacForm : DevExpress.XtraEditors.XtraForm
    {
        public string name;
        public NewPacForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.name = this.textEditName.Text;
            if (Program.mainFrm.pacList.ContainsKey(name))
            {
                MessageBox.Show("报文名称重复，请重新命名！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}