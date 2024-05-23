Public Class WalkInForm
    Public walkinListOfPetsInput As New List(Of WalkInPetInputPanel)

    Public Sub loadWalkInForm()
        clearFields()
        petFormPanel.Controls.Clear()

        Dim petPanel As New WalkInPetInputPanel
        petFormPanel.Controls.Add(petPanel)
        walkinListOfPetsInput.Add(petPanel)
    End Sub

    Public Sub clearFields()
        txtPetOwnerName.Clear()
        txtPetOwnerAddress.Clear()
        cbPetOwnerSex.Text = ""
        txtPetOwnerUsername.Clear()
        txtPetOwnerPassword.Clear()
        numUIPetOwnerAge.Value = 0
    End Sub




    Private Sub btnAddPetInput_Click(sender As Object, e As EventArgs) Handles btnAddPetInput.Click
        Dim petPanel As New WalkInPetInputPanel
        petFormPanel.Controls.Add(petPanel)
        walkinListOfPetsInput.Add(petPanel)
    End Sub

    Private Sub btnSaveSession_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        Dim inputControls As List(Of Control) = GetAllInputControls(parentPanelInput)
        Dim fieldsAreEmpty As Boolean = ConflictChecker.checkIfControlsTextIsEmpty(inputControls)
        If fieldsAreEmpty Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Walk In Form")
            Exit Sub
        End If

        Dim petOwnerName As String = txtPetOwnerName.Text
        Dim petOwnerAge As Integer = numUIPetOwnerAge.Text
        Dim petOwnerSex As String = cbPetOwnerSex.SelectedItem
        Dim petOwnerAddress As String = txtPetOwnerAddress.Text
        Dim petOwnerUsername As String = txtPetOwnerUsername.Text
        Dim petOwnerPassword As String = txtPetOwnerPassword.Text

        Dim petOwnerListOfPets As New List(Of Pet)
        Dim petWithProcedureList As New List(Of String)

        For Each petPanel As WalkInPetInputPanel In walkinListOfPetsInput
            petOwnerListOfPets.Add(petPanel.getPetObject())
            petWithProcedureList.Add(Session.createPetProcedure(petPanel.txtPetName.Text, petPanel.cbPetType.SelectedItem.ToString, petPanel.cbPetProcedure.SelectedItem))
        Next

        Dim petOwner As New PetOwner(petOwnerUsername, petOwnerPassword, petOwnerName, petOwnerAge, petOwnerSex, petOwnerAddress, petOwnerListOfPets)
        FileManipulator.SavePetOwner(petOwner)

        Dim sessionObj As New Session(Session.ranCode, petOwner, Date.Now, petWithProcedureList)
        FileManipulator.SaveSession(sessionObj)

        MsgBox("Information Saved.", vbOKOnly + vbInformation, "NOMVC Saving")
        loadWalkInForm()
    End Sub
End Class