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
        Dim listOfBookings As List(Of Appointment) = FileManipulator.ReadBookings(activeAccount.strName)
        Dim listOfPetNames As List(Of String) = FileManipulator.getListOfPetsName(listOfBookings)

        For Each pet In activeAccount.petsList
            If Not (listOfPetNames.Contains(pet.strName)) Then
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
        Dim procedure As String = cbProcedure.SelectedItem
        Dim dateOfApppointment As Date = dtpAppointmentDate.Value.Date
        Dim petName As String = cbPet.SelectedItem

        For Each pet In activeAccount.petsList
            If petName = pet.strName Then
                Dim randomId As Integer = Session.ranCode()
                Dim petAppointment As New Appointment(randomId, activeAccount.strName, pet.strName, procedure, dateOfApppointment)
                FileManipulator.SaveBooking(petAppointment)

                Dim petListWithProcedure As New List(Of String)
                petListWithProcedure.Add(pet.strName & "#" & pet.strType & "#" & procedure)
                Dim sessionObj As New Session(randomId, activeAccount, dateOfApppointment, petListWithProcedure)
                FileManipulator.SaveSession(sessionObj)
                Exit For
            End If
        Next

        refreshBookingPage()


        MsgBox("Appointment has been Booked!", vbOKOnly + vbInformation, "Booking")
    End Sub
End Class