Public Class frmEditDetails
    Private Sub frmEditDetails_shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = frmUserLogin.LoginUserID)

        lblID.Text = "" & user.user_id
        lblUsername.Text = "" & user.user_name
        lblMemberID.Text = "" & user.member_id
        lblStaffID.Text = "" & user.staff_id


    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Me.ValidateChildren() = False Then
            Return

        End If


        Dim db As New DBDataContext()
        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = frmUserLogin.LoginUserID)

        user.user_cardtype = cboCardType.SelectedItem
        user.user_CCV = txtCCV.Text
        user.user_ccompany = cboCCompany.SelectedItem
        user.user_email = txtEmail.Text
        user.user_password = txtPassword.Text

        db.Users.DeleteOnSubmit(user)
        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        MsgBox("Succesfully Edited!", MessageBoxIcon.Information)

        Me.Close()
        frmViewDetails.Close()

    End Sub

    Private Sub cboCardType_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCardType.Validating
        Dim cardtype As String = If(cboCardType.SelectedItem, "")

        If cardtype = "" Then
            Err.SetError(cboCardType, "Please choose a card type!")
            e.Cancel = True
        Else
            Err.SetError(cboCardType, Nothing)
        End If

    End Sub

    Private Sub txtCCV_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCCV.Validating

        If txtCCV.Text = "" Then
            Err.SetError(txtCCV, "Please enter a valid CCV!")
            e.Cancel = True
        Else
            Err.SetError(txtCCV, Nothing)
        End If

    End Sub

    Private Sub cboCCompany_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCCompany.Validating
        Dim ccompany As String = If(cboCCompany.SelectedItem, "")
        If ccompany = "" Then
            Err.SetError(cboCCompany, "Please select a card company!")
            e.Cancel = True
        Else
            Err.SetError(cboCCompany, Nothing)
        End If

    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        If txtPassword.Text = "" Then
            Err.SetError(txtPassword, "Please enter the password!")
            e.Cancel = True
        Else
            Err.SetError(txtPassword, Nothing)
        End If

    End Sub

    Private Sub txtEmail_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If txtEmail.Text = "" Then
            Err.SetError(txtEmail, "Please enter a valid email address!")
            e.Cancel = True
        Else
            Err.SetError(txtEmail, Nothing)
        End If
    End Sub

End Class