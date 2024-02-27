Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        round(Me)
    End Sub

    Private Sub round(ByVal obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.FromArgb(245, 245, 245)

    
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        DGP.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        DGP.AddLine(10, 0, obj.Width - 10, 0)

        DGP.AddArc(New Rectangle(obj.Width - 10, 0, 10, 10), -90, 90)
        DGP.AddLine(obj.Width, 10, obj.Width, obj.Height - 10)

        DGP.AddArc(New Rectangle(obj.Width - 10, obj.Height - 10, 10, 10), 0, 10)
        DGP.AddLine(obj.Width - 10, obj.Height, 10, obj.Height)

        DGP.AddArc(New Rectangle(0, obj.Height - 10, 10, 10), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

End Class
