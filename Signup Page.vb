Imports System.IO

Public Class Signup_Page

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        Dim username As String = txt_signUserName.Text
        Dim password As String = txt_signPassword.Text
        Dim name As String = txt_signName.Text
        Dim age As Integer = Val(txt_signAge.Text)
        Dim sex As String = txt_signSex.Text
        Dim address As String = txt_signAddress.Text

        Dim fields() = {txt_signUserName, txt_signPassword, txt_signName, txt_signAge, txt_signSex, txt_signAddress}

        Dim validFields As Boolean = ConflictChecker.checkForEmptyFields(fields)
        Dim validUsername As Boolean = ConflictChecker.checkForSameUsername(username)
        Dim validCharacters As Boolean = ConflictChecker.checkForInvalidCharacters(fields, "|")

        If validUsername = False Then
            MsgBox("Username already exists. PLease use another username.", vbOKOnly + vbExclamation, "Sign Up")
            txt_signUserName.Text = ""
            Exit Sub
        ElseIf validFields = False Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Sign Up")
            Exit Sub
        ElseIf validCharacters = False Then
            MsgBox("Please refrain from using these characters (|,#,%,*).", vbOKOnly + vbExclamation, "Sign Up")
            Exit Sub
        End If

        Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, Nothing)
        FileManipulator.SaveUser(petOwnerObject)
        clearAllFields(fields)
        MessageBox.Show("User created successfully!")
        Me.Hide()
        Login_Page.Show()
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLog_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Signup_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub
End Class


