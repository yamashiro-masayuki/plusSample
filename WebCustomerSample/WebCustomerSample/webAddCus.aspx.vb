Imports System.Data
Public Class webAddCus
    Inherits System.Web.UI.Page

    Dim common As commonCusData
    Dim addClass As addCusClass

    'ページの項目を全て初期状態にする。
    Sub Clear()

        txt_ID.Text = ""
        txt_Pass.Text = ""
        txt_PassCheck.Text = ""
        txt_Name.Text = ""
        ddl_Sex.SelectedIndex = 0
        txt_BYear.Text = ""
        txt_BMonth.Text = ""
        txt_BDay.Text = ""
        txt_PosAddres.Text = ""
        txt_Address1.Text = ""
        txt_Address2.Text = ""
        txt_ID.Focus()


    End Sub

    '画面が開かれた際に文字色を変更しエラーを隠す。
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'ポストバックしてない場合初期化
        If Not Page.IsPostBack Then
            Clear()
        End If

        'クラスの宣言
        common = New commonCusData()
        addClass = New addCusClass()
        '画面上の文字必須項目の文字色変更
        lbl_ID.ForeColor = System.Drawing.Color.Blue
        lbl_Pass.ForeColor = System.Drawing.Color.Blue
        lbl_PassCheck.ForeColor = System.Drawing.Color.Blue
        lbl_Name.ForeColor = System.Drawing.Color.Blue
        lbl_Sex.ForeColor = System.Drawing.Color.Blue
        lbl_BirthDay.ForeColor = System.Drawing.Color.Blue
        'エラーは赤文字に変更し初期は表示なし
        lbl_ErrorCheck.ForeColor = System.Drawing.Color.Red
        lbl_ErrorCheck.Visible = False

    End Sub

    '画面
    Protected Sub btn_Touroku_Click(sender As Object, e As EventArgs) Handles btn_Touroku.Click

        'エラーは最初は隠して、文字も空白に変更する。
        lbl_ErrorCheck.Visible = False
        lbl_ErrorCheck.Text = common.getAddErrorMsg(0)

        '必須項目チェックを行う。
#Region "必須項目チェック(Passチェック含む)"

        'IDに記述なし
        If txt_ID.Text = "" Then
            focusError(txt_ID, 1)
            Return
        End If
        'Passに記述なし
        If txt_Pass.Text = "" Then
            focusError(txt_Pass, 2)
            Return
        End If
        'Pass(確認)に記述なし
        If txt_PassCheck.Text = "" Then
            focusError(txt_PassCheck, 3)
            Return
        End If
        'PassとPass(確認)で一致しているか確認
        If Not txt_Pass.Text = txt_PassCheck.Text Then
            focusError(txt_PassCheck, 4)
            Return
        End If
        '氏名に記述なし
        If txt_Name.Text = "" Then
            focusError(txt_Name, 5)
            Return
        End If
        '生年月日に記述なし
        If txt_BYear.Text = "" Or txt_BMonth.Text = "" Or txt_BDay.Text = "" Then
            focusError(txt_Name, 6)
            Return
        End If
        '生年月日が数値じゃなかった場合
        If (IsNumeric(txt_BYear.Text) = False) Or (IsNumeric(txt_BMonth.Text) = False) Or (IsNumeric(txt_BDay.Text) = False) Then
            focusError(txt_BYear, 7)
            Return
        End If

#End Region

        '登録のためのテーブル作り
        Dim data As New DataTable
        data = addClass.addDataTable(data)
        'テーブルに値を入れる。
#Region "テーブルに値を入れる"

        Dim dtRow = data.NewRow
        dtRow("ID") = txt_ID.Text
        dtRow("PASS") = txt_Pass.Text
        dtRow("FULLNAME") = txt_Name.Text
        dtRow("SEX") = ddl_Sex.Text
        dtRow("BDYEAR") = txt_BYear.Text
        dtRow("BDMONTH") = txt_BMonth.Text
        dtRow("BDDAY") = txt_BDay.Text
        dtRow("POSADDRESS") = txt_PosAddres.Text
        dtRow("ADDRESS1") = txt_Address1.Text
        dtRow("ADDRESS2") = txt_Address2.Text
        data.Rows.Add(dtRow)

#End Region
        '登録する。
        addClass.addData(data)
        '初期化する。
        Clear()


    End Sub

    '必須項目で記述がない場合使用
    Sub focusError(txt As Object, i As Integer)

        txt.Focus()
        lbl_ErrorCheck.Visible = True
        lbl_ErrorCheck.Text = common.getAddErrorMsg(i)

    End Sub


End Class