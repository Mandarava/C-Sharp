using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 旅游景点资源管理系统
{
    public partial class F_Login : Form
    {
        private SqlConnection con;
        private DataSet dataSet;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;
        public F_Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
            int count = 0;
            try
            {
                string sql =
                    "select COUNT(*) from account where ID='" + txtAccount.Text + "'" + "and ID_password='" +
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
                MessageBox.Show("登陆成功！");
            }
        }

        private void ClrText(Control ctrlTop)
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
    }
}
