Public Class Payment_Page

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Rcd_Page.childForm(SessionHandlingPage)
        SessionHandlingPage.loadSessionHandlingPage()
    End Sub

    Private Sub btnPayAndShowReceipt_Click(sender As Object, e As EventArgs) Handles btnPayAndShowReceipt.Click
        Rcd_Page.childForm(WalkInReceiptPage)
        WalkInReceiptPage.loadWalkInReceiptPage()
        updatePets(SessionHandlingPage.selectedSession.petOwner.strName, SessionHandlingPage.nextVisitsList)
        updateSessions(SessionHandlingPage.selectedSession)
    End Sub

    Public Sub updatePets(petOwner As String, nextVisitsList As List(Of NextVisit))
        Dim owner As PetOwner = FileManipulator.findPetOwnerWithName(petOwner)
        Dim petsListtt As List(Of Pet) = FileManipulator.ReadPets(owner)
        owner.petsList = petsListtt

        For Each nv In nextVisitsList
            For Each pet In petsListtt
                If nv.petName = pet.strName Then
                    pet.dateOfNextVisit = nv.dateOfNextVisit
                    pet.boolVaccinated = nv.vacStatus
                End If
            Next
        Next

        FileManipulator.SavePets(owner)
    End Sub

    Public Sub updateSessions(ByVal session As Session)
        Dim sessions As List(Of Session) = FileManipulator.ReadSessions()
        For Each s As Session In sessions
            If s.sessionId = session.sessionId Then
                updateAppointments(s.sessionId)
                sessions.Remove(s)
                Exit For
            End If
        Next
        FileManipulator.SaveSessions(sessions)
    End Sub

    Public Sub updateAppointments(ByVal sessionId As Integer)
        Dim appointments As List(Of Appointment) = FileManipulator.ReadBookings()
        For Each a As Appointment In appointments
            If a.appointmentId = sessionId Then
                appointments.Remove(a)
                Exit For
            End If
        Next
        FileManipulator.SaveBookings(appointments)
    End Sub

    Public Sub loadPaymentPage()
        billRowsPanel.Controls.Clear()

        lblPetOwner.Text = SessionHandlingPage.selectedSession.petOwner.strName

        Dim total As Double = 0
        For Each petProcedureString In SessionHandlingPage.selectedSession.petWithProcedureList
            billRowsPanel.Controls.Add(New BillingRowPanel(petProcedureString))
            petType = petProcedureString.Split("#"c)(1)
            petProc = petProcedureString.Split("#"c)(2)
            total += computeTotalBill(petType, petProc)
        Next

        lblTotalFee.Text = ToPesoFormat(total)
    End Sub
End Class