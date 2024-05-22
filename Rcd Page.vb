Imports System.Diagnostics.Eventing.Reader

Public Class Rcd_Page
    Sub childForm(ByVal panel As Form)
        rcdDisplayPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        rcdDisplayPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Rcd_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rcd_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub

    Private Sub btnWalkinForm_Click(sender As Object, e As EventArgs) Handles btnWalkinForm.Click
        childForm(WalkInForm)
        WalkInForm.loadWalkInForm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        childForm(SessionHandlingPage)

        SessionHandlingPage.loadSessionHandlingPage()

    End Sub

    Private Sub btnLoginPage_Click(sender As Object, e As EventArgs) Handles btnLoginPage.Click
        Me.Hide()
        Login_Page.Show()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        childForm(AdminRecordsPage)
        AdminRecordsPage.loadAdminRecordsPage()
    End Sub
End Class