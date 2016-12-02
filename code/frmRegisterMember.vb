Public Class frmRegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        Dim member As New Member

        lblMemberID.Text = "MEMB00" & (db.Members.Count() + 1).ToString()

        txtName.Clear()
        txtPhone.Clear()
        txtName.Focus()
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
End Class