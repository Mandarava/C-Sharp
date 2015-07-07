<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grade.aspx.cs"  Theme="Staff" Inherits="Admin_Grade" %>

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
    <form id="form2" runat="server">
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
                                <asp:CommandField ShowEditButton="True" />
                                <asp:BoundField DataField="id" HeaderText="序号" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                <asp:BoundField DataField="courseid" HeaderText="课程号" SortExpression="courseid" />
                                <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
                                <asp:BoundField DataField="tname" HeaderText="教师姓名" SortExpression="tname" />
                                <asp:BoundField DataField="sn" HeaderText="学号" SortExpression="sn" />
                                <asp:BoundField DataField="sname" HeaderText="学生姓名" SortExpression="sname" />
                                <asp:BoundField DataField="coursename" HeaderText="课程名字" SortExpression="coursename" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Grade]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Grade] WHERE [id] = @original_id AND (([courseid] = @original_courseid) OR ([courseid] IS NULL AND @original_courseid IS NULL)) AND (([grade] = @original_grade) OR ([grade] IS NULL AND @original_grade IS NULL)) AND (([tname] = @original_tname) OR ([tname] IS NULL AND @original_tname IS NULL)) AND (([sn] = @original_sn) OR ([sn] IS NULL AND @original_sn IS NULL)) AND (([sname] = @original_sname) OR ([sname] IS NULL AND @original_sname IS NULL)) AND (([coursename] = @original_coursename) OR ([coursename] IS NULL AND @original_coursename IS NULL))" InsertCommand="INSERT INTO [Grade] ([courseid], [grade], [tname], [sn], [sname], [coursename]) VALUES (@courseid, @grade, @tname, @sn, @sname, @coursename)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Grade] SET [courseid] = @courseid, [grade] = @grade, [tname] = @tname, [sn] = @sn, [sname] = @sname, [coursename] = @coursename WHERE [id] = @original_id AND (([courseid] = @original_courseid) OR ([courseid] IS NULL AND @original_courseid IS NULL)) AND (([grade] = @original_grade) OR ([grade] IS NULL AND @original_grade IS NULL)) AND (([tname] = @original_tname) OR ([tname] IS NULL AND @original_tname IS NULL)) AND (([sn] = @original_sn) OR ([sn] IS NULL AND @original_sn IS NULL)) AND (([sname] = @original_sname) OR ([sname] IS NULL AND @original_sname IS NULL)) AND (([coursename] = @original_coursename) OR ([coursename] IS NULL AND @original_coursename IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_courseid" Type="String" />
                                <asp:Parameter Name="original_grade" Type="String" />
                                <asp:Parameter Name="original_tname" Type="String" />
                                <asp:Parameter Name="original_sn" Type="String" />
                                <asp:Parameter Name="original_sname" Type="String" />
                                <asp:Parameter Name="original_coursename" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="courseid" Type="String" />
                                <asp:Parameter Name="grade" Type="String" />
                                <asp:Parameter Name="tname" Type="String" />
                                <asp:Parameter Name="sn" Type="String" />
                                <asp:Parameter Name="sname" Type="String" />
                                <asp:Parameter Name="coursename" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="courseid" Type="String" />
                                <asp:Parameter Name="grade" Type="String" />
                                <asp:Parameter Name="tname" Type="String" />
                                <asp:Parameter Name="sn" Type="String" />
                                <asp:Parameter Name="sname" Type="String" />
                                <asp:Parameter Name="coursename" Type="String" />
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_courseid" Type="String" />
                                <asp:Parameter Name="original_grade" Type="String" />
                                <asp:Parameter Name="original_tname" Type="String" />
                                <asp:Parameter Name="original_sn" Type="String" />
                                <asp:Parameter Name="original_sname" Type="String" />
                                <asp:Parameter Name="original_coursename" Type="String" />
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

