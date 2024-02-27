Public Class ReportForm

    Private Sub ReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ReportPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ReportPanel.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), ReportPanel.ClientRectangle)
    End Sub
End Class