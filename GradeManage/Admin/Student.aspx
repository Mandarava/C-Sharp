<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student.aspx.cs"  Theme="Staff"  Inherits="Admin_Student" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>无标题页</title>
</head>
<body>

    <form id="form2" runat="server">
        <div>
            <div>
                <a href="javascript:window.print(); ">打印 </a>
                <asp:Button ID="Button2" runat="server" OnClick="btn_file_Click" Text="转存到文件" />
                &nbsp;<br />
                <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                    <tr>
                        <td align="center" colspan="3">&nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound" SkinID="GridView">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="序号" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                <asp:BoundField DataField="sn" HeaderText="学号" SortExpression="sn" />
                                <asp:BoundField DataField="sname" HeaderText="姓名" SortExpression="sname" />
                                <asp:BoundField DataField="pwd" HeaderText="密码" SortExpression="pwd" />
                                <asp:BoundField DataField="major" HeaderText="专业" SortExpression="major" />
                                <asp:BoundField DataField="dept" HeaderText="学院" SortExpression="dept" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px"></td>
                        <td style="width: 100px"></td>
                        <td style="width: 100px"></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
