using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 旅游景点资源管理系统
{
    public partial class F_Login : Form
    {
        //private SqlConnection con =
           // new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");

         private SqlConnection con= new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private SqlCommand sqlCommand;
        public static string ID;

        public F_Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        public void ClrText(Control ctrlTop)
        {
            if (ctrlTop.GetType() == typeof (TextBox))
                ctrlTop.Text = "";
            else
            {
                foreach (Control ctrl in ctrlTop.Controls)
                {
                    ClrText(ctrl);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ID = txtAccount.Text;
            int count = 0;
            try
            {
                string sql =
                    "select COUNT(*) from account2 where account_ID='" + txtAccount.Text + "'" +
                    "and account_password='" +
                    UserMd5(txtPwd.Text) + "'";
                con.Open();
                sqlCommand = new SqlCommand(sql, con);
                count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (count < 1)
            {
                MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClrText(this);
            }
            else
            {
                this.Hide();
                F_Main f_main = new F_Main();
                f_main.ShowDialog();
            }
        }

        public static string UserMd5(string str)
        {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                pwd = pwd + s[i].ToString("x2");
            }
            return pwd;
        }


        private void btnRegisiter_Click(object sender, EventArgs e)
        {
            regisiter reg = new regisiter();
            reg.Show();
        }
    }
}