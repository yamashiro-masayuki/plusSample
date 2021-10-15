Public Class webUpCus
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '画面上の文字必須項目の文字色変更
        lbl_Name.ForeColor = System.Drawing.Color.Blue
        lbl_Sex.ForeColor = System.Drawing.Color.Blue
        lbl_BirthDay.ForeColor = System.Drawing.Color.Blue
    End Sub

End Class