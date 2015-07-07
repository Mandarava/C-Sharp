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

public partial class Student_StudentLogin : System.Web.UI.Page
{
    SQLHelper sqlhelper = new SQLHelper();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Login lgn = new Login();
        if (lgn.StudentLogin(tbx_sn.Text,  tbx_pwd1.Text) != null)
        {
            Session["sn"] = tbx_sn.Text;
            Session["pwd"] = tbx_pwd1.Text;
            Response.Redirect("StudentIndex.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", "<script>alert('学号、用户名或密码错误！') ;</script>");
        }
    }
}
