<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigatorPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NavigatorPage))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnProfileDisplayName = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnPricing = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.displayPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1113, 75)
        Me.Panel3.TabIndex = 39
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnProfileDisplayName)
        Me.Panel7.Controls.Add(Me.PictureBox5)
        Me.Panel7.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(855, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(257, 67)
        Me.Panel7.TabIndex = 29
        '
        'btnProfileDisplayName
        '
        Me.btnProfileDisplayName.FlatAppearance.BorderSize = 0
        Me.btnProfileDisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfileDisplayName.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfileDisplayName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProfileDisplayName.Location = New System.Drawing.Point(68, 17)
        Me.btnProfileDisplayName.Name = "btnProfileDisplayName"
        Me.btnProfileDisplayName.Size = New System.Drawing.Size(186, 32)
        Me.btnProfileDisplayName.TabIndex = 39
        Me.btnProfileDisplayName.Text = "Tiana Rhiel Madsen"
        Me.btnProfileDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfileDisplayName.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.btnHome, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPricing, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBooking, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(538, 75)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(4, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(172, 67)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnPricing
        '
        Me.btnPricing.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnPricing.FlatAppearance.BorderSize = 0
        Me.btnPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPricing.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPricing.Location = New System.Drawing.Point(363, 4)
        Me.btnPricing.Name = "btnPricing"
        Me.btnPricing.Size = New System.Drawing.Size(172, 67)
        Me.btnPricing.TabIndex = 2
        Me.btnPricing.Text = "PRICING"
        Me.btnPricing.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.Location = New System.Drawing.Point(183, 4)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(172, 67)
        Me.btnBooking.TabIndex = 1
        Me.btnBooking.Text = "BOOKING"
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'displayPanel
        '
        Me.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayPanel.Location = New System.Drawing.Point(-1, 74)
        Me.displayPanel.Name = "displayPanel"
        Me.displayPanel.Size = New System.Drawing.Size(1122, 680)
        Me.displayPanel.TabIndex = 40
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'NavigatorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 749)
        Me.Controls.Add(Me.displayPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NavigatorPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NavigatorPage"
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnProfileDisplayName As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnPricing As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents displayPanel As Panel
End Class
