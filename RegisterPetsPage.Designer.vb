<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPetsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPetsPage))
        Me.petDetailsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.petInputPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAddPet = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegisterPets = New System.Windows.Forms.Button()
        Me.petDetailsPanel.SuspendLayout()
        Me.petInputPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'petDetailsPanel
        '
        Me.petDetailsPanel.AutoScroll = True
        Me.petDetailsPanel.BackColor = System.Drawing.Color.White
        Me.petDetailsPanel.Controls.Add(Me.Label11)
        Me.petDetailsPanel.Controls.Add(Me.petInputPanel)
        Me.petDetailsPanel.Controls.Add(Me.btnAddPet)
        Me.petDetailsPanel.Location = New System.Drawing.Point(42, 137)
        Me.petDetailsPanel.Name = "petDetailsPanel"
        Me.petDetailsPanel.Size = New System.Drawing.Size(1021, 395)
        Me.petDetailsPanel.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Pet(s) Details"
        '
        'petInputPanel
        '
        Me.petInputPanel.AutoScroll = True
        Me.petInputPanel.BackColor = System.Drawing.Color.White
        Me.petInputPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.petInputPanel.Location = New System.Drawing.Point(3, 22)
        Me.petInputPanel.Name = "petInputPanel"
        Me.petInputPanel.Size = New System.Drawing.Size(1007, 324)
        Me.petInputPanel.TabIndex = 46
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox2, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown2, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown3, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox3, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(957, 57)
        Me.TableLayoutPanel2.TabIndex = 45
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.ComboBox2.Location = New System.Drawing.Point(672, 23)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 28)
        Me.ComboBox2.TabIndex = 32
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(595, 23)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown2.TabIndex = 35
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(672, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Vaccine Status:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(5, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Pet Name:"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(523, 23)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown3.TabIndex = 34
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(595, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Weight(kg):"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 26)
        Me.TextBox1.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(166, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Pet Birthday:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(523, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Pet Age:"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Feline", "Canine", "Reptile"})
        Me.ComboBox3.Location = New System.Drawing.Point(370, 23)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(145, 28)
        Me.ComboBox3.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(370, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Type:"
        '
        'btnAddPet
        '
        Me.btnAddPet.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPet.BackgroundImage = CType(resources.GetObject("btnAddPet.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPet.FlatAppearance.BorderSize = 0
        Me.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPet.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnAddPet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddPet.Location = New System.Drawing.Point(10, 352)
        Me.btnAddPet.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnAddPet.Name = "btnAddPet"
        Me.btnAddPet.Size = New System.Drawing.Size(156, 34)
        Me.btnAddPet.TabIndex = 47
        Me.btnAddPet.Text = "Add Pet"
        Me.btnAddPet.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(23, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(380, 60)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "PET REGISTRATION"
        '
        'btnRegisterPets
        '
        Me.btnRegisterPets.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisterPets.BackgroundImage = CType(resources.GetObject("btnRegisterPets.BackgroundImage"), System.Drawing.Image)
        Me.btnRegisterPets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegisterPets.FlatAppearance.BorderSize = 0
        Me.btnRegisterPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterPets.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterPets.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegisterPets.Location = New System.Drawing.Point(480, 576)
        Me.btnRegisterPets.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnRegisterPets.Name = "btnRegisterPets"
        Me.btnRegisterPets.Size = New System.Drawing.Size(188, 55)
        Me.btnRegisterPets.TabIndex = 48
        Me.btnRegisterPets.Text = "Register Pet(s)"
        Me.btnRegisterPets.UseVisualStyleBackColor = False
        '
        'RegisterPetsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 674)
        Me.Controls.Add(Me.petDetailsPanel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRegisterPets)
        Me.Name = "RegisterPetsPage"
        Me.Text = "RegisterPetsPage"
        Me.petDetailsPanel.ResumeLayout(False)
        Me.petDetailsPanel.PerformLayout()
        Me.petInputPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents petDetailsPanel As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents petInputPanel As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnRegisterPets As Button
End Class
