Imports System.Data.SqlClient
Imports System.Data
Public Class addCusClass
	Inherits System.Web.UI.Page

	'dataColumの挿入
	Function addDataTable(data As DataTable) As DataTable

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
	Function addData(data As DataTable) As Boolean
		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String
		Sql = "Insert into  maCus ( "
		Sql += "ID, "
		Sql += "PASS, "
		Sql += "FULLNAME, "
		Sql += "SEX, "
		Sql += "BDYEAR, "
		Sql += "BDMONTH, "
		Sql += "BDDAY, "
		Sql += "POSADDRESS, "
		Sql += "ADDRESS1, "
		Sql += "ADDRESS2 ) "
		'実データの挿入
		Sql += "VALUES ( "
		Sql += $"'{data.Rows(0)("ID").ToString()}', "         'IDデータ
		Sql += $"'{data.Rows(0)("PASS").ToString()}', "       'PASSデータ
		Sql += $"'{data.Rows(0)("FULLNAME").ToString()}', "   'FULLNAMEデータ
		Sql += $"'{data.Rows(0)("SEX").ToString()}', "        'SEXデータ
		Sql += $"{data.Rows(0)("BDYEAR").ToString()}, "     'BDYEARデータ
		Sql += $"{data.Rows(0)("BDMONTH").ToString()}, "    'BDMONTHデータ
		Sql += $"{data.Rows(0)("BDDAY").ToString()}, "      'BDDAYデータ
		Sql += $"'{data.Rows(0)("POSADDRESS").ToString()}', " 'POSADDRESSデータ
		Sql += $"'{data.Rows(0)("ADDRESS1").ToString()}', "   'ADDRESS1データ
		Sql += $"'{data.Rows(0)("ADDRESS2").ToString()}' "   'ADDRESS2データ
		Sql += " ); "

		Try
			Using Conn As New SqlConnection
				Conn.ConnectionString = (con)
				Conn.Open()
				Using transaction As SqlTransaction = Conn.BeginTransaction()
					Try
						Using cmd As New SqlCommand(Sql, Conn, transaction)

							cmd.ExecuteNonQuery()

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
			addData = False
		End Try

	End Function

End Class
