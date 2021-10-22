Imports System.Data.SqlClient
Imports System.Data
Public Class serchViewClass

	'dataColumの挿入
	Function viewDataTable(data As DataTable) As DataTable

		data.Columns.Add("ID")
		data.Columns.Add("PASS")
		data.Columns.Add("FULLNAME")
		data.Columns.Add("SEX")
		data.Columns.Add("BDYEAR")
		data.Columns.Add("BDMONTH")
		data.Columns.Add("BDDAY")

		viewDataTable = data

	End Function

	'項目ごとのデータを取ってくる。
	Function GetData(common As commonCusData, ByRef data As DataTable, id As String, name As String, sex As String, bdy As String, bdm As String, bdd As String) As Integer
		Dim i As Integer = 0

		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String = $"SELECT * FROM maCus  "
		Sql += $"where 1 = 1 "
		If Not id = "" Then
			Sql += $"And ID like '%{id}%' "
		End If
		If Not name = "" Then
			Sql += $"And FULLNAME = '{name}' "
		End If
		If Not sex = "" Then
			Sql += $"And SEX = '{sex}' "
		End If
		If Not bdy = "" Then
			Sql += $"And BDYEAR = '{bdy}' "
		End If
		If Not bdm = "" Then
			Sql += $"And BDMONTH = '{bdm}' "
		End If
		If Not bdd = "" Then
			Sql += $"And BDDAY = '{bdd}' "
		End If

		Try
			Using Conn As New SqlConnection
				Conn.ConnectionString = (con)
				Conn.Open()
				Using cmd As New SqlCommand(Sql)
					cmd.Connection = Conn
					cmd.CommandType = CommandType.Text
					Using reader As SqlDataReader = cmd.ExecuteReader()
						While (reader.Read())
							data.Rows.Add()
							data.Rows(i)("ID") = reader.GetString(1)
							data.Rows(i)("FULLNAME") = reader.GetString(3)
							data.Rows(i)("SEX") = reader.GetString(4)
							data.Rows(i)("BDYEAR") = reader.GetInt32(5)
							data.Rows(i)("BDMONTH") = reader.GetInt32(6)
							data.Rows(i)("BDDAY") = reader.GetInt32(7)
							common.checkData = True
							i += 1
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




End Class
