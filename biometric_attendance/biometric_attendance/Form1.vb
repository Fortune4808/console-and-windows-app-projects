Imports DPFP
Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
Imports biometric_attendance.Functions

Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class RegistrationForm
    Implements DPFP.Capture.EventHandler
    Private capturer As DPFP.Capture.Capture

    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim reg_no As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = Functions.GetSqlConnection
    End Sub

    Public Sub counter_user(ByVal counter_id, ByVal counter_value)
        'counter query
        connection = Functions.GetSqlConnection
        query = "UPDATE counters_tab SET counter_value=@counter_value WHERE counter_id=@counter_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        command.Parameters.AddWithValue("@counter_value", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        connection.Close()
    End Sub

    Private Sub RegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub RegistrationPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RegistrationPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RegistrationPanel.ClientRectangle)
    End Sub

    Private Sub RegistrationPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegistrationPanel.Resize
        RegistrationPanel.Invalidate()
    End Sub

    Private Sub TimerTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeDate.Tick
        LabelDateTime.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub PassportPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Passport.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            Passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub BiometricButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiometricButton.Click
        BiometricForm.Show()
        BiometricForm.EnrollmentPanel.Visible = False
    End Sub

    Private Sub VerificationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationButton.Click
        VerificationForm.Show()
    End Sub

    Private Sub ClockkInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockkInButton.Click
        ClockInForm.Show()
    End Sub

    Private Sub ReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportButton.Click
        ReportForm.Show()
    End Sub

    Private Sub SaveButton_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.MouseEnter
        SaveButton.ForeColor = Color.White
    End Sub

    Private Sub SaveButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.MouseLeave
        SaveButton.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ClearButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.MouseHover
        ClearButton.ForeColor = Color.White
    End Sub

    Private Sub ClearButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.MouseLeave
        ClearButton.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        fullname_txt.Text = ""
        address_txt.Text = ""
        phoneno_txt.Text = ""
        email_txt.Text = ""
        Passport.Image = Nothing
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim response As Integer
        If (fullname_txt.Text = "") Or (address_txt.Text = "") Or (phoneno_txt.Text = "") Or (email_txt.Text = "") Then
            MessageBox.Show("All Fields Are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (Passport.Image Is Nothing) Then
            MessageBox.Show("Select a Passport to Continue", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf phoneno_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phoneno_txt.Text = ""
            phoneno_txt.Focus()
            Exit Sub
        Else
            response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If response = vbYes Then
                connection = Functions.GetSqlConnection
                query = "SELECT count(*) FROM users_tab WHERE email=@email"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@email", email_txt.Text)
                Dim count As Integer
                count = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()
                If count > 0 Then
                    MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    connection = Functions.GetSqlConnection
                    query = "SELECT count(*) FROM users_tab WHERE phone_no=@phone_no"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@phone_no", phoneno_txt.Text)
                    Dim count1 As Integer
                    count1 = Convert.ToInt32(command.ExecuteScalar())
                    connection.Close()
                    If count1 > 0 Then
                        MessageBox.Show("Phone Number is already Exist, Kindly Enter a new Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Registration()
                    End If
                End If
            End If
        End If
    End Sub

    Public Function validateEmail(ByVal emailAddress) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})")
        If email.IsMatch(emailAddress) Then
            Return True
        End If
    End Function

    Private Sub SearchCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchCheckBox.CheckedChanged
        If SearchCheckBox.Checked = True Then
            SearchIDCheckBox.Checked = False
        ElseIf SearchIDCheckBox.Checked = False Then
            SearchCheckBox.Checked = True
        End If
    End Sub

    Private Sub SearchIDCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchIDCheckBox.CheckedChanged
        If SearchIDCheckBox.Checked = True Then
            SearchCheckBox.Checked = False
        ElseIf SearchCheckBox.Checked = False Then
            SearchCheckBox.Checked = True
        End If
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub address_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles address_txt.KeyPress
        If e.Handled = Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Dot is Not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub phoneno_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneno_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Handled = Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Dot is Not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub email_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email_txt.KeyPress
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("A Dot before letters is not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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


    Private Sub Registration()
        ' insertion query code

        'allow passport to save
        'passport.Image.Save(mstream, passport.Image.RawFormat)
        Dim msstream As New System.IO.MemoryStream()
        Passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Dim counter_value As Integer
        Dim TimeID As String
        Dim command As MySqlCommand
        Try
            connection = Functions.GetSqlConnection
            query = "SELECT counter_value FROM counters_tab WHERE counter_id='REG'"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@counter_id", counter_value)
            reader = command.ExecuteReader
            reader.Read()
            counter_value = reader("counter_value")
            connection.Close()

            counter_value = counter_value + 1
            TimeID = Now.ToString("yyyyMMddss")
            Call counter_user("REG", counter_value)
            reg_no = "REG" + TimeID + counter_value.ToString

            connection = Functions.GetSqlConnection
            query = "INSERT into users_tab(reg_no,fullname,address,phone_no,email,passport,date) VALUES(@reg_no,@fullname,@address,@phone_no,@email,@passport,NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@reg_no", reg_no)
            command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
            command.Parameters.AddWithValue("@address", address_txt.Text)
            command.Parameters.AddWithValue("@phone_no", phoneno_txt.Text)
            command.Parameters.AddWithValue("@email", email_txt.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()
            Dim response As Integer
            response = MessageBox.Show("Record has been saved successfully!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            If response = vbOK Then
                fullname_txt.Text = ""
                address_txt.Text = ""
                phoneno_txt.Text = ""
                email_txt.Text = ""
                Passport.Image = Nothing
            End If
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Image Size is too Bigger, Kindly Reduce the Size to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
End Class
