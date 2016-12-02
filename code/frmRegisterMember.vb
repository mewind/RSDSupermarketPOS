Public Class frmRegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        Dim member As New Member

        lblMemberID.Text = "MEMB00" & (db.Members.Count() + 1).ToString()

        txtName.Clear()
        txtPhone.Clear()
        txtName.Focus()
    End Sub

Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New DBDataContext()
        Dim member As New Member



        member.member_id = "MEMB00" & (db.Members.Count() + 1).ToString()
        member.member_name = txtName.Text
        member.member_phone = txtPhone.Text
        If radMale.Checked = True Then member.member_gender = "Male"
        If radFemale.Checked = True Then member.member_gender = "Female"
        member.member_point = 0


        db.Members.InsertOnSubmit(member)


        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = frmUserLogin.LoginUserID)

        user.member_id = member.member_id

        db.Users.DeleteOnSubmit(user)
        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()


        MessageBox.Show("Register Succesfull, Please re-login to continue !", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmHome.ShowDialog(Me)
        Me.Close()

    End Sub
                
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtName.Text = ""
        radFemale.Checked = False
        radMale.Checked = False
        txtPhone.Text = ""
        txtName.Focus()
        txtName.SelectAll()
    End Sub
    

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
                
                 Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating

        If txtName.Text = "" Then
            err.SetError(txtName, "Please enter your name")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If

    End Sub

    Private Sub txtPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPhone.Validating

        If txtPhone.Text = "" Then
            err.SetError(txtPhone, "Please enter a valid CCV!")
            e.Cancel = True
        Else
            err.SetError(txtPhone, Nothing)
        End If

    End Sub
End Class
