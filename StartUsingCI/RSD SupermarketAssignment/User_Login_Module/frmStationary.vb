Public Class frmStationary
    Private Sub frmStationary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bindData()
    End Sub

    'Bind the products with category "Stationary" from databse
    Private Sub bindData()

        Dim db As New DBDataContext()

        Dim rs = From product In db.Products
                 Where product.product_catagory = "Stationary"


        dgvStationary.DataSource = rs



    End Sub

    Private Sub txtStationary_TextChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub
    Private Sub cboStationary_SelectedIndexChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

  Private Sub dgvStationary_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStationary.CellContentDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then

            Dim id As String = CStr(dgvStationary.Rows(i).Cells("product_id").Value)
            frmToCart.chosenProductId = id
            frmToCart.ShowDialog()
            bindData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class