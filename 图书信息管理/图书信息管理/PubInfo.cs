using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书信息管理
{
    public partial class PubInfo : Form
    {
        public PubInfo()
        {
            InitializeComponent();
        }
        private SqlConnection con;
        private DataSet dataSet;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;
        private void PubInfo_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Server=.;Initial Catalog=Library;Integrated Security=SSPI");
            con.Open();
            dataSet=new DataSet();
            string strSQL = "Select * from PubInfo";
            sqlCommand=new SqlCommand(strSQL,con);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox1.Text = sqlDataReader["pubid"].ToString();
                textBox4.Text = sqlDataReader["pubname"].ToString();
                textBox2.Text = sqlDataReader["pubcity"].ToString();
                textBox5.Text = sqlDataReader["ADDRESSS"].ToString();
                textBox3.Text = sqlDataReader["cperson"].ToString();
                textBox6.Text = sqlDataReader["cptel"].ToString();
            }
            con.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into PubInfo Values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "'," + textBox6.Text + ")";
            SqlOperation(sqlstr);
        }

         private void button2_Click(object sender, EventArgs e)
        {
            string sqlstr = "update PubInfo SET pubid='" + textBox1.Text + "'" + "," + "pubname='" + textBox4.Text +
                                "'" + "," + "pubcity='" + textBox2.Text + "'" + "," + "ADDRESSS='" + textBox5.Text + "'" +
                                "," + "cperson='" + textBox3.Text + "'" + "," + "cptel='" + textBox6.Text + "'" +
                                "where pubid='" + textBox1.Text + "'";
            SqlOperation(sqlstr);
        }      
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the PublisherID!");
                return;
            }
            con = new SqlConnection("Server=.;Initial Catalog=Library;Integrated Security=SSPI");
            con.Open();
            try
            {
                string sqlstr = "DELETE FROM PubInfo WHERE pubid='"+textBox1.Text+"'";
                sqlCommand = new SqlCommand(sqlstr, con);
                int r = sqlCommand.ExecuteNonQuery();
                if (r == 1)
                    MessageBox.Show("Delete successfully!", "提示");
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
            textBox1.Text = "";
        }

        private void SqlOperation(string sqlstr)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill all of the blanks!");
                return;
            }
            con = new SqlConnection("Server=.;Initial Catalog=Library;Integrated Security=SSPI");
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet.Clear();
                con = new SqlConnection("Server=.;Initial Catalog=Library;Integrated Security=SSPI");
                con.Open();
                sqlCommand = new SqlCommand("SELECT * FROM PubInfo", con);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteReader();
                con.Close();
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "PubInfo");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "PubInfo";
                dataGridView1.Columns[0].HeaderText = "编号";
                dataGridView1.Columns[1].HeaderText = "名称";
                dataGridView1.Columns[2].HeaderText = "所在城市";
                dataGridView1.Columns[3].HeaderText = "地址";
                dataGridView1.Columns[4].HeaderText = "联系人";
                dataGridView1.Columns[5].HeaderText = "联系电话";
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].Width = 140;
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 120;
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
    }
}
