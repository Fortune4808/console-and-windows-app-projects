Imports MySql.Data.MySqlClient
'Imports biometric_attendance.RegistrationForm

Module Functions

    Public Function GetSqlConnection() As MySqlConnection
        Dim connstring As String = "server=localhost;user id=root;password=;database=biometric_attendance_db"
        Dim connection As New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        Return connection
    End Function





End Module
