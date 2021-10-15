<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webMain.aspx.vb" Inherits="WebCustomerSample.webMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lbl_LoginName" runat="server" Text="LoginName"></asp:Label>
        </p>
        <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large;">
            会員情報編集画面へようこそ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large; height: 11px;">
            &nbsp;</p>
        <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large">
            　<asp:Button ID="btn_AddCus" runat="server" Height="61px" Text="会員情報登録" Width="153px" />
            　<asp:Button ID="btn_SerchCus" runat="server" Height="61px" Text="検索一覧表示" Width="153px" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
