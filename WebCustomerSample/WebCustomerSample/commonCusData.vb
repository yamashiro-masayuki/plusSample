Public Class commonCusData

    'ログイン成功した時のID
    Public Property cusID As String

    'ログイン成功した時のパスワード
    Public Property cusPass As String

    'ログイン成功した時の氏名
    Public Property fullName As String

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
        Else
            getAddErrorMsg = ""
        End If

    End Function
#End Region

End Class
