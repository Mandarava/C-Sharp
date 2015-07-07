<%@ Page Language="C#"AutoEventWireup="true" CodeFile="StudentIndex.aspx.cs" Inherits="Student_StudentIndex" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>欢迎光临学生子系统</title>
</head>
	<frameset rows="87,*,26" cols="*" framespacing="0" border="0" frameborder="no">
		<frame src="../top.aspx" name="topFrame" scrolling="no" noresize>
		<frameset id="attachucp" rows="*" cols="129,*" framespacing="0" frameborder="no" border="0">
			<frame src="StudentLeft.aspx" name="LeftMenu" scrolling="auto">
			<frame src="index.htm" name="mainFrame" scrolling="auto" >
		</frameset>
		<frame src="Bottom.aspx" name="bottomFrame" scrolling="no" noresize>
	</frameset>
</html>



