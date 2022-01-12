using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardBase64Converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Color.DarkRed;
                CbrdConverter.ToBase64(ofd.FileName);
                this.BackColor = Color.FromArgb(64,64,64);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CbrdConverter.FromBase64(null);
        }
    }
}
