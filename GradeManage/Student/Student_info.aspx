<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student_info.aspx.cs" Inherits="Student_Student_info" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body style="background-image: url(../images/BKGRD9.jpg); background-repeat: repeat">
    <form id="form1" runat="server">
    <div style="text-align: center">
        &nbsp; &nbsp; &nbsp;<strong><span style="font-size: 14pt"> &nbsp;学生本人信息查看</span></strong><br />
        <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1mm; margin-top: 20px;
            border-left-width: 1mm; border-left-color: #66ccff; border-bottom-width: 1mm;
            border-bottom-color: #66ccff; margin-left: 300px; width: 579px; border-top-color: #66ccff;
            margin-right: 200px; border-right-width: 1mm; border-right-color: #66ccff">
            <tr>
                <td align="center" style="width: 87px; height: 24px; text-align: right">
                    <span style="font-size: 14pt"><strong>学号：</strong></span></td>
                <td style="width: 155px; height: 24px; text-align: left">
                    <asp:Label ID="lbl_sn" runat="server" Font-Bold="True" Font-Size="14pt" Width="320px"></asp:Label></td>
            </tr>
            <tr style="font-weight: bold; font-size: 14pt; color: #000000">
                <td align="center" style="width: 87px; height: 26px; text-align: right">
                    <span>姓名：</span></td>
                <td style="width: 155px; height: 26px; text-align: left">
                    <asp:Label ID="lbl_name" runat="server" Width="334px"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" style="width: 87px; height: 19px; text-align: right">
                    <strong><span style="font-size: 14pt"> 专业：</span></strong></td>
                <td style="width: 155px; height: 19px; text-align: left">
                    <asp:Label ID="lbl_major" runat="server" Font-Bold="True" Font-Size="14pt" Width="465px"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" style="width: 87px; height: 22px; text-align: right">
                    <span style="font-size: 14pt"><strong>学院：</strong></span></td>
                <td style="width: 155px; height: 22px; text-align: left">
                    <asp:Label ID="lbl_dept" runat="server" Font-Bold="True" Font-Size="14pt" Width="426px"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
