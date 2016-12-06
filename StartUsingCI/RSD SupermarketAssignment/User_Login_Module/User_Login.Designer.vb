<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkRemember = New System.Windows.Forms.CheckBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.radCustomerNonMember = New System.Windows.Forms.RadioButton()
        Me.radCustomerMember = New System.Windows.Forms.RadioButton()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.lblLoginAs = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 112)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(95, 160)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(139, 112)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(255, 26)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(139, 160)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(255, 26)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.GreenYellow
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.FlatAppearance.BorderSize = 2
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(76, 381)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(145, 53)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.BackColor = System.Drawing.Color.Transparent
        Me.chkRemember.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRemember.ForeColor = System.Drawing.Color.White
        Me.chkRemember.Location = New System.Drawing.Point(95, 207)
        Me.chkRemember.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(113, 20)
        Me.chkRemember.TabIndex = 3
        Me.chkRemember.Text = "Remember Me"
        Me.chkRemember.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.GreenYellow
        Me.btnRegister.CausesValidation = False
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(276, 381)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(147, 53)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Image = Global.User_Login_Module.My.Resources.Resources.close_button_128
        Me.btnClose.Location = New System.Drawing.Point(470, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 12
        Me.btnClose.TabStop = False
        '
        'radCustomerNonMember
        '
        Me.radCustomerNonMember.AutoSize = True
        Me.radCustomerNonMember.BackColor = System.Drawing.Color.Transparent
        Me.radCustomerNonMember.ForeColor = System.Drawing.Color.White
        Me.radCustomerNonMember.Location = New System.Drawing.Point(185, 332)
        Me.radCustomerNonMember.Margin = New System.Windows.Forms.Padding(4)
        Me.radCustomerNonMember.Name = "radCustomerNonMember"
        Me.radCustomerNonMember.Size = New System.Drawing.Size(185, 21)
        Me.radCustomerNonMember.TabIndex = 6
        Me.radCustomerNonMember.TabStop = True
        Me.radCustomerNonMember.Text = "Customer (Non-Member)"
        Me.radCustomerNonMember.UseVisualStyleBackColor = False
        '
        'radCustomerMember
        '
        Me.radCustomerMember.AutoSize = True
        Me.radCustomerMember.BackColor = System.Drawing.Color.Transparent
        Me.radCustomerMember.ForeColor = System.Drawing.Color.White
        Me.radCustomerMember.Location = New System.Drawing.Point(185, 303)
        Me.radCustomerMember.Margin = New System.Windows.Forms.Padding(4)
        Me.radCustomerMember.Name = "radCustomerMember"
        Me.radCustomerMember.Size = New System.Drawing.Size(154, 21)
        Me.radCustomerMember.TabIndex = 5
        Me.radCustomerMember.TabStop = True
        Me.radCustomerMember.Text = "Customer (Member)"
        Me.radCustomerMember.UseVisualStyleBackColor = False
        '
        'radStaff
        '
        Me.radStaff.AutoSize = True
        Me.radStaff.BackColor = System.Drawing.Color.Transparent
        Me.radStaff.ForeColor = System.Drawing.Color.White
        Me.radStaff.Location = New System.Drawing.Point(185, 274)
        Me.radStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(58, 21)
        Me.radStaff.TabIndex = 4
        Me.radStaff.TabStop = True
        Me.radStaff.Text = "Staff"
        Me.radStaff.UseVisualStyleBackColor = False
        '
        'lblLoginAs
        '
        Me.lblLoginAs.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginAs.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginAs.ForeColor = System.Drawing.Color.White
        Me.lblLoginAs.Location = New System.Drawing.Point(118, 242)
        Me.lblLoginAs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginAs.Name = "lblLoginAs"
        Me.lblLoginAs.Size = New System.Drawing.Size(143, 30)
        Me.lblLoginAs.TabIndex = 16
        Me.lblLoginAs.Text = "Login as: "
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'frmUserLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 469)
        Me.Controls.Add(Me.lblLoginAs)
        Me.Controls.Add(Me.radCustomerNonMember)
        Me.Controls.Add(Me.radCustomerMember)
        Me.Controls.Add(Me.radStaff)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.chkRemember)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSD Supermarket POS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents chkRemember As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents radCustomerNonMember As RadioButton
    Friend WithEvents radCustomerMember As RadioButton
    Friend WithEvents radStaff As RadioButton
    Friend WithEvents lblLoginAs As Label
    Friend WithEvents err As ErrorProvider
End Class
