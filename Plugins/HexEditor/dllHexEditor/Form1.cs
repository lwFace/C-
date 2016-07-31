using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
namespace dllHexEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte[] array = new byte[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToByte(i * 3);
            }
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBox1.ByteProvider = provider;
            this.hexBox1.ByteProvider.ApplyChanges();
            byte[] array2 = new byte[1];
             DynamicByteProvider provider2 = new DynamicByteProvider(array2);
             this.hexBox2.ByteProvider = provider2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long len = this.hexBox1.ByteProvider.Length;
            byte[] array = new byte[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = this.hexBox1.ByteProvider.ReadByte(i);
            }
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBox2.ByteProvider = provider;
        }
    }
}
