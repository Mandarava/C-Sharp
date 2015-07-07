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
    private static string strUser = "";
    SQLHelper sqlhelper = new SQLHelper();
    Common common = new Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            common.BindDropDownList(ref ddl_major, "select id,major from Major");
            common.BindDropDownList(ref ddl_dept, "select id,dept from Major");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (this.tbx_sn.Text != "" & this.tbx_name.Text != "")
        {
            strUser = sqlhelper.RunSqlReturn("select sn from Student where sn='" + this.tbx_sn.Text + "' and sname='" + this.tbx_name.Text + "'and pwd='" + this.tbx_pwd1.Text + "'");// 执行SQL语句，并返回第一行第一列结果,即学号
            if (strUser.Equals(this.tbx_sn.Text))
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", "<script>alert('该学生的信息已经有了！') ;</script>");
            }
            else
            {
                SqlParameter[] prams ={
                sqlhelper.CreateInParam("@sn",SqlDbType.NVarChar,50,this.tbx_sn.Text),
                sqlhelper.CreateInParam("@sname",SqlDbType.NVarChar,50,this.tbx_name.Text),
                sqlhelper.CreateInParam("@pwd",SqlDbType.NVarChar,50,this.tbx_pwd1.Text),
                sqlhelper.CreateInParam("@major",SqlDbType.NVarChar,50,this.ddl_major.SelectedItem.Text),
                sqlhelper.CreateInParam("@dept",SqlDbType.NVarChar,50,this.ddl_dept.SelectedItem.Text),
         };
                sqlhelper.RunProc("StudentInsert", prams);
                Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", "<script>alert('保存成功');window.close();</script>");
            }
        }
    }
}

