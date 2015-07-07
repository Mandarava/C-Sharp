<%@ Page Language="C#" AutoEventWireup="true" Theme="Staff" CodeFile="Course_add.aspx.cs" Inherits="Student_StudentReg" %>

<%@ Register Assembly="Coolite.Ext.Web" Namespace="Coolite.Ext.Web" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <base target="_self"></base>
</head>
<body style="background-image: url(../images/BKGRD9.jpg)">
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="2" cellspacing="0" height="42" width="90%">
            <tr>
                <td align="right" width="39">
                    <img height="24" src="Images/ima_title.gif" width="30" /></td>
                <td align="left" class="font-tit14" height="20">
                    课程增加</td>
                <td align="right">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="保存" />
                    &nbsp;</td>
            </tr>
        </table>
        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
            <tr>
                <td style="width: 7px; height: 20px">
                    <img height="20" src="Images/showinfo_top_left.gif" width="7" /></td>
                <td background="Images/showinfo_top_bg.gif" style="height: 20px" width="786">
                </td>
                <td style="width: 7px; height: 20px">
                    <img height="20" src="Images/showinfo_top_right.gif" width="7" /></td>
            </tr>
            <tr>
                <td background="Images/showinfo_ima_left.gif" style="width: 7px">
                </td>
                <td align="center" class="tr-openwindow-bgcolor">
                    <table border="0" cellpadding="0" cellspacing="1" class="table-out-whiteforshow">
                        <tr class="tr-openwindow-show">
                            <td align="right" width="20%" style="height: 24px">
                                课程号：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 24px;">
                    <asp:TextBox ID="tbx_courseid" runat="server" Width="139px" ></asp:TextBox></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                                课程名：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:TextBox ID="tbx_coursename" runat="server" Width="139px"></asp:TextBox></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                                执教老师：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:TextBox ID="tbx_tname" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
                <td background="Images/showinfo_ima_right.gif" style="width: 7px">
                </td>
            </tr>
            <tr>
                <td style="width: 7px; height: 20px;">
                    <img height="20" src="Images/showinfo_bott_left.gif" width="7" /></td>
                <td background="Images/showinfo_bott_bg.gif" style="height: 20px">
                </td>
                <td style="width: 7px; height: 20px;">
                    <img height="20" src="Images/showinfo_bott_right.gif" width="7" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
