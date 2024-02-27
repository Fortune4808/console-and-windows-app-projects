<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiometricForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BiometricForm))
        Me.BiometricSideNav = New System.Windows.Forms.Panel()
        Me.EnrollmentButton = New System.Windows.Forms.Button()
        Me.BiometricNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.TimerTimeData = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BiometricPanel = New System.Windows.Forms.Panel()
        Me.EnrollmentPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BiometricSideNav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BiometricPanel.SuspendLayout()
        Me.EnrollmentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BiometricSideNav
        '
        Me.BiometricSideNav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BiometricSideNav.BackColor = System.Drawing.Color.White
        Me.BiometricSideNav.Controls.Add(Me.EnrollmentButton)
        Me.BiometricSideNav.Controls.Add(Me.BiometricNameTextbox)
        Me.BiometricSideNav.Controls.Add(Me.Label2)
        Me.BiometricSideNav.Controls.Add(Me.RegNoComboBox)
        Me.BiometricSideNav.Controls.Add(Me.Label1)
        Me.BiometricSideNav.Controls.Add(Me.PictureBox1)
        Me.BiometricSideNav.Location = New System.Drawing.Point(0, 0)
        Me.BiometricSideNav.Name = "BiometricSideNav"
        Me.BiometricSideNav.Size = New System.Drawing.Size(288, 534)
        Me.BiometricSideNav.TabIndex = 1
        '
        'EnrollmentButton
        '
        Me.EnrollmentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.EnrollmentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.EnrollmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollmentButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.EnrollmentButton.Location = New System.Drawing.Point(16, 338)
        Me.EnrollmentButton.Name = "EnrollmentButton"
        Me.EnrollmentButton.Size = New System.Drawing.Size(253, 64)
        Me.EnrollmentButton.TabIndex = 0
        Me.EnrollmentButton.TabStop = False
        Me.EnrollmentButton.Text = "Start Enrollment"
        Me.EnrollmentButton.UseVisualStyleBackColor = False
        '
        'BiometricNameTextbox
        '
        Me.BiometricNameTextbox.Enabled = False
        Me.BiometricNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BiometricNameTextbox.Location = New System.Drawing.Point(52, 288)
        Me.BiometricNameTextbox.Name = "BiometricNameTextbox"
        Me.BiometricNameTextbox.Size = New System.Drawing.Size(217, 26)
        Me.BiometricNameTextbox.TabIndex = 0
        Me.BiometricNameTextbox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'RegNoComboBox
        '
        Me.RegNoComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RegNoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegNoComboBox.FormattingEnabled = True
        Me.RegNoComboBox.Location = New System.Drawing.Point(52, 253)
        Me.RegNoComboBox.Name = "RegNoComboBox"
        Me.RegNoComboBox.Size = New System.Drawing.Size(217, 28)
        Me.RegNoComboBox.TabIndex = 0
        Me.RegNoComboBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Regno"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.biometric_attendance.My.Resources.Resources.security_bnr_fp
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelDateTime.Location = New System.Drawing.Point(869, 4)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(196, 12)
        Me.LabelDateTime.TabIndex = 2
        Me.LabelDateTime.Text = "Time 00:00:00 Date 00 mmm, 0000"
        '
        'TimerTimeData
        '
        Me.TimerTimeData.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 5)
        Me.Panel1.TabIndex = 0
        '
        'BiometricPanel
        '
        Me.BiometricPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BiometricPanel.BackgroundImage = Global.biometric_attendance.My.Resources.Resources.punchclock_app
        Me.BiometricPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BiometricPanel.Controls.Add(Me.Panel1)
        Me.BiometricPanel.Location = New System.Drawing.Point(298, 18)
        Me.BiometricPanel.Name = "BiometricPanel"
        Me.BiometricPanel.Size = New System.Drawing.Size(779, 504)
        Me.BiometricPanel.TabIndex = 2
        '
        'EnrollmentPanel
        '
        Me.EnrollmentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnrollmentPanel.Controls.Add(Me.Panel2)
        Me.EnrollmentPanel.Location = New System.Drawing.Point(298, 23)
        Me.EnrollmentPanel.Name = "EnrollmentPanel"
        Me.EnrollmentPanel.Size = New System.Drawing.Size(778, 501)
        Me.EnrollmentPanel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 5)
        Me.Panel2.TabIndex = 1
        '
        'BiometricForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 534)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.BiometricSideNav)
        Me.Controls.Add(Me.EnrollmentPanel)
        Me.Controls.Add(Me.BiometricPanel)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BiometricForm"
        Me.Text = "AfooTech Biometric Attendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BiometricSideNav.ResumeLayout(False)
        Me.BiometricSideNav.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BiometricPanel.ResumeLayout(False)
        Me.EnrollmentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BiometricSideNav As System.Windows.Forms.Panel
    Friend WithEvents LabelDateTime As System.Windows.Forms.Label
    Friend WithEvents TimerTimeData As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RegNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BiometricNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents EnrollmentButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BiometricPanel As System.Windows.Forms.Panel
    Friend WithEvents EnrollmentPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
