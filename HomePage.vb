Public Class HomePage

    Private Sub HomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NavigatorPage.childForm(Booking_Page)
    End Sub
End Class