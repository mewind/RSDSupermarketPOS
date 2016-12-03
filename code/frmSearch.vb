Public Class frmSearch
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BindData()
        Dim name As String = txtName.Text
        Dim id As String = txtID.Text
        Dim db As New DBDataContext()

        If txtID.Text = "" Or txtName.Text = "" Then

            Dim rs = From u In db.Users
                     Where u.user_name.Contains(name) _
                     And u.user_id.Contains(id)


            dgv.DataSource = rs
            lblCount.Text = rs.Count().ToString("0 record(s)")

        Else
            Dim rs = From u In db.Users
                     Where u.user_name.Contains(name) Or
                     u.user_id.Contains(id)

            dgv.DataSource = rs

            lblCount.Text = rs.Count().ToString("0 record(s)")

        End If
        dgv.Columns(2).Visible = False
        dgv.Columns(3).Visible = False
        dgv.Columns(4).Visible = False
        dgv.Columns(5).Visible = False

    End Sub



    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        BindData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)


            BindData()

        End If
    End Sub
End Class