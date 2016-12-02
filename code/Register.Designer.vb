<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRetype = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.grpCreditDetails = New System.Windows.Forms.GroupBox()
        Me.txtCCV = New System.Windows.Forms.TextBox()
        Me.lblCCV = New System.Windows.Forms.Label()
        Me.cboCardCompany = New System.Windows.Forms.ComboBox()
        Me.lblCardCompany = New System.Windows.Forms.Label()
        Me.cboCardType = New System.Windows.Forms.ComboBox()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpPersonalDetails.SuspendLayout()
        Me.grpCreditDetails.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(346, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Register"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(111, 131)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(112, 27)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username*"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(111, 162)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(215, 22)
        Me.txtUsername.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(111, 203)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(72, 27)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email*"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(59, 178)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(105, 27)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password*"
        '
        'lblRetype
        '
        Me.lblRetype.AutoSize = True
        Me.lblRetype.BackColor = System.Drawing.Color.Transparent
        Me.lblRetype.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetype.ForeColor = System.Drawing.Color.White
        Me.lblRetype.Location = New System.Drawing.Point(54, 235)
        Me.lblRetype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRetype.Name = "lblRetype"
        Me.lblRetype.Size = New System.Drawing.Size(173, 27)
        Me.lblRetype.TabIndex = 6
        Me.lblRetype.Text = "Retype password*"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 234)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(215, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(59, 209)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(215, 22)
        Me.txtPassword.TabIndex = 5
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(56, 266)
        Me.txtRetype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetype.Multiline = True
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetype.Size = New System.Drawing.Size(215, 22)
        Me.txtRetype.TabIndex = 6
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.GreenYellow
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(472, 489)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(168, 93)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpPersonalDetails.Controls.Add(Me.txtMemberID)
        Me.grpPersonalDetails.Controls.Add(Me.lblStaffID)
        Me.grpPersonalDetails.Controls.Add(Me.txtStaffID)
        Me.grpPersonalDetails.Controls.Add(Me.lblMemberID)
        Me.grpPersonalDetails.Controls.Add(Me.cboUserType)
        Me.grpPersonalDetails.Controls.Add(Me.txtRetype)
        Me.grpPersonalDetails.Controls.Add(Me.lblUserType)
        Me.grpPersonalDetails.Controls.Add(Me.txtPassword)
        Me.grpPersonalDetails.Controls.Add(Me.lblRetype)
        Me.grpPersonalDetails.Controls.Add(Me.lblPassword)
        Me.grpPersonalDetails.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grpPersonalDetails.Location = New System.Drawing.Point(52, 93)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(364, 489)
        Me.grpPersonalDetails.TabIndex = 11
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal Information"
        '
        'txtMemberID
        '
        Me.txtMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberID.Location = New System.Drawing.Point(56, 437)
        Me.txtMemberID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberID.Multiline = True
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(215, 22)
        Me.txtMemberID.TabIndex = 9
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.ForeColor = System.Drawing.Color.White
        Me.lblStaffID.Location = New System.Drawing.Point(59, 349)
        Me.lblStaffID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(82, 27)
        Me.lblStaffID.TabIndex = 17
        Me.lblStaffID.Text = "Staff ID"
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(56, 380)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffID.Multiline = True
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(215, 22)
        Me.txtStaffID.TabIndex = 8
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.ForeColor = System.Drawing.Color.White
        Me.lblMemberID.Location = New System.Drawing.Point(54, 406)
        Me.lblMemberID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(117, 27)
        Me.lblMemberID.TabIndex = 16
        Me.lblMemberID.Text = "Member ID"
        '
        'cboUserType
        '
        Me.cboUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Items.AddRange(New Object() {"Staff", "Member", "Non-member"})
        Me.cboUserType.Location = New System.Drawing.Point(56, 322)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(215, 24)
        Me.cboUserType.TabIndex = 7
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.BackColor = System.Drawing.Color.Transparent
        Me.lblUserType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(54, 292)
        Me.lblUserType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(161, 27)
        Me.lblUserType.TabIndex = 14
        Me.lblUserType.Text = "Select User Type"
        '
        'grpCreditDetails
        '
        Me.grpCreditDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpCreditDetails.Controls.Add(Me.txtCCV)
        Me.grpCreditDetails.Controls.Add(Me.lblCCV)
        Me.grpCreditDetails.Controls.Add(Me.cboCardCompany)
        Me.grpCreditDetails.Controls.Add(Me.lblCardCompany)
        Me.grpCreditDetails.Controls.Add(Me.cboCardType)
        Me.grpCreditDetails.Controls.Add(Me.lblCardType)
        Me.grpCreditDetails.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCreditDetails.Location = New System.Drawing.Point(463, 115)
        Me.grpCreditDetails.Name = "grpCreditDetails"
        Me.grpCreditDetails.Size = New System.Drawing.Size(364, 275)
        Me.grpCreditDetails.TabIndex = 12
        Me.grpCreditDetails.TabStop = False
        Me.grpCreditDetails.Text = "Credit Details"
        '
        'txtCCV
        '
        Me.txtCCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCV.Location = New System.Drawing.Point(59, 220)
        Me.txtCCV.Multiline = True
        Me.txtCCV.Name = "txtCCV"
        Me.txtCCV.Size = New System.Drawing.Size(215, 22)
        Me.txtCCV.TabIndex = 12
        '
        'lblCCV
        '
        Me.lblCCV.AutoSize = True
        Me.lblCCV.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCV.ForeColor = System.Drawing.Color.White
        Me.lblCCV.Location = New System.Drawing.Point(54, 190)
        Me.lblCCV.Name = "lblCCV"
        Me.lblCCV.Size = New System.Drawing.Size(54, 27)
        Me.lblCCV.TabIndex = 4
        Me.lblCCV.Text = "CCV"
        '
        'cboCardCompany
        '
        Me.cboCardCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardCompany.FormattingEnabled = True
        Me.cboCardCompany.Items.AddRange(New Object() {"VISA", "Mastercard", "AMEX", "Public Bank", "Maybank"})
        Me.cboCardCompany.Location = New System.Drawing.Point(59, 144)
        Me.cboCardCompany.Name = "cboCardCompany"
        Me.cboCardCompany.Size = New System.Drawing.Size(215, 24)
        Me.cboCardCompany.TabIndex = 11
        '
        'lblCardCompany
        '
        Me.lblCardCompany.AutoSize = True
        Me.lblCardCompany.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardCompany.ForeColor = System.Drawing.Color.White
        Me.lblCardCompany.Location = New System.Drawing.Point(54, 114)
        Me.lblCardCompany.Name = "lblCardCompany"
        Me.lblCardCompany.Size = New System.Drawing.Size(148, 27)
        Me.lblCardCompany.TabIndex = 2
        Me.lblCardCompany.Text = "Card Company"
        '
        'cboCardType
        '
        Me.cboCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardType.FormattingEnabled = True
        Me.cboCardType.Items.AddRange(New Object() {"Debit Card", "Credit Card"})
        Me.cboCardType.Location = New System.Drawing.Point(59, 73)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(215, 24)
        Me.cboCardType.TabIndex = 10
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardType.ForeColor = System.Drawing.Color.White
        Me.lblCardType.Location = New System.Drawing.Point(51, 43)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(105, 27)
        Me.lblCardType.TabIndex = 0
        Me.lblCardType.Text = "Card Type"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(665, 489)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 93)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'frmRegister
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(954, 631)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpCreditDetails)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.grpPersonalDetails)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.grpPersonalDetails.PerformLayout()
        Me.grpCreditDetails.ResumeLayout(False)
        Me.grpCreditDetails.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblRetype As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRetype As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents grpPersonalDetails As GroupBox
    Friend WithEvents grpCreditDetails As GroupBox
    Friend WithEvents cboCardCompany As ComboBox
    Friend WithEvents lblCardCompany As Label
    Friend WithEvents cboCardType As ComboBox
    Friend WithEvents lblCardType As Label
    Friend WithEvents txtCCV As TextBox
    Friend WithEvents lblCCV As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents cboUserType As ComboBox
    Friend WithEvents lblUserType As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents err As ErrorProvider
End Class
