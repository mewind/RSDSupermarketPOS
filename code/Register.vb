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
    'check whther STAFFID is empty when STAFFS is selected in the cbox
    Private Sub txtStaffID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStaffID.Validating
        If cboUserType.Text = "Staff" Then
            Dim staffid As String = If(txtStaffID.Text, " ")

            If staffid = "" Then
                err.SetError(txtStaffID, "Please enter your staff ID")
                e.Cancel = True

            Else
                err.SetError(txtStaffID, Nothing)
            End If
        End If


    End Sub

    'check whether MEMBER ID is empty when MEMBERS is selected in the cbox
    Private Sub txtMemberID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMemberID.Validating

        If cboUserType.Text = "Member" Then
            Dim memberid As String = If(txtMemberID.Text, " ")

            If memberid = "" Then
                err.SetError(txtMemberID, "Please enter your member ID")
                e.Cancel = True


            Else
                err.SetError(txtMemberID, Nothing)
            End If


        End If


    End Sub
    '<----------------VALIDATING --------------------------->


    'VALIDATE STAFF ID
    Private Function ValidateStaff(staffid As String) As Boolean
        Dim db As New DBDataContext()

        Dim staff As Staff = db.Staffs.SingleOrDefault(Function(s) s.staff_id = staffid)

        Return (staff IsNot Nothing)
    End Function

    'VALIDATE MEMBER ID
    Private Function ValidateMember(memberid As String) As Boolean
        Dim db As New DBDataContext()

        Dim member As Member = db.Members.SingleOrDefault(Function(m) m.member_id = memberid)

        Return (member IsNot Nothing)
    End Function

    'btnRegister Clicked  
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'FORMAT
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 2


        Dim ismember As Boolean = ValidateMember(txtMemberID.Text)
        If ismember = False Then
            err.SetError(txtMemberID, "You've entered the wrong MemberID!")
        Else
            err.SetError(txtMemberID, Nothing)
        End If

        Dim isstaff As Boolean = ValidateStaff(txtStaffID.Text)
        If isstaff = False Then
            err.SetError(txtStaffID, "You've entered the wrong StaffID!")
        Else
            err.SetError(txtStaffID, Nothing)
        End If


        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New DBDataContext()
        Dim user As New User

        'Insert new user
        user.user_id = "RSD000" & (db.Users.Count() + 1).ToString

        user.user_name = txtUsername.Text
        user.user_password = txtPassword.Text
        user.user_email = txtEmail.Text
        If cboCardType.SelectedItem = "Debit Card" Then
            user.user_cardtype = "Debit"
        ElseIf cboCardType.SelectedItem = "Credit Card" Then
            user.user_cardtype = "Credit"
        End If
        user.user_ccompany = ""
        user.user_CCV = ""
        user.staff_id = ""
        user.member_id = ""
        user.user_ccompany = cboCardCompany.Text
        user.user_CCV = txtCCV.Text

        If cboUserType.SelectedItem = "Member" Then

            user.member_id = txtMemberID.Text
            user.staff_id = Nothing
        ElseIf cboUserType.SelectedItem = "Staff" Then
            user.staff_id = txtStaffID.Text
            user.staff_id = Nothing
        ElseIf cboUserType.SelectedItem = "Non-member" Then
            user.staff_id = Nothing
            user.member_id = Nothing
        End If

        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        If btnRegister.Enabled = True Then
            MessageBox.Show("Congratulations! You have registered successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None)

            frmUserLogin.Show()
            Me.Hide()

        End If


    End Sub


End Class