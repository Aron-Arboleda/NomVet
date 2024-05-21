Public Class WalkInForm
    Public walkinListOfPetsInput As New List(Of WalkInPetInputPanel)

    Private Sub WalkInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
            petWithProcedureList.Add(petPanel.txtPetName.Text & "#" & petPanel.cbPetType.SelectedItem.ToString & "#" & petPanel.cbPetProcedure.SelectedItem)
        Next

        Dim petOwner As New PetOwner(petOwnerUsername, petOwnerPassword, petOwnerName, petOwnerAge, petOwnerSex, petOwnerAddress, petOwnerListOfPets)
        FileManipulator.SavePetOwner(petOwner)



        Dim session As New Session(petOwner, Date.Now, petWithProcedureList)
        FileManipulator.SaveSession(session)

        MsgBox("Information Saved.", vbOKOnly + vbInformation, "NOMVC Saving")
        loadWalkInForm()
    End Sub
End Class