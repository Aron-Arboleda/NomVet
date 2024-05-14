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
        closingApplication(e)
    End Sub
End Class


