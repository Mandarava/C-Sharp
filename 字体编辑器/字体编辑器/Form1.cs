using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字体编辑器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button1.Click -= new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (blue.Checked)
                    richTextBox1.ForeColor = Color.Blue;
                if (red.Checked)
                    richTextBox1.ForeColor = Color.Red;
                if (green.Checked)
                    richTextBox1.ForeColor = Color.Green;
                if (size16.Checked)
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 16, richTextBox1.Font.Style);
                if (size20.Checked)
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 20, richTextBox1.Font.Style);
                if (size24.Checked)
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 24, richTextBox1.Font.Style);
                if (楷体.Checked)
                    richTextBox1.Font = new Font("楷体", richTextBox1.Font.Size, richTextBox1.Font.Style);
                if (隶书.Checked)
                    richTextBox1.Font = new Font("隶书", richTextBox1.Font.Size, richTextBox1.Font.Style);
                if (华文彩云.Checked)
                    richTextBox1.Font = new Font("华文彩云", richTextBox1.Font.Size, richTextBox1.Font.Style);          
        }

        private void underline_CheckedChanged(object sender, EventArgs e)
        {
            if (underline.Checked)
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            if (italic.Checked)
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);
            //richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style &~ FontStyle.Italic);  &~  ^ 不祥
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            if (bold.Checked)
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }
    }
}
