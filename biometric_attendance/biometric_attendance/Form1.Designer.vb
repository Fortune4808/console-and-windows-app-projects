<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.RegistrationButton = New System.Windows.Forms.Button()
        Me.BiometricButton = New System.Windows.Forms.Button()
        Me.VerificationButton = New System.Windows.Forms.Button()
        Me.ClockkInButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.SideNavPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavHeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullname_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.phoneno_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Passport = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RecordPictureBox = New System.Windows.Forms.PictureBox()
        Me.RecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.SearchCheckBox = New System.Windows.Forms.CheckBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegistrationPanel = New System.Windows.Forms.Panel()
        Me.SideNavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RecordPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelDateTime.Location = New System.Drawing.Point(716, 4)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(196, 12)
        Me.LabelDateTime.TabIndex = 1
        Me.LabelDateTime.Text = "Time 00:00:00 Date 00 mmm, 0000"
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'RegistrationButton
        '
        Me.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistrationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationButton.ForeColor = System.Drawing.Color.White
        Me.RegistrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegistrationButton.Location = New System.Drawing.Point(62, 209)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(262, 36)
        Me.RegistrationButton.TabIndex = 0
        Me.RegistrationButton.TabStop = False
        Me.RegistrationButton.Text = "Registration / Edit User Data"
        Me.RegistrationButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RegistrationButton.UseVisualStyleBackColor = True
        '
        'BiometricButton
        '
        Me.BiometricButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BiometricButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BiometricButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BiometricButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BiometricButton.ForeColor = System.Drawing.Color.White
        Me.BiometricButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BiometricButton.Location = New System.Drawing.Point(62, 251)
        Me.BiometricButton.Name = "BiometricButton"
        Me.BiometricButton.Size = New System.Drawing.Size(262, 36)
        Me.BiometricButton.TabIndex = 0
        Me.BiometricButton.TabStop = False
        Me.BiometricButton.Text = "New User Biometric Enrollment"
        Me.BiometricButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BiometricButton.UseVisualStyleBackColor = True
        '
        'VerificationButton
        '
        Me.VerificationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerificationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.VerificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerificationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerificationButton.ForeColor = System.Drawing.Color.White
        Me.VerificationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VerificationButton.Location = New System.Drawing.Point(62, 293)
        Me.VerificationButton.Name = "VerificationButton"
        Me.VerificationButton.Size = New System.Drawing.Size(262, 36)
        Me.VerificationButton.TabIndex = 0
        Me.VerificationButton.TabStop = False
        Me.VerificationButton.Text = "User Biometric Verification"
        Me.VerificationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VerificationButton.UseVisualStyleBackColor = True
        '
        'ClockkInButton
        '
        Me.ClockkInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClockkInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ClockkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockkInButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockkInButton.ForeColor = System.Drawing.Color.White
        Me.ClockkInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockkInButton.Location = New System.Drawing.Point(62, 335)
        Me.ClockkInButton.Name = "ClockkInButton"
        Me.ClockkInButton.Size = New System.Drawing.Size(262, 36)
        Me.ClockkInButton.TabIndex = 0
        Me.ClockkInButton.TabStop = False
        Me.ClockkInButton.Text = "Clock In"
        Me.ClockkInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockkInButton.UseVisualStyleBackColor = True
        '
        'ReportButton
        '
        Me.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportButton.ForeColor = System.Drawing.Color.White
        Me.ReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportButton.Location = New System.Drawing.Point(62, 377)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(262, 36)
        Me.ReportButton.TabIndex = 0
        Me.ReportButton.TabStop = False
        Me.ReportButton.Text = "Report"
        Me.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportButton.UseVisualStyleBackColor = True
        '
        'SideNavPanel
        '
        Me.SideNavPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SideNavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.SideNavPanel.Controls.Add(Me.ReportButton)
        Me.SideNavPanel.Controls.Add(Me.ClockkInButton)
        Me.SideNavPanel.Controls.Add(Me.VerificationButton)
        Me.SideNavPanel.Controls.Add(Me.BiometricButton)
        Me.SideNavPanel.Controls.Add(Me.RegistrationButton)
        Me.SideNavPanel.Controls.Add(Me.PictureBox1)
        Me.SideNavPanel.Location = New System.Drawing.Point(0, 0)
        Me.SideNavPanel.Name = "SideNavPanel"
        Me.SideNavPanel.Size = New System.Drawing.Size(324, 579)
        Me.SideNavPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.biometric_attendance.My.Resources.Resources.afootech_logo2
        Me.PictureBox1.Location = New System.Drawing.Point(62, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NavHeaderPanel
        '
        Me.NavHeaderPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.NavHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavHeaderPanel.Name = "NavHeaderPanel"
        Me.NavHeaderPanel.Size = New System.Drawing.Size(590, 5)
        Me.NavHeaderPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'fullname_txt
        '
        Me.fullname_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fullname_txt.Location = New System.Drawing.Point(76, 16)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.Size = New System.Drawing.Size(494, 20)
        Me.fullname_txt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.address_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.address_txt.Location = New System.Drawing.Point(76, 41)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(494, 20)
        Me.address_txt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone No"
        '
        'phoneno_txt
        '
        Me.phoneno_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneno_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.phoneno_txt.Location = New System.Drawing.Point(76, 66)
        Me.phoneno_txt.Name = "phoneno_txt"
        Me.phoneno_txt.Size = New System.Drawing.Size(494, 20)
        Me.phoneno_txt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email"
        '
        'email_txt
        '
        Me.email_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.email_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.email_txt.Location = New System.Drawing.Point(76, 91)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(494, 20)
        Me.email_txt.TabIndex = 8
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SaveButton.Location = New System.Drawing.Point(14, 203)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(82, 49)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.TabStop = False
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClearButton.Location = New System.Drawing.Point(103, 203)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(82, 49)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.TabStop = False
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Passport)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Passport"
        '
        'Passport
        '
        Me.Passport.BackgroundImage = Global.biometric_attendance.My.Resources.Resources.Click_to_browse
        Me.Passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Passport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Passport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Passport.Location = New System.Drawing.Point(10, 19)
        Me.Passport.Name = "Passport"
        Me.Passport.Size = New System.Drawing.Size(100, 100)
        Me.Passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Passport.TabIndex = 12
        Me.Passport.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RecordPictureBox)
        Me.GroupBox2.Controls.Add(Me.RecordDataGridView)
        Me.GroupBox2.Controls.Add(Me.SearchIDCheckBox)
        Me.GroupBox2.Controls.Add(Me.SearchCheckBox)
        Me.GroupBox2.Controls.Add(Me.SearchTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 263)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record View"
        '
        'RecordPictureBox
        '
        Me.RecordPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordPictureBox.BackgroundImage = CType(resources.GetObject("RecordPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.RecordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecordPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecordPictureBox.Location = New System.Drawing.Point(435, 55)
        Me.RecordPictureBox.Name = "RecordPictureBox"
        Me.RecordPictureBox.Size = New System.Drawing.Size(110, 110)
        Me.RecordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RecordPictureBox.TabIndex = 5
        Me.RecordPictureBox.TabStop = False
        '
        'RecordDataGridView
        '
        Me.RecordDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordDataGridView.Location = New System.Drawing.Point(9, 55)
        Me.RecordDataGridView.Name = "RecordDataGridView"
        Me.RecordDataGridView.Size = New System.Drawing.Size(420, 195)
        Me.RecordDataGridView.TabIndex = 4
        '
        'SearchIDCheckBox
        '
        Me.SearchIDCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchIDCheckBox.AutoSize = True
        Me.SearchIDCheckBox.Location = New System.Drawing.Point(465, 22)
        Me.SearchIDCheckBox.Name = "SearchIDCheckBox"
        Me.SearchIDCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.SearchIDCheckBox.TabIndex = 0
        Me.SearchIDCheckBox.TabStop = False
        Me.SearchIDCheckBox.Text = "Search by ID"
        Me.SearchIDCheckBox.UseVisualStyleBackColor = True
        '
        'SearchCheckBox
        '
        Me.SearchCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchCheckBox.AutoSize = True
        Me.SearchCheckBox.Checked = True
        Me.SearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SearchCheckBox.Location = New System.Drawing.Point(351, 22)
        Me.SearchCheckBox.Name = "SearchCheckBox"
        Me.SearchCheckBox.Size = New System.Drawing.Size(105, 17)
        Me.SearchCheckBox.TabIndex = 0
        Me.SearchCheckBox.TabStop = False
        Me.SearchCheckBox.Text = "Search by Name"
        Me.SearchCheckBox.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchTextBox.Location = New System.Drawing.Point(100, 20)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(248, 20)
        Me.SearchTextBox.TabIndex = 0
        Me.SearchTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Search Here :"
        '
        'RegistrationPanel
        '
        Me.RegistrationPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistrationPanel.Controls.Add(Me.GroupBox2)
        Me.RegistrationPanel.Controls.Add(Me.GroupBox1)
        Me.RegistrationPanel.Controls.Add(Me.ClearButton)
        Me.RegistrationPanel.Controls.Add(Me.SaveButton)
        Me.RegistrationPanel.Controls.Add(Me.email_txt)
        Me.RegistrationPanel.Controls.Add(Me.Label4)
        Me.RegistrationPanel.Controls.Add(Me.phoneno_txt)
        Me.RegistrationPanel.Controls.Add(Me.Label3)
        Me.RegistrationPanel.Controls.Add(Me.address_txt)
        Me.RegistrationPanel.Controls.Add(Me.Label2)
        Me.RegistrationPanel.Controls.Add(Me.fullname_txt)
        Me.RegistrationPanel.Controls.Add(Me.Label1)
        Me.RegistrationPanel.Controls.Add(Me.NavHeaderPanel)
        Me.RegistrationPanel.Location = New System.Drawing.Point(332, 20)
        Me.RegistrationPanel.Name = "RegistrationPanel"
        Me.RegistrationPanel.Size = New System.Drawing.Size(590, 546)
        Me.RegistrationPanel.TabIndex = 0
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 578)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.SideNavPanel)
        Me.Controls.Add(Me.RegistrationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrationForm"
        Me.Text = "AfooTech Biometric Attendance"
        Me.SideNavPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RecordPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationPanel.ResumeLayout(False)
        Me.RegistrationPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDateTime As System.Windows.Forms.Label
    Friend WithEvents TimerTimeDate As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RegistrationButton As System.Windows.Forms.Button
    Friend WithEvents BiometricButton As System.Windows.Forms.Button
    Friend WithEvents VerificationButton As System.Windows.Forms.Button
    Friend WithEvents ClockkInButton As System.Windows.Forms.Button
    Friend WithEvents ReportButton As System.Windows.Forms.Button
    Friend WithEvents SideNavPanel As System.Windows.Forms.Panel
    Friend WithEvents NavHeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fullname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents address_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents phoneno_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Passport As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RecordPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RecordDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchIDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SearchCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RegistrationPanel As System.Windows.Forms.Panel

End Class
