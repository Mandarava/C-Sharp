<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grade_add.aspx.cs" Inherits="Teacher_Grade" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
     <base target="_self"></base>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table>
            <tr>
                <td colspan="2" style="text-align: center">
                    学生成绩录入</td>
            </tr>
            <tr>
                <td style="width: 156px">
                    选择学生的系别：</td>
                <td style="width: 264px">
                    <asp:DropDownList ID="ddl_dept" runat="server" Width="160px">
                        <asp:ListItem>-请选择-</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 156px">
                    选择学生的专业：</td>
                <td style="width: 264px">
                    <asp:DropDownList ID="ddl_major" runat="server" Width="160px">
                        <asp:ListItem>-请选择-</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 156px">
                    选择教授课程：</td>
                <td style="width: 264px">
                    <asp:DropDownList ID="ddl_course" runat="server" Width="160px">
                        <asp:ListItem>-请选择-</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 156px">
                    选择上课学生：</td>
                <td style="width: 264px">
                    <asp:DropDownList ID="ddl_student" runat="server" Width="160px" DataSourceID="SqlDataSource1" DataTextField="sname" DataValueField="sname">
                        <asp:ListItem>-请选择-</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT [sname] FROM [Student]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 19px; text-align: center">
                    填写成绩</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
