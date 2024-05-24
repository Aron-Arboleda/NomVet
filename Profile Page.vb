Public Class Profile_Page

    Sub loadProfile()
        Dim lines() As String = FileManipulator.readData(activeAccount.getUsername() & ".txt")
        Dim listOfBookings As List(Of Appointment) = FileManipulator.ReadBookings(activeAccount.strName)
        lblPetOwnerName.Text = activeAccount.strName
        lblPetOwnerAge.Text = activeAccount.intAge
        lblPetOwnerSex.Text = activeAccount.strSex
        lblPetOwnerAddress.Text = activeAccount.strAddress
        lblPetOwnerNumPets.Text = lines.Length

        registeredPetsPanel.Controls.Clear()
        schedulesPanel.Controls.Clear()

        Dim noPetsLabel As Label

        If lines.Length > 0 Then
            For Each line In lines
                Dim petObject As Pet = FileManipulator.parseAsPet(line)
                Dim petPanel As New PetPanel(petObject)
                registeredPetsPanel.Controls.Add(petPanel)
            Next
        Else
            noPetsLabel = New Label()
            noPetsLabel.Text = "No Registered Pets"
            noPetsLabel.ForeColor = Color.White
            noPetsLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            noPetsLabel.Margin = New Padding(15, 15, 0, 0)
            noPetsLabel.AutoSize = True
            registeredPetsPanel.Controls.Add(noPetsLabel)
        End If

        If listOfBookings.Count > 0 Then
            For Each booking In listOfBookings
                Dim apptPanel As New AppointmentPanel(booking)
                schedulesPanel.Controls.Add(apptPanel)
            Next
        Else
            Dim noApptsLabel As New Label()
            noApptsLabel.Text = "No Appointment Schedules"
            noApptsLabel.ForeColor = Color.White
            noApptsLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            noApptsLabel.Margin = New Padding(15, 15, 0, 0)
            noApptsLabel.AutoSize = True
            schedulesPanel.Controls.Add(noApptsLabel)
        End If
    End Sub

    Private Sub btnBackToHome_Click(sender As Object, e As EventArgs) Handles btnBackToHome.Click
        Login_Page.Show()
        NavigatorPage.Hide()
    End Sub
End Class

