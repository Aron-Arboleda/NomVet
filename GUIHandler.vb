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

    Public Sub clearAllFields(fields() As Control)
        For Each field In fields
            field.Text = ""
        Next
    End Sub

    Public Function GetAllInputControls(parentControl As Control) As List(Of Control)
        Dim inputControls As New List(Of Control)

        For Each control As Control In parentControl.Controls
            If TypeOf control Is TextBox OrElse
               TypeOf control Is ComboBox OrElse
               TypeOf control Is NumericUpDown Then
                inputControls.Add(control)
            End If

            If control.Controls.Count > 0 Then
                inputControls.AddRange(GetAllInputControls(control))
            End If
        Next

        Return inputControls
    End Function


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

            Dim lblPetNextVisitLabel As New PetLabel
            lblPetNextVisitLabel.Text = "Next Visit:"
            Dim lblPetNextVisitValue As New PetLabel
            lblPetNextVisitValue.Text = petObject.dateOfNextVisit

            Dim PetLabels() As PetLabel = {lblTypeLabel, lblBdayLabel, lblAgeLabel, lblWeightLabel, lblPetStatusLabel, lblPetNextVisitLabel}
            Dim PetValues() As PetLabel = {lblTypeValue, lblBdayValue, lblAgeValue, lblWeightValue, lblPetStatusValue, lblPetNextVisitValue}

            Dim propertiesPanel As New TableLayoutPanel
            propertiesPanel.AutoSize = True
            propertiesPanel.Padding = New Padding(5, 5, 5, 5)
            propertiesPanel.ColumnCount = 2
            propertiesPanel.RowCount = 6

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
        Inherits TableLayoutPanel

        Public appointment As Appointment
        Public Sub New(appointment As Appointment)
            Me.appointment = appointment

            Me.BackColor = Color.FromArgb(251, 254, 249)
            Me.AutoSize = True
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            Me.ColumnCount = 1
            Me.RowCount = 2

            Dim headerPanel As New TableLayoutPanel
            headerPanel.Size = New System.Drawing.Size(216, 31)
            headerPanel.ColumnCount = 2
            headerPanel.RowCount = 1

            Me.Controls.Add(headerPanel, 0, 0)

            Dim iconPicture As New PictureBox
            iconPicture.Image = My.Resources.calendarIcon
            iconPicture.SizeMode = PictureBoxSizeMode.Zoom
            iconPicture.Size = New System.Drawing.Size(37, 28)
            iconPicture.Margin = New Padding(5, 0, 5, 10)
            headerPanel.Controls.Add(iconPicture, 0, 0)

            Dim lblPetAppointment As New PetLabel
            lblPetAppointment.Text = appointment.dateAppointment.ToString("MMMM d, yyyy")
            lblPetAppointment.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
            lblPetAppointment.AutoSize = True
            lblPetAppointment.Margin = New Padding(0, 0, 5, 5)
            headerPanel.Controls.Add(lblPetAppointment, 1, 0)

            Dim infoPanel As New TableLayoutPanel
            infoPanel.AutoSize = True
            infoPanel.Padding = New Padding(5, 5, 5, 5)
            infoPanel.ColumnCount = 2
            infoPanel.RowCount = 2


            Dim lblPetNameLabel As New PetLabel
            lblPetNameLabel.Text = "Pet: "
            Dim lblPetNameValue As New PetLabel
            lblPetNameValue.Text = appointment.pet

            Dim lblPetProcedureLabel As New PetLabel
            lblPetProcedureLabel.Text = "Procedure: "
            Dim lblPetProcedureValue As New PetLabel
            lblPetProcedureValue.Text = appointment.strProcedure

            infoPanel.Controls.Add(lblPetNameLabel, 0, 0)
            infoPanel.Controls.Add(lblPetNameValue, 1, 0)
            infoPanel.Controls.Add(lblPetProcedureLabel, 0, 1)
            infoPanel.Controls.Add(lblPetProcedureValue, 1, 1)

            Me.Controls.Add(infoPanel, 0, 1)
        End Sub

    End Class

    Public Class RegisterPetPanel
        Inherits TableLayoutPanel

        Public lblPetName As New PetLabel
        Public lblPetBirthday As New PetLabel
        Public lblPetType As New PetLabel
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
            Me.AutoSize = True
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
            lblPetBirthday.Text = "Pet Birthday: "
            lblPetType.Text = "Type: "
            lblPetAge.Text = "Pet Age(yr):"
            lblPetWeight.Text = "Pet Weight(kg):"
            lblPetVaccineStatus.Text = "Vaccine Status: "

            Dim PetLabels() As PetLabel = {lblPetName, lblPetBirthday, lblPetType, lblPetAge, lblPetWeight, lblPetVaccineStatus}


            'Inputs

            txtPetName.Size = New System.Drawing.Size(155, 26)

            dtpPetBirthday.Size = New System.Drawing.Size(196, 20)

            cbPetType.Size = New System.Drawing.Size(145, 28)
            cbPetType.DropDownStyle = ComboBoxStyle.DropDownList
            cbPetType.Items.Add("Feline")
            cbPetType.Items.Add("Canine")
            cbPetType.Items.Add("Reptile")
            cbPetType.SelectedItem = "Feline"

            numPetAge.Size = New System.Drawing.Size(64, 20)

            numPetWeight.Size = New System.Drawing.Size(64, 20)

            cbPetVacStatus.Size = New System.Drawing.Size(150, 28)
            cbPetVacStatus.DropDownStyle = ComboBoxStyle.DropDownList
            cbPetVacStatus.Items.Add("Complete")
            cbPetVacStatus.Items.Add("Incomplete")
            cbPetVacStatus.SelectedItem = "Incomplete"

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

        Public Overridable Function getPetObject() As Pet
            petObject = New Pet(txtPetName.Text, numPetAge.Text, dtpPetBirthday.Value.Date, numPetWeight.Text, cbPetType.SelectedItem, cbPetVacStatus.SelectedItem, "N/A")

            Return petObject
        End Function

        Public Overridable Sub setPetObject(petObject As Pet)
            Me.txtPetName.Text = petObject.strName
            Me.numPetAge.Value = petObject.intAge
            Me.dtpPetBirthday.Value = petObject.dateBirthday
            Me.numPetWeight.Value = petObject.dblWeight
            Me.cbPetType.SelectedItem = petObject.strType
            Me.cbPetVacStatus.SelectedItem = petObject.boolVaccinated
        End Sub

    End Class

    Public Class WalkInPetInputPanel
        Inherits RegisterPetPanel

        Public lblPetProcedure As New PetLabel
        Public cbPetProcedure As New ComboBox


        Public Sub New()
            Me.ColumnCount = 7

            lblPetProcedure.Text = "Procedure:"
            lblPetProcedure.AutoSize = True
            lblPetProcedure.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            Me.Controls.Add(lblPetProcedure, 7, 0)

            cbPetProcedure.Size = New System.Drawing.Size(100, 28)
            cbPetProcedure.DropDownStyle = ComboBoxStyle.DropDownList
            cbPetProcedure.Items.Add("Check-Up")
            cbPetProcedure.Items.Add("Vaccine")
            cbPetProcedure.Items.Add("Both")
            cbPetProcedure.SelectedItem = "Check-Up"
            Me.Controls.Add(cbPetProcedure, 7, 1)

            cbPetType.Size = New System.Drawing.Size(125, 28)
            cbPetVacStatus.Size = New System.Drawing.Size(125, 28)

            AddHandler Me.cbPetVacStatus.SelectedIndexChanged, AddressOf Me.cbPetVacStatus_SelectedIndexChanged


        End Sub

        Private Sub cbPetVacStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
            If cbPetVacStatus.SelectedItem = "Complete" Then
                cbPetProcedure.Items.Clear()
                cbPetProcedure.Items.Add("Check-Up")
                cbPetProcedure.SelectedItem = "Check-Up"
            ElseIf cbPetVacStatus.SelectedItem = "Incomplete" Then
                cbPetProcedure.Items.Clear()
                cbPetProcedure.Items.Add("Check-Up")
                cbPetProcedure.Items.Add("Vaccine")
                cbPetProcedure.Items.Add("Both")
                cbPetProcedure.SelectedItem = "Vaccine"
            End If
        End Sub

        Public Overrides Function getPetObject() As Pet
            petObject = New Pet(txtPetName.Text, numPetAge.Text, dtpPetBirthday.Value.Date, numPetWeight.Text, cbPetType.SelectedItem, cbPetVacStatus.SelectedItem, "N/A")

            Return petObject
        End Function
    End Class

    Public Class SessionPetPanel
        Inherits TableLayoutPanel


        Public Sub New(petWithProcedureString As String)

            Me.BackColor = Color.FromArgb(251, 254, 249)
            Me.AutoSize = True
            Me.Padding = New Padding(1, 1, 1, 1)
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            Me.ColumnCount = 1
            Me.RowCount = 2


            Dim lblPetName As New PetLabel
            lblPetName.Text = petWithProcedureString.Split("#"c)(0)
            lblPetName.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
            lblPetName.AutoSize = True
            lblPetName.Anchor = AnchorStyles.Bottom

            Me.Controls.Add(lblPetName, 0, 0)

            Dim lblTypeLabel As New PetLabel
            lblTypeLabel.Text = "Type:"
            Dim lblTypeValue As New PetLabel
            lblTypeValue.Text = petWithProcedureString.Split("#"c)(1)

            Dim lblProcedureLabel As New PetLabel
            lblProcedureLabel.Text = "Procedure:"
            Dim lblProcedureValue As New PetLabel
            lblProcedureValue.Text = petWithProcedureString.Split("#"c)(2)

            Dim PetLabels() As PetLabel = {lblTypeLabel, lblProcedureLabel}
            Dim PetValues() As PetLabel = {lblTypeValue, lblProcedureValue}

            Dim propertiesPanel As New TableLayoutPanel
            propertiesPanel.AutoSize = True
            propertiesPanel.Padding = New Padding(5, 5, 5, 5)
            propertiesPanel.ColumnCount = 2
            propertiesPanel.RowCount = 2

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

    Public Class SessionNextVisitPanel
        Inherits TableLayoutPanel

        Public lblPetName As New PetLabel
        Public lblNextVisitChooser As New PetLabel
        Public lblNextVisitDate As New PetLabel
        Public lblPetVaccineStatus As New PetLabel
        Public lblProcedure As New PetLabel

        Public rbYes As New RadioButton
        Public rbNo As New RadioButton
        Public dtpNextVisitDate As New DateTimePicker
        Public cbPetProcedure As New ComboBox
        Public cbPetVacStatus As New ComboBox


        Public Sub New(petWithProcedureString As String)

            Me.BackColor = Color.White
            'Me.Size = New System.Drawing.Size(769, 67)
            Me.AutoSize = True
            Me.Padding = New Padding(10, 10, 10, 10)
            Me.Margin = New Padding(0, 0, 0, 5)
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            Me.ColumnCount = 2
            Me.RowCount = 1


            'For i As Integer = 1 To Me.ColumnCount
            '    Me.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            'Next

            'For i As Integer = 1 To Me.RowCount
            '    Me.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            'Next

            'Labels

            lblPetName.Text = petWithProcedureString.Split("#"c)(0)
            lblPetName.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
            lblPetName.AutoSize = True
            lblPetName.Anchor = AnchorStyles.Left

            Me.Controls.Add(lblPetName, 0, 0)


            lblNextVisitChooser.Text = "Next Visit?:"
            lblNextVisitDate.Text = "Date of Next Visit:"
            lblPetVaccineStatus.Text = "Vaccine Status:"
            lblProcedure.Text = "Procedure:"

            Dim PetLabels() As PetLabel = {lblNextVisitChooser, lblNextVisitDate, lblPetVaccineStatus, lblProcedure}


            'Inputs

            rbYes.Text = "Yes"
            rbNo.Text = "No"
            rbYes.AutoSize = True
            rbNo.AutoSize = True

            AddHandler Me.rbYes.CheckedChanged, AddressOf Me.rbYes_CheckedChanged
            AddHandler Me.rbNo.CheckedChanged, AddressOf Me.rbNo_CheckedChanged

            dtpNextVisitDate.Size = New System.Drawing.Size(196, 20)

            cbPetProcedure.Size = New System.Drawing.Size(145, 28)
            cbPetProcedure.Items.Add("Check-Up")
            cbPetProcedure.Items.Add("Vaccine")
            cbPetProcedure.Items.Add("Both")

            cbPetVacStatus.Size = New System.Drawing.Size(150, 28)
            cbPetVacStatus.Items.Add("Complete")
            cbPetVacStatus.Items.Add("Incomplete")

            Dim propertiesPanel As New TableLayoutPanel
            propertiesPanel.AutoSize = True
            propertiesPanel.Padding = New Padding(5, 5, 5, 5)
            propertiesPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
            propertiesPanel.ColumnCount = 4
            propertiesPanel.RowCount = 2

            Me.Controls.Add(propertiesPanel, 1, 0)

            With propertiesPanel
                For i = 0 To PetLabels.Length - 1
                    PetLabels(i).AutoSize = True
                    PetLabels(i).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                    .Controls.Add(PetLabels(i), i, 0)
                Next
                Dim radioPanel As New FlowLayoutPanel
                radioPanel.AutoSize = True
                radioPanel.Controls.Add(rbYes)
                radioPanel.Controls.Add(rbNo)
                .Controls.Add(radioPanel, 0, 1)
                .Controls.Add(dtpNextVisitDate, 1, 1)
                .Controls.Add(cbPetVacStatus, 2, 1)
                .Controls.Add(cbPetProcedure, 3, 1)
                rbYes.PerformClick()
            End With
        End Sub

        Public Function getNextVistObject() As NextVisit
            Dim nextVisitObject As NextVisit
            If rbYes.Checked Then
                nextVisitObject = New NextVisit(lblPetName.Text, rbYes.Checked, dtpNextVisitDate.Value.Date, cbPetVacStatus.SelectedItem, cbPetProcedure.SelectedItem)
            Else
                nextVisitObject = New NextVisit(lblPetName.Text, rbYes.Checked, "N/A", cbPetVacStatus.SelectedItem, cbPetProcedure.SelectedItem)
            End If
            Return nextVisitObject
        End Function

        Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs)
            If rbYes.Checked Then
                dtpNextVisitDate.Enabled = True
                cbPetProcedure.Enabled = True
            End If
        End Sub

        Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs)
            If rbNo.Checked Then
                dtpNextVisitDate.Enabled = False
                cbPetProcedure.Enabled = False
            End If
        End Sub
    End Class

    Public Class BillingRowPanel
        Inherits TableLayoutPanel

        Public lblPetName As New PetLabel
        Public lblPetType As New PetLabel
        Public lblProcedure As New PetLabel
        Public lblTotal As New PetLabel


        Public Sub New(petWithProcedureString As String)

            Me.BackColor = Color.Transparent
            Me.AutoSize = False
            'Me.Width = 376
            Me.Size = New System.Drawing.Size(376, 40)
            Me.ColumnCount = 4
            Me.RowCount = 1
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25))
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25))
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27))
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23))
            Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset

            Dim petType As String = petWithProcedureString.Split("#"c)(1)
            Dim petProcedure As String = petWithProcedureString.Split("#"c)(2)

            lblPetName.Text = petWithProcedureString.Split("#"c)(0)
            lblPetName.Font = New Font("Tw Cen MT", 12, FontStyle.Regular)
            lblPetType.Text = petType
            lblPetType.Font = New Font("Tw Cen MT", 12, FontStyle.Regular)
            lblProcedure.Text = petProcedure
            lblProcedure.Font = New Font("Tw Cen MT", 12, FontStyle.Regular)
            lblTotal.Text = ToPesoFormat(computeTotalBill(petType, petProcedure))
            lblTotal.Font = New Font("Tw Cen MT", 12, FontStyle.Bold)

            Dim PetLabels() As Label = {lblPetName, lblPetType, lblProcedure, lblTotal}

            With Me
                For i = 0 To PetLabels.Length - 1
                    PetLabels(i).AutoSize = True
                    PetLabels(i).Anchor = AnchorStyles.None
                    .Controls.Add(PetLabels(i), i, 0)
                Next
            End With
        End Sub
    End Class

    Public Class ReceiptRowPanel
        Inherits BillingRowPanel

        Public Sub New(petWithProcedureString As String)
            MyBase.New(petWithProcedureString)

            Me.AutoSize = False
            Me.Size = New System.Drawing.Size(540, 30)

        End Sub
    End Class


    Public Class PetLabel
        Inherits Label

        Public Sub New()
            Me.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
            Me.AutoSize = True
        End Sub
    End Class

    Public Function ToPesoFormat(ByVal decimalNum As Double) As String
        Return decimalNum.ToString("C2", Globalization.CultureInfo.GetCultureInfo("en-PH"))
    End Function


End Module
