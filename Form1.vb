Public Class LoadPg

    Private Sub LoadPg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar2.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar2.Value < ProgressBar2.Maximum Then
            ProgressBar2.Value += 1
            Login_Page.Show()
            Me.Hide()
        Else
            Timer1.Enabled = False
        End If
    End Sub


End Class
