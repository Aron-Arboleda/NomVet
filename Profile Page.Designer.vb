<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile_Page))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPetOwnerNumPets = New System.Windows.Forms.Label()
        Me.lblPetOwnerAddress = New System.Windows.Forms.Label()
        Me.lblPetOwnerSex = New System.Windows.Forms.Label()
        Me.lblPetOwnerAge = New System.Windows.Forms.Label()
        Me.lblPetOwnerName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.registeredPetsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.schedulesPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBackToHome = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.registeredPetsPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblPetOwnerNumPets)
        Me.Panel1.Controls.Add(Me.lblPetOwnerAddress)
        Me.Panel1.Controls.Add(Me.lblPetOwnerSex)
        Me.Panel1.Controls.Add(Me.lblPetOwnerAge)
        Me.Panel1.Controls.Add(Me.lblPetOwnerName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(28, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 623)
        Me.Panel1.TabIndex = 3
        '
        'lblPetOwnerNumPets
        '
        Me.lblPetOwnerNumPets.AutoSize = True
        Me.lblPetOwnerNumPets.BackColor = System.Drawing.Color.Transparent
        Me.lblPetOwnerNumPets.Font = New System.Drawing.Font("Tw Cen MT", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblPetOwnerNumPets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPetOwnerNumPets.Location = New System.Drawing.Point(115, 394)
        Me.lblPetOwnerNumPets.Name = "lblPetOwnerNumPets"
        Me.lblPetOwnerNumPets.Size = New System.Drawing.Size(25, 27)
        Me.lblPetOwnerNumPets.TabIndex = 22
        Me.lblPetOwnerNumPets.Text = "4"
        '
        'lblPetOwnerAddress
        '
        Me.lblPetOwnerAddress.AutoSize = True
        Me.lblPetOwnerAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblPetOwnerAddress.Font = New System.Drawing.Font("Tw Cen MT", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblPetOwnerAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPetOwnerAddress.Location = New System.Drawing.Point(143, 302)
        Me.lblPetOwnerAddress.Name = "lblPetOwnerAddress"
        Me.lblPetOwnerAddress.Size = New System.Drawing.Size(182, 27)
        Me.lblPetOwnerAddress.TabIndex = 21
        Me.lblPetOwnerAddress.Text = "Tarlac, Tarlac City"
        '
        'lblPetOwnerSex
        '
        Me.lblPetOwnerSex.AutoSize = True
        Me.lblPetOwnerSex.BackColor = System.Drawing.Color.Transparent
        Me.lblPetOwnerSex.Font = New System.Drawing.Font("Tw Cen MT", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblPetOwnerSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPetOwnerSex.Location = New System.Drawing.Point(100, 243)
        Me.lblPetOwnerSex.Name = "lblPetOwnerSex"
        Me.lblPetOwnerSex.Size = New System.Drawing.Size(79, 27)
        Me.lblPetOwnerSex.TabIndex = 20
        Me.lblPetOwnerSex.Text = "Female"
        '
        'lblPetOwnerAge
        '
        Me.lblPetOwnerAge.AutoSize = True
        Me.lblPetOwnerAge.BackColor = System.Drawing.Color.Transparent
        Me.lblPetOwnerAge.Font = New System.Drawing.Font("Tw Cen MT", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblPetOwnerAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPetOwnerAge.Location = New System.Drawing.Point(102, 182)
        Me.lblPetOwnerAge.Name = "lblPetOwnerAge"
        Me.lblPetOwnerAge.Size = New System.Drawing.Size(38, 27)
        Me.lblPetOwnerAge.TabIndex = 19
        Me.lblPetOwnerAge.Text = "22"
        '
        'lblPetOwnerName
        '
        Me.lblPetOwnerName.AutoSize = True
        Me.lblPetOwnerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPetOwnerName.Font = New System.Drawing.Font("Tw Cen MT", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblPetOwnerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPetOwnerName.Location = New System.Drawing.Point(122, 126)
        Me.lblPetOwnerName.Name = "lblPetOwnerName"
        Me.lblPetOwnerName.Size = New System.Drawing.Size(193, 27)
        Me.lblPetOwnerName.TabIndex = 18
        Me.lblPetOwnerName.Text = "Tiana Rhiel Madsen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(40, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 58)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "List of pets enrolled in the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clinic: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(40, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(40, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(40, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(40, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 60)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(413, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Registered Pet(s)"
        '
        'registeredPetsPanel
        '
        Me.registeredPetsPanel.AutoScroll = True
        Me.registeredPetsPanel.BackColor = System.Drawing.Color.White
        Me.registeredPetsPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.registeredPetsPanel.Location = New System.Drawing.Point(420, 95)
        Me.registeredPetsPanel.Name = "registeredPetsPanel"
        Me.registeredPetsPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.registeredPetsPanel.Size = New System.Drawing.Size(665, 214)
        Me.registeredPetsPanel.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(414, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 35)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Appointment Schedule(s)"
        '
        'schedulesPanel
        '
        Me.schedulesPanel.AutoScroll = True
        Me.schedulesPanel.BackColor = System.Drawing.Color.White
        Me.schedulesPanel.Location = New System.Drawing.Point(419, 418)
        Me.schedulesPanel.Name = "schedulesPanel"
        Me.schedulesPanel.Size = New System.Drawing.Size(665, 214)
        Me.schedulesPanel.TabIndex = 27
        '
        'btnBackToHome
        '
        Me.btnBackToHome.BackColor = System.Drawing.Color.Transparent
        Me.btnBackToHome.BackgroundImage = CType(resources.GetObject("btnBackToHome.BackgroundImage"), System.Drawing.Image)
        Me.btnBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackToHome.FlatAppearance.BorderSize = 0
        Me.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackToHome.Font = New System.Drawing.Font("Segoe UI Black", 11.25!)
        Me.btnBackToHome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackToHome.Location = New System.Drawing.Point(975, 12)
        Me.btnBackToHome.Name = "btnBackToHome"
        Me.btnBackToHome.Size = New System.Drawing.Size(110, 34)
        Me.btnBackToHome.TabIndex = 41
        Me.btnBackToHome.Text = "Log Out"
        Me.btnBackToHome.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.28042!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.71957!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(176, 189)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(170, 107)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Profile_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 674)
        Me.Controls.Add(Me.btnBackToHome)
        Me.Controls.Add(Me.schedulesPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.registeredPetsPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Profile_Page"
        Me.Text = "Profile_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.registeredPetsPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPetOwnerNumPets As Label
    Friend WithEvents lblPetOwnerAddress As Label
    Friend WithEvents lblPetOwnerSex As Label
    Friend WithEvents lblPetOwnerAge As Label
    Friend WithEvents lblPetOwnerName As Label
    Friend WithEvents registeredPetsPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents schedulesPanel As FlowLayoutPanel
    Friend WithEvents btnBackToHome As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
