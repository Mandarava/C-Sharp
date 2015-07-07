using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


public partial class Student_StudentReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ConnectionString = "server=.;database=GradeManage;Integrated Security = SSPI";
        SqlConnection conn = new SqlConnection(ConnectionString);
        string courseid = tbx_courseid.Text;
        string coursename = tbx_coursename.Text;
        string tname = tbx_tname.Text;

        conn.Open();
        string sql = "insert into Course(coursename,tname,courseid) values(@coursename,@tname,@courseid)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlParameter parp = new SqlParameter("@coursename", coursename);
        cmd.Parameters.Add(parp);
        SqlParameter parn = new SqlParameter("@tname", tname);
        cmd.Parameters.Add(parn);
        SqlParameter pp = new SqlParameter("@courseid", courseid);
        cmd.Parameters.Add(pp);
        int result = cmd.ExecuteNonQuery();
        conn.Close();
        cmd.Dispose();

        if (result == 1)
        {
            Response.Write("<script>alert('添加成功!')</script>");
            Response.Redirect("Course_add.aspx");
        }
    }
}

