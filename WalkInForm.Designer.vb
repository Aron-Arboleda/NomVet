<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WalkInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WalkInForm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.parentPanelInput = New System.Windows.Forms.Panel()
        Me.petFormPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddPetInput = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPetOwnerPassword = New System.Windows.Forms.TextBox()
        Me.txtPetOwnerUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPetOwnerAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUIPetOwnerAge = New System.Windows.Forms.NumericUpDown()
        Me.txtPetOwnerName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbPetOwnerSex = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSaveSession = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.parentPanelInput.SuspendLayout()
        CType(Me.numUIPetOwnerAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Input Form"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.parentPanelInput)
        Me.Panel1.Location = New System.Drawing.Point(33, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 529)
        Me.Panel1.TabIndex = 19
        '
        'parentPanelInput
        '
        Me.parentPanelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.parentPanelInput.Controls.Add(Me.petFormPanel)
        Me.parentPanelInput.Controls.Add(Me.btnAddPetInput)
        Me.parentPanelInput.Controls.Add(Me.Label11)
        Me.parentPanelInput.Controls.Add(Me.txtPetOwnerPassword)
        Me.parentPanelInput.Controls.Add(Me.txtPetOwnerUsername)
        Me.parentPanelInput.Controls.Add(Me.Label2)
        Me.parentPanelInput.Controls.Add(Me.txtPetOwnerAddress)
        Me.parentPanelInput.Controls.Add(Me.Label1)
        Me.parentPanelInput.Controls.Add(Me.numUIPetOwnerAge)
        Me.parentPanelInput.Controls.Add(Me.txtPetOwnerName)
        Me.parentPanelInput.Controls.Add(Me.Label19)
        Me.parentPanelInput.Controls.Add(Me.cbPetOwnerSex)
        Me.parentPanelInput.Controls.Add(Me.Label20)
        Me.parentPanelInput.Controls.Add(Me.Label24)
        Me.parentPanelInput.Controls.Add(Me.Label25)
        Me.parentPanelInput.Controls.Add(Me.Label23)
        Me.parentPanelInput.Controls.Add(Me.Label22)
        Me.parentPanelInput.Location = New System.Drawing.Point(28, 21)
        Me.parentPanelInput.Name = "parentPanelInput"
        Me.parentPanelInput.Size = New System.Drawing.Size(1005, 474)
        Me.parentPanelInput.TabIndex = 42
        '
        'petFormPanel
        '
        Me.petFormPanel.AutoScroll = True
        Me.petFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.petFormPanel.Location = New System.Drawing.Point(11, 134)
        Me.petFormPanel.Name = "petFormPanel"
        Me.petFormPanel.Size = New System.Drawing.Size(983, 296)
        Me.petFormPanel.TabIndex = 45
        '
        'btnAddPetInput
        '
        Me.btnAddPetInput.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPetInput.BackgroundImage = CType(resources.GetObject("btnAddPetInput.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPetInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPetInput.FlatAppearance.BorderSize = 0
        Me.btnAddPetInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPetInput.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPetInput.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddPetInput.Location = New System.Drawing.Point(826, 430)
        Me.btnAddPetInput.Name = "btnAddPetInput"
        Me.btnAddPetInput.Size = New System.Drawing.Size(86, 34)
        Me.btnAddPetInput.TabIndex = 40
        Me.btnAddPetInput.Text = "Add Pet"
        Me.btnAddPetInput.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(7, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Pet(s) Details"
        '
        'txtPetOwnerPassword
        '
        Me.txtPetOwnerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetOwnerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetOwnerPassword.Location = New System.Drawing.Point(718, 53)
        Me.txtPetOwnerPassword.Multiline = True
        Me.txtPetOwnerPassword.Name = "txtPetOwnerPassword"
        Me.txtPetOwnerPassword.Size = New System.Drawing.Size(139, 26)
        Me.txtPetOwnerPassword.TabIndex = 42
        '
        'txtPetOwnerUsername
        '
        Me.txtPetOwnerUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetOwnerUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetOwnerUsername.Location = New System.Drawing.Point(554, 53)
        Me.txtPetOwnerUsername.Multiline = True
        Me.txtPetOwnerUsername.Name = "txtPetOwnerUsername"
        Me.txtPetOwnerUsername.Size = New System.Drawing.Size(139, 26)
        Me.txtPetOwnerUsername.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(715, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Password:"
        '
        'txtPetOwnerAddress
        '
        Me.txtPetOwnerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetOwnerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetOwnerAddress.Location = New System.Drawing.Point(352, 56)
        Me.txtPetOwnerAddress.Multiline = True
        Me.txtPetOwnerAddress.Name = "txtPetOwnerAddress"
        Me.txtPetOwnerAddress.Size = New System.Drawing.Size(139, 26)
        Me.txtPetOwnerAddress.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Pet Owner Details"
        '
        'numUIPetOwnerAge
        '
        Me.numUIPetOwnerAge.Location = New System.Drawing.Point(166, 58)
        Me.numUIPetOwnerAge.Name = "numUIPetOwnerAge"
        Me.numUIPetOwnerAge.Size = New System.Drawing.Size(64, 20)
        Me.numUIPetOwnerAge.TabIndex = 34
        Me.numUIPetOwnerAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPetOwnerName
        '
        Me.txtPetOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetOwnerName.Location = New System.Drawing.Point(11, 58)
        Me.txtPetOwnerName.Multiline = True
        Me.txtPetOwnerName.Name = "txtPetOwnerName"
        Me.txtPetOwnerName.Size = New System.Drawing.Size(139, 26)
        Me.txtPetOwnerName.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(349, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Address:"
        '
        'cbPetOwnerSex
        '
        Me.cbPetOwnerSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPetOwnerSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPetOwnerSex.FormattingEnabled = True
        Me.cbPetOwnerSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbPetOwnerSex.Location = New System.Drawing.Point(247, 56)
        Me.cbPetOwnerSex.Name = "cbPetOwnerSex"
        Me.cbPetOwnerSex.Size = New System.Drawing.Size(86, 28)
        Me.cbPetOwnerSex.TabIndex = 31
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(163, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 16)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Age:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(550, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(193, 19)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "NOMVC Account Credentials:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(8, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(244, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 16)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Sex:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(551, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Username:"
        '
        'btnSaveSession
        '
        Me.btnSaveSession.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveSession.BackgroundImage = CType(resources.GetObject("btnSaveSession.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSession.FlatAppearance.BorderSize = 0
        Me.btnSaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSession.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnSaveSession.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSaveSession.Location = New System.Drawing.Point(490, 628)
        Me.btnSaveSession.Name = "btnSaveSession"
        Me.btnSaveSession.Size = New System.Drawing.Size(156, 34)
        Me.btnSaveSession.TabIndex = 39
        Me.btnSaveSession.Text = "Save Session"
        Me.btnSaveSession.UseVisualStyleBackColor = False
        '
        'WalkInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 674)
        Me.Controls.Add(Me.btnSaveSession)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "WalkInForm"
        Me.Text = "WalkInForm"
        Me.Panel1.ResumeLayout(False)
        Me.parentPanelInput.ResumeLayout(False)
        Me.parentPanelInput.PerformLayout()
        CType(Me.numUIPetOwnerAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents parentPanelInput As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents numUIPetOwnerAge As NumericUpDown
    Friend WithEvents txtPetOwnerName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cbPetOwnerSex As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPetOwnerAddress As TextBox
    Friend WithEvents txtPetOwnerPassword As TextBox
    Friend WithEvents txtPetOwnerUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSaveSession As Button
    Friend WithEvents btnAddPetInput As Button
    Friend WithEvents petFormPanel As FlowLayoutPanel
End Class
