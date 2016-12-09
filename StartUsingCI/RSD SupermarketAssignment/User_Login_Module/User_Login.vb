Public Class frmUserLogin
    Public LoginUser As String
    Public LoginUserID As String
    Friend attempt As Integer = 0
    Public SCount As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFrom()
    End Sub

    Private Sub frmUserLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If chkRemember.Checked = True Then
            txtUsername.Text = LoginUser

            Dim db As New DBDataContext()
            Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_name = LoginUser)

            txtPassword.Text = user.user_password

            If user.member_id <> Nothing Then
                radCustomerMember.Checked = True

            ElseIf user.staff_id <> Nothing Then
                radStaff.Checked = True

            Else
                radCustomerNonMember.Checked = True
            End If

        Else
            ResetFrom()
        End If
    End Sub

    Private Sub frmUserLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If chkRemember.Checked = True Then
            txtUsername.Text = LoginUser

            Dim db As New DBDataContext()
            Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_name = LoginUser)

            txtPassword.Text = user.user_password

            If user.member_id <> Nothing Then
                radCustomerMember.Checked = True

            ElseIf user.staff_id <> Nothing Then
                radStaff.Checked = True

            Else
                radCustomerNonMember.Checked = True
            End If

        Else
            ResetFrom()
        End If
    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover

        btnLogin.BackColor = Color.Chartreuse
        btnLogin.FlatAppearance.BorderColor = Color.Black
        btnLogin.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave

        btnLogin.BackColor = Color.GreenYellow
        btnLogin.FlatAppearance.BorderColor = Color.Black
        btnLogin.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        txtUsername.Select()

        'changed color after user typed the input
        txtUsername.ForeColor = Color.Black

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        txtPassword.Select()

        'changed color after user typed the input
        txtPassword.ForeColor = Color.Black

    End Sub

    Private Sub btnLogin_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseClick

        btnLogin.FlatAppearance.BorderColor = Color.Black
        btnLogin.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click

        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2
        Dim frmRegister As New frmRegister
        frmRegister.Show()
        Me.Hide()

    End Sub

    Private Sub btnRegister_MouseLeave_1(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave

        btnRegister.BackColor = Color.GreenYellow
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover

        btnRegister.BackColor = Color.Chartreuse
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End

    End Sub

    'RESET FORM 
    Private Sub ResetFrom()
        txtUsername.Text = "Username"
        txtPassword.Text = "Password"
        radCustomerNonMember.Checked = True
        txtUsername.Focus()
        txtUsername.SelectAll()
        err.Clear()

    End Sub

    'Set error when txtUsername left empty
    Private Sub txtUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating
        Dim username As String = If(txtUsername.Text, "")

        If username = "" Then
            err.SetError(txtUsername, "Please enter your [username]")
            e.Cancel = True
        Else
            err.SetError(txtUsername, Nothing)

        End If
    End Sub

    'Set error when txtPassword left empty
    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Dim password As String = If(txtPassword.Text, "")

        If password = "" Then
            err.SetError(txtPassword, "Please enter your [username]")
            e.Cancel = True
        Else
            err.SetError(txtPassword, Nothing)
        End If
    End Sub

    'VALIDATION FUNCTION
    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim db As New DBDataContext()

        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_name = username AndAlso u.user_password = password)

        Return (user IsNot Nothing)
    End Function

    'Get logged in user id
    Private Function GetLoginUser(username As String, password As String) As String
        Dim db As New DBDataContext()

        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_name = username AndAlso u.user_password = password)

        Return user.user_id
    End Function


    'btnLOGIN clicked
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click



        'Format 
        btnLogin.FlatAppearance.BorderColor = Color.Black
        btnLogin.FlatAppearance.BorderSize = 2

        'Declaration
        Dim valid As Boolean
        Dim frmHome As New frmHome

        'ADD SALES COUNT FOR ADD TO CART
        SCount += 1

        'Validation of user
        valid = ValidateLogin(txtUsername.Text, txtPassword.Text)
        If valid = True Then

            'Call GetLoginUser to store the login userID
            LoginUserID = GetLoginUser(txtUsername.Text, txtPassword.Text)
            LoginUser = txtUsername.Text

            'Check whether choosing correct user type
            Dim db As New DBDataContext()
            Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = LoginUserID)

            If radCustomerMember.Checked = True Then
                'Clear the err for all
                err.SetError(radCustomerMember, Nothing)
                err.SetError(radStaff, Nothing)
                err.SetError(radCustomerNonMember, Nothing)

                If user.member_id Is Nothing Then
                    err.SetError(radCustomerMember, "You've selected a wrong usertype")
                    attempt += 1
                Else
                    'Show FORM HOME
                    frmHome.Show()
                    Me.Hide()
                End If
            End If

            If radStaff.Checked = True Then

                'Clear the err for all
                err.SetError(radCustomerMember, Nothing)
                err.SetError(radStaff, Nothing)
                err.SetError(radCustomerNonMember, Nothing)

                If user.staff_id Is Nothing Then
                    err.SetError(radStaff, "You've selected a wrong usertype")
                    attempt += 1
                Else
                    'Show FORM HOME
                    frmHome.Show()
                    Me.Hide()
                End If
            End If

            If radCustomerNonMember.Checked = True Then
                'Clear the err for all
                err.SetError(radCustomerMember, Nothing)
                err.SetError(radStaff, Nothing)
                err.SetError(radCustomerNonMember, Nothing)

                If (user.staff_id <> Nothing) Or (user.member_id <> Nothing) Then
                    err.SetError(radCustomerNonMember, "You've selected a wrong usertype")
                    attempt += 1
                Else
                    'Show FORM HOME
                    frmHome.Show()
                    Me.Hide()

                End If
            End If

        Else
            MessageBox.Show("Please enter a valid username and password", "ERROR",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
            attempt += 1

            txtUsername.Focus()
            txtUsername.SelectAll()
            txtPassword.SelectAll()

        End If

        If attempt > 3 Then
            FailLogin.ShowDialog(Me)
        End If



    End Sub


End Class

