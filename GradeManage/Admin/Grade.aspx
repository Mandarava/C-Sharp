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
             window.showModalDialog ('Grade_update.aspx?id='+d, '', 'dialogWidth=600px;dialogHeight=320px;status=no;help=no;scrollbars=yes');
	     window.navigate(location) ;         
        }
        
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            学生成绩管理<br />
            <a href="javascript:window.print(); ">打印 </a>
            <asp:Button ID="Button2" runat="server" OnClick="btn_file_Click" Text="转存到文件" />&nbsp;<br />
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
                <tr>
                    <td align="center" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SkinID="GridView"
                            Width="985px" OnRowDataBound="GridView1_RowDataBound" PageSize="30" AllowSorting="True" CellPadding="4" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="courseid" HeaderText="课程号" SortExpression="courseid" />
                                <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
                                <asp:BoundField DataField="tname" HeaderText="教师名字" SortExpression="tname" />
                                <asp:BoundField DataField="sn" HeaderText="学号" SortExpression="sn" />
                                <asp:BoundField DataField="sname" HeaderText="学生名字" SortExpression="sname" />
                                <asp:BoundField DataField="coursename" HeaderText="课程名字" SortExpression="coursename" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GradeManageConnectionString %>" SelectCommand="SELECT * FROM [Grade] ORDER BY [id]"></asp:SqlDataSource>
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
