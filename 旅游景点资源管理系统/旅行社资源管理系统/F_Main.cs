using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 旅行社资源管理系统
{
    public partial class addAdmin : Form
    {
        public addAdmin()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection("Data source=localhost;User ID=sa;password=123456789;Initial Catalog=TRMS");

        //private SqlConnection con = new SqlConnection("Server=.;Initial Catalog=TRMS;Integrated Security=SSPI");
        private DataSet dataSet;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;

        private void F_Main_Load(object sender, EventArgs e)
        {
            string var = GetWeather(101020100);
            this.toolStripStatusLabel3.Text = var;
        }

        public static string GetWeather(int cityCode)
        {
            try
            {
                string wUrl = string.Format("http://www.weather.com.cn/data/cityinfo/{0}.html", cityCode);
                HttpWebRequest wNetr = (HttpWebRequest) HttpWebRequest.Create(wUrl);
                HttpWebResponse wNetp = (HttpWebResponse) wNetr.GetResponse();
                wNetr.ServicePoint.Expect100Continue = false;
                wNetr.ServicePoint.UseNagleAlgorithm = false;
                wNetr.ContentType = "text/html";
                wNetr.Headers.Clear(); //清除http请求头信息
                wNetr.Timeout = 15; //超时时间
                wNetr.Method = "GET";
                Stream Streams = wNetp.GetResponseStream();
                StreamReader Reads = new StreamReader(Streams, Encoding.UTF8);
                String ReCode = Reads.ReadToEnd();
                //关闭暂时不适用的资源
                Reads.Dispose();
                Streams.Dispose();
                wNetp.Close();
                //分析返回代码
                String[] Splits = new String[] {"\"", ",", "\""};
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


        private List<Control> getDatagridControls()
        {
            List<Control> strList = new List<Control>();
            foreach (Control ctrl in btnShowUser.Controls)
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
            foreach (Control ctrl in btnShowUser.TabPages[btnShowUser.SelectedIndex].Controls)
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
                DataGridView f = (DataGridView) strList[btnShowUser.SelectedIndex];
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
            DataGridView f = (DataGridView) strList[btnShowUser.SelectedIndex];
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

        public void SqlOperation(string sqlstr)
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
            string tableName = "scene2";
            string[] HeaderText = {"景点编号", "景点名字", "景点地址", "联系电话", "城市", "成人票价", "儿童票价", "景点介绍"};
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
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定执行？", "取消", messButton);
            if (dr == DialogResult.OK)
            {
                string sqlstr = string.Format("EXECUTE proc_sceneByAllDelete {0}", tourNum.Text);
                SqlOperation(sqlstr);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_sceneByAllUpdate '{0}','{1}','{2}','{3}','{4}'", tourTel.Text,
                tourPrice.Text, childPrice.Text, txtViewIntro.Text, tourNum.Text);
            SqlOperation(strsql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0; //判断是否有该条记录
            string sqlstr2 = string.Format("EXECUTE proc_scene2ByCountSelect '{0}'", tourSearch.Text);
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
                string a = tourSearch.Text.Trim(); //检测输入是否为空值
                if (a != "")
                {
                    string strsql = string.Format("EXECUTE proc_scene2Byview_nameSelect '{0}'", tourSearch.Text);
                    string[] HeaderText = {" 景点编号", "景点名字", "景点地址", "联系电话", "城市", "成人票价", "儿童票价", "简介"};
                    string tableName = "scene2";
                    show_dataGridView(strsql, tableName, HeaderText);
                    showDetails();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("EXECUTE proc_scene2ByALLInsert {0},{1},{2},{3},{4},{5},{6},{7}", tourNum.Text,
                tourName.Text, tourAddress.Text, tourTel.Text, tourCity.Text, tourPrice.Text, childPrice.Text,
                txtViewIntro.Text);
            SqlOperation(strsql);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tourNum_TextChanged(object sender, EventArgs e)
        {
            string appPath = Environment.CurrentDirectory;
            try
            {
                picView.Image = Image.FromFile(string.Format(appPath + @"\picture\{0}.jpg", tourNum.Text.Trim()));
            }
            catch (Exception)
            {
                picView.Image = Image.FromFile(appPath + @"\picture\error.jpg");
            }
        }
    }
}