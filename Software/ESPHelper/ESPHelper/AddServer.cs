using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ESPHelper
{
    public partial class AddServer : DevExpress.XtraEditors.XtraForm
    {
        List<ServiceEvent> list = new List<ServiceEvent>();
        public AddServer()
        {
            InitializeComponent();
        }

        private void AddServer_Load(object sender, EventArgs e)
        {
            list.Clear();
            foreach (var item in ServerManager.IOAll)
            {
                list.Add(item.Value);
            }
            this.gridControlServer.DataSource = list;
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.gridControlServer.BeginUpdate();
            list.Clear();
            foreach (var item in ServerManager.IOAll)
            {
                list.Add(item.Value);
            }
            this.gridControlServer.EndUpdate();
        }
        /// <summary>
        /// 全部选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectall_Click(object sender, EventArgs e)
        {
            this.gridControlServer.BeginUpdate();
            foreach (var item in list)
            {
                item.Selected = true;
            }
            this.gridControlServer.EndUpdate();
        }
        /// <summary>
        /// 全部取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisselectAll_Click(object sender, EventArgs e)
        {
            this.gridControlServer.BeginUpdate();
            foreach (var item in list)
            {
                item.Selected = false;
            }
            this.gridControlServer.EndUpdate();
        }
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}