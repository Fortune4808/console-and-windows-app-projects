<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.profile_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'submit_btn
        '
        Me.submit_btn.Location = New System.Drawing.Point(142, 162)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(244, 54)
        Me.submit_btn.TabIndex = 0
        Me.submit_btn.Text = "SUBMIT"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(41, 76)
        Me.name_txt.Multiline = True
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(244, 41)
        Me.name_txt.TabIndex = 1
        '
        'profile_id
        '
        Me.profile_id.Location = New System.Drawing.Point(291, 76)
        Me.profile_id.Multiline = True
        Me.profile_id.Name = "profile_id"
        Me.profile_id.Size = New System.Drawing.Size(244, 41)
        Me.profile_id.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 454)
        Me.Controls.Add(Me.profile_id)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.submit_btn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents name_txt As System.Windows.Forms.TextBox
    Friend WithEvents profile_id As System.Windows.Forms.TextBox

End Class
