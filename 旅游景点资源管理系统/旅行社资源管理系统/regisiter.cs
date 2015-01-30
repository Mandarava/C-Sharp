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
    public partial class regisiter : Form
    {
        public regisiter()
        {
            InitializeComponent();
        }

        //private SqlConnection con =
        //    new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");

        private SqlConnection con= new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private SqlCommand sqlCommand;

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

        public void SqlOperation(string sqlstr)
        {
            con.Open();
            try
            {
                sqlCommand = new SqlCommand(sqlstr, con);
                int r = sqlCommand.ExecuteNonQuery();
                if (r == 1)
                    MessageBox.Show("注册成功!", "提示");
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
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

        private void btnreg_Click(object sender, EventArgs e)
        {
            string str = txtRegID.Text.Trim();
            if (txtRegPwd.Text != txtPwdVerify.Text)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
                txtRegPwd.Text = "";
                txtPwdVerify.Text = "";
            }
            else
            {
                string strsql = string.Format("insert into account values('{0}','{1}','{2}')", str,
                    UserMd5(txtRegPwd.Text), "0");
                SqlOperation(strsql);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtRegID.Text.Trim().Length != 0 && txtRegPwd.Text.Trim().Length != 0 &&
                txtPwdVerify.Text.Trim().Length != 0)
            {
                btnreg.Enabled = true;
            }
            else
            {
                btnreg.Enabled = false;
            }
        }
    }
}