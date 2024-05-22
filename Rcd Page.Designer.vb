<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rcd_Page
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnWalkinForm = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnLoginPage = New System.Windows.Forms.Button()
        Me.rcdDisplayPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWalkinForm, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRecords, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(754, 75)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(455, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(295, 67)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SESSION HANDLING"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnWalkinForm
        '
        Me.btnWalkinForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnWalkinForm.FlatAppearance.BorderSize = 0
        Me.btnWalkinForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWalkinForm.Location = New System.Drawing.Point(192, 4)
        Me.btnWalkinForm.Name = "btnWalkinForm"
        Me.btnWalkinForm.Size = New System.Drawing.Size(256, 67)
        Me.btnWalkinForm.TabIndex = 1
        Me.btnWalkinForm.Text = "WALK-IN FORM"
        Me.btnWalkinForm.UseVisualStyleBackColor = True
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Location = New System.Drawing.Point(4, 4)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(181, 67)
        Me.btnRecords.TabIndex = 0
        Me.btnRecords.Text = "RECORDS"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnLoginPage)
        Me.Panel7.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1113, 75)
        Me.Panel7.TabIndex = 33
        '
        'btnLoginPage
        '
        Me.btnLoginPage.BackColor = System.Drawing.Color.White
        Me.btnLoginPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnLoginPage.FlatAppearance.BorderSize = 0
        Me.btnLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginPage.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnLoginPage.Location = New System.Drawing.Point(934, 9)
        Me.btnLoginPage.Name = "btnLoginPage"
        Me.btnLoginPage.Size = New System.Drawing.Size(168, 59)
        Me.btnLoginPage.TabIndex = 24
        Me.btnLoginPage.Text = "Login Page"
        Me.btnLoginPage.UseVisualStyleBackColor = False
        '
        'rcdDisplayPanel
        '
        Me.rcdDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rcdDisplayPanel.Location = New System.Drawing.Point(-2, 74)
        Me.rcdDisplayPanel.Name = "rcdDisplayPanel"
        Me.rcdDisplayPanel.Size = New System.Drawing.Size(1122, 680)
        Me.rcdDisplayPanel.TabIndex = 41
        '
        'Rcd_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1114, 749)
        Me.Controls.Add(Me.rcdDisplayPanel)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "Rcd_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnWalkinForm As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents rcdDisplayPanel As Panel
    Friend WithEvents btnLoginPage As Button
End Class
