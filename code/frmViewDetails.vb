Public Class frmViewDetails
    Private Sub frmViewDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = frmUserLogin.LoginUserID)

        lblID.Text = "" & user.user_id
        lblUsername.Text = "" & user.user_name
        lblCardtype.Text = "" & user.user_cardtype
        lblCCV.Text = "" & user.user_CCV
        lblCCompany.Text = "" & user.user_ccompany
        lblPassword.Text = "" & user.user_password
        lblEmail.Text = "" & user.user_email
        lblMemberID.Text = "" & user.member_id
        lblStaffID.Text = "" & user.staff_id


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEditDetails_Click(sender As Object, e As EventArgs) Handles btnEditDetails.Click
        frmEditDetails.ShowDialog(Me)
    End Sub
End Class