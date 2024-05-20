<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbProcedure = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbPet = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(93, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 413)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTotalBill)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnBook)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cbProcedure)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpAppointmentDate)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.cbPet)
        Me.Panel3.Location = New System.Drawing.Point(24, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(390, 326)
        Me.Panel3.TabIndex = 16
        '
        'lblTotalBill
        '
        Me.lblTotalBill.AutoSize = True
        Me.lblTotalBill.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBill.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalBill.Location = New System.Drawing.Point(165, 170)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(17, 19)
        Me.lblTotalBill.TabIndex = 50
        Me.lblTotalBill.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(18, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Estimated Total Bill:"
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.Transparent
        Me.btnBook.BackgroundImage = CType(resources.GetObject("btnBook.BackgroundImage"), System.Drawing.Image)
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBook.Location = New System.Drawing.Point(145, 269)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(110, 34)
        Me.btnBook.TabIndex = 48
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Pet:"
        '
        'cbProcedure
        '
        Me.cbProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProcedure.FormattingEnabled = True
        Me.cbProcedure.Items.AddRange(New Object() {"Check-Up", "Vaccine", "Both"})
        Me.cbProcedure.Location = New System.Drawing.Point(194, 41)
        Me.cbProcedure.Name = "cbProcedure"
        Me.cbProcedure.Size = New System.Drawing.Size(150, 28)
        Me.cbProcedure.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(190, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Procedure:"
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(22, 110)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(203, 20)
        Me.dtpAppointmentDate.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(18, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 19)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Date of Appointment:"
        '
        'cbPet
        '
        Me.cbPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPet.FormattingEnabled = True
        Me.cbPet.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.cbPet.Location = New System.Drawing.Point(22, 41)
        Me.cbPet.Name = "cbPet"
        Me.cbPet.Size = New System.Drawing.Size(150, 28)
        Me.cbPet.TabIndex = 43
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Booking_Page"
        Me.Text = "Booking_Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbProcedure As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents cbPet As ComboBox
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBook As Button
End Class
