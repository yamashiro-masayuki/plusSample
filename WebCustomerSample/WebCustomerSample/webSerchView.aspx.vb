Public Class webSerchView
    Inherits System.Web.UI.Page

    'ページの項目を全て初期状態にする。
    Sub Clear()

        txt_ID.Text = ""
        txt_Name.Text = ""
        ddl_Sex.SelectedIndex = 0
        txt_BDYear.Text = ""
        'txt_BDMonth.Text = ""
        txt_BDDay.Text = ""
        txt_ID.Focus()


    End Sub

    '全データを取得して最初から表示する。
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'GridViewを表示する。
        gv_CusInfo.DataBind()
        '最初は更新を行うページを表示するラジオボタンにする。
        RBtn_Up.Checked = True

    End Sub

    '項目内のデータを初期化する。
    Protected Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        Clear()

    End Sub

    Protected Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click

    End Sub
End Class