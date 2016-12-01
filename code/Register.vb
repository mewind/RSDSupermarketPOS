Public Class frmRegister
    'FORMAT
    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.GreenYellow
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2
    End Sub

    'FORMAT
    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        btnRegister.BackColor = Color.Chartreuse
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2
    End Sub

    'CANCEL BUTTON
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        'Click to return User login page
        frmUserLogin.Show()
        Me.Hide()
    End Sub


End Class