using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinDriverDemo.Modules
{
    public partial class OptionsFrm : DevExpress.XtraEditors.XtraForm
    {
        public OptionsFrm()
        {
            InitializeComponent();
        }

        private void OptionsFrm_Load(object sender, EventArgs e)
        {
            //treeOptions.Nodes.AddRange("Board Scan","Board Configuration","Register Test");
            //TreeNode node = treeOptions.Nodes.Add("Register Test");
            //node.Nodes.Add("General");
            //node = treeOptions.Nodes.Add("Board Scan");
            //node.Nodes.Add("General");
            //node = treeOptions.Nodes.Add("Board Configuration");
            //node.Nodes.Add("General");
            //this.tabOptions.ItemSize = new Size(0, 1);
          //  this.tabPage1.Parent = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}