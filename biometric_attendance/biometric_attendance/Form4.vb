Public Class ClockInForm
    Private Sub ClockInForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ClockInPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClockInPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), ClockInPanel.ClientRectangle)
    End Sub

    Private Sub TimerTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeDate.Tick
        LabelDateTime.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), Panel2.ClientRectangle)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), Panel3.ClientRectangle)
    End Sub

  
   
End Class