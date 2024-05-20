Public Class NavigatorPage
    Sub childForm(ByVal panel As Form)
        displayPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        displayPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        childForm(HomePage)
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        childForm(Booking_Page)
    End Sub

    Private Sub btnProfileDisplayName_Click(sender As Object, e As EventArgs) Handles btnProfileDisplayName.Click
        childForm(Profile_Page)
        Profile_Page.loadProfile()
    End Sub

    Private Sub NavigatorPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub

    Private Sub btnPricing_Click(sender As Object, e As EventArgs) Handles btnPricing.Click
        childForm(PricingPage)
    End Sub

    Private Sub btnRegisterPet_Click(sender As Object, e As EventArgs) Handles btnRegisterPet.Click
        RegisterPetsPage.loadRegisterPetsPage()
    End Sub
End Class