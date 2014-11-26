using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 读取文本文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            var sr = new StreamReader(path + @"\Form1.cs", Encoding.UTF8);
            string str;
            str = sr.ReadToEnd();
            richTextBox1.Text = str;
            sr.Close();
        }
    }
}