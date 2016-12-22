<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSummary))
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnSummaryAugust = New System.Windows.Forms.Button()
        Me.btnSummaryJuly = New System.Windows.Forms.Button()
        Me.btnSummaryJune = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblExceptionReport = New System.Windows.Forms.Label()
        Me.dlgPrintCardJune = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgPrintCardJuly = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgPrintCardAug = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintCardJune = New System.Drawing.Printing.PrintDocument()
        Me.PrintCardJuly = New System.Drawing.Printing.PrintDocument()
        Me.PrintCardAug = New System.Drawing.Printing.PrintDocument()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.User_Login_Module.My.Resources.Resources.close_button_128
        Me.btnClose.Location = New System.Drawing.Point(885, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 48
        Me.btnClose.TabStop = False
        '
        'btnSummaryAugust
        '
        Me.btnSummaryAugust.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryAugust.Location = New System.Drawing.Point(630, 121)
        Me.btnSummaryAugust.Name = "btnSummaryAugust"
        Me.btnSummaryAugust.Size = New System.Drawing.Size(272, 170)
        Me.btnSummaryAugust.TabIndex = 47
        Me.btnSummaryAugust.Text = "Card Transactions Report For August"
        Me.btnSummaryAugust.UseVisualStyleBackColor = True
        '
        'btnSummaryJuly
        '
        Me.btnSummaryJuly.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryJuly.Location = New System.Drawing.Point(332, 121)
        Me.btnSummaryJuly.Name = "btnSummaryJuly"
        Me.btnSummaryJuly.Size = New System.Drawing.Size(272, 170)
        Me.btnSummaryJuly.TabIndex = 46
        Me.btnSummaryJuly.Text = "Card Transactions Report For July"
        Me.btnSummaryJuly.UseVisualStyleBackColor = True
        '
        'btnSummaryJune
        '
        Me.btnSummaryJune.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryJune.Location = New System.Drawing.Point(38, 121)
        Me.btnSummaryJune.Name = "btnSummaryJune"
        Me.btnSummaryJune.Size = New System.Drawing.Size(272, 170)
        Me.btnSummaryJune.TabIndex = 45
        Me.btnSummaryJune.Text = "Card Transactions Report For June"
        Me.btnSummaryJune.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.User_Login_Module.My.Resources.Resources.summary2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'lblExceptionReport
        '
        Me.lblExceptionReport.AutoSize = True
        Me.lblExceptionReport.BackColor = System.Drawing.Color.Transparent
        Me.lblExceptionReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExceptionReport.ForeColor = System.Drawing.Color.Lime
        Me.lblExceptionReport.Location = New System.Drawing.Point(47, 19)
        Me.lblExceptionReport.Name = "lblExceptionReport"
        Me.lblExceptionReport.Size = New System.Drawing.Size(172, 25)
        Me.lblExceptionReport.TabIndex = 43
        Me.lblExceptionReport.Text = "Summary Report"
        '
        'dlgPrintCardJune
        '
        Me.dlgPrintCardJune.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardJune.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardJune.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintCardJune.Enabled = True
        Me.dlgPrintCardJune.Icon = CType(resources.GetObject("dlgPrintCardJune.Icon"), System.Drawing.Icon)
        Me.dlgPrintCardJune.Name = "dlgPrintCardJune"
        Me.dlgPrintCardJune.Visible = False
        '
        'dlgPrintCardJuly
        '
        Me.dlgPrintCardJuly.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardJuly.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardJuly.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintCardJuly.Enabled = True
        Me.dlgPrintCardJuly.Icon = CType(resources.GetObject("dlgPrintCardJuly.Icon"), System.Drawing.Icon)
        Me.dlgPrintCardJuly.Name = "dlgPrintCardJuly"
        Me.dlgPrintCardJuly.Visible = False
        '
        'dlgPrintCardAug
        '
        Me.dlgPrintCardAug.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardAug.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintCardAug.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintCardAug.Enabled = True
        Me.dlgPrintCardAug.Icon = CType(resources.GetObject("dlgPrintCardAug.Icon"), System.Drawing.Icon)
        Me.dlgPrintCardAug.Name = "dlgPrintCardAug"
        Me.dlgPrintCardAug.Visible = False
        '
        'FrmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 356)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSummaryAugust)
        Me.Controls.Add(Me.btnSummaryJuly)
        Me.Controls.Add(Me.btnSummaryJune)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblExceptionReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSummary"
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnSummaryAugust As Button
    Friend WithEvents btnSummaryJuly As Button
    Friend WithEvents btnSummaryJune As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblExceptionReport As Label
    Friend WithEvents dlgPrintCardJune As PrintPreviewDialog
    Friend WithEvents dlgPrintCardJuly As PrintPreviewDialog
    Friend WithEvents dlgPrintCardAug As PrintPreviewDialog
    Friend WithEvents PrintCardJune As Printing.PrintDocument
    Friend WithEvents PrintCardJuly As Printing.PrintDocument
    Friend WithEvents PrintCardAug As Printing.PrintDocument
End Class
