Public Class Payment_Page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigatorPage.childForm(Booking_Page)
        Booking_Page.tempPetObject = Nothing
    End Sub
End Class