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

    Public Sub refreshProcedureControl()
        Dim petName As String = cbPet.SelectedItem

        For Each pet In activeAccount.petsList
            If petName = pet.strName Then
                cbProcedure.Items.Clear()
                If pet.boolVaccinated = "Complete" Then
                    cbProcedure.Items.Add("Check-Up")
                    cbProcedure.SelectedItem = "Check-Up"
                Else
                    cbProcedure.Items.Add("Check-Up")
                    cbProcedure.Items.Add("Vaccine")
                    cbProcedure.Items.Add("Both")
                    cbProcedure.SelectedItem = "Vaccine"
                End If
                Exit For
            End If
        Next
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
        refreshProcedureControl()
        refreshEstimatedTotalBill()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim procedure As String = cbProcedure.SelectedItem
        Dim dateOfApppointment As Date = dtpAppointmentDate.Value.Date
        Dim petName As String = cbPet.SelectedItem

        If lblErrorMessage.Visible = True Then
            MsgBox("Please resolve all invalid inputs.", vbOKOnly + vbExclamation, "Booking")
            Exit Sub
        End If

        Dim comboBoxes() As ComboBox = {cbPet, cbProcedure}
        Dim comboBoxesAreEmpty As Boolean = checkIfComboBoxesAreEmpty(comboBoxes)
        If comboBoxesAreEmpty = True Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Booking")
            Exit Sub
        End If

        For Each pet In activeAccount.petsList
            If petName = pet.strName Then
                Dim randomId As String = GenerateRandomString(5)
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

    Private Sub dtpAppointmentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointmentDate.ValueChanged
        checkIfDatePickedIsValid(dtpAppointmentDate, lblErrorMessage)
    End Sub

    Public Sub checkIfDatePickedIsValid(dtpAppointmentDate As DateTimePicker, lblErrorMessage As Label)
        lblErrorMessage.Visible = False

        Dim bookingsList As List(Of Appointment) = FileManipulator.ReadBookings()
        Dim datesList As List(Of Date) = bookingsList.Select(Function(appointment) appointment.dateAppointment).ToList()

        If dtpAppointmentDate.Value.Date < DateTime.Now.Date Then
            lblErrorMessage.Visible = True
            lblErrorMessage.Text = "Date has passed already. Pick another date."
        ElseIf dtpAppointmentDate.Value.Date.DayOfWeek = DayOfWeek.Sunday Then
            lblErrorMessage.Visible = True
            lblErrorMessage.Text = "Clinic is not open on Sundays. Pick another date."
        Else
            For Each dateObj In datesList
                If dateObj = dtpAppointmentDate.Value.Date Then
                    lblErrorMessage.Visible = True
                    lblErrorMessage.Text = "There is already an appointment that day. Pick another date."
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Shared Function checkIfComboBoxesAreEmpty(fields() As ComboBox) As Boolean
        Dim empty = False

        For Each field In fields
            If field.SelectedIndex = -1 Then
                empty = True
                Exit For
            End If
        Next

        Return empty
    End Function
End Class