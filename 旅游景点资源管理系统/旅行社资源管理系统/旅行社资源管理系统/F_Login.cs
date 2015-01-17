﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 旅行社资源管理系统
{
    public partial class F_Login : Form
    {
        private SqlConnection con;
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
            if (ctrlTop.GetType() == typeof(TextBox))
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
           // con = new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
            con = new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");
            int count = 0;
            try
            {
                string sql =
                    "select COUNT(*) from account2 where account_ID='" + txtAccount.Text + "'" + "and account_password='" +
                    txtPwd.Text + "'";
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
    }
}
