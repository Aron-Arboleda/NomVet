﻿Public Class LoadPg

    Private Sub LoadPg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
<<<<<<< HEAD
        If (ProgressBar2.Value >= ProgressBar2.Maximum) Then
            Timer1.Stop()
=======
        If ProgressBar2.Value < ProgressBar2.Maximum Then
            ProgressBar2.Value += 1
            Login_Page.Show()
>>>>>>> origin/master
            Me.Hide()
            Login_Page.Show()
        Else
            ProgressBar2.PerformStep()
            lblLoadingLabel.Text = "Loading . . . " & ProgressBar2.Value & ("%")
        End If
    End Sub


End Class
