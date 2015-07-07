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

public partial class Teacher_TeacherLogin : System.Web.UI.Page
{
    SQLHelper sqlhelper = new SQLHelper();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (this.tbx_name.Text.IndexOf("'") > 0 || this.tbx_name.Text.IndexOf("-") > 0)
        {
            this.Label_Msg.Text = "用户名中有非法字符";
            return;
        }
        Login lgn = new Login();
        if (lgn.TeacherLogin(tbx_name.Text, tbx_pwd1.Text) != null)
        {
            Session["id"] = tbx_name.Text;
            Session["tpwd"] = tbx_pwd1.Text;
            Response.Redirect("TeacherIndex.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", "<script>alert('用户名或密码错误！') ;</script>");
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        this.tbx_name.Text = "";
        this.tbx_pwd1.Text = "";
    }
}
