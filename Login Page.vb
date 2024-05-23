Imports System.IO

Public Class Login_Page


    Private Sub btn_userLogin_Click(sender As Object, e As EventArgs) Handles btn_userLogin.Click
        Dim username As String = txt_userName.Text
        Dim password As String = txt_userPass.Text

        Dim fields() = {txt_userName, txt_userPass}

        Dim validFields As Boolean = ConflictChecker.checkForEmptyFields(fields)
        If validFields = False Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Log In")
            Exit Sub
        End If

        Dim databaseIsEmpty As Boolean = ConflictChecker.checkIfDatabaseIsEmpty(FileManipulator.accountsDatabaseFilePath)
        If databaseIsEmpty = True Then
            MsgBox("Database is empty. Please create an account first.", vbOKOnly + vbExclamation, "Log In")
            Exit Sub
        End If

        Dim petOwnerloggedIn As PetOwner = ConflictChecker.checkCredentialsAndGetPetOwner(username, password)
        If petOwnerloggedIn Is Nothing Then
            MsgBox("Invalid username or password.", vbOKOnly + vbExclamation, "Log In")
            Exit Sub
        End If

        activeAccount = petOwnerloggedIn
        activeAccount.petsList = FileManipulator.ReadPets(activeAccount)
        clearAllFields(fields)
        MessageBox.Show("Log-in Succesful!")
        loadActiveAccount(activeAccount)
        NavigatorPage.Show()
        NavigatorPage.btnHome.PerformClick()
        Me.Hide()
    End Sub



    Public Sub loadActiveAccount(activeAcc As PetOwner)
        NavigatorPage.btnProfileDisplayName.Text = activeAcc.strName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Signup_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLog_Page.Show()

        Me.Hide()
    End Sub

    Private Sub Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub
End Class
