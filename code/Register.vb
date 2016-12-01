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

    '<----------------VALIDATING --------------------------->
    'Check whther txtUsername is empty 
    Private Sub txtUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating
        Dim username As String = If(txtUsername.Text, " ")

        If username = "" Then
            err.SetError(txtUsername, "Please enter a valid [Username]")
            e.Cancel = True
        ElseIf IsDuplicatedUser(username) Then
            err.SetError(txtUsername, "Username is duplicated")
            e.Cancel = True
        Else
            err.SetError(txtUsername, Nothing)
        End If
    End Sub

    'Check whther txtEmail is empty 
    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email As String = If(txtEmail.Text, " ")

        If email = "" Then
            err.SetError(txtEmail, "Please enter a valid [Email]")
            e.Cancel = True
        ElseIf IsDuplicatedEmail(email) Then
            err.SetError(txtEmail, "This email have been registered by another account")
            e.Cancel = True
        Else
            err.SetError(txtEmail, Nothing)
        End If
    End Sub
    'Check whther txtPassword is empty 
    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Dim password As String = If(txtPassword.Text, " ")

        If password = "" Then
            err.SetError(txtPassword, "Please enter a valid [password]")
            e.Cancel = True
        Else
            err.SetError(txtPassword, Nothing)
        End If
    End Sub
    'Check whether cboRetype is empty 
    Private Sub txtRetype_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRetype.Validating
        Dim confirm As Boolean

        confirm = ValidatePassword(txtPassword.Text, txtRetype.Text)
        If confirm = False Then
            err.SetError(txtRetype, "Your password is unmatch!")
            e.Cancel = True

        Else
            err.SetError(txtRetype, Nothing)
        End If

    End Sub
    'Check whther cboUserType is empty 
    Private Sub cboUserType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboUserType.Validating
        Dim usertype As String = If(cboUserType.Text, " ")

        If usertype = "" Then
            err.SetError(cboUserType, "Please Select your user type")
            e.Cancel = True
        Else
            err.SetError(cboUserType, Nothing)
        End If
    End Sub
    'Check whther cboCardType is empty 
    Private Sub cboCardType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCardType.Validating
        Dim cardtype As String = If(cboCardType.Text, " ")

        If cardtype = "" Then
            err.SetError(cboCardType, "Please Select your card type")
            e.Cancel = True
        Else
            err.SetError(cboCardType, Nothing)
        End If
    End Sub

    'Check whether txtCCV is empty 
    Private Sub txtCCV_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCCV.Validating
        Dim ccv As String = If(txtCCV.Text, " ")

        If ccv = "" Then
            err.SetError(txtCCV, "Please Enter a valid CCV")
            e.Cancel = True
        Else
            err.SetError(txtCCV, Nothing)
        End If
    End Sub
    'Check whther cboCardCompany is empty 
    Private Sub cboCardCompany_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCardCompany.Validating
        Dim cardcompany As String = If(cboCardCompany.Text, " ")

        If cardcompany = "" Then
            err.SetError(cboCardCompany, "Please Select your Card Company")
            e.Cancel = True
        Else
            err.SetError(cboCardCompany, Nothing)
        End If
    End Sub

End Class