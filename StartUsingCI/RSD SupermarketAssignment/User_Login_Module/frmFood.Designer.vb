<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFood
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvFood = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFood = New System.Windows.Forms.ComboBox()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvFood,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.btnClose,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(405, 376)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 47)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = true
        '
        'dgvFood
        '
        Me.dgvFood.AllowUserToAddRows = false
        Me.dgvFood.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFood.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFood.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFood.Location = New System.Drawing.Point(34, 102)
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.ReadOnly = true
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFood.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFood.RowTemplate.Height = 24
        Me.dgvFood.Size = New System.Drawing.Size(502, 254)
        Me.dgvFood.TabIndex = 14
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.User_Login_Module.My.Resources.Resources.close_button_1_512
        Me.btnClose.Location = New System.Drawing.Point(540, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 26
        Me.btnClose.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.User_Login_Module.My.Resources.Resources.food2
        Me.PictureBox1.Location = New System.Drawing.Point(17, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(53, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 32)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "FOOD"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Double Click an item to buy it."
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(336, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Category:"
        '
        'cboFood
        '
        Me.cboFood.Font = New System.Drawing.Font("Palatino Linotype", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboFood.FormattingEnabled = true
        Me.cboFood.Items.AddRange(New Object() {"All", "Bread", "Spread"})
        Me.cboFood.Location = New System.Drawing.Point(411, 65)
        Me.cboFood.Name = "cboFood"
        Me.cboFood.Size = New System.Drawing.Size(121, 28)
        Me.cboFood.TabIndex = 30
        '
        'txtFood
        '
        Me.txtFood.Font = New System.Drawing.Font("Palatino Linotype", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFood.Location = New System.Drawing.Point(140, 68)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(190, 28)
        Me.txtFood.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Product Name:"
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.User_Login_Module.My.Resources.Resources.backgroundimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 446)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboFood)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFood"
        CType(Me.dgvFood,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.btnClose,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvFood As DataGridView
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboFood As ComboBox
    Friend WithEvents txtFood As TextBox
    Friend WithEvents Label1 As Label
End Class
