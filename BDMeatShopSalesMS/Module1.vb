Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Imports MySqlConnector
Module Module1
    Public query As MySqlCommand
    Public read As MySqlDataReader
    Public dataadapter As MySqlDataAdapter

    Public Function con() As MySqlConnection
        Dim connectionString As String = "server=localhost;user id=root;password=;database=bd_meatshop_sales"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Console.WriteLine("Connection to the database was successful!")
        Catch ex As MySqlException
            Console.WriteLine("MySQL Error: " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return connection
    End Function
End Module

