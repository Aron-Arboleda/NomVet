Public Class Rcd_Page
    Private Sub Rcd_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rcd_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub


End Class