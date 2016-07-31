using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Services;

namespace ESPHelper.DocControl
{
    public partial class ServerInfoControl : DevExpress.XtraEditors.XtraUserControl
    {
        public Project m_project = null;
        public ServerInfoControl(Project prj)
        {
            InitializeComponent();
            m_project = prj;
            this.textEditInitPath.Text = prj.initXml;
            this.textEditrouterPath.Text = prj.routerXml;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "All files (*.*)|*.*|xml (*.xml)|*.xml";
                dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    this.textEditInitPath.Text = dlg.FileName.ToString();
                    this.m_project.initXml = this.textEditInitPath.Text;
                }
            }
        }

        private void btnRouter_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "All files (*.*)|*.*|xml (*.xml)|*.xml";
                dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.textEditrouterPath.Text = dlg.FileName.ToString();
                    this.m_project.routerXml = this.textEditrouterPath.Text;
                }
            }
        }

        private void btnInitPreView_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.textEditInitPath.Text.ToString()))
            {
                string tmp = File.ReadAllText(this.textEditInitPath.Text);
                string xml = tmp.Replace("\n", "\r\n");
                this.textXml.Text = xml;
//                 richEditControl1.ReplaceService<ISyntaxHighlightService>(new MySyntaxHighlightService(richEditControl1));
//                 richEditControl1.LoadDocument(this.textEditInitPath.Text.ToString(), DocumentFormat.PlainText);
            }
            else
            {
                Program.mainFrm.LogError(string.Format("File {0} is not exist.", this.textEditInitPath.Text.ToString()));
            }
        }

        private void btnRouterPreView_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.textEditrouterPath.Text.ToString()))
            {
                string tmp = File.ReadAllText(this.textEditrouterPath.Text);
                string xml = tmp.Replace("\n", "\r\n");
                this.textXml.Text = xml;
//                 richEditControl1.ReplaceService<ISyntaxHighlightService>(new MySyntaxHighlightService(richEditControl1));
//                 richEditControl1.LoadDocument(this.textEditrouterPath.Text.ToString(), DocumentFormat.PlainText);
            }
            else
            {
                Program.mainFrm.LogError(string.Format("File {0} is not exist.", this.textEditInitPath.Text.ToString()));
            }
        }

       
    }
}
