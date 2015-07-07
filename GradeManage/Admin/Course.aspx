<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Course.aspx.cs" Theme="Staff" Inherits="Admin_Course" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <a href="javascript:window.print(); ">打印 </a>
                <asp:Button ID="Button2" runat="server" OnClick="btn_file_Click" Text="转存到文件" />&nbsp;<br />
                <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                    <tr>
                        <td align="center" colspan="3">
                            &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SkinID="GridView" OnRowDataBound="GridView1_RowDataBound" AllowSorting="True" CellPadding="4" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    <asp:BoundField DataField="coursename" HeaderText="课程名称" SortExpression="coursename" />
                                    <asp:BoundField DataField="tname" HeaderText="教师名字" SortExpression="tname" />
                                    <asp:BoundField DataField="courseid" HeaderText="课程号" SortExpression="courseid" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Course]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Course] WHERE [id] = @original_id AND (([coursename] = @original_coursename) OR ([coursename] IS NULL AND @original_coursename IS NULL)) AND (([tname] = @original_tname) OR ([tname] IS NULL AND @original_tname IS NULL)) AND (([courseid] = @original_courseid) OR ([courseid] IS NULL AND @original_courseid IS NULL))" InsertCommand="INSERT INTO [Course] ([coursename], [tname], [courseid]) VALUES (@coursename, @tname, @courseid)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Course] SET [coursename] = @coursename, [tname] = @tname, [courseid] = @courseid WHERE [id] = @original_id AND (([coursename] = @original_coursename) OR ([coursename] IS NULL AND @original_coursename IS NULL)) AND (([tname] = @original_tname) OR ([tname] IS NULL AND @original_tname IS NULL)) AND (([courseid] = @original_courseid) OR ([courseid] IS NULL AND @original_courseid IS NULL))">
                                <DeleteParameters>
                                    <asp:Parameter Name="original_id" Type="Int32" />
                                    <asp:Parameter Name="original_coursename" Type="String" />
                                    <asp:Parameter Name="original_tname" Type="String" />
                                    <asp:Parameter Name="original_courseid" Type="String" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="coursename" Type="String" />
                                    <asp:Parameter Name="tname" Type="String" />
                                    <asp:Parameter Name="courseid" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="coursename" Type="String" />
                                    <asp:Parameter Name="tname" Type="String" />
                                    <asp:Parameter Name="courseid" Type="String" />
                                    <asp:Parameter Name="original_id" Type="Int32" />
                                    <asp:Parameter Name="original_coursename" Type="String" />
                                    <asp:Parameter Name="original_tname" Type="String" />
                                    <asp:Parameter Name="original_courseid" Type="String" />
                                </UpdateParameters>
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
