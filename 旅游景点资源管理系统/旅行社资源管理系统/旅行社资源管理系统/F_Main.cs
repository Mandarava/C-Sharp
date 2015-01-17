using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 旅行社资源管理系统
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private string account;
        private string authority = "0";
        private SqlConnection con =
            new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");
        //  private SqlConnection con = new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private DataSet dataSet;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;

        private void F_Main_Load(object sender, EventArgs e)
        {
            account = F_Login.ID;                           //根据不同用户加载界面
            try
            {
                string sql =
                    "select account_authority from account where account_ID='" + Convert.ToString(account) + "'";
                con.Open();
                sqlCommand = new SqlCommand(sql, con);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    authority = sqlDataReader["account_authority"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (authority == "0")
            {
                btnAdd.Visible = false;
                btnAdd2.Visible = false;
                btnDel.Visible = false;
                btnDel2.Visible = false;
                btnDel3.Visible = false;
                btnUpdate.Visible = false;
                btnUpdate2.Visible = false;
                btnUpdate3.Visible = false;
                //TabPage tp = new TabPage();         //隐藏导游管理tabpage
                //tp = this.tabControl1.TabPages[1];
                //this.tabControl1.TabPages.Remove(tp);
            }
            else
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            string strsql = "SELECT * FROM hotel_scene";
            string[] HeaderText = { "酒店名字", "联系电话", "酒店地址", "酒店星级", "所属景点" };
            string tableName = "hotel_scene";
            show_dataGridView(strsql,tableName,HeaderText);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            if (hotelNum.Text == null)
            {
                MessageBox.Show("请输入酒店编号！");
            }
            string sqlstr = "delete from hotel where hotel_num='" + hotelNum.Text + "'";
            SqlOperation(sqlstr);
        }

        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            string sqlstr = "update hotel set hotel_level='" + hotelGrade.Text + "'," + "hotel_name='" + hotelName.Text +
                            "'," + "hotel_tel='" + hotelAddress.Text + "' where hotel_name='" + hotelName.Text + "'";
            SqlOperation(sqlstr);
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            int count = 0; //判断是否有该条记录
            string sqlstr2 = "select count(*) from hotel_scene where hotel_name like '%" + hotelSearch.Text + "%'";
            try
            {
                con.Open();
                sqlCommand = new SqlCommand(sqlstr2, con);
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
            if (count == 0)
            {
                ClrText(this);
                MessageBox.Show("没有该条信息");
            }
            else
            {
                string strsql = "select * from hotel_scene where hotel_name like '%" + hotelSearch.Text + "%'";
                string[] HeaderText = { "酒店名字", "联系电话", "酒店地址", "酒店星级", "所属景点" };
                string tableName = "hotel_scene";
                show_dataGridView(strsql, tableName, HeaderText);
                showDetails();
            }
        }

        private List<Control> getDatagridControls()
        {
            List<Control> strList = new List<Control>();
            foreach (Control ctrl in tabControl1.Controls)
            {
                foreach (Control datagridControl in ctrl.Controls)
                {
                    if (datagridControl is DataGridView)
                    {
                        strList.Add(datagridControl);
                    }
                }
            }
            return strList;
        }

        private List<Control> getTextControls()
        {
            List<Control> textboxList = new List<Control>();
            foreach (Control ctrl in tabControl1.TabPages[tabControl1.SelectedIndex].Controls)
               // foreach (Control ctrl in tabPage3.Controls)
            {
                foreach (Control textboxControl in ctrl.Controls)
                {
                    if (textboxControl is TextBox)
                    {
                        textboxList.Add(textboxControl);
                    }
                }
            }
            return textboxList;
        }

        private void show_dataGridView(string strsql, string tableName, string[] HeaderText)
        {
            try
            {
                con.Open();
                sqlCommand = new SqlCommand(strsql, con);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteReader();
                con.Close();
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet,tableName);
                List<Control> strList = getDatagridControls();
                DataGridView f = (DataGridView)strList[tabControl1.SelectedIndex];               
                f.DataSource = dataSet;
                f.DataMember =tableName; 
                int a = f.Columns.Count;      
                f.ScrollBars=ScrollBars.Both;
                for (int i = 0; i < a; i++)
                {
                    f.Columns[i].HeaderText = HeaderText[i];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void showDetails()
        {
            List<Control> strList = getDatagridControls();
            DataGridView f = (DataGridView) strList[tabControl1.SelectedIndex];
            int columnsCount = f.Columns.Count;  //获取数据的列数
            int a = f.CurrentRow.Index;
            List<Control> textboxList = getTextControls();
            int textIndex = columnsCount - 1;
            for (int j = 0; j < columnsCount; j++)
            {
                string str = f.Rows[a].Cells[j].Value.ToString();
                textboxList[textIndex].Text = str;
                textIndex--;
            }
        }

        private void SqlOperation(string sqlstr)
        {
            con.Open();
            try
            {
                sqlCommand = new SqlCommand(sqlstr, con);
                int r = sqlCommand.ExecuteNonQuery();
                if (r == 1)
                    MessageBox.Show("Operate Successfully!", "提示");
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

        public void ClrText(Control ctrlTop) //清空文本框
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

        //旅游景点管理

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string tableName = "scene";
            string[] HeaderText = { "景点编号", "景点名字", "景点地址", "联系电话", "城市", "门票价格" };
            string strsql = "SELECT * FROM scene";
            show_dataGridView(strsql, tableName, HeaderText);
        }

        private void viewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }





        //导游管理
        private void btnReset2_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            string tableName = "guide_scene";
            string[] HeaderText = {"工号", "名字", "性别", "工龄", "负责景点"};
            string strsql = "select * from guide_scene";
            show_dataGridView(strsql,tableName,HeaderText);
        }

        private void guide_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }

        private void empVisitor_Click(object sender, EventArgs e)
        {
            string tableName = "tourist_guide";
            string[] HeaderText = {"游客名字", "游客电话", "游客性别", "游客景点"};
            string strsql = "select * from tourist_guide where view_name='"+guide_view.Text+"'";
            show_dataGridView(strsql,tableName,HeaderText);
        }


    }
}