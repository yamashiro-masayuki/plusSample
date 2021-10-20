<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="webSerchView.aspx.vb" Inherits="WebCustomerSample.webSerchView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <p style="font-family: 'MS UI Gothic', 'ＭＳ Ｐゴシック', sans-serif; font-size: xx-large; width: 477px; height: 37px;">
                    　　　会員情報の検索・一覧表示</p>
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <p>
            検索情報の選択・記述</p>
        <asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" Height="131px" Width="478px">
            <br />
            　&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txt_ID" runat="server" MaxLength="10" Width="90px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="性別"></asp:Label>
            <asp:DropDownList ID="ddl_Sex" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="man">男性</asp:ListItem>
                <asp:ListItem Value="woman">女性</asp:ListItem>
                <asp:ListItem Value="other">その他</asp:ListItem>
            </asp:DropDownList>
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="氏名"></asp:Label>
            <asp:TextBox ID="txt_Name" runat="server" MaxLength="10" Width="92px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="生年月日"></asp:Label>
            <asp:TextBox ID="txt_BDYear" runat="server" MaxLength="4" Width="43px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="年"></asp:Label>
            <asp:TextBox ID="txt_BDMonth0" runat="server" MaxLength="12" Width="21px"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="月"></asp:Label>
            <asp:TextBox ID="txt_BDDay" runat="server" MaxLength="12" Width="21px"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="日"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Clear" runat="server" Height="30px" Text="項目クリア" Width="80px" />
            <br /> &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
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
        　　　　　　　※何も書かれていない項目は検索条件には含まれません。<br />
       　　　　　　　　　　　　　　　　　　　　　　　　　　　<asp:Button ID="btn_View" runat="server" Height="30px" Text="表示" Width="80px" />
        <br />
        <br />
        <asp:Panel ID="pnl_RBtn" runat="server" BorderStyle="Solid" Height="22px" Width="141px">
            <asp:RadioButton ID="RBtn_Up" runat="server" Text="更新" />
            　<asp:RadioButton ID="RBtn_Del" runat="server" Text="消去" />
        </asp:Panel>
        ※ダブルクリックした際左のチェックされているページが表示<br />
        <asp:GridView ID="gv_CusInfo" runat="server" AutoGenerateColumns="False" Width="511px">
            <Columns>
                <asp:BoundField AccessibleHeaderText="ID" FooterText="ID" HeaderText="ID">
                <ItemStyle Width="120px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="氏名">
                <ItemStyle Width="120px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="性別">
                <ItemStyle Width="70px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="生年月日">
                <ItemStyle Width="120px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
