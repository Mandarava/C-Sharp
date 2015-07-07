<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grade.aspx.cs" Theme="Staff" Inherits="Teacher_Grade" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            成绩管理<br />
            <a href="javascript:window.print(); ">打印 </a>
            <asp:Button ID="Button2" runat="server" OnClick="btn_file_Click" Text="转存到文件" />&nbsp;<br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                <tr>
                    <td align="left" colspan="3" style="height: 8px">
                        &nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" /></td>
                </tr>
                <tr>
                    <td align="center" colspan="3">
                        &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SkinID="GridView" OnRowDataBound="GridView1_RowDataBound" EnableModelValidation="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" DataKeyNames="id" DataSourceID="SqlDataSource1">
                            <Columns>
<asp:BoundField DataField="courseid" HeaderText="课程号" SortExpression="courseid"></asp:BoundField>
                                <asp:BoundField DataField="coursename" HeaderText="课程名字" SortExpression="coursename" />
                                <asp:BoundField DataField="sn" HeaderText="学号" SortExpression="sn" />
<asp:BoundField DataField="sname" HeaderText="姓名" SortExpression="sname"></asp:BoundField>
                                <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Grade] WHERE ([tid] = @tid)">
                            <SelectParameters>
                                <asp:SessionParameter Name="tid" SessionField="id" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 100px">
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
