<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainIndex.aspx.cs" Inherits="MainIndex" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>物流管理系统</title>
      <script language=Javascript>   
          window.moveTo(0,0);   
          window.resizeTo(screen.width,screen.height-25);   
  </script>
</head>
	<frameset rows="87,*,26" cols="*" framespacing="0" border="0" frameborder="no">
		<frame src="top.aspx" name="topFrame" scrolling="no" noresize>
		<frameset id="attachucp" rows="*" cols="129,10,*" framespacing="0" frameborder="no" border="0">
			<frame src="Left.aspx" name="LeftMenu" scrolling="auto">
			<frame id="leftbar" scrolling="no" noresize="" name="switchFrame" src="Switch.aspx">
</frame>
			<frame src="main.htm" name="mainFrame" scrolling="auto" >
		</frameset>
		<frame src="Bottom.aspx" name="bottomFrame" scrolling="no" noresize>
	</frameset>
</html>