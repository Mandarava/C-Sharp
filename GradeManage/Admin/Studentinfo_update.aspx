<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studentinfo_update.aspx.cs"  Theme="Staff" Inherits="Admin_Grade" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
        <script language="javascript" type="text/javascript">  
        	  function aa(user)
		      {
		  	    parent.window.returnValue=user;
			    window.close();
		      }      
        function DbClickEvent(d)
        {
             window.showModalDialog ('Student_add.aspx?id='+d, '', 'dialogWidth=600px;dialogHeight=320px;status=no;help=no;scrollbars=yes');
	     window.navigate(location) ;         
        }
        
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            学生信息修改<br />
            <a href="javascript:window.print(); ">打印 </a>
            &nbsp;<br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                <tr>
                    <td align="center" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SkinID="GridView"
                            Width="985px" OnRowDataBound="GridView1_RowDataBound" PageSize="30" AllowSorting="True" CellPadding="4" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" DataKeyNames="id" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
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
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Student]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Student] WHERE [id] = @original_id AND (([sn] = @original_sn) OR ([sn] IS NULL AND @original_sn IS NULL)) AND (([sname] = @original_sname) OR ([sname] IS NULL AND @original_sname IS NULL)) AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([major] = @original_major) OR ([major] IS NULL AND @original_major IS NULL)) AND (([dept] = @original_dept) OR ([dept] IS NULL AND @original_dept IS NULL))" InsertCommand="INSERT INTO [Student] ([sn], [sname], [pwd], [major], [dept]) VALUES (@sn, @sname, @pwd, @major, @dept)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Student] SET [sn] = @sn, [sname] = @sname, [pwd] = @pwd, [major] = @major, [dept] = @dept WHERE [id] = @original_id AND (([sn] = @original_sn) OR ([sn] IS NULL AND @original_sn IS NULL)) AND (([sname] = @original_sname) OR ([sname] IS NULL AND @original_sname IS NULL)) AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([major] = @original_major) OR ([major] IS NULL AND @original_major IS NULL)) AND (([dept] = @original_dept) OR ([dept] IS NULL AND @original_dept IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_sn" Type="String" />
                                <asp:Parameter Name="original_sname" Type="String" />
                                <asp:Parameter Name="original_pwd" Type="String" />
                                <asp:Parameter Name="original_major" Type="String" />
                                <asp:Parameter Name="original_dept" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="sn" Type="String" />
                                <asp:Parameter Name="sname" Type="String" />
                                <asp:Parameter Name="pwd" Type="String" />
                                <asp:Parameter Name="major" Type="String" />
                                <asp:Parameter Name="dept" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="sn" Type="String" />
                                <asp:Parameter Name="sname" Type="String" />
                                <asp:Parameter Name="pwd" Type="String" />
                                <asp:Parameter Name="major" Type="String" />
                                <asp:Parameter Name="dept" Type="String" />
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_sn" Type="String" />
                                <asp:Parameter Name="original_sname" Type="String" />
                                <asp:Parameter Name="original_pwd" Type="String" />
                                <asp:Parameter Name="original_major" Type="String" />
                                <asp:Parameter Name="original_dept" Type="String" />
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
