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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            StreamWriter sw;
            sw = new StreamWriter("MyRecord.txt", true, System.Text.Encoding.Unicode);
            Record p=new Record("admin","admin");
            p.Writefile(sw);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regisiter reg=new regisiter();
            reg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str;
            string account, key,ak;
            if (textBox1.Text == ""||textBox2.Text=="")
            {
                MessageBox.Show("账号或密码不能为空");
            }
            account = textBox1.Text;
            key = textBox2.Text;
            ak = account + "," + key;
            StreamReader sr=new StreamReader("MyRecord.txt",System.Text.Encoding.Unicode);
            string[] a = new string[50];
            str = sr.ReadLine();
            while (str != null)
            {
                if (str == ak)
                {
                    MessageBox.Show("登陆成功");
                    return;                     //或者显示别的窗体
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                str = sr.ReadLine();
            }
            MessageBox.Show("账号或者密码错误");
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号");
            }
            else
            {
                MessageBox.Show("暂时不支持找回");
            }
        }
    }
}
