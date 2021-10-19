Public Class commonCusData


#Region "共通変数"

    'ID
    Public Property cusID As String

    'パスワード
    Public Property cusPass As String

    '氏名
    Public Property fullName As String

    '性別
    Public Property sex As String

    '生年月日年
    Public Property BDYear As String

    '生年月日月
    Public Property BDMonth As String

    '生年月日日
    Public Property BDDay As String

    '郵便番号
    Public Property posAdress As String

    '住所1
    Public Property address1 As String

    '住所2
    Public Property address2 As String

    'データ取れたかの判断
    Public Property checkData As Boolean

#End Region



#Region "共通で使用"

    '送られてきたTextBoxに記述があるかを判断
    Function objErrorCheck(txt As Object) As Boolean

        If Not txt.Text = "" Then
            objErrorCheck = False
        Else
            objErrorCheck = True
        End If

    End Function

    '必須項目で記述がない場合使用
    Sub focusError(txt As Object, lbl As Object, i As Integer)

        txt.Focus()
        lbl.Visible = True
        lbl.Text = getErrorMsg(i)

    End Sub

#End Region

#Region "エラーメッセージ"

    Function getErrorMsg(i As Integer) As String

        If i = 1 Then
            getErrorMsg = "IDに記述がありません。"
        ElseIf i = 2 Then
            getErrorMsg = "Passに記述がありません。"
        ElseIf i = 3 Then
            getErrorMsg = "Pass(確認)に記述がありません。"
        ElseIf i = 4 Then
            getErrorMsg = "パスワードが一致しません。"
        ElseIf i = 5 Then
            getErrorMsg = "氏名に記述がありません。"
        ElseIf i = 6 Then
            getErrorMsg = "生年月日に記述がありません。"
        ElseIf i = 7 Then
            getErrorMsg = "数字で入力してください"
        ElseIf i = 20 Then
            '20からはデータに関しての記述に変更
            getErrorMsg = "データが存在しません"
        ElseIf i = 21 Then
            getErrorMsg = "SQLエラーです。"
        Else
            getErrorMsg = ""
        End If

    End Function

#Region "ログインで使用"
    Function getLoginErrorMsg(i As Integer) As String

        If i = 1 Then
            getLoginErrorMsg = "IDまたはパスに記述がありません。"
        ElseIf i = 2 Then
            getLoginErrorMsg = "IDまたはパスが間違っています。"
        Else
            getLoginErrorMsg = ""
        End If

    End Function
#End Region

#Region "会員情報登録で使用"
    Function getAddErrorMsg(i As Integer) As String

        If i = 1 Then
            getAddErrorMsg = "IDに記述がありません。"
        ElseIf i = 2 Then
            getAddErrorMsg = "Passに記述がありません。"
        ElseIf i = 3 Then
            getAddErrorMsg = "Pass(確認)に記述がありません。"
        ElseIf i = 4 Then
            getAddErrorMsg = "パスワードが一致しません。"
        ElseIf i = 5 Then
            getAddErrorMsg = "氏名に記述がありません。"
        ElseIf i = 6 Then
            getAddErrorMsg = "生年月日に記述がありません。"
        ElseIf i = 7 Then
            getAddErrorMsg = "数字で入力してください"
        Else
            getAddErrorMsg = ""
        End If

    End Function
#End Region

#Region "会員情報更新で使用"
    Function getUpErrorMsg(i As Integer) As String

        If i = 1 Then
            getUpErrorMsg = "IDに記述がありません。"
        ElseIf i = 2 Then
            getUpErrorMsg = "Passに記述がありません。"
        ElseIf i = 3 Then
            getUpErrorMsg = "Pass(確認)に記述がありません。"
        ElseIf i = 4 Then
            getUpErrorMsg = "パスワードが一致しません。"
        ElseIf i = 5 Then
            getUpErrorMsg = "氏名に記述がありません。"
        ElseIf i = 6 Then
            getUpErrorMsg = "生年月日に記述がありません。"
        ElseIf i = 7 Then
            getUpErrorMsg = "数字で入力してください"
        Else
            getUpErrorMsg = ""
        End If

    End Function
#End Region

#End Region



End Class
