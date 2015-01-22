using System;
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
    public partial class addInfo : Form
    {
        public addInfo()
        {
            InitializeComponent();
        }

        //private SqlConnection con =
            //new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");

         private SqlConnection con= new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private SqlCommand sqlCommand;
        private string phoneNum = F_Login.ID;
        private string viewNum = addAdmin.view_num;

        public void SqlOperation(string sqlstr)
        {
            con.Open();
            try
            {
                sqlCommand = new SqlCommand(sqlstr, con);
                int r = sqlCommand.ExecuteNonQuery();
                if (r == 1)
                    MessageBox.Show("成功!", "提示");
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("insert into tourist values ('{0}','{1}','{2}','{3}')", txtName.Text.Trim(),
                phoneNum,
                txtSex.Text.Trim(), viewNum.Trim());
            SqlOperation(strsql);
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length != 0 && txtSex.Text.Trim().Length != 0)
            {
                btnFinish.Enabled = true;
            }
            else
            {
                btnFinish.Enabled = false;
            }
        }
    }
}