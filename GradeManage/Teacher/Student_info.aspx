<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student_info.aspx.cs" Theme="Staff"  Inherits="Teacher_Student_info" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
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
          学生管理<br />
          <a href="javascript:window.print(); ">打印 </a>
          <asp:Button ID="Button2" runat="server" OnClick="btn_file_Click" Text="转存到文件" />&nbsp;<br />
          <br />
          <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 90%">
            <tr>
                <td style="height: 20px;" align="left" colspan="3">
                    &nbsp; 
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新建" /></td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" Width="985px" AutoGenerateColumns="False" SkinID="GridView" OnRowDataBound="GridView1_RowDataBound" EnableModelValidation="True">
                        <Columns>
                            <asp:BoundField DataField="sn" HeaderText="学号" />
                            <asp:BoundField DataField="sname" HeaderText="姓名" >
                            </asp:BoundField>
                            <asp:BoundField DataField="major" HeaderText="专业" >
                            </asp:BoundField>
                            <asp:BoundField DataField="dept" HeaderText="学院" />
                        </Columns>
                    </asp:GridView>
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
    </form>
</body>
</html>
