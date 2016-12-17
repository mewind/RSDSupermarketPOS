<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentUpdate
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
        Me.components = New System.ComponentModel.Container()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProductDes = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblNamePrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblNameProductID = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.err,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(220, 170)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Multiline = true
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(102, 28)
        Me.txtQuantity.TabIndex = 20
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = true
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(220, 132)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(108, 24)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "                        "
        '
        'lblProductDes
        '
        Me.lblProductDes.AutoSize = true
        Me.lblProductDes.BackColor = System.Drawing.Color.Transparent
        Me.lblProductDes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductDes.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProductDes.ForeColor = System.Drawing.Color.White
        Me.lblProductDes.Location = New System.Drawing.Point(220, 94)
        Me.lblProductDes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductDes.Name = "lblProductDes"
        Me.lblProductDes.Size = New System.Drawing.Size(108, 24)
        Me.lblProductDes.TabIndex = 18
        Me.lblProductDes.Text = "                        "
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = true
        Me.lblProductID.BackColor = System.Drawing.Color.Transparent
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductID.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProductID.ForeColor = System.Drawing.Color.White
        Me.lblProductID.Location = New System.Drawing.Point(220, 51)
        Me.lblProductID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(108, 24)
        Me.lblProductID.TabIndex = 17
        Me.lblProductID.Text = "                        "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCoral
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(455, 98)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 57)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = false
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Khaki
        Me.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.Black
        Me.btnChange.Location = New System.Drawing.Point(455, 35)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(134, 57)
        Me.btnChange.TabIndex = 15
        Me.btnChange.Text = "C&hange"
        Me.btnChange.UseVisualStyleBackColor = false
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = true
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(115, 166)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 22)
        Me.lblQuantity.TabIndex = 14
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblNamePrice
        '
        Me.lblNamePrice.AutoSize = true
        Me.lblNamePrice.BackColor = System.Drawing.Color.Transparent
        Me.lblNamePrice.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNamePrice.ForeColor = System.Drawing.Color.White
        Me.lblNamePrice.Location = New System.Drawing.Point(141, 131)
        Me.lblNamePrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamePrice.Name = "lblNamePrice"
        Me.lblNamePrice.Size = New System.Drawing.Size(48, 22)
        Me.lblNamePrice.TabIndex = 13
        Me.lblNamePrice.Text = "Price:"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = true
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.White
        Me.lblProductName.Location = New System.Drawing.Point(38, 96)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(149, 22)
        Me.lblProductName.TabIndex = 12
        Me.lblProductName.Text = "Product Description:"
        '
        'lblNameProductID
        '
        Me.lblNameProductID.AutoSize = true
        Me.lblNameProductID.BackColor = System.Drawing.Color.Transparent
        Me.lblNameProductID.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNameProductID.ForeColor = System.Drawing.Color.White
        Me.lblNameProductID.Location = New System.Drawing.Point(96, 51)
        Me.lblNameProductID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameProductID.Name = "lblNameProductID"
        Me.lblNameProductID.Size = New System.Drawing.Size(93, 22)
        Me.lblNameProductID.TabIndex = 11
        Me.lblNameProductID.Text = "Product ID :"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Update"
        '
        'FrmPaymentUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(628, 239)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblProductDes)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblNamePrice)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblNameProductID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPaymentUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPaymentUpdate"
        CType(Me.err,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProductDes As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblNamePrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblNameProductID As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents Label1 As Label
End Class
