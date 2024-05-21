Public Class SessionHandlingPage
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxPendingSessions.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Public Sub loadSessionHandlingPage()
        lstBoxPendingSessions.Items.Clear()

        Dim sessionsList As List(Of Session) = FileManipulator.ReadSessions()
        For Each session In sessionsList
            lstBoxPendingSessions.Items.Add("Name: " & session.petOwner.strName & " | " & session.dateMade.Date)
        Next

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class