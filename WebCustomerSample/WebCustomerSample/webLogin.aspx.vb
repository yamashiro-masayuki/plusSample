Public Class webLogin
    Inherits System.Web.UI.Page


    'クラス宣言
    Dim loginClass As LoginClass
    Dim common As commonCusData

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'クラスの宣言
        loginClass = New LoginClass()
        common = New commonCusData()
        'デバックモードではないのでTrueに変更
        common.CheckLogin = True
        'エラー表記を最初は隠す。
        lbl_checkError.Visible = False
        'エラー表記の色を赤にする。
        lbl_checkError.ForeColor = System.Drawing.Color.Red

    End Sub

    Protected Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        'エラー表記を最初は隠す。
        lbl_checkError.Visible = False
        'IDかパスに記述がない時エラーメッセージを表示して処理を終了する。
        If txt_ID.Text = "" Or txt_Pass.Text = "" Then
            lbl_checkError.Text = common.getLoginErrorMsg(1)
            lbl_checkError.Visible = True
            Return
        End If

        'IDとパスワードのチェック
        Call loginClass.loginIDPassCheck(common, txt_ID.Text, txt_Pass.Text)
        'データをとってこれた時名前が入っていたら画面を表示する。
        If common.fullName = "" Then
            '検索にヒットしないエラーの記述。
            lbl_checkError.Text = common.getLoginErrorMsg(2)
            lbl_checkError.Visible = True
        Else
            'ログインが出来た時共通変数に値を入れる。
            common.LoginID = common.cusID
            common.LoginPass = common.cusPass
            common.LoginName = common.fullName
            'メイン画面の表示
            Response.Redirect("/webMain.aspx")
        End If

    End Sub

    Protected Sub btn_AddCus_Click(sender As Object, e As EventArgs) Handles btn_AddCus.Click

        Dim add As New webAddCus()
        '顧客情報登録ページの表示
        Response.Redirect("/webAddCus.aspx")

    End Sub

End Class