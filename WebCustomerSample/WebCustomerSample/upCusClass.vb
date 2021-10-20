Imports System.Data.SqlClient
Imports System.Data
Public Class upCusClass

	'ログイン時にそのIDとPassが一致するものがあるかを判断するSQL
	Function upGetData(common As commonCusData, id As String, pass As String) As Integer
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
					upGetData = 1
				End Using
			End Using
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			upGetData = 2
		End Try
	End Function

	'dataColumの挿入
	Function upDataTable(data As DataTable) As DataTable

		data.Columns.Add("ID")
		data.Columns.Add("PASS")
		data.Columns.Add("FULLNAME")
		data.Columns.Add("SEX")
		data.Columns.Add("BDYEAR")
		data.Columns.Add("BDMONTH")
		data.Columns.Add("BDDAY")
		data.Columns.Add("POSADDRESS")
		data.Columns.Add("ADDRESS1")
		data.Columns.Add("ADDRESS2")

		upDataTable = data

	End Function

	'編集したデータを登録する。
	Function upDataSql(data As DataTable) As Boolean
		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String
		Sql = "update maCus set "
		'パスワードを変更していない場合更新をしない。
		If Not data.Rows(0)("PASS").ToString() = "" Then
			Sql += $"PASS = '{data.Rows(0)("PASS").ToString()}', "
		End If
		Sql += $"FULLNAME = '{data.Rows(0)("FULLNAME").ToString()}', "
		Sql += $"SEX = '{data.Rows(0)("SEX").ToString()}', "
		Sql += $"BDYEAR = {data.Rows(0)("BDYEAR").ToString()}, "
		Sql += $"BDMONTH = {data.Rows(0)("BDMONTH").ToString()}, "
		Sql += $"BDDAY = {data.Rows(0)("BDDAY").ToString()}, "
		Sql += $"POSADDRESS = '{data.Rows(0)("POSADDRESS").ToString()}', "
		Sql += $"ADDRESS1 = '{data.Rows(0)("ADDRESS1").ToString()}', "
		Sql += $"ADDRESS2 = '{data.Rows(0)("ADDRESS2").ToString()}' "
		Sql += $"WHERE ID = '{data.Rows(0)("ID")}' "

		Try
			Using Conn As New SqlConnection
				Conn.ConnectionString = (con)
				Conn.Open()
				Using transaction As SqlTransaction = Conn.BeginTransaction()
					Try
						Using cmd As New SqlCommand(Sql, Conn, transaction)

							cmd.ExecuteNonQuery()
							upDataSql = True
							transaction.Commit()
						End Using
					Catch ex As Exception
						transaction.Rollback()
						Console.WriteLine(ex.Message)
					End Try
				End Using
			End Using
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			upDataSql = False
		End Try

	End Function





End Class
