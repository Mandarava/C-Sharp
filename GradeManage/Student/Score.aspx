<%@ Page Language="C#" AutoEventWireup="true" Theme="Staff" CodeFile="Score.aspx.cs" Inherits="Student_Score" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SkinID="GridView" DataSourceID="SqlDataSource1" EnableModelValidation="True" AllowSorting="True" CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="courseid" HeaderText="课程号" SortExpression="courseid" />
                <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
                <asp:BoundField DataField="tname" HeaderText="教师名字" SortExpression="tname" />
                <asp:BoundField DataField="coursename" HeaderText="课程名字" SortExpression="coursename" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Grade] WHERE ([sn] = @sn)">
            <SelectParameters>
                <asp:SessionParameter Name="sn" SessionField="sn" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
