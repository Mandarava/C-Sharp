using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 动物奔跑.Properties;

namespace 动物奔跑
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int index = 0;
        string[] path =
        {
            Application.StartupPath + @"\IMG00000.bmp", Application.StartupPath + @"\IMG00001.bmp",
            Application.StartupPath + @"\IMG00002.bmp",Application.StartupPath + @"\IMG00003.bmp",
            Application.StartupPath + @"\IMG00004.bmp",Application.StartupPath + @"\IMG00005.bmp",
            Application.StartupPath + @"\IMG00006.bmp",Application.StartupPath + @"\IMG00007.bmp",
            Application.StartupPath + @"\IMG00008.bmp",
        };
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[index]);
            index++;
            index = index%8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = Convert.ToInt32(hScrollBar1.Value*5);
        }
    }
}
