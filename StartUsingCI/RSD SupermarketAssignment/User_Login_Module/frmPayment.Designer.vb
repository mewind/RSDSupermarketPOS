<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.pnlPrice = New System.Windows.Forms.Panel()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCardCompany = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Receipt = New System.Drawing.Printing.PrintDocument()
        Me.dlgReceiptPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblEncouragement = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPrice.SuspendLayout
        Me.SuspendLayout
        '
        'pnlPrice
        '
        Me.pnlPrice.BackColor = System.Drawing.Color.DimGray
        Me.pnlPrice.Controls.Add(Me.lblGrandTotal)
        Me.pnlPrice.Controls.Add(Me.Label3)
        Me.pnlPrice.Location = New System.Drawing.Point(3, -2)
        Me.pnlPrice.Name = "pnlPrice"
        Me.pnlPrice.Size = New System.Drawing.Size(321, 46)
        Me.pnlPrice.TabIndex = 21
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrandTotal.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblGrandTotal.Location = New System.Drawing.Point(133, 12)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(124, 23)
        Me.lblGrandTotal.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grand Total :"
        '
        'lblCardCompany
        '
        Me.lblCardCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCardCompany.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCardCompany.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblCardCompany.Location = New System.Drawing.Point(7, 109)
        Me.lblCardCompany.Name = "lblCardCompany"
        Me.lblCardCompany.Size = New System.Drawing.Size(134, 20)
        Me.lblCardCompany.TabIndex = 27
        Me.lblCardCompany.Text = "Card Company:"
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblDateTime.Location = New System.Drawing.Point(7, 89)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(292, 20)
        Me.lblDateTime.TabIndex = 26
        Me.lblDateTime.Text = "Date/Time:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Payment Successful!"
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.LightGray
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnNo.Location = New System.Drawing.Point(160, 205)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(92, 34)
        Me.btnNo.TabIndex = 24
        Me.btnNo.Text = "&No"
        Me.btnNo.UseVisualStyleBackColor = false
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.LightGray
        Me.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Palatino Linotype", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnYes.Location = New System.Drawing.Point(32, 205)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(92, 34)
        Me.btnYes.TabIndex = 23
        Me.btnYes.Text = "&Yes"
        Me.btnYes.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(12, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Do you want to print your receipt?"
        '
        'Receipt
        '
        Me.Receipt.DocumentName = "receipt"
        '
        'dlgReceiptPreview
        '
        Me.dlgReceiptPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgReceiptPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgReceiptPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgReceiptPreview.Enabled = true
        Me.dlgReceiptPreview.Icon = CType(resources.GetObject("dlgReceiptPreview.Icon"),System.Drawing.Icon)
        Me.dlgReceiptPreview.Name = "dlgReceiptPreview"
        Me.dlgReceiptPreview.Visible = false
        '
        'lblEncouragement
        '
        Me.lblEncouragement.AutoSize = true
        Me.lblEncouragement.BackColor = System.Drawing.Color.Green
        Me.lblEncouragement.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblEncouragement.ForeColor = System.Drawing.Color.White
        Me.lblEncouragement.Location = New System.Drawing.Point(305, 181)
        Me.lblEncouragement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEncouragement.Name = "lblEncouragement"
        Me.lblEncouragement.Size = New System.Drawing.Size(452, 19)
        Me.lblEncouragement.TabIndex = 28
        Me.lblEncouragement.Text = "Protect Mother Earth, you're encouraged not to print the receipt."
        '
        'timer1
        '
        Me.timer1.Enabled = true
        Me.timer1.Interval = 80
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 279)
        Me.Controls.Add(Me.pnlPrice)
        Me.Controls.Add(Me.lblCardCompany)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEncouragement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.pnlPrice.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pnlPrice As Panel
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCardCompany As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Receipt As Printing.PrintDocument
    Friend WithEvents dlgReceiptPreview As PrintPreviewDialog
    Friend WithEvents lblEncouragement As Label
    Friend WithEvents timer1 As Timer
End Class
