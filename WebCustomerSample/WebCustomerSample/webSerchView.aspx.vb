Public Class webSerchView
    Inherits System.Web.UI.Page

    '全データを取得して最初から表示する。
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'GridViewを表示する。
        gv_CusInfo.DataBind()

    End Sub

End Class