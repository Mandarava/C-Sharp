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
    SQLHelper sqlhelper = new SQLHelper();
    Common common = new Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                DataSet dt = new DataSet();
                sqlhelper.RunSQL("SELECT * from Student where id='" + Request.QueryString["id"].ToString() + "'", ref dt);

                this.tbx_sn.Text = dt.Tables[0].Rows[0]["sn"].ToString();
                this.tbx_name.Text = dt.Tables[0].Rows[0]["sname"].ToString();
                this.tbx_pwd1.Text = dt.Tables[0].Rows[0]["pwd"].ToString();
                this.tbx_pwd2.Text = dt.Tables[0].Rows[0]["pwd"].ToString();
                this.tbx_major.Text = dt.Tables[0].Rows[0]["major"].ToString();
                this.tbx_dept.Text = dt.Tables[0].Rows[0]["dept"].ToString();
            }
            else
            {
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", "<script>alert('保存成功');window.close();</script>");
        
        string ConnectionString = "server=.;database=GradeManage;Integrated Security = SSPI";
        SqlConnection conn = new SqlConnection(ConnectionString);

        string sn = tbx_sn.Text;
        string name = tbx_name.Text;
        string pwd2 = tbx_pwd2.Text;
        string major = tbx_major.Text;
        string dept = tbx_dept.Text;


        conn.Open();
        string sql = "insert into Student(sn,sname,pwd,major,dept) values(@sn,@sname,@pwd,@major,@dept)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlParameter parp = new SqlParameter("@sn", sn);
        cmd.Parameters.Add(parp);
        SqlParameter parn = new SqlParameter("@sname", name);
        cmd.Parameters.Add(parn);
        SqlParameter pp = new SqlParameter("@pwd", pwd2);
        cmd.Parameters.Add(pp);
        SqlParameter pa = new SqlParameter("@major", major);
        cmd.Parameters.Add(pa);
        SqlParameter pb = new SqlParameter("@dept", dept);
        cmd.Parameters.Add(pb);
        int result = cmd.ExecuteNonQuery();
        conn.Close();
        cmd.Dispose();

        if (result == 1)
        {
            Response.Write("<script>alert('添加成功!')</script>");
            Response.Redirect("Student_add.aspx");
        }
    
    }
}

