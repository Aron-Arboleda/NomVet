Imports System.IO

Public Class Signup_Page
    Dim databaseFilePath As String
    Sub createDataBaseFile(filename As String)
        databaseFilePath = filename

        If Not File.Exists(databaseFilePath) Then
            File.Create(databaseFilePath).Dispose()
        End If
    End Sub
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        Dim username As String = txt_signUserName.Text
        Dim password As String = txt_signPassword.Text
        Dim name As String = txt_signName.Text
        Dim age As Integer = Convert.ToInt16(txt_signAge.Text)
        Dim sex As String = txt_signSex.Text
        Dim address As String = txt_signAddress.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso
           Not String.IsNullOrEmpty(name) AndAlso Not String.IsNullOrEmpty(age) AndAlso
           Not String.IsNullOrEmpty(sex) AndAlso Not String.IsNullOrEmpty(address) Then

            Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, Nothing)
            SaveUser(petOwnerObject)
            MessageBox.Show("User created successfully!")
            Me.Hide()
            Login_Page.Show()
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub

    Public Shared Function ReadPetOwners()
        Dim petOwnersList As List(Of String)
        Using reader As New System.IO.StreamReader("database.txt")
            Dim line As String
            Do While reader.Peek() >= 0
                line = reader.ReadLine()
                petOwnersList.Add(line)
            Loop
        End Using
        Return petOwnersList
    End Function


    Private Sub SaveUser(petOwnerObject As PetOwner)
        createDataBaseFile(petOwnerObject.getUsername & ".txt")
        Using writer As StreamWriter = File.AppendText("database.txt")
            writer.WriteLine(petOwnerObject.getUsername & "," & petOwnerObject.getPassword & "," & petOwnerObject.strName & "," & petOwnerObject.intAge & "," & petOwnerObject.strSex & "," & petOwnerObject.strAddress)
        End Using
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
        If (Login_Page.isClosing = False) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Login_Page.isClosing = True
                ' Close all forms and terminate the application
                Application.Exit()
            Else
                ' Cancel the form closing
                e.Cancel = True
            End If
        End If
    End Sub
End Class

Public Class PetOwner
    Private strUsername As String
    Private strPassword As String
    Public strName As String
    Public intAge As Integer
    Public strSex As String
    Public strAddress As String
    Public petsList As List(Of Pet)

    Public Sub New(ByVal strUsername As String, ByVal strPassword As String, ByVal strName As String, ByVal intAge As Integer, ByVal strSex As String, ByVal strAddress As String, ByVal petsList As List(Of Pet))
        Me.strUsername = strUsername
        Me.strPassword = strPassword
        Me.strName = strName
        Me.intAge = intAge
        Me.strSex = strSex
        Me.strAddress = strAddress
        Me.petsList = petsList
    End Sub

    Public Function getUsername()
        Return strUsername
    End Function

    Public Function getPassword()
        Return strPassword
    End Function

    Public Sub SavePets()
        Using writer As StreamWriter = File.AppendText(strUsername + ".txt")
            For Each pet In petsList
                writer.WriteLine(pet.strName & "," & pet.intAge & "," & pet.strBirthday & "," & pet.dblWeight & "," & pet.strType & "," & pet.boolVaccinated)
            Next
        End Using
    End Sub

End Class

Public Class Pet
    Public strName As String
    Public intAge As Integer
    Public strBirthday As String
    Public dblWeight As Double
    Public strType As String
    Public boolVaccinated As Boolean

    Public Sub New(ByVal strName As String, ByVal intAge As Integer, ByVal strBirthday As String, ByVal dblWeight As Double, ByVal strType As String, boolVaccinated As Boolean)
        Me.strName = strName
        Me.intAge = intAge
        Me.strBirthday = strBirthday
        Me.dblWeight = dblWeight
        Me.strType = strType
        Me.boolVaccinated = boolVaccinated
    End Sub
End Class
