<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup_Page))
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.txt_signSex = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_signAge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_signAddress = New System.Windows.Forms.TextBox()
        Me.txt_signName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_signUserName = New System.Windows.Forms.TextBox()
        Me.txt_signPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.Color.Transparent
        Me.btn_signup.BackgroundImage = CType(resources.GetObject("btn_signup.BackgroundImage"), System.Drawing.Image)
        Me.btn_signup.FlatAppearance.BorderSize = 0
        Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.Location = New System.Drawing.Point(709, 549)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(155, 45)
        Me.btn_signup.TabIndex = 43
        Me.btn_signup.Text = "Sign up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'txt_signSex
        '
        Me.txt_signSex.BackColor = System.Drawing.Color.White
        Me.txt_signSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signSex.Location = New System.Drawing.Point(865, 386)
        Me.txt_signSex.Name = "txt_signSex"
        Me.txt_signSex.Size = New System.Drawing.Size(153, 30)
        Me.txt_signSex.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(797, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 31)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Sex:"
        '
        'txt_signAge
        '
        Me.txt_signAge.BackColor = System.Drawing.Color.White
        Me.txt_signAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signAge.Location = New System.Drawing.Point(639, 387)
        Me.txt_signAge.Name = "txt_signAge"
        Me.txt_signAge.Size = New System.Drawing.Size(132, 30)
        Me.txt_signAge.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(568, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 31)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Age:"
        '
        'txt_signAddress
        '
        Me.txt_signAddress.BackColor = System.Drawing.Color.White
        Me.txt_signAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signAddress.Location = New System.Drawing.Point(639, 458)
        Me.txt_signAddress.Name = "txt_signAddress"
        Me.txt_signAddress.Size = New System.Drawing.Size(379, 30)
        Me.txt_signAddress.TabIndex = 38
        '
        'txt_signName
        '
        Me.txt_signName.BackColor = System.Drawing.Color.White
        Me.txt_signName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signName.Location = New System.Drawing.Point(639, 307)
        Me.txt_signName.Name = "txt_signName"
        Me.txt_signName.Size = New System.Drawing.Size(379, 30)
        Me.txt_signName.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(687, 660)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Already have an account?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(526, 458)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 31)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(548, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 31)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(489, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 63)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "SIGN UP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(705, 707)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "If you're a admin"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(815, 704)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 25)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "click here"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(847, 654)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 25)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(506, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 31)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Username:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(510, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 31)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Password:"
        '
        'txt_signUserName
        '
        Me.txt_signUserName.BackColor = System.Drawing.Color.White
        Me.txt_signUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signUserName.Location = New System.Drawing.Point(639, 171)
        Me.txt_signUserName.Name = "txt_signUserName"
        Me.txt_signUserName.Size = New System.Drawing.Size(379, 30)
        Me.txt_signUserName.TabIndex = 37
        '
        'txt_signPassword
        '
        Me.txt_signPassword.BackColor = System.Drawing.Color.White
        Me.txt_signPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txt_signPassword.Location = New System.Drawing.Point(639, 242)
        Me.txt_signPassword.Name = "txt_signPassword"
        Me.txt_signPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_signPassword.Size = New System.Drawing.Size(379, 30)
        Me.txt_signPassword.TabIndex = 37
        '
        'Signup_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1114, 749)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.txt_signSex)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_signAge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_signAddress)
        Me.Controls.Add(Me.txt_signPassword)
        Me.Controls.Add(Me.txt_signUserName)
        Me.Controls.Add(Me.txt_signName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Signup_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_signup As Button
    Friend WithEvents txt_signSex As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_signAge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_signAddress As TextBox
    Friend WithEvents txt_signName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_signUserName As TextBox
    Friend WithEvents txt_signPassword As TextBox
End Class
