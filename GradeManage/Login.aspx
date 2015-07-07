<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >

<title>
    上海应用技术学院教学管理信息系统
</title>
<head>
  
    <style type="text/css">
        td {
            font-size: 10pt;
        }
    </style>
</head>

<body style="margin:0;">
<br>

<form id="form1" runat="server">
    <div style="text-align: center">
        <br />
    <table width="500" border="0" cellpadding=0 cellspacing=0 align=center>
        <tr>
            <td colspan=2>
                <img src="images/njue3.gif" alt="">
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/head2.jpg" alt="" style="align:center"><br/>
                <a href="http://tao.sit.edu.cn/">>>访问教务处主页</a>
            </td>
            <td align="center" width="400">
                <table border=0  cellspacing=0 align=center cellpadding="2" style="width: 86%">
                    <tr>
                        <td colspan="2" style="font-weight:700;text-align:center;font-size:11pt;">上海应用技术学院教学管理信息系统<br><br></td>
                    </tr>
                    <tr>
                        <td >学生：</td>
                        <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="学生登录" Width="80px" />
                        </td>
                       
                    </tr>
                    <tr>
                        <td>老师：</td>
                        <td><asp:Button ID="Button2" runat="server" Height="21px" OnClick="Button2_Click" Text="老师登录" Width="77px" />
                        </td>
                    </tr>
					 <tr>
                        <td >管理员：</td>
                        <td><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="管理员登录" Width="79px" />
                         </td>
                    </tr>
                     <td style="text-align: left">

                         &nbsp;</table>
            </td>
        </tr>
        <tr>
            <td colspan=2>
                <img src="images/njue2.gif" alt="">
            </td>
        </tr>
    </table>
   </div>
</form>

</body>
</html>

