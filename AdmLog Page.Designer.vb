﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmLog_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmLog_Page))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_admPassword = New System.Windows.Forms.TextBox()
        Me.txt_admUsername = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1023, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(378, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(884, 574)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(94, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOM VETERINARY CLINIC"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txt_admPassword)
        Me.Panel1.Controls.Add(Me.txt_admUsername)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnAdminLogin)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(59, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 593)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "If you're a customer"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(251, 516)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 25)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "click here"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_admPassword
        '
        Me.txt_admPassword.BackColor = System.Drawing.Color.White
        Me.txt_admPassword.Font = New System.Drawing.Font("Microsoft YaHei", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_admPassword.Location = New System.Drawing.Point(175, 250)
        Me.txt_admPassword.Name = "txt_admPassword"
        Me.txt_admPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_admPassword.Size = New System.Drawing.Size(262, 43)
        Me.txt_admPassword.TabIndex = 28
        Me.txt_admPassword.UseSystemPasswordChar = True
        '
        'txt_admUsername
        '
        Me.txt_admUsername.BackColor = System.Drawing.Color.White
        Me.txt_admUsername.Font = New System.Drawing.Font("Microsoft YaHei", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_admUsername.Location = New System.Drawing.Point(175, 188)
        Me.txt_admUsername.Name = "txt_admUsername"
        Me.txt_admUsername.Size = New System.Drawing.Size(262, 43)
        Me.txt_admUsername.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 31)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Password:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(32, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 31)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Username:"
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminLogin.BackgroundImage = CType(resources.GetObject("btnAdminLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnAdminLogin.FlatAppearance.BorderSize = 0
        Me.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminLogin.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.White
        Me.btnAdminLogin.Location = New System.Drawing.Point(157, 332)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(155, 45)
        Me.btnAdminLogin.TabIndex = 23
        Me.btnAdminLogin.Text = "Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(105, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(259, 55)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Admin Log-in"
        '
        'AdmLog_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdmLog_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdmLog_Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents txt_admPassword As TextBox
    Friend WithEvents txt_admUsername As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
End Class
