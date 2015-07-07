using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Student_Student_info : System.Web.UI.Page
{

    private SqlDataReader sqlDataReader;
    protected void Page_Load(object sender, EventArgs e)
    {

        
        string ConnectionString = "server=.;database=GradeManage;Integrated Security = SSPI";
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        DataSet dt = new DataSet();
        string sql = "select * from Student where sn='"+Session["sn"].ToString()+"'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        sqlDataReader = cmd.ExecuteReader();
        while (sqlDataReader.Read())
        {
            lbl_sn.Text = sqlDataReader["sn"].ToString();
            lbl_name.Text = sqlDataReader["sname"].ToString();
            lbl_major.Text = sqlDataReader["major"].ToString();
            lbl_dept.Text = sqlDataReader["dept"].ToString();
        }
        conn.Close();
        cmd.Dispose();
    }
}
