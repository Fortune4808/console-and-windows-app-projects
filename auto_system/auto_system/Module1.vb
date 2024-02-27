Imports MySql.Data.MySqlClient

Module Module1
    Public connstring As MySqlConnection
    Public command As MySqlCommand


    Sub connection()
        ' connstring = "server=localhost;user=root;password=;database=auto_system_db;"
        connstring = New MySqlConnection("server=localhost; userid=root;password=; database=auto_system_db")
        connstring.Open()
        'Dim connect As New SqlClient.SqlConnection("server=127.0.0.1; user=root; password=;  database=;")
        'server=127.0.0.1; user=root@localhost; password=;database=auto_system_db;
        Try
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("Connected fails")
        End Try


    End Sub



End Module
