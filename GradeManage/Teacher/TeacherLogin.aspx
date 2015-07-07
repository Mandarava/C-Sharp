<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeacherLogin.aspx.cs" Inherits="Teacher_TeacherLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body background="../images/BKGRD9.jpg">
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <div style="text-align: center">
                   <br />
        <br />
        &nbsp;<span style="font-size: 36pt"><strong>教师登录</strong></span><br />
        <br />
                <table style="width: 25%;margin:0 auto">
                    <tr style="font-weight: bold; font-size: 14pt; color: #000000">
                        <td style="width: 98px; height: 26px; text-align: right">
                            工<span>号：</span></td>
                        <td style="font-size: 12pt; width: 148px; height: 26px; text-align: left">
                            <asp:TextBox ID="tbx_name" runat="server" Width="149px"></asp:TextBox></td>
                        <td style="font-size: 12pt; width: 81px; height: 26px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbx_name"
                                Display="Dynamic" ErrorMessage="工号空"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr style="font-size: 14pt; color: #000000">
                        <td style="width: 98px; height: 19px; text-align: right">
                            <span><strong>密码：</strong></span></td>
                        <td style="font-size: 12pt; width: 148px; height: 19px; text-align: left">
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
                                OnClick="ImageButton1_Click" Width="65px" />
                            &nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/bbblog_05_10.gif" OnClick="ImageButton2_Click" /><span
                                style="font-size: 14pt"> </span>
                        </td>
                    </tr>
                </table>
                <br />
            </div>
            <asp:Label ID="Label_Msg" runat="server"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
