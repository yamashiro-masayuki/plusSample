Imports System.Data.SqlClient
Imports System.Data
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

    '表示画面から別画面開く際の変数
    'ID
    Public Property viewID As String

#End Region

#Region "ログイン確認共通変数"

    'ログインできた場合の顧客ID
    Public Shared loginCusID As String
    Public Property LoginID() As String
        Get
            Return loginCusID
        End Get
        Set(ByVal value As String)
            loginCusID = value
        End Set
    End Property

    'ログインできた場合の顧客Pass
    Public Shared loginCusPass As String
    Public Property LoginPass() As String
        Get
            Return loginCusPass
        End Get
        Set(ByVal value As String)
            loginCusPass = value
        End Set
    End Property

    'ログインできた場合の顧客氏名
    Public Shared loginCusName As String
    Public Property LoginName() As String
        Get
            Return loginCusName
        End Get
        Set(ByVal value As String)
            loginCusName = value
        End Set
    End Property

    'デバックモードかの判断
    Public Shared checkCusLogin As Boolean = False
    Public Property CheckLogin() As Boolean
        Get
            Return checkCusLogin
        End Get
        Set(ByVal value As Boolean)
            checkCusLogin = value
        End Set
    End Property

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

#Region "共通で使用SQL"

    'IDとPassに当てはまるデータを取ってくるSQL
    Function GetData(common As commonCusData, id As String, pass As String) As Integer
        Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
        Dim Sql As String = $"SELECT * FROM maCus where ID = '{id}' and PASS = '{pass}' "

        Try
            Using Conn As New SqlConnection
                Conn.ConnectionString = (con)
                Conn.Open()
                Using cmd As New SqlCommand(Sql)
                    cmd.Connection = Conn
                    cmd.CommandType = CommandType.Text
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While (reader.Read())
                            common.cusID = reader.GetString(1)
                            common.cusPass = reader.GetString(2)
                            common.fullName = reader.GetString(3)
                            common.sex = reader.GetString(4)
                            common.BDYear = reader.GetInt32(5)
                            common.BDMonth = reader.GetInt32(6)
                            common.BDDay = reader.GetInt32(7)
                            common.posAdress = reader.GetString(8)
                            common.address1 = reader.GetString(9)
                            common.address2 = reader.GetString(10)
                            common.checkData = True
                        End While
                    End Using
                    GetData = 1
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            GetData = 2
        End Try
    End Function

#End Region

#Region "エラーメッセージ"

    Function getErrorMsg(i As Integer) As String

        If i = 1 Then
            getErrorMsg = "IDでエラーです。"
        ElseIf i = 2 Then
            getErrorMsg = "Passでエラーです。"
        ElseIf i = 3 Then
            getErrorMsg = "Pass(確認)でエラーです。"
        ElseIf i = 4 Then
            getErrorMsg = "パスワードでエラーです。"
        ElseIf i = 5 Then
            getErrorMsg = "氏名でエラーです。"
        ElseIf i = 6 Then
            getErrorMsg = "生年月日でエラーです。"
        ElseIf i = 7 Then
            getErrorMsg = "数字で入力してください"
        ElseIf i = 20 Then
            '20からはデータに関しての記述に変更
            getErrorMsg = "データが存在しません"
        ElseIf i = 21 Then
            getErrorMsg = "SQLエラーです。"
        ElseIf i = 22 Then
            getErrorMsg = "SQLエラーです。データの追加に失敗しました。"
        ElseIf i = 23 Then
            getErrorMsg = "SQLエラーです。データの更新に失敗しました。"
        ElseIf i = 24 Then
            getErrorMsg = "SQLエラーです。データの消去に失敗しました。"
        ElseIf i = 30 Then
            getErrorMsg = "データが存在しているため作成できません。"
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
