using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xsd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = System.IO.File.ReadAllText("queue.xml");
            eDSPNNet note = (eDSPNNet)SerializeHelp.Deserialize(typeof(eDSPNNet), content);
        }
    }
}
