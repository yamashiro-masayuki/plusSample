<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webNotAccess.aspx.vb" Inherits="WebCustomerSample.webNotAccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="ログインを行ってください。"></asp:Label>
            <br />
        </div>
        　　　　　　　　<asp:Button ID="btn_Login" runat="server" Height="51px" Text="ログイン画面へ" />
    </form>
</body>
</html>
