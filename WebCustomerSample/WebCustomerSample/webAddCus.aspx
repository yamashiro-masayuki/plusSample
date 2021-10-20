<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webAddCus.aspx.vb" Inherits="WebCustomerSample.webAddCus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="77px" Width="624px">
            <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large; width: 448px;">
                　　　　　　会員情報登録 　</p>
            <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: medium; width: 613px; margin-top: 0px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 　※青文字は必須項目</p>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="264px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lbl_ID" runat="server" Text="ID"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_ID" runat="server" MaxLength="6"></asp:TextBox>
            <br />
            &nbsp;　　&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_Pass" runat="server" Text="Pass"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txt_Pass" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            &nbsp;&nbsp;<asp:Label ID="lbl_PassCheck" runat="server" Text="Pass(確認)"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_PassCheck" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_Name" runat="server" Text="氏名"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_Name" runat="server" MaxLength="10"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_Sex" runat="server" Text="性別"></asp:Label>
            <asp:DropDownList ID="ddl_Sex" runat="server">
                <asp:ListItem>男性</asp:ListItem>
                <asp:ListItem>女性</asp:ListItem>
                <asp:ListItem>その他</asp:ListItem>
            </asp:DropDownList>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_BirthDay" runat="server" Text="生年月日"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_BYear" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
            <asp:Label ID="lbl_BYear" runat="server" Text="年"></asp:Label>
            <asp:TextBox ID="txt_BMonth" runat="server" MaxLength="2" Width="25px"></asp:TextBox>
            <asp:Label ID="lbl_BMonth" runat="server" Text="月"></asp:Label>
            <asp:TextBox ID="txt_BDay" runat="server" MaxLength="2" Width="25px"></asp:TextBox>
            <asp:Label ID="lbl_BDay" runat="server" Text="日"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_PosAddres" runat="server" Text="郵便番号"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_PosAddres" runat="server" MaxLength="8" Width="84px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="lbl_PosAddres0" runat="server" Text="※「000-0000」のように「-」を書いてください"></asp:Label>
            <br />
            　　 　<asp:Label ID="lbl_PosAddres1" runat="server" Text="住所"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_Address1" runat="server" MaxLength="30" Width="376px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Address2" runat="server" MaxLength="30" Width="376px"></asp:TextBox>
            <br />
            　　<asp:Label ID="lbl_ErrorCheck" runat="server" Text="エラーチェック"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <p style="margin-left: 360px">
            &nbsp;<asp:Button ID="btn_Touroku" runat="server" Height="40px" Text="登録" Width="110px" />
        </p>
    </form>
</body>
</html>
