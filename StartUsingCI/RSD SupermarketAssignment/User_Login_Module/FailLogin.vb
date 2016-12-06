Public Class FailLogin
    Private timeLeft As Integer
    Private Sub FailLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start the timer
        timeLeft = 30
        lblTimeLeft.Text = "30 seconds"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            'Display the new time left by updating Time Left Label
            btnOK.Enabled = False
            timeLeft -= 1
            lblTimeLeft.Text = timeLeft & " seconds"
        Else
            Timer1.Stop()
            'If user ran out of time, enable OK button
            btnOK.Enabled = True
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        frmUserLogin.Show()
        frmUserLogin.attempt = 0
    End Sub
End Class