﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking_Page))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBookAndPay = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbProcedure = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.numUIPetWeight = New System.Windows.Forms.NumericUpDown()
        Me.numUIPetAge = New System.Windows.Forms.NumericUpDown()
        Me.dtpPetBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbVaccineStatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbPetType = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.numUIPetWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUIPetAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(28, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 60)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "BOOKING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NomVet.My.Resources.Resources.cow_removebg__1_
        Me.PictureBox1.Location = New System.Drawing.Point(575, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(483, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btnBookAndPay
        '
        Me.btnBookAndPay.BackColor = System.Drawing.Color.Transparent
        Me.btnBookAndPay.BackgroundImage = CType(resources.GetObject("btnBookAndPay.BackgroundImage"), System.Drawing.Image)
        Me.btnBookAndPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBookAndPay.FlatAppearance.BorderSize = 0
        Me.btnBookAndPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookAndPay.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnBookAndPay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBookAndPay.Location = New System.Drawing.Point(237, 531)
        Me.btnBookAndPay.Name = "btnBookAndPay"
        Me.btnBookAndPay.Size = New System.Drawing.Size(156, 34)
        Me.btnBookAndPay.TabIndex = 38
        Me.btnBookAndPay.Text = "Book and Pay"
        Me.btnBookAndPay.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(93, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 382)
        Me.Panel2.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbProcedure)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpAppointmentDate)
        Me.Panel1.Controls.Add(Me.numUIPetWeight)
        Me.Panel1.Controls.Add(Me.numUIPetAge)
        Me.Panel1.Controls.Add(Me.dtpPetBirthday)
        Me.Panel1.Controls.Add(Me.txtPetName)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.cbVaccineStatus)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cbPetType)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Location = New System.Drawing.Point(21, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 295)
        Me.Panel1.TabIndex = 41
        '
        'cbProcedure
        '
        Me.cbProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProcedure.FormattingEnabled = True
        Me.cbProcedure.Items.AddRange(New Object() {"Check-Up", "Vaccine", "Both"})
        Me.cbProcedure.Location = New System.Drawing.Point(190, 206)
        Me.cbProcedure.Name = "cbProcedure"
        Me.cbProcedure.Size = New System.Drawing.Size(139, 28)
        Me.cbProcedure.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(9, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Procedure:"
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(189, 252)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(188, 20)
        Me.dtpAppointmentDate.TabIndex = 36
        '
        'numUIPetWeight
        '
        Me.numUIPetWeight.Location = New System.Drawing.Point(263, 90)
        Me.numUIPetWeight.Name = "numUIPetWeight"
        Me.numUIPetWeight.Size = New System.Drawing.Size(64, 20)
        Me.numUIPetWeight.TabIndex = 35
        Me.numUIPetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numUIPetAge
        '
        Me.numUIPetAge.Location = New System.Drawing.Point(13, 90)
        Me.numUIPetAge.Name = "numUIPetAge"
        Me.numUIPetAge.Size = New System.Drawing.Size(64, 20)
        Me.numUIPetAge.TabIndex = 34
        Me.numUIPetAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpPetBirthday
        '
        Me.dtpPetBirthday.Location = New System.Drawing.Point(184, 29)
        Me.dtpPetBirthday.Name = "dtpPetBirthday"
        Me.dtpPetBirthday.Size = New System.Drawing.Size(188, 20)
        Me.dtpPetBirthday.TabIndex = 33
        '
        'txtPetName
        '
        Me.txtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetName.Location = New System.Drawing.Point(10, 29)
        Me.txtPetName.Multiline = True
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(139, 26)
        Me.txtPetName.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(9, 252)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(174, 19)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Date of Appointment:"
        '
        'cbVaccineStatus
        '
        Me.cbVaccineStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVaccineStatus.FormattingEnabled = True
        Me.cbVaccineStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.cbVaccineStatus.Location = New System.Drawing.Point(10, 156)
        Me.cbVaccineStatus.Name = "cbVaccineStatus"
        Me.cbVaccineStatus.Size = New System.Drawing.Size(170, 28)
        Me.cbVaccineStatus.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(260, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Weight(kg):"
        '
        'cbPetType
        '
        Me.cbPetType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPetType.FormattingEnabled = True
        Me.cbPetType.Items.AddRange(New Object() {"Feline", "Canine", "Reptile"})
        Me.cbPetType.Location = New System.Drawing.Point(102, 90)
        Me.cbPetType.Name = "cbPetType"
        Me.cbPetType.Size = New System.Drawing.Size(139, 28)
        Me.cbPetType.TabIndex = 31
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(181, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 16)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Pet Birthday:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(10, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 16)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Pet Age:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(8, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Pet Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(99, 71)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 16)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Type:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(10, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Vaccine Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(138, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 35)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Booking Form"
        '
        'Booking_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 674)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBookAndPay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Booking_Page"
        Me.Text = "Booking_Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numUIPetWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUIPetAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents cbVaccineStatus As ComboBox
    Friend WithEvents cbPetType As ComboBox
    Friend WithEvents btnBookAndPay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents numUIPetAge As NumericUpDown
    Friend WithEvents dtpPetBirthday As DateTimePicker
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents numUIPetWeight As NumericUpDown
    Friend WithEvents cbProcedure As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
