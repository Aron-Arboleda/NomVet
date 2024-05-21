Public Class Profile_Page
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblPetOwnerName.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Sub loadProfile()
        lblPetOwnerName.Text = activeAccount.strName
        lblPetOwnerAge.Text = activeAccount.intAge
        lblPetOwnerSex.Text = activeAccount.strSex
        lblPetOwnerAddress.Text = activeAccount.strAddress
        Dim lines() As String = FileManipulator.readData(activeAccount.getUsername() & ".txt")
        lblPetOwnerNumPets.Text = lines.Length

        If lines.Length > 0 Then
            registeredPetsPanel.Controls.Clear()
            schedulesPanel.Controls.Clear()
            For Each line In lines
                Dim petObject As Pet = FileManipulator.parseAsPet(line)
                Dim petPanel As New PetPanel(petObject)
                'Dim apptPanel As New AppointmentPanel(petObject)
                With registeredPetsPanel
                    .Controls.Add(petPanel)
                End With
                With schedulesPanel
                    '.Controls.Add(apptPanel)
                End With
            Next
        Else
            registeredPetsPanel.Controls.Clear()
            schedulesPanel.Controls.Clear()
            Dim noPetsLabel As New Label()
            noPetsLabel.Text = "No Registered Pets"
            noPetsLabel.ForeColor = Color.White
            noPetsLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            noPetsLabel.Margin = New Padding(15, 15, 0, 0)
            noPetsLabel.AutoSize = True

            Dim noApptsLabel As New Label()
            noApptsLabel.Text = "No Appointment Schedules"
            noApptsLabel.ForeColor = Color.White
            noApptsLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            noApptsLabel.Margin = New Padding(15, 15, 0, 0)
            noApptsLabel.AutoSize = True

            With registeredPetsPanel
                .Controls.Add(noPetsLabel)
            End With
            With schedulesPanel
                .Controls.Add(noApptsLabel)
            End With
        End If

        'Dim tempPanel As New Panel
        'tempPanel.BackColor = Color.White
        'tempPanel.Size = New System.Drawing.Size(50, 50)


    End Sub

    Private Sub btnBackToHome_Click(sender As Object, e As EventArgs) Handles btnBackToHome.Click
        Login_Page.Show()
        NavigatorPage.Hide()
    End Sub
End Class