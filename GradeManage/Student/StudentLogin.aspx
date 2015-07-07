<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentLogin.aspx.cs" Inherits="Student_StudentLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .auto-style1 {
            width: 98px;
            height: 26px;
        }
        .auto-style2 {
            width: 148px;
            height: 26px;
        }
        .auto-style3 {
            width: 81px;
            height: 26px;
        }
    </style>
</head>
<body  font-family: 宋体; text-align: center" background="../images/BKGRD9.jpg">
    <form id="form1" runat="server">
    <div style="text-align: center">
        <br />
        <br />
        &nbsp;<span style="font-size: 36pt"><strong>学生登录</strong></span><br />
        <br />
        <table style="width: 25%;margin:0 auto">
            <tr>
                <td style="text-align: right;" class="auto-style1">
                    <strong><span style="font-size: 14pt">学号：</span></strong></td>
                <td class="auto-style2">
                    <asp:TextBox ID="tbx_sn" runat="server" Width="149px"></asp:TextBox></td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbx_sn"
                        Display="Dynamic" ErrorMessage="学号空"></asp:RequiredFieldValidator></td>
            </tr>
            <tr style="color: #000000">
                <td style="width: 98px; height: 19px; text-align: right;">
                    <strong><span style="font-size: 14pt">
                    密码：</span></strong></td>
                <td style="width: 148px; height: 19px">
                    <asp:TextBox ID="tbx_pwd1" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
                <td style="width: 81px; height: 19px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbx_pwd1"
                        Display="Dynamic" ErrorMessage="密码空"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 13px" valign="middle">
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/images/Login.jpg"
                         Width="57px" OnClick="ImageButton1_Click" />
                    &nbsp;&nbsp;&nbsp;<span style="font-size: 14pt"></span></td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="Label_Msg" runat="server"></asp:Label>
    </form>
</body>
</html>
