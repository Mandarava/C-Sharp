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

namespace 登陆界面
{
    public partial class regisiter : Form
    {
        public regisiter()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            string account;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("账号或密码不能为空");
            }
            account = textBox1.Text;
            StreamReader sr = new StreamReader("MyRecord.txt", System.Text.Encoding.Unicode);
            string[] a = new string[20];
            str = sr.ReadLine();
            while (str != null)
            {
                a = str.Split(',');
                if (a[0].Equals(account))
                {
                    MessageBox.Show("账号已经存在");
                    return; 
                }
                str = sr.ReadLine();
            }            
            sr.Close();    
            this.Close();
            StreamWriter sw;
            sw = new StreamWriter("MyRecord.txt", true, System.Text.Encoding.Unicode);
            Record r;
            r = new Record(textBox1.Text, textBox2.Text);
            r.Writefile(sw);
            sw.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("注册成功");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
