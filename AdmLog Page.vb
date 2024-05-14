Imports System.IO
Public Class AdmLog_Page
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim validLogin As Boolean = False
        Dim databaseFilePath As String = "admindatabase.txt"

        If File.Exists(databaseFilePath) Then
            Dim lines() As String = File.ReadAllLines(databaseFilePath)

            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length = 6 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    validLogin = True
                    Exit For
                End If
            Next
        End If

        Return validLogin
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txt_admUsername.Text
        Dim password As String = txt_admPassword.Text

        If username = "admin" And password = "admin" Then
            Rcd_Page.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid input.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub AdmLog_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub

End Class