Public Class webNotAccess
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        'ログインページの表示
        Response.Redirect("~/webLogin.aspx")

    End Sub
End Class