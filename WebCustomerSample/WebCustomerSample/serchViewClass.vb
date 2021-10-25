Imports System.Data.SqlClient
Imports System.Data
Public Class serchViewClass

	'dataColumの挿入
	Function viewDataTable(data As DataTable) As DataTable

		data.Columns.Add("ID")
		data.Columns.Add("氏名")
		data.Columns.Add("性別")
		data.Columns.Add("誕生年")
		data.Columns.Add("誕生月")
		data.Columns.Add("誕生日")

		viewDataTable = data

	End Function

	'項目ごとのデータを取ってくる。
	Function GetData(common As commonCusData, ByRef data As DataTable, id As String, name As String, sex As String, bdy As String, bdm As String, bdd As String) As Integer
		Dim i As Integer = 0

		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String = $"SELECT ID, "
		Sql += $"FULLNAME As '氏名', "
		Sql += $"SEX As '性別', "
		Sql += $"BDYEAR As '誕生年', "
		Sql += $"BDMONTH As '誕生月', "
		Sql += $"BDDAY As '誕生日' "
		Sql += $"FROM maCus "
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
							data.Rows(i)("ID") = reader.GetString(0)
							data.Rows(i)("氏名") = reader.GetString(1)
							data.Rows(i)("性別") = reader.GetString(2)
							data.Rows(i)("誕生年") = reader.GetInt32(3)
							data.Rows(i)("誕生月") = reader.GetInt32(4)
							data.Rows(i)("誕生日") = reader.GetInt32(5)
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
