Public Class commonCusData

    'ログイン成功した時のID
    Public Property cusID As String

    'ログイン成功した時のパスワード
    Public Property cusPass As String

    'ログイン成功した時の氏名
    Public Property fullName As String

    Function getErrorMsg(i As Integer) As String

        If i = 1 Then
            getErrorMsg = "IDまたはパスに記述がありません。"
        ElseIf i = 2 Then
            getErrorMsg = "IDまたはパスが間違っています。"
        Else
            getErrorMsg = ""
        End If

    End Function


End Class
