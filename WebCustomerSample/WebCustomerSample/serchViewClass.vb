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
	Function idCheckGetData(common As commonCusData, data As DataTable) As Integer
		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String = $"SELECT * FROM maCus  "
		Sql += $"where 1 = 1 "

		Try
			Using Conn As New SqlConnection
				Conn.ConnectionString = (con)
				Conn.Open()
				Using cmd As New SqlCommand(Sql)
					cmd.Connection = Conn
					cmd.CommandType = CommandType.Text
					Using reader As SqlDataReader = cmd.ExecuteReader()
						While (reader.Read())
							common.checkData = True
						End While
					End Using
					idCheckGetData = 1
				End Using
			End Using
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			idCheckGetData = 2
		End Try
	End Function




End Class
