Public Class Booking_Page
    Public tempPetObject As Pet = Nothing
    Public checkupFee As Double = 0
    Public vaccineFee As Double = 0
    Public totalFee As Double = 0
    Private Sub btnBookAndPay_Click(sender As Object, e As EventArgs) Handles btnBookAndPay.Click
        Dim petName As String = txtPetName.Text
        Dim petAge As Integer = numUIPetAge.Text
        Dim petBirthday As Date = dtpPetBirthday.Value.Date
        Dim petWeight As Double = numUIPetWeight.Text
        Dim petType As String = cbPetType.SelectedItem
        Dim petVaccineStatus As String = cbVaccineStatus.SelectedItem
        Dim petProcedure As String = cbProcedure.SelectedItem
        Dim petDateOfAppointment As Date = dtpAppointmentDate.Value.Date
        Dim petAppointment As New Appointment(petProcedure, petDateOfAppointment)
        Dim petObject As New Pet(petName, petAge, petBirthday, petWeight, petType, petVaccineStatus)
        petObject.appointment = petAppointment
        tempPetObject = petObject

        If petProcedure = "Both" Then
            If petType = "Feline" Then
                checkupFee = 500.0
                vaccineFee = 1000.0
            ElseIf petType = "Canine" Then
                checkupFee = 400.0
                vaccineFee = 1500.0
            ElseIf petType = "Reptile" Then
                checkupFee = 600.0
                vaccineFee = 2000.0
            End If
        ElseIf petProcedure = "Check-Up" Then
            If petType = "Feline" Then
                checkupFee = 500.0
            ElseIf petType = "Canine" Then
                checkupFee = 400.0
            ElseIf petType = "Reptile" Then
                checkupFee = 600.0
            End If
        ElseIf petProcedure = "Vaccine" Then
            If petType = "Feline" Then
                vaccineFee = 1000.0
            ElseIf petType = "Canine" Then
                vaccineFee = 1500.0
            ElseIf petType = "Reptile" Then
                vaccineFee = 2000.0
            End If
        End If
        totalFee = checkupFee + vaccineFee

        Payment_Page.lblCheckupFee.Text = "₱" & checkupFee
        Payment_Page.lblVaccineFee.Text = "₱" & vaccineFee
        Payment_Page.lblTotalFee.Text = "₱" & totalFee



        NavigatorPage.childForm(Payment_Page)
    End Sub
End Class