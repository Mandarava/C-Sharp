using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Common 的摘要说明
/// </summary>
public class Common
{
    public void BindDropDownList(DropDownList ddl, SqlParameter[] prams, string cmd)
    {
        SQLHelper sqlhelper = new SQLHelper();
        DataSet dt = new DataSet();
        sqlhelper.RunSQL(cmd, prams, ref dt);
        ddl.Items.Clear();
        if (dt.Tables[0].Rows.Count > 0)
        {
            ddl.DataSource = dt.Tables[0];
            ddl.DataTextField = dt.Tables[0].Columns[1].ToString();
            ddl.DataValueField = dt.Tables[0].Columns[0].ToString();
            ddl.DataBind();
        }
    }



    public void BindDropDownList(ref DropDownList ddl, string cmd)
    {
        SQLHelper sqlhelper = new SQLHelper();
        DataSet dt = new DataSet();
        sqlhelper.RunSQL(cmd, ref dt);
        ddl.Items.Clear();
        if (dt.Tables[0].Rows.Count > 0)
        {
            ListItem li = new ListItem();
            foreach (DataRow dr in dt.Tables[0].Rows)
            {
                li = new ListItem(dr[1].ToString(), dr[0].ToString());
                ddl.Items.Add(li);
            }
        }
    }



    /// <summary>
    /// 鼠标移动到每项时颜色交替效果
    /// </summary>
    /// <param name="e"></param>
    public void MoustBackColor(GridViewRowEventArgs e)
    {
        //鼠标移动到每项时颜色交替效果
        e.Row.Attributes.Add("OnMouseOut",
"this.style.backgroundColor='White';this.style.color='#003399'");
        e.Row.Attributes.Add("OnMouseOver",
"this.style.backgroundColor='#ccffcc';this.style.color='#8C4510'");
    }
}
  

