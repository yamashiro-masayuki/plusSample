Public Class webAddCus
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '画面上の文字必須項目の文字色変更
        lbl_ID.ForeColor = System.Drawing.Color.Blue
        lbl_Pass.ForeColor = System.Drawing.Color.Blue
        lbl_PassCheck.ForeColor = System.Drawing.Color.Blue
    End Sub

    Protected Sub btn_Touroku_Click(sender As Object, e As EventArgs) Handles btn_Touroku.Click

    End Sub

End Class