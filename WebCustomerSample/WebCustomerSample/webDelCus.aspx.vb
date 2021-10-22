Public Class webDelCus
    Inherits System.Web.UI.Page

    '変数
    Dim common As commonCusData
    Dim delClass As delCusClass
    Dim dataError As Integer

    'ページの項目を全て初期状態にする。
    Sub Clear()

        txt_ID.Text = ""
        txt_Pass.Text = ""
        panelClear()
        txt_ID.Focus()
        '更新ボタンを使用不可能にする。
        btn_DeleteButton.Enabled = False

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
        txt_checkID.Text = ""
        txt_checkPass.Text = ""

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'クラスの宣言
        Common = New commonCusData()
        delClass = New delCusClass()

        '共通変数にログイン時の名前がなかったらエラーページに移行する。
        If common.LoginName = "" And common.CheckLogin Then
            'エラーページの表示
            Response.Redirect("~/webNotAccess.aspx")
        End If

        'エラーは赤文字に変更し初期は表示なし
        lbl_ErrorCheck.ForeColor = System.Drawing.Color.Red
        lbl_ErrorCheck.Visible = False

        'ポストバックしてない場合初期化
        If Not Page.IsPostBack Then
            Clear()
        End If

    End Sub

    'IDとパスが一致した時に項目を表示する。
    Protected Sub btn_ViewButton_Click(sender As Object, e As EventArgs) Handles btn_ViewButton.Click

        '更新ボタンを使用不可能にする。
        btn_DeleteButton.Enabled = False
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
        dataError = common.GetData(common, txt_ID.Text, txt_Pass.Text)
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

        '更新ボタンを使用可能にする。
        btn_DeleteButton.Enabled = True
        'データがとって来れた時に項目に挿入
        txt_checkID.Text = txt_ID.Text
        txt_checkPass.Text = txt_Pass.Text
        txt_Name.Text = common.fullName
        ddl_Sex.Text = common.sex
        txt_BYear.Text = common.BDYear
        txt_BMonth.Text = common.BDMonth
        txt_BDay.Text = common.BDDay
        txt_PosAddres.Text = common.posAdress
        txt_Address1.Text = common.address1
        txt_Address2.Text = common.address2

    End Sub

    '全項目のクリア
    Protected Sub btn_ClearButon_Click(sender As Object, e As EventArgs) Handles btn_ClearButon.Click

        Clear()

    End Sub

    'データの消去を行う。
    Protected Sub btn_DeleteButton_Click(sender As Object, e As EventArgs) Handles btn_DeleteButton.Click

        'データを消去する。
        If Not delClass.delDataSql(txt_ID.Text) Then
            common.focusError(txt_ID, lbl_ErrorCheck, 24)
            Return
        End If

        '初期化する。
        Clear()

    End Sub

End Class