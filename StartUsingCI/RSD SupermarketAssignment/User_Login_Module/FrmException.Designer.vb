<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmException
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmException))
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnExpAugust = New System.Windows.Forms.Button()
        Me.btnExpJuly = New System.Windows.Forms.Button()
        Me.btnExpJune = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblExceptionReport = New System.Windows.Forms.Label()
        Me.dlgLeastSalesJune = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgLeastSalesJuly = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgLeastSalesAug = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintLeastSaleJune = New System.Drawing.Printing.PrintDocument()
        Me.PrintLeastSaleJuly = New System.Drawing.Printing.PrintDocument()
        Me.PrintLeastSaleAug = New System.Drawing.Printing.PrintDocument()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.User_Login_Module.My.Resources.Resources.close_button_128
        Me.btnClose.Location = New System.Drawing.Point(885, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 42
        Me.btnClose.TabStop = False
        '
        'btnExpAugust
        '
        Me.btnExpAugust.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpAugust.Location = New System.Drawing.Point(630, 119)
        Me.btnExpAugust.Name = "btnExpAugust"
        Me.btnExpAugust.Size = New System.Drawing.Size(272, 170)
        Me.btnExpAugust.TabIndex = 41
        Me.btnExpAugust.Text = "Least Sale Report For August"
        Me.btnExpAugust.UseVisualStyleBackColor = True
        '
        'btnExpJuly
        '
        Me.btnExpJuly.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpJuly.Location = New System.Drawing.Point(332, 119)
        Me.btnExpJuly.Name = "btnExpJuly"
        Me.btnExpJuly.Size = New System.Drawing.Size(272, 170)
        Me.btnExpJuly.TabIndex = 40
        Me.btnExpJuly.Text = "Least Sale Report For July"
        Me.btnExpJuly.UseVisualStyleBackColor = True
        '
        'btnExpJune
        '
        Me.btnExpJune.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpJune.Location = New System.Drawing.Point(38, 119)
        Me.btnExpJune.Name = "btnExpJune"
        Me.btnExpJune.Size = New System.Drawing.Size(272, 170)
        Me.btnExpJune.TabIndex = 39
        Me.btnExpJune.Text = "Least Sale Report For June"
        Me.btnExpJune.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.User_Login_Module.My.Resources.Resources.exception2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'lblExceptionReport
        '
        Me.lblExceptionReport.AutoSize = True
        Me.lblExceptionReport.BackColor = System.Drawing.Color.Transparent
        Me.lblExceptionReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExceptionReport.ForeColor = System.Drawing.Color.Lime
        Me.lblExceptionReport.Location = New System.Drawing.Point(47, 17)
        Me.lblExceptionReport.Name = "lblExceptionReport"
        Me.lblExceptionReport.Size = New System.Drawing.Size(176, 25)
        Me.lblExceptionReport.TabIndex = 37
        Me.lblExceptionReport.Text = "Exception Report"
        '
        'dlgLeastSalesJune
        '
        Me.dlgLeastSalesJune.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesJune.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesJune.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgLeastSalesJune.Enabled = True
        Me.dlgLeastSalesJune.Icon = CType(resources.GetObject("dlgLeastSalesJune.Icon"), System.Drawing.Icon)
        Me.dlgLeastSalesJune.Name = "dlgLeastSalesJune"
        Me.dlgLeastSalesJune.Visible = False
        '
        'dlgLeastSalesJuly
        '
        Me.dlgLeastSalesJuly.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesJuly.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesJuly.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgLeastSalesJuly.Enabled = True
        Me.dlgLeastSalesJuly.Icon = CType(resources.GetObject("dlgLeastSalesJuly.Icon"), System.Drawing.Icon)
        Me.dlgLeastSalesJuly.Name = "dlgLeastSalesJuly"
        Me.dlgLeastSalesJuly.Visible = False
        '
        'dlgLeastSalesAug
        '
        Me.dlgLeastSalesAug.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesAug.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgLeastSalesAug.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgLeastSalesAug.Enabled = True
        Me.dlgLeastSalesAug.Icon = CType(resources.GetObject("dlgLeastSalesAug.Icon"), System.Drawing.Icon)
        Me.dlgLeastSalesAug.Name = "dlgLeastSalesAug"
        Me.dlgLeastSalesAug.Visible = False
        '
        'FrmException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(936, 324)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExpAugust)
        Me.Controls.Add(Me.btnExpJuly)
        Me.Controls.Add(Me.btnExpJune)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblExceptionReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmException"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmException"
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnExpAugust As Button
    Friend WithEvents btnExpJuly As Button
    Friend WithEvents btnExpJune As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblExceptionReport As Label
    Friend WithEvents dlgLeastSalesJune As PrintPreviewDialog
    Friend WithEvents dlgLeastSalesJuly As PrintPreviewDialog
    Friend WithEvents dlgLeastSalesAug As PrintPreviewDialog
    Friend WithEvents PrintLeastSaleJune As Printing.PrintDocument
    Friend WithEvents PrintLeastSaleJuly As Printing.PrintDocument
    Friend WithEvents PrintLeastSaleAug As Printing.PrintDocument
End Class
