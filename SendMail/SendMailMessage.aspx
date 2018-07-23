<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendMailMessage.aspx.cs" Inherits="SendMailMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #main{width:500px;margin:0 auto;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <table>
                <tr><td>要发送的邮箱：</td><td><asp:TextBox ID="txtmailTo" runat="server"></asp:TextBox></td><td>(格式：abc123@qq.com)</td></tr>
                <tr><td>主题：</td><td><asp:TextBox ID="txtmailSubject" runat="server"></asp:TextBox></td></tr>
                <tr><td>内容:</td><td><asp:TextBox ID="txtmailContent" Height="100" TextMode="MultiLine"  runat="server"></asp:TextBox></td></tr>    
        </table>
            <asp:Button ID="Button1" runat="server" Text="发送" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
