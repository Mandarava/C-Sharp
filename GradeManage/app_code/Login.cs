using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Login 的摘要说明
/// </summary>
public class Login
{
    SQLHelper sqlhelper = new SQLHelper();
    public string StudentLogin(string strSn,  string strPwd)
    {
        string strStudentID = null;
        string strSQL = "select sn from Student where sn='" + strSn + "' and pwd='" + strPwd + "'";
        strStudentID = sqlhelper.RunSqlReturn(strSQL);
        if (!Equals(strStudentID, ""))
        {
            return strStudentID;
        }
        else
        {
            return null;
        }
    }
    public string TeacherLogin(string strName, string strPwd)
    {
        string strTeacherID = null;
        string strSQL = "select id from Teacher where id='" + strName + "' and tpwd='" + strPwd + "'";
        strTeacherID = sqlhelper.RunSqlReturn(strSQL);
        if (!Equals(strTeacherID, ""))
        {
            return strTeacherID;
        }
        else
        {
            return null;
        }
    }
    public string AdminLogin(string strName, string strPwd)
    {
        string strAdminID = null;
        string strSQL = "select aname from Admin where aname='" + strName + "' and apwd='" + strPwd + "'";
        strAdminID = sqlhelper.RunSqlReturn(strSQL);
        if (!Equals(strAdminID, ""))
        {
            return strAdminID;
        }
        else
        {
            return null;
        }
    }
}
