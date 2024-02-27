Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connectionString As String = "server=localhost;username=root;password=;database=autoid_db"
    Dim connection As New MySqlConnection(connectionString)
    Dim mycmd As New MySqlCommand
    Dim reader As MySqlDataReader



   
    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Try
            connection.Open()
            MsgBox("Database Connected Succesfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            MsgBox("dastabase connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
