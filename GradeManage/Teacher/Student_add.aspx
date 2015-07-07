<%@ Page Language="C#" AutoEventWireup="true" Theme="Staff" CodeFile="Student_add.aspx.cs" Inherits="Student_StudentReg" %>

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
                    学生信息增加</td>
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
                                学号：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 24px;">
                    <asp:TextBox ID="tbx_sn" runat="server" Width="139px" ></asp:TextBox></td>
                            <td align="right" width="20%" style="height: 24px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbx_sn"
                        Display="Dynamic" ErrorMessage="学号空"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                    姓名：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:TextBox ID="tbx_name" runat="server" Width="139px"></asp:TextBox></td>
                            <td align="right" style="height: 19px" width="20%">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbx_name"
                        Display="Dynamic" ErrorMessage="姓名空"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                                初始密码：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:TextBox ID="tbx_pwd1" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td align="right" style="height: 19px" width="20%">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbx_pwd1"
                        Display="Dynamic" ErrorMessage="密码空"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                                确认：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:TextBox ID="tbx_pwd2" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td align="right" style="height: 19px" width="20%">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbx_pwd1"
                        ControlToValidate="tbx_pwd2" Display="Dynamic" ErrorMessage="密码不一致"></asp:CompareValidator></td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                    专业：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                    <asp:DropDownList ID="ddl_major" runat="server" DataTextField="zhuanyename" DataValueField="zhuanyename"
                        Width="147px" DataSourceID="SqlDataSource1">
                    </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                            </td>
                            <td align="right" style="height: 19px" width="20%">
                                </td>
                        </tr>
                        <tr class="tr-openwindow-show">
                            <td align="right" style="height: 19px" width="20%">
                                学院：</td>
                            <td align="left" class="td-openwindow-show" style="width: 30%; height: 19px">
                                <asp:DropDownList ID="ddl_dept" runat="server" DataTextField="zhuanyename" DataValueField="zhuanyename"
                        Width="193px">
                </asp:DropDownList></td>
                            <td align="right" style="height: 19px" width="20%">
                                </td>
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
