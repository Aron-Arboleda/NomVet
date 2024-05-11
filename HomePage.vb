Public Class HomePage
    Private Sub HomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Login_Page.isClosing = False) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Login_Page.isClosing = True
                ' Close all forms and terminate the application
                Application.Exit()
            Else
                ' Cancel the form closing
                e.Cancel = True
            End If
        End If
    End Sub
End Class