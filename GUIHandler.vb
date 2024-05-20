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

    Public Class RegisterPetPanel
        Inherits TableLayoutPanel

        Public petObject As Pet

        Public Sub New()
            Me.petObject = petObject

            Me.BackColor = Color.White
            Me.Size = New System.Drawing.Size(957, 70)
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.Margin = New Padding(0, 0, 0, 5)
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            Me.ColumnCount = 6
            Me.RowCount = 2

            For i As Integer = 1 To Me.ColumnCount
                Me.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            Next

            For i As Integer = 1 To Me.RowCount
                Me.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Next

            'Labels
            Dim lblPetName As New PetLabel
            lblPetName.Text = "Pet Name:"
            Dim lblPetProcedure As New PetLabel
            lblPetProcedure.Text = "Pet Birthday: "
            Dim lblPetAppointment As New PetLabel
            lblPetAppointment.Text = "Type: "
            Dim lblPetAge As New PetLabel
            lblPetAge.Text = "Pet Age:"
            Dim lblPetWeight As New PetLabel
            lblPetWeight.Text = "Pet Weight(kg):"
            Dim lblPetVaccineStatus As New PetLabel
            lblPetVaccineStatus.Text = "Vaccine Status: "

            Dim PetLabels() As PetLabel = {lblPetName, lblPetProcedure, lblPetAppointment, lblPetAge, lblPetWeight, lblPetVaccineStatus}


            'Inputs
            Dim txtPetName As New TextBox
            txtPetName.Size = New System.Drawing.Size(155, 26)
            Dim dtpPetBirthday As New DateTimePicker
            dtpPetBirthday.Size = New System.Drawing.Size(196, 20)
            Dim cbPetType As New ComboBox
            cbPetType.Size = New System.Drawing.Size(145, 28)
            cbPetType.Items.Add("Feline")
            cbPetType.Items.Add("Canine")
            cbPetType.Items.Add("Reptile")
            Dim numPetAge As New NumericUpDown
            numPetAge.Size = New System.Drawing.Size(64, 20)
            Dim numPetWeight As New NumericUpDown
            numPetWeight.Size = New System.Drawing.Size(64, 20)
            Dim cbPetVacStatus As New ComboBox
            cbPetVacStatus.Size = New System.Drawing.Size(150, 28)
            cbPetVacStatus.Items.Add("Complete")
            cbPetVacStatus.Items.Add("Incomplete")

            With Me
                For i = 0 To PetLabels.Length - 1
                    PetLabels(i).AutoSize = True
                    PetLabels(i).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                    .Controls.Add(PetLabels(i), i, 0)
                Next
                .Controls.Add(txtPetName, 0, 1)
                .Controls.Add(dtpPetBirthday, 1, 1)
                .Controls.Add(cbPetType, 2, 1)
                .Controls.Add(numPetAge, 3, 1)
                .Controls.Add(numPetWeight, 4, 1)
                .Controls.Add(cbPetVacStatus, 5, 1)
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
