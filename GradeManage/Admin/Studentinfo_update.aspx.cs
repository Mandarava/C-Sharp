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

public partial class Admin_Grade : System.Web.UI.Page
{
    SQLHelper sql = new SQLHelper();
    DataSet dt = new DataSet();
    Common common = new Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        //sql.RunSQL("select * from Student", ref dt);
        //GridView1.DataSource = dt.Tables[0];
        //GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            common.MoustBackColor(e);
            if (Request.QueryString["id"] != null)
            {
                //单击 事件
                e.Row.Attributes.Add("OnClick", "aa('" +
       e.Row.Cells[0].Text + "&" + e.Row.Cells[1].Text + "')");
            }
            else
            {
                //双击 事件
                e.Row.Attributes.Add("OnDblClick", "DbClickEvent('" +
       e.Row.Cells[0].Text + "')");
                //设置悬浮鼠标指针形状为"小手"
                e.Row.Attributes["style"] = "Cursor:hand";
            }

        }
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
