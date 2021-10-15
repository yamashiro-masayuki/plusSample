<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webDelCus.aspx.vb" Inherits="WebCustomerSample.webDelCus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large; width: 364px; height: 37px;">
                    会員情報<asp:Label ID="lbl_DeleteTitle" runat="server" Text="消去"></asp:Label>
                </p>
            </div>
            <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 613px; margin-top: 0px;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ※会員情報が消去されます</p>
            <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 613px; margin-top: 0px">
                <asp:Label ID="lbl_causion" runat="server" Text="注意事項"></asp:Label>
            </p>
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Height="74px" Width="524px">
                <asp:Label ID="lbl_causion1" runat="server" Text="・他者のデータを消去する場合よく確認してください。"></asp:Label>
            <br />
                <asp:Label ID="lbl_causion2" runat="server" Text="・自分のデータを消去する場合ログイン画面に戻されます。"></asp:Label>
            <br />
                <asp:Label ID="lbl_causion3" runat="server" Text="・再ログインの際には新規でデータを作成してください。"></asp:Label>
            <br />
            <br />
            <br />
                <div style="width: 890px">
                    <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 654px; margin-top: 0px;">
                        <asp:Label ID="lbl_ID" runat="server" Text="ID"></asp:Label>
                        <asp:TextBox ID="txt_ID" runat="server" MaxLength="6" Width="100px"></asp:TextBox>
                        　　<asp:Label ID="lbl_Pass" runat="server" Text="パスワード"></asp:Label>
                        <asp:TextBox ID="txt_Pass" runat="server" MaxLength="6"></asp:TextBox>
                        　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_ViewButton" runat="server" Height="40px" Text="表示" Width="110px" />
                        <asp:Button ID="btn_ClearButon" runat="server" Height="40px" Text="クリア" Width="110px" />
                    </p>
                    <asp:Panel ID="pnl_viewPanel" runat="server" BorderStyle="Double" Height="215px" Width="654px">
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbl_ID0" runat="server" Text="ID"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="txt_ID0" runat="server" MaxLength="6"></asp:TextBox>
                    <br />
                        &nbsp;　　&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_Pass0" runat="server" Text="Pass"></asp:Label>
                        &nbsp;&nbsp;<asp:TextBox ID="txt_Pass0" runat="server" MaxLength="10"></asp:TextBox>
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_Name0" runat="server" Text="氏名"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txt_Name0" runat="server" MaxLength="10"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbl_Sex0" runat="server" Text="性別"></asp:Label>
                        <asp:DropDownList ID="ddl_Sex0" runat="server">
                            <asp:ListItem>男性</asp:ListItem>
                            <asp:ListItem>女性</asp:ListItem>
                            <asp:ListItem>その他</asp:ListItem>
                        </asp:DropDownList>
                    <br />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbl_BirthDay0" runat="server" Text="生年月日"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txt_BYear0" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                        <asp:Label ID="lbl_BYear0" runat="server" Text="年"></asp:Label>
                        <asp:TextBox ID="txt_BMonth0" runat="server" MaxLength="2" Width="25px"></asp:TextBox>
                        <asp:Label ID="lbl_BMonth0" runat="server" Text="月"></asp:Label>
                        <asp:TextBox ID="txt_BDay0" runat="server" MaxLength="2" Width="25px"></asp:TextBox>
                        <asp:Label ID="lbl_BDay0" runat="server" Text="日"></asp:Label>
                    <br />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbl_PosAddres2" runat="server" Text="郵便番号"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txt_PosAddres0" runat="server" MaxLength="8" Width="84px"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:Label ID="lbl_PosAddres3" runat="server" Text="※「000-0000」のように「-」を書いてください"></asp:Label>
                    <br />
                        　　 　<asp:Label ID="lbl_PosAddres4" runat="server" Text="住所"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txt_Address3" runat="server" MaxLength="30" Width="376px"></asp:TextBox>
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_Address4" runat="server" MaxLength="30" Width="376px"></asp:TextBox>
                    <br />
                        &nbsp;　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　<br /> 
                    <br />
                    <br />
                    <br />
                        　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　</asp:Panel>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_DeleteButton" runat="server" Height="40px" Text="消去" Width="110px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                </div>
                <p>
                    　　　　　　　　　　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                </p>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
