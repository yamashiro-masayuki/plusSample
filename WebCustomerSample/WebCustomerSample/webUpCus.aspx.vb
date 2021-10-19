Public Class webUpCus
    Inherits System.Web.UI.Page

    '変数
    Dim common As commonCusData
    Dim upClass As upCusClass
    Dim dataError As Integer

    'ページの項目を全て初期状態にする。
    Sub Clear()

        txt_ID.Text = ""
        txt_Pass.Text = ""
        panelClear()
        txt_ID.Focus()

    End Sub

    'IDとPassを覗く全てを初期化する。
    Sub panelClear()

        txt_Name.Text = ""
        ddl_Sex.SelectedIndex = 0
        txt_BYear.Text = ""
        txt_BMonth.Text = ""
        txt_BDay.Text = ""
        txt_PosAddres.Text = ""
        txt_Address1.Text = ""
        txt_Address2.Text = ""
        txt_ChangePass.Text = ""
        txt_changePassCheck.Text = ""
        chb_PassCheck.Checked = False
        common.checkData = False

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'クラスの宣言
        common = New commonCusData()
        upClass = New upCusClass()
        '画面上の文字必須項目の文字色変更
        lbl_Name.ForeColor = System.Drawing.Color.Blue
        lbl_Sex.ForeColor = System.Drawing.Color.Blue
        lbl_BirthDay.ForeColor = System.Drawing.Color.Blue
        'エラーは赤文字に変更し初期は表示なし
        lbl_ErrorCheck.ForeColor = System.Drawing.Color.Red
        lbl_ErrorCheck.Visible = False

        'ポストバックしてない場合初期化
        If Not Page.IsPostBack Then
            Clear()
        End If

    End Sub

    Protected Sub btn_ViewButton_Click(sender As Object, e As EventArgs) Handles btn_ViewButton.Click

        '項目に記述があるかを判断する。
        'ID項目確認
        If common.objErrorCheck(txt_ID) Then
            common.focusError(txt_ID, lbl_ErrorCheck, 1)
            Return
        End If
        'Pass項目確認
        If common.objErrorCheck(txt_Pass) Then
            common.focusError(txt_Pass, lbl_ErrorCheck, 2)
            Return
        End If

        'データの確認を取るためにパネル内をクリアする。
        panelClear()

        'データの確認(Trueで帰ってきたらデータない為、処理の中止)
        dataError = upClass.upGetData(common, txt_ID.Text, txt_Pass.Text)
        If Not common.checkData Then

            If dataError = 1 Then
                'データ件数が0件
                common.focusError(txt_Pass, lbl_ErrorCheck, 20)
                Return
            ElseIf dataError = 2 Then
                'SQLエラー
                common.focusError(txt_Pass, lbl_ErrorCheck, 21)
                Return
            End If

        End If

        'データがとって来れた時に項目に挿入
        txt_Name.Text = common.fullName
        ddl_Sex.Text = common.sex
        txt_BYear.Text = common.BDYear
        txt_BMonth.Text = common.BDMonth
        txt_BDay.Text = common.BDDay
        txt_PosAddres.Text = common.posAdress
        txt_Address1.Text = common.address1
        txt_Address2.Text = common.address2



    End Sub

    'クリアボタンを押したときに初期化する。
    Protected Sub btn_ClearButton_Click(sender As Object, e As EventArgs) Handles btn_ClearButton.Click

        '初期状態に戻す
        Clear()

    End Sub

    '更新ボタンを押したときにデータを更新する。
    Protected Sub btn_UpButton_Click(sender As Object, e As EventArgs) Handles btn_UpButton.Click



    End Sub

End Class