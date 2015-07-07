<html>
<head>
<title>Untitled Document</title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<style>
a{color:black;font-size:10pt;background:#ececec;text-decoration:none;padding:2px;text-align:center}
a:hover{color:red;text-decoration:underline}
</style>
<script language="JavaScript" src="AppSetting.js"></script>
<script language="javascript">
   function doSearch(str){

   if (parseInt(navigator.appVersion)<4) return;
   if (navigator.appName=="Netscape"||navigator.appName=="Mozilia"||navigator.appName=="Firefox") {
    strFound=self.find();
   }
 if (navigator.appName.indexOf("Microsoft")!=-1) {

  // EXPLORER-SPECIFIC CODE
   top.frames["mainFrame"].showModelessDialog(sAppRoot+"/admin/search.htm",window.top.frames["mainFrame"],"status:0;center:true;dialogWidth:300px;dialogHeight:100px")
 }

}

function doEdit(obj){
alert("您现在可以更改主页面的内容，注意所做修改不会永久保存，点浏览取消编辑模式")
top.frames["mainFrame"].document.body.contentEditable=true;
}

function doUnEdit(obj){
top.frames["mainFrame"].document.body.contentEditable=false;
}
</script>

</head>

<body style="margin:0px" >
<table  border="0" cellspacing="0" cellpadding="0" style="border-bottom:1px solid #ececec">
<tr>
<td  align="left">
    <img src="images/students.jpg">
</td>
<td align="right" valign1="bottom">
<table   border="0" cellpadding="0" cellspacing="1">
<tr ><td>
<a href="main.jsp"  target="mainFrame" >主页</a>
<a href="#" onclick="javascript:doSearch('搜索')"  >搜索</a>
<a href="Login.aspx" target="_top" >退出</a>
</td></tr>
</table>
</td>
</tr></table>

</body>
</html>
