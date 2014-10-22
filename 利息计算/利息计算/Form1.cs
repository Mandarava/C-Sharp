using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 利息计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = Convert.ToString(hScrollBar1.Value);
            textBox4.Text = Convert.ToString(cal());
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = Convert.ToString(hScrollBar3.Value);
            textBox4.Text = Convert.ToString(cal());
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(hScrollBar2.Value)/10.0);
            textBox4.Text = Convert.ToString(cal());
        }

        private double cal()
        {
            return Convert.ToDouble(hScrollBar1.Value)*(1+(Convert.ToDouble(hScrollBar2.Value)/1000*
                   Convert.ToInt64(hScrollBar3.Value))/12);
        }
    }
}
