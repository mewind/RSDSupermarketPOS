<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FailLogin
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
        Me.lblSorry = New System.Windows.Forms.Label()
        Me.lblTryagain = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSorry
        '
        Me.lblSorry.AutoSize = True
        Me.lblSorry.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorry.ForeColor = System.Drawing.Color.Maroon
        Me.lblSorry.Location = New System.Drawing.Point(21, 43)
        Me.lblSorry.Name = "lblSorry"
        Me.lblSorry.Size = New System.Drawing.Size(601, 32)
        Me.lblSorry.TabIndex = 0
        Me.lblSorry.Text = "We're sorry, you've attempt to login more than 3 times."
        '
        'lblTryagain
        '
        Me.lblTryagain.AutoSize = True
        Me.lblTryagain.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTryagain.ForeColor = System.Drawing.Color.Red
        Me.lblTryagain.Location = New System.Drawing.Point(112, 96)
        Me.lblTryagain.Name = "lblTryagain"
        Me.lblTryagain.Size = New System.Drawing.Size(363, 32)
        Me.lblTryagain.TabIndex = 1
        Me.lblTryagain.Text = "Please try again after 30 seconds"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(201, 209)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(252, 72)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeLeft.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.Gray
        Me.lblTimeLeft.Location = New System.Drawing.Point(272, 151)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(41, 34)
        Me.lblTimeLeft.TabIndex = 3
        Me.lblTimeLeft.Text = "    "
        '
        'FailLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 344)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTryagain)
        Me.Controls.Add(Me.lblSorry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FailLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FailLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSorry As Label
    Friend WithEvents lblTryagain As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimeLeft As Label
End Class
