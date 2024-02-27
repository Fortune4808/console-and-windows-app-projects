Imports DPFP
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class BiometricForm
    Implements DPFP.Capture.EventHandler
    Private capturer As DPFP.Capture.Capture

    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String
    Dim reg_no As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        dbconnection()
        regnocomboboxload()

    End Sub

    Private Sub BiometricPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BiometricPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), BiometricPanel.ClientRectangle)
    End Sub

    Private Sub BiometricPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles BiometricPanel.Resize
        BiometricPanel.Invalidate()
    End Sub

    Private Sub TimerTimeData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeData.Tick
        LabelDateTime.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub EnrollmentButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles EnrollmentButton.MouseHover
        EnrollmentButton.ForeColor = Color.White
    End Sub

    Private Sub EnrollmentButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles EnrollmentButton.MouseLeave
        EnrollmentButton.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub EnrollmentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentButton.Click
        If (RegNoComboBox.Text = "") Or (BiometricNameTextbox.Text = "") Then
            MessageBox.Show("All Fields Are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            EnrollmentPanel.Visible = True
            BiometricPanel.Visible = False
        End If
    End Sub

    Private Sub EnrollmentPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles EnrollmentPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), EnrollmentPanel.ClientRectangle)
    End Sub

    Private Sub EnrollmentPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles EnrollmentPanel.Resize
        EnrollmentPanel.Invalidate()
    End Sub

    Private Sub regnocomboboxload()
        dbconnection()
        query = "SELECT * FROM users_tab WHERE reg_no=reg_no"
        command = New MySqlCommand(query, connection)
        reader = command.ExecuteReader
        While reader.Read
            Dim load = reader.GetString("reg_no")
            RegNoComboBox.Items.Add(load)
        End While
        connection.Close()
    End Sub

    Private Sub RegNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegNoComboBox.SelectedIndexChanged
        dbconnection()
        query = "SELECT * FROM users_tab WHERE reg_no='" & RegNoComboBox.Text & "'"
        command = New MySqlCommand(query, connection)
        reader = command.ExecuteReader
        While reader.Read
            BiometricNameTextbox.Text = reader.GetString("fullname")
        End While
        connection.Close()
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete

    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality

    End Sub

    'FUNCTION CODE START HERE!!!............
    Private Sub dbconnection()
        'connection to database
        connstring = "server=localhost;userid=root;password=;database=biometric_attendance_db"
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
    End Sub



End Class