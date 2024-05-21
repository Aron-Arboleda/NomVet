Public Module GUIHandler
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
        Inherits TableLayoutPanel

        Public petObject As Pet
        Public Sub New(petObject As Pet)
            Me.petObject = petObject

            Me.BackColor = Color.FromArgb(251, 254, 249)
            Me.AutoSize = True
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            Me.ColumnCount = 1
            Me.RowCount = 2


            Dim lblPetName As New PetLabel
            lblPetName.Text = petObject.strName
            lblPetName.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
            lblPetName.AutoSize = True
            lblPetName.Anchor = AnchorStyles.Bottom

            Me.Controls.Add(lblPetName, 0, 0)


            Dim lblTypeLabel As New PetLabel
            lblTypeLabel.Text = "Type:"
            Dim lblTypeValue As New PetLabel
            lblTypeValue.Text = petObject.strType.ToUpper()

            Dim lblBdayLabel As New PetLabel
            lblBdayLabel.Text = "Birthdate:"
            Dim lblBdayValue As New PetLabel
            lblBdayValue.Text = petObject.dateBirthday

            Dim lblAgeLabel As New PetLabel
            lblAgeLabel.Text = "Age:"
            Dim lblAgeValue As New PetLabel
            lblAgeValue.Text = petObject.intAge & " yr(s) old"

            Dim lblWeightLabel As New PetLabel
            lblWeightLabel.Text = "Weight:"
            Dim lblWeightValue As New PetLabel
            lblWeightValue.Text = petObject.dblWeight & " kg"

            Dim lblPetStatusLabel As New PetLabel
            lblPetStatusLabel.Text = "Vac Status:"
            Dim lblPetStatusValue As New PetLabel
            lblPetStatusValue.Text = petObject.boolVaccinated


            Dim PetLabels() As PetLabel = {lblTypeLabel, lblBdayLabel, lblAgeLabel, lblWeightLabel, lblPetStatusLabel}
            Dim PetValues() As PetLabel = {lblTypeValue, lblBdayValue, lblAgeValue, lblWeightValue, lblPetStatusValue}

            Dim propertiesPanel As New TableLayoutPanel
            propertiesPanel.Size = New System.Drawing.Size(170, 107)
            propertiesPanel.Padding = New Padding(5, 5, 5, 5)
            propertiesPanel.ColumnCount = 2
            propertiesPanel.RowCount = 5

            Me.Controls.Add(propertiesPanel, 0, 1)

            With propertiesPanel
                For i = 0 To PetLabels.Length - 1
                    PetLabels(i).AutoSize = True
                    PetLabels(i).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                    .Controls.Add(PetLabels(i), 0, i)

                    PetValues(i).AutoSize = True
                    PetValues(i).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                    .Controls.Add(PetValues(i), 1, i)
                Next
            End With
        End Sub

    End Class

    Public Class AppointmentPanel
        Inherits FlowLayoutPanel

        Public appointment As Appointment
        Public Sub New(appointment As Appointment)
            Me.appointment = appointment

            Me.BackColor = Color.White
            Me.Size = New System.Drawing.Size(645, 40)
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.Margin = New Padding(0, 10, 0, 10)


            Dim lblPetName As New PetLabel
            lblPetName.Text = "Pet: " & appointment.pet
            Dim lblPetProcedure As New PetLabel
            lblPetProcedure.Text = "Procedure: " & appointment.strProcedure
            Dim lblPetAppointment As New PetLabel
            lblPetAppointment.Text = "Date of Appointment: " & appointment.dateAppointment.ToString("MMMM d, yyyy")

            With Me
                .Controls.Add(lblPetName)
                .Controls.Add(lblPetProcedure)
                .Controls.Add(lblPetAppointment)
            End With
        End Sub

    End Class

    Public Class RegisterPetPanel
        Inherits TableLayoutPanel

        Public lblPetName As New PetLabel
        Public lblPetProcedure As New PetLabel
        Public lblPetAppointment As New PetLabel
        Public lblPetAge As New PetLabel
        Public lblPetWeight As New PetLabel
        Public lblPetVaccineStatus As New PetLabel

        Public txtPetName As New TextBox
        Public dtpPetBirthday As New DateTimePicker
        Public cbPetType As New ComboBox
        Public numPetAge As New NumericUpDown
        Public numPetWeight As New NumericUpDown
        Public cbPetVacStatus As New ComboBox

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

            lblPetName.Text = "Pet Name:"
            lblPetProcedure.Text = "Pet Birthday: "
            lblPetAppointment.Text = "Type: "
            lblPetAge.Text = "Pet Age:"
            lblPetWeight.Text = "Pet Weight(kg):"
            lblPetVaccineStatus.Text = "Vaccine Status: "

            Dim PetLabels() As PetLabel = {lblPetName, lblPetProcedure, lblPetAppointment, lblPetAge, lblPetWeight, lblPetVaccineStatus}


            'Inputs

            txtPetName.Size = New System.Drawing.Size(155, 26)

            dtpPetBirthday.Size = New System.Drawing.Size(196, 20)

            cbPetType.Size = New System.Drawing.Size(145, 28)
            cbPetType.Items.Add("Feline")
            cbPetType.Items.Add("Canine")
            cbPetType.Items.Add("Reptile")

            numPetAge.Size = New System.Drawing.Size(64, 20)

            numPetWeight.Size = New System.Drawing.Size(64, 20)

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

        Public Function getPetObject() As Pet
            petObject = New Pet(txtPetName.Text, numPetAge.Text, dtpPetBirthday.Value.Date, numPetWeight.Text, cbPetType.SelectedItem, cbPetVacStatus.SelectedItem)

            Return petObject
        End Function

        Public Sub setPetObject(petObject As Pet)
            Me.txtPetName.Text = petObject.strName
            Me.numPetAge.Value = petObject.intAge
            Me.dtpPetBirthday.Value = petObject.dateBirthday
            Me.numPetWeight.Value = petObject.dblWeight
            Me.cbPetType.SelectedItem = petObject.strType
            Me.cbPetVacStatus.SelectedItem = petObject.boolVaccinated
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
