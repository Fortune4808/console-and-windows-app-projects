Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        Dim connection As MySqlConnection

        Dim connstring As String
       

    
        connstring = "server=localhost;userid=root;password=;database=auto_system_db"
        ' Dim command As MySqlCommand
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        'Dim connect As New SqlClient.SqlConnection("server=127.0.0.1; user=root; password=;  database=;")
        'server=127.0.0.1; user=root@localhost; password=;database=auto_system_db;
        Try
            MessageBox.Show("Connected successfully")
        Catch ex As Exception
            MessageBox.Show("Connected fails")
        End Try
    End Sub










   
End Class
