using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
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

        //private SqlConnection con =
        // new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");

        private SqlConnection con = new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private DataSet dataSet;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;

        private void F_Main_Load(object sender, EventArgs e)
        {
            account = F_Login.ID; //根据不同用户加载界面
            try
            {
                string userID = Convert.ToString(account);
                string sql = string.Format("EXECUTE proc_accountByaccount_authoritySelect '{0}'", userID);
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
                btnDel.Visible = false;
                btnDel3.Visible = false;
                btnUpdate.Visible = false;
                btnUpdate2.Visible = false;
                btnUpdate3.Visible = false;

                //TabPage tp = new TabPage();         //隐藏导游管理tabpage
                //tp = this.tabControl1.TabPages[1];
                //this.tabControl1.TabPages.Remove(tp);
            }
            btnUpdate2.Visible = false;
            string var = GetWeather();
            this.toolStripStatusLabel3.Text = var;
        }

        public static string GetWeather()
        {
            try
            {
                string wUrl = string.Format("http://www.weather.com.cn/data/cityinfo/{0}.html", 101020100);
                HttpWebRequest wNetr = (HttpWebRequest)HttpWebRequest.Create(wUrl);
                HttpWebResponse wNetp = (HttpWebResponse)wNetr.GetResponse();
                wNetr.ServicePoint.Expect100Continue = false;
                wNetr.ServicePoint.UseNagleAlgorithm = false;
                wNetr.ContentType = "text/html";
                wNetr.Headers.Clear();  //清除http请求头信息
                wNetr.Timeout = 15;   //超时时间
                wNetr.Method = "GET";
                Stream Streams = wNetp.GetResponseStream();
                StreamReader Reads = new StreamReader(Streams, Encoding.UTF8);
                String ReCode = Reads.ReadToEnd();
                //关闭暂时不适用的资源
                Reads.Dispose();
                Streams.Dispose();
                wNetp.Close();
                //分析返回代码
                String[] Splits = new String[] { "\"", ",", "\"" };
                String[] Temp = ReCode.Split(Splits, StringSplitOptions.RemoveEmptyEntries);
                ReCode = String.Format("{0}: {1} ~{2} {3}", Temp[5], Temp[11], Temp[14], Temp[17]);
                return ReCode;
            }
            catch (Exception)
            {
                return null;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            string strsql = "EXECUTE proc_hotel_sceneByAllSelect";
            string[] HeaderText = { "酒店名字", "联系电话", "酒店地址", "酒店星级", "所属景点" };
            string tableName = "hotel_scene";
            show_dataGridView(strsql, tableName, HeaderText);
        }

        private void hotelMouseClick(object sender, MouseEventArgs e)
        {
            hotelSearch.Text = "";
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            ClrText(this);
            hotelNum.Text = "";
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            if (hotelNum.Text == null)
            {
                MessageBox.Show("请输入酒店编号！");
            }
            string sqlstr = string.Format("EXECUTE proc_hotelByAllDelete {0}", hotelNum.Text);
            SqlOperation(sqlstr);
        }

        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_hotelByAllUpdate '{0}','{1}','{2}'", hotelGrade.Text,
                hotelName.Text, hotelTel.Text);
            SqlOperation(strsql);
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            int count = 0; //判断是否有该条记录
            string sqlstr2 = string.Format("EXECUTE proc_hotel_sceneByCountSelect '{0}'", hotelSearch.Text);
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
                string a = hotelSearch.Text.Trim();
                if (a != "")
                {
                    string strsql = string.Format("EXECUTE proc_hotel_sceneByhotel_nameSelect '{0}'", hotelSearch.Text);
                    string[] HeaderText = { "酒店名字", "联系电话", "酒店地址", "酒店星级", "所属景点" };
                    string tableName = "hotel_scene";
                    show_dataGridView(strsql, tableName, HeaderText);
                    showDetails();
                }
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
                sqlDataAdapter.Fill(dataSet, tableName);
                List<Control> strList = getDatagridControls();
                DataGridView f = (DataGridView)strList[tabControl1.SelectedIndex];
                f.DataSource = dataSet;
                f.DataMember = tableName;
                int a = f.Columns.Count;
                f.ScrollBars = ScrollBars.Both;
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
            DataGridView f = (DataGridView)strList[tabControl1.SelectedIndex];
            int columnsCount = f.Columns.Count; //获取数据的列数
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
            List<Control> ctrlList = getTextControls();
            for (int i = 0; i < ctrlList.Count; i++)
            {
                ctrlList[i].Text = "";
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
            string strsql = "EXECUTE proc_sceneByAllSelect";
            show_dataGridView(strsql, tableName, HeaderText);
        }

        private void viewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }

        private void viewMouseClick(object sender, MouseEventArgs e)
        {
            tourSearch.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tourNum.Text == null)
            {
                MessageBox.Show("请输入景点编号！");
            }
            string sqlstr = string.Format("EXECUTE proc_sceneByAllDelete {0}", tourNum.Text);
            SqlOperation(sqlstr);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_sceneByAllUpdate '{0}','{1}','{2}'", tourTel.Text, tourPrice.Text, tourNum.Text);
            SqlOperation(strsql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0; //判断是否有该条记录
            string sqlstr2 = string.Format("EXECUTE proc_sceneByCountSelect '{0}'", tourSearch.Text);
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
                string a = tourSearch.Text.Trim();   //检测输入是否为空值
                if (a != "")
                {
                    string strsql = string.Format("EXECUTE proc_sceneByview_nameSelect '{0}'", tourSearch.Text);
                    string[] HeaderText = { " 景点编号", "景点名字", "景点地址", "联系电话", "城市", "门票价格" };
                    string tableName = "scene";
                    show_dataGridView(strsql, tableName, HeaderText);
                    showDetails();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_sceneByALLInsert {0},{1},{2},{3},{4},{5}", tourNum.Text,
                tourName.Text, tourAddress.Text, tourTel.Text, tourCity.Text, tourPrice.Text);
            SqlOperation(strsql);
        }
        //导游管理
        private void btnReset2_Click(object sender, EventArgs e)
        {
            ClrText(this);
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            string tableName = "guide_scene";
            string[] HeaderText = { "工号", "名字", "性别", "工龄", "负责景点" };
            string strsql = "EXECUTE proc_guide_sceneByAllSelect";
            show_dataGridView(strsql, tableName, HeaderText);
        }

        private void guide_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails();
        }

        private void empVisitor_Click(object sender, EventArgs e)
        {
            string tableName = "tourist_guide";
            string[] HeaderText = { "游客名字", "游客电话", "游客性别", "游客景点" };
            string strsql = string.Format("EXECUTE proc_tourist_guideByALLSelect '{0}'", guide_view.Text);
            show_dataGridView(strsql, tableName, HeaderText);
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_guideByAllUpdate '{0}','{1}','{2}'", empID.Text, guide_view.Text, empWorkAge.Text);
            SqlOperation(strsql);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // string view_num = string.Format("DECLARE @view_num varchar(50) EXECUTE proc_sceneByview_umSelect '{0}',@view_num output", guide_view.Text.Trim());
                con.Open();

                    //设置要调用的存储过程的名称  
                    sqlCommand.CommandText = "proc_sceneByview_umSelect";
                    //指定SqlCommand对象传给数据库的是存储过程的名称而不是sql语句  
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = sqlCommand.Parameters.Add(new SqlParameter("@view_name", SqlDbType.VarChar, 50));
                    //指明"@username"是输入参数  
                    username.Direction = ParameterDirection.Input;
                    //为“@username”参数赋值  
                    username.Value = this.guide_view.Text.Trim();

                    SqlParameter view_num = sqlCommand.Parameters.Add(new SqlParameter("@view_num", SqlDbType.VarChar, 50));
                    //指定"@password"为输出参数  
                    view_num.Direction = ParameterDirection.Output;
                    //执行  
                    sqlCommand.ExecuteNonQuery();
                    //得到输出参数的值,把赋值给name,注意,这里得到的是object类型的,要进行相应的类型轮换  
                    string output = Convert.ToString(sqlCommand.Parameters["@view_num"].Value);
                   MessageBox.Show(output);
                string strsql = string.Format("EXECUTE proc_guide_sceneByALLInsert '{0}','{1}','{2}','{3}','{4}'", empID.Text, empName.Text, empSex.Text, empWorkAge.Text, guide_view.Text);
                SqlOperation(strsql);
            }

        
    }
}