Imports System.IO

Public Class Login_Page


    Private Sub btn_userLogin_Click(sender As Object, e As EventArgs) Handles btn_userLogin.Click
        Dim username As String = txt_userName.Text
        Dim password As String = txt_userPass.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            If FileManipulator.ValidateLogin(username, password) Then
                activeAccount.petsList = FileManipulator.ReadPets(activeAccount)
                loadActiveAccount(activeAccount)
                NavigatorPage.Show()
                NavigatorPage.btnHome.PerformClick()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Else
            MessageBox.Show("Please enter both username and password.")
        End If
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
