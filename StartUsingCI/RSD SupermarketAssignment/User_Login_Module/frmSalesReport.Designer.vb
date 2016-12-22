<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnSalesAugust = New System.Windows.Forms.Button()
        Me.btnSalesJuly = New System.Windows.Forms.Button()
        Me.btnSalesJune = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSalesReport = New System.Windows.Forms.Label()
        Me.dlgPrintSalesJune = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSalesJune = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintSalesJuly = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSalesJuly = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintSalesAug = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSalesAug = New System.Drawing.Printing.PrintDocument()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.User_Login_Module.My.Resources.Resources.close_button_128
        Me.btnClose.Location = New System.Drawing.Point(885, 48)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 36
        Me.btnClose.TabStop = False
        '
        'btnSalesAugust
        '
        Me.btnSalesAugust.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesAugust.Location = New System.Drawing.Point(630, 150)
        Me.btnSalesAugust.Name = "btnSalesAugust"
        Me.btnSalesAugust.Size = New System.Drawing.Size(272, 170)
        Me.btnSalesAugust.TabIndex = 35
        Me.btnSalesAugust.Text = "Sales Report For August"
        Me.btnSalesAugust.UseVisualStyleBackColor = True
        '
        'btnSalesJuly
        '
        Me.btnSalesJuly.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesJuly.Location = New System.Drawing.Point(332, 150)
        Me.btnSalesJuly.Name = "btnSalesJuly"
        Me.btnSalesJuly.Size = New System.Drawing.Size(272, 170)
        Me.btnSalesJuly.TabIndex = 34
        Me.btnSalesJuly.Text = "Sales Report For July"
        Me.btnSalesJuly.UseVisualStyleBackColor = True
        '
        'btnSalesJune
        '
        Me.btnSalesJune.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesJune.Location = New System.Drawing.Point(38, 150)
        Me.btnSalesJune.Name = "btnSalesJune"
        Me.btnSalesJune.Size = New System.Drawing.Size(272, 170)
        Me.btnSalesJune.TabIndex = 33
        Me.btnSalesJune.Text = "Sales Report For June"
        Me.btnSalesJune.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.User_Login_Module.My.Resources.Resources.dollar2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'lblSalesReport
        '
        Me.lblSalesReport.AutoSize = True
        Me.lblSalesReport.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesReport.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesReport.ForeColor = System.Drawing.Color.Lime
        Me.lblSalesReport.Location = New System.Drawing.Point(47, 48)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(127, 25)
        Me.lblSalesReport.TabIndex = 31
        Me.lblSalesReport.Text = "Sales Report"
        '
        'dlgPrintSalesJune
        '
        Me.dlgPrintSalesJune.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesJune.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesJune.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintSalesJune.Enabled = True
        Me.dlgPrintSalesJune.Icon = CType(resources.GetObject("dlgPrintSalesJune.Icon"), System.Drawing.Icon)
        Me.dlgPrintSalesJune.Name = "dlgPrintSalesJune"
        Me.dlgPrintSalesJune.Visible = False
        '
        'dlgPrintSalesJuly
        '
        Me.dlgPrintSalesJuly.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesJuly.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesJuly.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintSalesJuly.Enabled = True
        Me.dlgPrintSalesJuly.Icon = CType(resources.GetObject("dlgPrintSalesJuly.Icon"), System.Drawing.Icon)
        Me.dlgPrintSalesJuly.Name = "dlgPrintSalesJuly"
        Me.dlgPrintSalesJuly.Visible = False
        '
        'dlgPrintSalesAug
        '
        Me.dlgPrintSalesAug.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesAug.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintSalesAug.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintSalesAug.Enabled = True
        Me.dlgPrintSalesAug.Icon = CType(resources.GetObject("dlgPrintSalesAug.Icon"), System.Drawing.Icon)
        Me.dlgPrintSalesAug.Name = "dlgPrintSalesAug"
        Me.dlgPrintSalesAug.Visible = False
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 363)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSalesAugust)
        Me.Controls.Add(Me.btnSalesJuly)
        Me.Controls.Add(Me.btnSalesJune)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSalesReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesReport"
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnSalesAugust As Button
    Friend WithEvents btnSalesJuly As Button
    Friend WithEvents btnSalesJune As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSalesReport As Label
    Friend WithEvents dlgPrintSalesJune As PrintPreviewDialog
    Friend WithEvents PrintSalesJune As Printing.PrintDocument
    Friend WithEvents dlgPrintSalesJuly As PrintPreviewDialog
    Friend WithEvents PrintSalesJuly As Printing.PrintDocument
    Friend WithEvents dlgPrintSalesAug As PrintPreviewDialog
    Friend WithEvents PrintSalesAug As Printing.PrintDocument
End Class
