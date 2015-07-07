<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Admin_AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body style="margin:0;" background="../images/BKGRD9.jpg">
    <form id="form1" runat="server">
    <div style="text-align: center">
        <div style="text-align: center">
   <br />
        <br />
        &nbsp;<span style="font-size: 36pt"><strong>管理员登录</strong></span><br />
        <br />
            <table style="width: 25%;margin:0 auto" >
                    <td style="width: 98px; height: 26px; text-align: right">
                        <span>姓名：</span></td>
                    <td style="width: 148px; height: 26px; font-size: 12pt; text-align: left;">
                        <asp:TextBox ID="tbx_name" runat="server" Width="149px"></asp:TextBox></td>
                    <td style="width: 81px; height: 26px; font-size: 12pt;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbx_name"
                            Display="Dynamic" ErrorMessage="姓名空"></asp:RequiredFieldValidator></td>
                </tr>
                <tr style="font-size: 14pt; color: #000000">
                    <td style="width: 98px; height: 19px; text-align: right">
                        <span><strong>密码：</strong></span></td>
                    <td style="font-size: 12pt; width: 148px; height: 19px; text-align: left;">
                        <asp:TextBox ID="tbx_pwd1" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
                    <td style="font-size: 12pt; width: 81px; height: 19px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbx_pwd1"
                            Display="Dynamic" ErrorMessage="密码空"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td align="center" colspan="3" style="height: 9px" valign="middle">
                        <br />
                        <br />
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="18px" ImageUrl="~/images/Login.gif"
                            Width="65px" OnClick="ImageButton1_Click" />
                        &nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/bbblog_05_10.gif" OnClick="ImageButton2_Click" /><span
                            style="font-size: 14pt"> </span>
                    </td>
                </tr>
            </table>
            <br />
        </div>
        <asp:Label ID="Label_Msg" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
