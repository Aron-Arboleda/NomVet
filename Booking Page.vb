Public Class Booking_Page
    Public tempPetObject As Pet = Nothing
    Private Sub btnBookAndPay_Click(sender As Object, e As EventArgs) Handles btnBookAndPay.Click
        Dim petName As String = txtPetName.Text
        Dim petAge As Integer = numUIPetAge.Text
        Dim petBirthday As Date = dtpPetBirthday.Value.Date
        Dim petWeight As Double = numUIPetWeight.Text
        Dim petType As String = cbPetType.SelectedItem
        Dim petVaccineStatus As String = cbVaccineStatus.SelectedItem
        Dim petProcedure As String = cbProcedure.SelectedItem
        Dim petDateOfAppointment As Date = dtpAppointmentDate.Value.Date
        Dim petObject As New Pet(petName, petAge, petBirthday, petWeight, petType, petVaccineStatus, petProcedure, petDateOfAppointment)
        tempPetObject = petObject

        Dim checkupFee As Double = 0
        If petType = "Feline" Then

        End If


        NavigatorPage.childForm(Payment_Page)
    End Sub
End Class