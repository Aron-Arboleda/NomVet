<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Page))
        Me.txt_userPass = New System.Windows.Forms.TextBox()
        Me.btn_userLogin = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_userPass
        '
        Me.txt_userPass.BackColor = System.Drawing.Color.White
        Me.txt_userPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_userPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_userPass.Location = New System.Drawing.Point(685, 298)
        Me.txt_userPass.Name = "txt_userPass"
        Me.txt_userPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_userPass.Size = New System.Drawing.Size(330, 38)
        Me.txt_userPass.TabIndex = 55
        Me.txt_userPass.UseSystemPasswordChar = True
        '
        'btn_userLogin
        '
        Me.btn_userLogin.BackColor = System.Drawing.Color.Transparent
        Me.btn_userLogin.BackgroundImage = CType(resources.GetObject("btn_userLogin.BackgroundImage"), System.Drawing.Image)
        Me.btn_userLogin.FlatAppearance.BorderSize = 0
        Me.btn_userLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_userLogin.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_userLogin.ForeColor = System.Drawing.Color.White
        Me.btn_userLogin.Location = New System.Drawing.Point(734, 400)
        Me.btn_userLogin.Name = "btn_userLogin"
        Me.btn_userLogin.Size = New System.Drawing.Size(155, 45)
        Me.btn_userLogin.TabIndex = 53
        Me.btn_userLogin.Text = "Login"
        Me.btn_userLogin.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(716, 591)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 19)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "If you're an admin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(706, 472)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 19)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Don't have an account?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(542, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 31)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Password:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(542, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 31)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Username:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Tw Cen MT", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(516, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(221, 85)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "LOGIN"
        '
        'txt_userName
        '
        Me.txt_userName.BackColor = System.Drawing.Color.White
        Me.txt_userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_userName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_userName.Location = New System.Drawing.Point(685, 218)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.Size = New System.Drawing.Size(330, 38)
        Me.txt_userName.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(854, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Sign up"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(826, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 25)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "click here"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1114, 749)
        Me.Controls.Add(Me.txt_userName)
        Me.Controls.Add(Me.txt_userPass)
        Me.Controls.Add(Me.btn_userLogin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Login_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_userPass As TextBox
    Friend WithEvents btn_userLogin As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_userName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
