Public Class RegisterPetsPage
    Public petPanelsList As New List(Of RegisterPetPanel)

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Dim petPanel As New RegisterPetPanel
        petInputPanel.Controls.Add(petPanel)
        petPanelsList.Add(petPanel)
    End Sub

    Private Sub btnRegisterPets_Click(sender As Object, e As EventArgs) Handles btnRegisterPets.Click
        Dim inputControls As List(Of Control) = GetAllInputControls(petInputPanel)
        Dim fieldsAreEmpty As Boolean = ConflictChecker.checkIfControlsTextIsEmpty(inputControls)
        If fieldsAreEmpty Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Pet Registration")
            Exit Sub
        End If

        Dim registeredPetsList As New List(Of Pet)
        For Each petPanel In petPanelsList
            registeredPetsList.Add(petPanel.getPetObject())
        Next
        activeAccount.petsList = registeredPetsList

        FileManipulator.SavePets(activeAccount)
        MsgBox("Pets Registered!", vbOKOnly + vbInformation, "Pet Registration")
    End Sub

    Public Sub loadRegisterPetsPage()
        NavigatorPage.childForm(Me)
        Me.petInputPanel.Controls.Clear()
        petPanelsList.Clear()
        If activeAccount.petsList.Count = 0 Then
            Dim petPanel As RegisterPetPanel = New RegisterPetPanel()
            Me.petInputPanel.Controls.Add(petPanel)
            Me.petPanelsList.Add(petPanel)
        Else
            For Each pet In activeAccount.petsList
                Dim petPanel As RegisterPetPanel = New RegisterPetPanel()
                Me.petInputPanel.Controls.Add(petPanel)
                petPanel.setPetObject(pet)
                Me.petPanelsList.Add(petPanel)
            Next
        End If
    End Sub
End Class
