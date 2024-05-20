Public Class Booking_Page
    Public tempPetObject As Pet = Nothing
    Public checkupFee As Double = 0
    Public vaccineFee As Double = 0
    Public totalFee As Double = 0

    Public Sub loadBookingPage()
        refreshBookingPage()
    End Sub

    Public Sub refreshEstimatedTotalBill()
        Dim type As String = ""
        For Each pet In activeAccount.petsList
            If pet.strName = cbPet.SelectedItem.ToString() Then
                type = pet.strType
                Exit For
            End If
        Next
        Dim procedure As String = cbProcedure.SelectedItem
        Dim dblTotalBill As Double = computeTotalBill(type, procedure)
        lblTotalBill.Text = ("₱" & dblTotalBill.ToString() & ".00")
    End Sub


    Public Sub refreshBookingPage()
        cbPet.Items.Clear()
        For Each pet In activeAccount.petsList
            If pet.appointment.strProcedure = "Nothing" Then
                cbPet.Items.Add(pet.strName)
            End If
        Next
        cbPet.Text = ""
        cbProcedure.Text = ""
        dtpAppointmentDate.Value = DateTime.Now
    End Sub

    Private Sub cbProcedure_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProcedure.SelectedIndexChanged
        refreshEstimatedTotalBill()
    End Sub

    Private Sub cbPet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPet.SelectedIndexChanged
        refreshEstimatedTotalBill()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        FileManipulator.ClearPets(activeAccount)
        For Each pet In activeAccount.petsList
            Dim procedure As String = cbProcedure.SelectedItem
            Dim dateOfApppointment As Date = dtpAppointmentDate.Value.Date
            Dim petAppointment As New Appointment(procedure, dateOfApppointment)
            pet.appointment = petAppointment
            FileManipulator.SaveAppointment(activeAccount, pet)
        Next

        refreshBookingPage()
        MsgBox("Appointment has been Booked!", vbOKOnly + vbInformation, "Booking")
    End Sub
End Class