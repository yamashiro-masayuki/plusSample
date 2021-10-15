<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webUpCus.aspx.vb" Inherits="WebCustomerSample.webUpCus" %>

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
                <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large; width: 586px;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 会員情報更新 　</p>
                <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 613px; margin-top: 0px;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ※青文字は必須項目</p>
                <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 613px; margin-top: 0px;">
                    <asp:Label ID="lbl_ID" runat="server" Text="ID"></asp:Label>
                    <asp:TextBox ID="txt_ID" runat="server" MaxLength="6" Width="100px"></asp:TextBox>
                    　　<asp:Label ID="lbl_Pass" runat="server" Text="パスワード"></asp:Label>
                    <asp:TextBox ID="txt_Pass" runat="server" MaxLength="6"></asp:TextBox>
                    　<asp:Button ID="btn_ViewButton" runat="server" Height="40px" Text="表示" Width="110px" />
                </p>
                <asp:Panel ID="Panel1" runat="server" BorderStyle="Double" Height="272px" Width="607px">
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_Name" runat="server" Text="氏名"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txt_Name0" runat="server" MaxLength="10"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_Sex" runat="server" Text="性別"></asp:Label>
                    <asp:DropDownList ID="ddl_Sex0" runat="server">
                        <asp:ListItem>男性</asp:ListItem>
                        <asp:ListItem>女性</asp:ListItem>
                        <asp:ListItem>その他</asp:ListItem>
                    </asp:DropDownList>
                <br />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_BirthDay" runat="server" Text="生年月日"></asp:Label>
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
                    &nbsp;<asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" Height="84px" style="margin-left: 20px; margin-top: 0px" Width="447px">
                        　<asp:CheckBox ID="chb_PassCheck" runat="server" Text="パスワード変更" />
                    <br />
                        &nbsp;　<asp:Label ID="lbl_ChangePass" runat="server" Text="新規パスワード"></asp:Label>
                        　&nbsp;
                        <asp:TextBox ID="txt_ChangePass" runat="server" MaxLength="6"></asp:TextBox>
                    <br />
                        　&nbsp;<asp:Label ID="lbl_changePassCheck" runat="server" Text="パスワード(確認)"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txt_changePassCheck" runat="server" MaxLength="6"></asp:TextBox>
                    </asp:Panel>
                    　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　<br /> 
                <br />
                <br />
                <br />
                    　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　</asp:Panel>
            </div>
            <p>
                　　　　　　　　　　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="btn_ClearButton" runat="server" Height="40px" Text="クリア" Width="110px" />
                <asp:Button ID="btn_UpButton" runat="server" Height="40px" Text="更新" Width="110px" />
            </p>
        </div>
    </form>
</body>
</html>
