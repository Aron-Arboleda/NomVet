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

    Private Function GetAllInputControls(parentControl As Control) As List(Of Control)
        Dim inputControls As New List(Of Control)

        For Each control As Control In parentControl.Controls
            If TypeOf control Is TextBox OrElse
               TypeOf control Is ComboBox OrElse
               TypeOf control Is NumericUpDown Then
                inputControls.Add(control)
            End If

            If control.Controls.Count > 0 Then
                inputControls.AddRange(GetAllInputControls(control))
            End If
        Next

        Return inputControls
    End Function

    Private Function checkIfControlsTextIsEmpty(inputControls As List(Of Control)) As Boolean
        Dim emptyFields As Boolean = False

        For Each control As Control In inputControls
            If control.Text = "" Then
                emptyFields = True
                Exit For
            End If
        Next

        Return emptyFields
    End Function

    Private Sub btnAddPetInput_Click(sender As Object, e As EventArgs) Handles btnAddPetInput.Click
        Dim petPanel As New WalkInPetInputPanel
        petFormPanel.Controls.Add(petPanel)
        walkinListOfPetsInput.Add(petPanel)
    End Sub

    Private Sub btnSaveSession_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        'Dim petOwnerfields() As Control = {txtPetOwnerName, cbPetOwnerSex, txtPetOwnerAddress, txtPetOwnerUsername, txtPetOwnerPassword}
        'Dim petOwnerValidFields As Boolean = ConflictChecker.checkForEmptyFields(petOwnerfields)
        'If petOwnerValidFields = False Then
        '    MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Walk In Form")
        '    Exit Sub
        'End If

        'Dim petfieldsList() = walkinListOfPetsInput.Select(Function(panel) panel.txtPetName).ToArray()
        'Dim petValidFields As Boolean = ConflictChecker.checkForEmptyFields(petfieldsList)
        'If petValidFields = False Then
        '    MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Walk In Form")
        '    Exit Sub
        'End If
        Dim inputControls As List(Of Control) = GetAllInputControls(parentPanelInput)
        Dim fieldsAreEmpty As Boolean = checkIfControlsTextIsEmpty(inputControls)
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