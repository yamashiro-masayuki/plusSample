Imports System.Data
Public Class webAddCus
    Inherits System.Web.UI.Page

    Dim common As commonCusData
    Dim addClass As addCusClass

    '画面が開かれた際に文字色を変更しエラーを隠す。
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        End If
        'Passに記述なし
        If txt_Pass.Text = "" Then
            focusError(txt_Pass, 2)
        End If
        'Pass(確認)に記述なし
        If txt_PassCheck.Text = "" Then
            focusError(txt_PassCheck, 3)
        End If
        'PassとPass(確認)で一致しているか確認
        If txt_Pass.Text = txt_PassCheck.Text Then
            focusError(txt_PassCheck, 4)
        End If
        '氏名に記述なし
        If txt_Name.Text = "" Then
            focusError(txt_Name, 5)
        End If
        '生年月日に記述なし
        If txt_BYear.Text = "" Or txt_BMonth.Text = "" Or txt_BDay.Text = "" Then
            focusError(txt_Name, 6)
        End If

#End Region

        '登録を行う
        Dim data As New DataTable
        data.Rows.Add()
        data = addClass.addDataTable(data)



    End Sub

    '必須項目で記述がない場合使用
    Sub focusError(txt As Object, i As Integer)

        txt.Focus()
        lbl_ErrorCheck.Visible = True
        lbl_ErrorCheck.Text = common.getAddErrorMsg(i)

    End Sub


End Class