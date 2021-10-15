Public Class webMain
    Inherits System.Web.UI.Page
    Dim fullName As String


    Sub New()
        fullName = "デバックモード"
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_LoginName.Text = $"{fullName}さんようこそ"
    End Sub

    Protected Sub btn_AddCus_Click(sender As Object, e As EventArgs) Handles btn_AddCus.Click

        '顧客情報登録ページの表示
        Response.Redirect("~/webAddCus.aspx")

    End Sub

    Protected Sub btn_SerchCus_Click(sender As Object, e As EventArgs) Handles btn_SerchCus.Click

        '顧客情報検索・一覧表示ページの表示
        Response.Redirect("~/webSerchView.aspx")

    End Sub

End Class