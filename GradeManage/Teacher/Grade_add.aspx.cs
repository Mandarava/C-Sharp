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

public partial class Teacher_Grade : System.Web.UI.Page
{
    SQLHelper sqlhelper = new SQLHelper();
    Common common = new Common();
    private SqlDataReader sqlDataReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            common.BindDropDownList(ref ddl_dept, "select id,dept from Major");
            common.BindDropDownList(ref ddl_major, "select id,major from Major");         
            common.BindDropDownList(ref ddl_course, "select courseid,coursename from Course");
            common.BindDropDownList(ref ddl_student, "select sn,sname from Student where dept='" + this.ddl_dept.SelectedItem.ToString() + "' and major='" + this.ddl_major.SelectedItem.ToString() + "'");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string ConnectionString = "server=.;database=GradeManage;Integrated Security = SSPI";
        SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();
        string courseid = this.ddl_course.SelectedItem.Value;
        string grade = this.TextBox1.Text;
        string sn = null;
        string sname = this.ddl_student.SelectedItem.Text;
        string coursename = this.ddl_course.SelectedItem.Text;
        string tid = Session["id"].ToString();
        string tname=null;

        string sql2 = "select tname from teacher where id = '" + tid + "'";
        SqlCommand cd = new SqlCommand(sql2,conn);
        sqlDataReader = cd.ExecuteReader();
        while (sqlDataReader.Read())
        {
            tname = sqlDataReader["tname"].ToString();
        }
        cd.Dispose();
        sqlDataReader.Close();


        string sql3 = "select sn from Student where sname ='" + sname + "'";
        SqlCommand cd2 = new SqlCommand(sql3, conn);
        sqlDataReader = cd2.ExecuteReader();
        while (sqlDataReader.Read())
        {
            sn = sqlDataReader["sn"].ToString();
        }
        cd2.Dispose();
        sqlDataReader.Close();

        
        string sql =
            "insert into Grade(courseid,grade,tname,sn,sname,coursename,tid) values (@courseid,@grade,@tname,@sn,@sname,@coursename,@tid)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlParameter parn = new SqlParameter("@courseid", courseid);
        cmd.Parameters.Add(parn);
        SqlParameter parp = new SqlParameter("@grade", grade);
        cmd.Parameters.Add(parp);
        SqlParameter pa = new SqlParameter("@tname", tname);
        cmd.Parameters.Add(pa);
        SqlParameter pb = new SqlParameter("@sn", sn);
        cmd.Parameters.Add(pb);
        SqlParameter pc = new SqlParameter("@sname", sname);
        cmd.Parameters.Add(pc);
        SqlParameter pd = new SqlParameter("@coursename", coursename);
        cmd.Parameters.Add(pd);
        SqlParameter pe = new SqlParameter("@tid", tid);
        cmd.Parameters.Add(pe);
        int result = cmd.ExecuteNonQuery();
        conn.Close();
        cmd.Dispose();

    }
}
