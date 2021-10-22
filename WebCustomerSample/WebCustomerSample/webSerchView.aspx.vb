Public Class webSerchView
    Inherits System.Web.UI.Page

    Dim common As commonCusData
    Dim serchViewClass As serchViewClass
    Dim dataError As Integer

    'ページの項目を全て初期状態にする。
    Sub Clear()

        txt_ID.Text = ""
        txt_Name.Text = ""
        ddl_Sex.SelectedIndex = 0
        txt_BDYear.Text = ""
        txt_BDMonth.Text = ""
        txt_BDDay.Text = ""
        txt_ID.Focus()

    End Sub

    '全データを取得して最初から表示する。
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'ポストバックしてない場合初期化
        If Not Page.IsPostBack Then
            Clear()
        End If

        'クラスの宣言
        common = New commonCusData()
        serchViewClass = New serchViewClass()

        '共通変数にログイン時の名前がなかったらエラーページに移行する。
        If common.LoginName = "" And common.CheckLogin Then
            'エラーページの表示
            Response.Redirect("~/webNotAccess.aspx")
        End If

        'エラーは赤文字に変更し初期は表示なし
        lbl_ErrorCheck.ForeColor = System.Drawing.Color.Red
        lbl_ErrorCheck.Visible = False
        'GridViewを表示する。
        gv_CusInfo.DataBind()
        '最初は更新を行うページを表示するラジオボタンにする。
        RBtn_Up.Checked = True

    End Sub

    '項目内のデータを初期化する。
    Protected Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        Clear()

    End Sub

    'データの表示を行う。
    Protected Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click

        '登録のためのテーブル作り
        Dim data As New DataTable
        data = serchViewClass.viewDataTable(data)

        'データの取得
        DataError = serchViewClass.GetData(common, data, txt_ID.Text, txt_Name.Text, txt_BDYear.Text, txt_BDMonth.Text, txt_BDDay.Text, ddl_Sex.Text)

        If Not common.checkData Then

            If DataError = 1 Then
                'データ件数が0件
                common.focusError(txt_ID, lbl_ErrorCheck, 20)
                Return
            ElseIf DataError = 2 Then
                'SQLエラー
                common.focusError(txt_ID, lbl_ErrorCheck, 21)
                Return
            End If

        End If


        'グリッドビューに表示
        gv_CusInfo.DataSource = data
        gv_CusInfo.DataBind()
        'gv_CusInfo.Rows(0)("ID") = data.Rows(0)("ID").ToString()






    End Sub

End Class