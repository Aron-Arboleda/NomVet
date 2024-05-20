Public Class HomePage

    Private Sub HomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NavigatorPage.childForm(Booking_Page)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterPetsPage.loadRegisterPetsPage()
    End Sub
End Class