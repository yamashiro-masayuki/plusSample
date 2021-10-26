Imports System.Data.SqlClient
Imports System.Data
Public Class LoginClass
	Inherits System.Web.UI.Page
	Public finCheck As Boolean

	'ログイン時にそのIDとPassが一致するものがあるかを判断するSQL
	Sub loginIDPassCheck(common As commonCusData, id As String, pass As String)
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
							Session("fullName") = reader.GetString(3)
							finCheck = True
						End While
					End Using
				End Using
			End Using
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
	End Sub



End Class
