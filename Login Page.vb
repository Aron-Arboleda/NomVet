Imports System.IO

Public Class Login_Page
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim validLogin As Boolean = False
        Dim databaseFilePath As String = "database.txt"

        If File.Exists(databaseFilePath) Then
            Dim lines() As String = File.ReadAllLines(databaseFilePath)

            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length = 6 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    validLogin = True
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("No database file found.")
        End If

        Return validLogin
    End Function

    Private Sub btn_userLogin_Click(sender As Object, e As EventArgs) Handles btn_userLogin.Click
        Dim username As String = txt_userName.Text
        Dim password As String = txt_userPass.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            If ValidateLogin(username, password) Then
                HomePage.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Else
            MessageBox.Show("Please enter both username and password.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Signup_Page.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLog_Page.Show()
        Me.Close()
    End Sub
End Class
