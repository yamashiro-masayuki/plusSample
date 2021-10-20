Imports System.Data.SqlClient
Imports System.Data
Public Class delCusClass


	'データを消去する。
	Function delDataSql(txtID As String) As Boolean
		Dim con As String = "Data Source=DESKTOP-CF5KSJ9;Initial Catalog=sampleDDB;Integrated Security=SSPI;"
		Dim Sql As String
		Sql = "DELETE FROM maCus "
		Sql += $"WHERE ID = '{txtID}'; "

		Try
			Using Conn As New SqlConnection
				Conn.ConnectionString = (con)
				Conn.Open()
				Using transaction As SqlTransaction = Conn.BeginTransaction()
					Try
						Using cmd As New SqlCommand(Sql, Conn, transaction)

							cmd.ExecuteNonQuery()
							delDataSql = True

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
			delDataSql = False
		End Try

	End Function

End Class
