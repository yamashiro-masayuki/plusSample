<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webLogin.aspx.vb" Inherits="WebCustomerSample.webLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large;">
                &nbsp;
                会員情報確認　編集プログラム&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            </p>
            <p>
                &nbsp;</p>
            <p class="auto-style1">
                ID&nbsp;&nbsp;&nbsp;&nbsp; :
                <asp:TextBox ID="txt_ID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </p>
            <p style="margin-left: 80px">
                Pass&nbsp; :
                <asp:TextBox ID="txt_Pass" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Label ID="lbl_checkError" runat="server" Text="エラーメッセージ"></asp:Label>
            </p>
            <p style="font-weight: 700; margin-left: 240px">
                <asp:Button ID="btn_Login" runat="server" Text="ログイン" />
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_AddCus" runat="server" Text="会員でない方はこちら" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        </div>
    </form>
</body>
</html>
