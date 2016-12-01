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

    'IS DUPLICATED USERNAME    
    Private Function IsDuplicatedUser(username As String) As Boolean
        Dim db As New DBDataContext()

        If db.Users.Any(Function(user) user.user_name = txtUsername.Text) Then
            Return True
        End If
        Return False

    End Function

    'IS DUPLICATED EMAIL    
    Private Function IsDuplicatedEmail(email As String) As Boolean
        Dim db As New DBDataContext()

        If db.Users.Any(Function(user) user.user_email = txtEmail.Text) Then
            Return True
        End If
        Return False
    End Function

    'COMPARE PASSWORD & RETYPE PASSWORD
    Private Function ValidatePassword(password As String, retype As String) As Boolean
        If retype = password Then
            Return True

        Else
            Return False
        End If
    End Function

End Class