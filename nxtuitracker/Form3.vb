Public Class frm_mini

    Private Sub frm_mini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.6
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 50

        Me.ShowInTaskbar = False

    End Sub
End Class