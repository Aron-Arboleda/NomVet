Imports System.IO

Public Class Login_Page
    Public isClosing As Boolean = False
    Public activeAccount As PetOwner
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim validLogin As Boolean = False

        Dim lines() As String = readData("database.txt")
        Dim petOwnerObject As PetOwner = findPetOwner(lines, username, password)
        If Not (petOwnerObject Is Nothing) Then
            validLogin = True
            activeAccount = petOwnerObject
        End If

        Return validLogin
    End Function

    Public Function findPetOwner(lines() As String, username As String, password As String) As PetOwner
        Dim petOwnerObject As PetOwner
        For Each line As String In lines
            petOwnerObject = parseAsPetOwner(line)
            If petOwnerObject.getUsername = username AndAlso petOwnerObject.getPassword = password Then
                Return petOwnerObject
            End If
        Next
        Return Nothing
    End Function

    Public Function readData(fileName As String)
        Dim lines() As String
        If File.Exists(fileName) Then
            lines = File.ReadAllLines(fileName)
        Else
            MessageBox.Show("No database file found.")
        End If
        Return lines
    End Function

    Public Function parseAsPetOwner(line As String) As PetOwner
        Dim parsedStringsList() As String = line.Split(","c)
        Dim username = parsedStringsList(0)
        Dim password = parsedStringsList(1)
        Dim name = parsedStringsList(2)
        Dim age = parsedStringsList(3)
        Dim sex = parsedStringsList(4)
        Dim address = parsedStringsList(5)
        Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, Nothing)
        Return petOwnerObject
    End Function



    Private Sub btn_userLogin_Click(sender As Object, e As EventArgs) Handles btn_userLogin.Click
        Dim username As String = txt_userName.Text
        Dim password As String = txt_userPass.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            If ValidateLogin(username, password) Then
                HomePage.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Else
            MessageBox.Show("Please enter both username and password.")
        End If
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
        If (isClosing = False) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                isClosing = True
                ' Close all forms and terminate the application
                Application.Exit()
            Else
                ' Cancel the form closing
                e.Cancel = True
            End If
        End If
    End Sub
End Class
