Public Class Payment_Page
    Dim total As Double = 0
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Rcd_Page.childForm(SessionHandlingPage)
        SessionHandlingPage.loadSessionHandlingPage()
    End Sub

    Private Sub btnPayAndShowReceipt_Click(sender As Object, e As EventArgs) Handles btnPayAndShowReceipt.Click
        Dim validPayment As Boolean = checkIfPaymentIsValid(Val(txtPayment.Text))
        If validPayment = False Then
            MsgBox("Insufficient funds.", vbOKOnly + vbExclamation, "Payment")
            txtPayment.Clear()
            Exit Sub
        End If

        Rcd_Page.childForm(WalkInReceiptPage)
        WalkInReceiptPage.loadWalkInReceiptPage()
        updatePets(SessionHandlingPage.selectedSession.petOwner.strName, SessionHandlingPage.nextVisitsList)
        updateSessions(SessionHandlingPage.selectedSession)
        makeNewSessionOrBookIfNeeded(SessionHandlingPage.nextVisitsList)
    End Sub

    Public Function checkIfPaymentIsValid(payment As Double)
        Dim valid As Boolean = True
        If payment < total Then
            valid = False
            Return valid
        End If
        Return valid
    End Function

    Public Sub makeNewSessionOrBookIfNeeded(nextVisitsList As List(Of NextVisit))
        For Each nextVisit In nextVisitsList
            If nextVisit.boolNextVisit = True Then
                Dim selectedSession As Session = SessionHandlingPage.selectedSession

                Dim id As String = GenerateRandomString(5)
                Dim petOwner As String = selectedSession.petOwner.strName
                Dim pet As String = nextVisit.petName
                Dim procedure As String = nextVisit.procedure
                Dim dateOfNextVisit As String = nextVisit.dateOfNextVisit
                Dim appointment As New Appointment(id, petOwner, pet, procedure, dateOfNextVisit)
                FileManipulator.SaveBooking(appointment)

                Dim owner As PetOwner = FileManipulator.findPetOwnerWithName(petOwner)
                Dim petsProclist As New List(Of String)
                For Each nv In nextVisitsList
                    If nv.boolNextVisit = True Then
                        For Each petProc In selectedSession.petWithProcedureList
                            Dim petType = petProc.Split("#"c)(1)
                            If petProc.Split("#"c)(0) = nv.petName Then
                                petsProclist.Add(Session.createPetProcedure(nv.petName, petType, procedure))
                                Exit For
                            End If
                        Next

                    End If
                Next
                Dim sessionObj As New Session(id, owner, dateOfNextVisit, petsProclist)
                FileManipulator.SaveSession(sessionObj)
            End If
        Next
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
            If s.sessionCodeId = session.sessionCodeId Then
                updateAppointments(s.sessionCodeId)
                sessions.Remove(s)
                Exit For
            End If
        Next
        FileManipulator.SaveSessions(sessions)
    End Sub

    Public Sub updateAppointments(ByVal sessionId As String)
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

        total = 0
        For Each petProcedureString In SessionHandlingPage.selectedSession.petWithProcedureList
            billRowsPanel.Controls.Add(New BillingRowPanel(petProcedureString))
            petType = petProcedureString.Split("#"c)(1)
            petProc = petProcedureString.Split("#"c)(2)
            total += computeTotalBill(petType, petProc)
        Next

        lblTotalFee.Text = ToPesoFormat(total)
        txtPayment.Clear()
    End Sub
End Class