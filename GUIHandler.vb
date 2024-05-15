Module GUIHandler
    Public isClosing As Boolean = False
    Public activeAccount As PetOwner = Nothing

    Public Sub closingApplication(e As FormClosingEventArgs)
        If (isClosing = False) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                isClosing = True
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Public Class PetPanel
        Inherits FlowLayoutPanel

        Public petObject As Pet
        Public Sub New(petObject As Pet)
            Me.petObject = petObject

            Me.BackColor = Color.White
            Me.Size = New System.Drawing.Size(645, 55)
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.Margin = New Padding(0, 10, 0, 10)


            Dim lblPetName As New PetLabel
            lblPetName.Text = "Name: " & petObject.strName
            Dim lblPetType As New PetLabel
            lblPetType.Text = petObject.strType.ToUpper()
            Dim lblPetBday As New PetLabel
            lblPetBday.Text = "Birthdate: " & petObject.dateBirthday
            Dim lblPetAge As New PetLabel
            lblPetAge.Text = petObject.intAge & " yr(s) old"
            Dim lblPetWeight As New PetLabel
            lblPetWeight.Text = petObject.dblWeight & " kg"
            Dim lblPetVaccineStatus As New PetLabel
            lblPetVaccineStatus.Text = "Vaccine Status: " & petObject.boolVaccinated
            Dim lblPetProcedure As New PetLabel
            lblPetProcedure.Text = "Procedure: " & petObject.strProcedure
            Dim lblPetAppointment As New PetLabel
            lblPetAppointment.Text = "Date of Appointment: " & petObject.dateAppointment

            With Me
                .Controls.Add(lblPetName)
                .Controls.Add(lblPetType)
                .Controls.Add(lblPetBday)
                .Controls.Add(lblPetAge)
                .Controls.Add(lblPetWeight)
                .Controls.Add(lblPetVaccineStatus)
                .Controls.Add(lblPetProcedure)
                .Controls.Add(lblPetAppointment)
            End With
        End Sub

    End Class

    Public Class AppointmentPanel
        Inherits FlowLayoutPanel

        Public petObject As Pet
        Public Sub New(petObject As Pet)
            Me.petObject = petObject

            Me.BackColor = Color.White
            Me.Size = New System.Drawing.Size(645, 40)
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.Margin = New Padding(0, 10, 0, 10)


            Dim lblPetName As New PetLabel
            lblPetName.Text = "Pet: " & petObject.strName
            Dim lblPetProcedure As New PetLabel
            lblPetProcedure.Text = "Procedure: " & petObject.strProcedure
            Dim lblPetAppointment As New PetLabel
            lblPetAppointment.Text = "Date of Appointment: " & petObject.dateAppointment.ToString("MMMM d, yyyy")

            With Me
                .Controls.Add(lblPetName)
                .Controls.Add(lblPetProcedure)
                .Controls.Add(lblPetAppointment)
            End With
        End Sub

    End Class

    Public Class PetLabel
        Inherits Label

        Public Sub New()
            Me.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
            Me.AutoSize = True
        End Sub
    End Class


End Module
