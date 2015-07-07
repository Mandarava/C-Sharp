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

public partial class Teacher_Student_info : System.Web.UI.Page
{
    SQLHelper sql = new SQLHelper();
    DataSet dt = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        sql.RunSQL("select * from Student", ref dt);
        GridView1.DataSource = dt.Tables[0];
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "MyScript", Jscript.GetModalString("Student_add.aspx", 600, 320));
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[1].Attributes.Add("style", "vnd.ms-Excel.numberformat:@;");
        }
    }
    protected void btn_file_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = false;
        Response.Charset = "GB2312";
        Response.AppendHeader("Content-Disposition", "attachment;filename=pkmv_de.xls");
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
        Response.ContentType = "application/ms-excel";
        Response.Write("<meta http-equiv=Content-Type content=\"text/html; charset=GB2312\">");
        this.EnableViewState = false;
        System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
        HtmlTextWriter oHtmlTextWriter = new HtmlTextWriter(oStringWriter);
        GridView1.RenderControl(oHtmlTextWriter);
        Response.Write(oStringWriter.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    { }

}
