Public Class SessionHandlingPage
    Dim sessionsList As List(Of Session)
    Public selectedSession As Session

    Public nextVisitPanelsList As List(Of SessionNextVisitPanel)
    Public nextVisitsList As New List(Of NextVisit)

    Public Sub loadSessionHandlingPage()
        loadListView()
        lblPetOwner.Text = "N/A"
        petsAndProceduresPanel.Controls.Clear()
        nextVisitFlowParentPanel.Controls.Clear()
    End Sub

    Public Sub loadPets()
        petsAndProceduresPanel.Controls.Clear()
        lblPetOwner.Text = "N/A"
        If lstViewSessions.SelectedIndices.Count > 0 Then
            selectedSession = sessionsList.Item(lstViewSessions.SelectedIndices.Item(0))
            lblPetOwner.Text = selectedSession.petOwner.strName
            For Each aPetString In selectedSession.petWithProcedureList
                Dim petPanel As New SessionPetPanel(aPetString)
                petsAndProceduresPanel.Controls.Add(petPanel)
            Next
        End If
    End Sub

    Public Sub loadNextVisits()
        nextVisitFlowParentPanel.Controls.Clear()
        If lstViewSessions.SelectedIndices.Count > 0 Then
            selectedSession = sessionsList.Item(lstViewSessions.SelectedIndices.Item(0))
            Dim nVPanelsList As New List(Of SessionNextVisitPanel)
            For Each aPetString In selectedSession.petWithProcedureList
                Dim petPanel As New SessionNextVisitPanel(aPetString)
                nVPanelsList.Add(petPanel)
                nextVisitFlowParentPanel.Controls.Add(petPanel)
            Next
            nextVisitPanelsList = nVPanelsList
            reloadAllDateTimePicker(nextVisitPanelsList)
        End If
    End Sub

    Public Sub reloadAllDateTimePicker(nextVisitPanelsList As List(Of SessionNextVisitPanel))
        For Each nvPanel In nextVisitPanelsList
            SessionNextVisitPanel.checkIfDatePickedIsValid(nvPanel.dtpNextVisitDate, nvPanel.lblErrorMessage)
        Next
    End Sub

    Private Sub loadListView()
        With lstViewSessions
            .Items.Clear()

            .View = View.Details
            .GridLines = True
            .FullRowSelect = True

            .Columns.Clear()
            .Columns.Add("ID", 40)
            .Columns.Add("Pet Owner", 80)
            .Columns.Add("Date of Session", 120)

            sessionsList = FileManipulator.ReadSessions()
            counter = 0
            For Each session In sessionsList
                .Items.Add(session.sessionCodeId)
                .Items(counter).SubItems.Add(session.petOwner.strName)
                .Items(counter).SubItems.Add(session.dateMade.Date)
                counter += 1
            Next
        End With
    End Sub

    Private Sub lstViewSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewSessions.SelectedIndexChanged
        loadPets()
        loadNextVisits()
    End Sub

    Private Sub btnBookAndPay_Click(sender As Object, e As EventArgs) Handles btnBookAndPay.Click
        Dim inputControls As List(Of Control) = GetAllInputControls(Me)
        Dim fieldsAreEmpty As Boolean = ConflictChecker.checkIfControlsTextIsEmpty(inputControls)
        If fieldsAreEmpty Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Walk In Form")
            Exit Sub
        End If


        Rcd_Page.childForm(Payment_Page)
        storeNextVisitsTemporarily()
        Payment_Page.loadPaymentPage()
    End Sub

    Public Sub storeNextVisitsTemporarily()
        If lstViewSessions.SelectedIndices.Count > 0 Then
            nextVisitsList.Clear()
            For Each nvPanel In nextVisitPanelsList
                nextVisitsList.Add(nvPanel.getNextVistObject())
            Next
        End If
    End Sub

End Class

