Imports System.Data.SqlClient
Imports System.Data
Public Class addCusClass
	Inherits System.Web.UI.Page

	'dataColumの挿入
	Function addDataTable(data As DataTable) As DataTable

		data.Columns.Add("NUMBER")
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

		addDataTable = data

	End Function


	'新しくデータを作成する
	Function addData(common As commonCusData, id As String, pass As String) As Boolean
		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String
		Sql = "Insert into  maCus ( "
		Sql += "NUMBER "
		Sql += "ID "
		Sql += "PASS "
		Sql += "FULLNAME "
		Sql += "SEX "
		Sql += "BDYEAR "
		Sql += "BDMONTH "
		Sql += "BDDAY "
		Sql += "POSADDRESS "
		Sql += "ADDRESS1 "
		Sql += "ADDRESS2 ) "
		Sql += "VALUES ( "  '実データの挿入
		Sql += "NUMBER "    'NUMBERデータ
		Sql += "ID "        'IDデータ
		Sql += "PASS "      'PASSデータ
		Sql += "FULLNAME "  'FULLNAMEデータ
		Sql += "BDDAY ); "

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
						End While
					End Using
				End Using
			End Using
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			addData = False
		End Try
	End Function

End Class
