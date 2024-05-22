Public Class SessionHandlingPage
    Dim sessionsList As List(Of Session)
    Public selectedSession As Session
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

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
            For Each aPetString In selectedSession.petWithProcedureList
                Dim petPanel As New SessionNextVisitPanel(aPetString)
                nextVisitFlowParentPanel.Controls.Add(petPanel)
            Next
        End If
    End Sub

    Private Sub loadListView()
        With lstViewSessions
            .Items.Clear()

            .View = View.Details
            .GridLines = True
            .FullRowSelect = True

            .Columns.Clear()
            .Columns.Add("Pet Owner", 80)
            .Columns.Add("Session Created", 150)

            sessionsList = FileManipulator.ReadSessions()
            counter = 0
            For Each session In sessionsList
                .Items.Add(session.petOwner.strName)
                .Items(counter).SubItems.Add(session.dateMade.Date)
                counter += 1
            Next
        End With
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles nextVisitFlowParentPanel.Paint

    End Sub

    Private Sub lstViewSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewSessions.SelectedIndexChanged
        loadPets()
        loadNextVisits()
    End Sub

    Private Sub btnBookAndPay_Click(sender As Object, e As EventArgs) Handles btnBookAndPay.Click
        Rcd_Page.childForm(Payment_Page)

        Payment_Page.loadPaymentPage()
    End Sub
End Class