﻿Imports System.IO

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
        Dim age As String = txt_signAge.Text
        Dim sex As String = txt_signSex.Text
        Dim address As String = txt_signAddress.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso
           Not String.IsNullOrEmpty(name) AndAlso Not String.IsNullOrEmpty(age) AndAlso
           Not String.IsNullOrEmpty(sex) AndAlso Not String.IsNullOrEmpty(address) Then

            SaveUser(username, password, name, age, sex, address)
            MessageBox.Show("User created successfully!")
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub

    Private Sub SaveUser(username As String, password As String, name As String, age As String, sex As String, address As String)
        createDataBaseFile(username & ".txt")
        Using writer As StreamWriter = File.AppendText("database.txt")
            writer.WriteLine(username & "," & password & "," & name & "," & age & "," & sex & "," & address)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login_Page.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLog_Page.Close()
        Me.Close()
    End Sub
End Class