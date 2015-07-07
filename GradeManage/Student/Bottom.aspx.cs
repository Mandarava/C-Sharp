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
//该源码下载自www.51aspx.com(５１ａsｐｘ．ｃｏｍ)

public partial class Bottom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblStudentName.Text = Session["sname"].ToString();
        }
        catch
        {
        }
    }
}
