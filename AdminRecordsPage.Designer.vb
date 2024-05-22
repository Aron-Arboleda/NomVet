<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRecordsPage
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDatabaseSessions = New System.Windows.Forms.ListView()
        Me.lstDatabaseAccounts = New System.Windows.Forms.ListView()
        Me.lstDatabaseBookings = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label5.Size = New System.Drawing.Size(175, 48)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Databases"
        '
        'lstDatabaseSessions
        '
        Me.lstDatabaseSessions.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.lstDatabaseSessions.HideSelection = False
        Me.lstDatabaseSessions.Location = New System.Drawing.Point(774, 125)
        Me.lstDatabaseSessions.Name = "lstDatabaseSessions"
        Me.lstDatabaseSessions.Size = New System.Drawing.Size(254, 430)
        Me.lstDatabaseSessions.TabIndex = 43
        Me.lstDatabaseSessions.UseCompatibleStateImageBehavior = False
        '
        'lstDatabaseAccounts
        '
        Me.lstDatabaseAccounts.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.lstDatabaseAccounts.HideSelection = False
        Me.lstDatabaseAccounts.Location = New System.Drawing.Point(95, 125)
        Me.lstDatabaseAccounts.Name = "lstDatabaseAccounts"
        Me.lstDatabaseAccounts.Size = New System.Drawing.Size(608, 177)
        Me.lstDatabaseAccounts.TabIndex = 44
        Me.lstDatabaseAccounts.UseCompatibleStateImageBehavior = False
        '
        'lstDatabaseBookings
        '
        Me.lstDatabaseBookings.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.lstDatabaseBookings.HideSelection = False
        Me.lstDatabaseBookings.Location = New System.Drawing.Point(95, 378)
        Me.lstDatabaseBookings.Name = "lstDatabaseBookings"
        Me.lstDatabaseBookings.Size = New System.Drawing.Size(608, 177)
        Me.lstDatabaseBookings.TabIndex = 45
        Me.lstDatabaseBookings.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(343, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 19)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Accounts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(343, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Bookings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(856, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Sessions"
        '
        'AdminRecordsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 674)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstDatabaseBookings)
        Me.Controls.Add(Me.lstDatabaseAccounts)
        Me.Controls.Add(Me.lstDatabaseSessions)
        Me.Controls.Add(Me.Label5)
        Me.Name = "AdminRecordsPage"
        Me.Text = "AdminRecordsPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents lstDatabaseSessions As ListView
    Friend WithEvents lstDatabaseAccounts As ListView
    Friend WithEvents lstDatabaseBookings As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
