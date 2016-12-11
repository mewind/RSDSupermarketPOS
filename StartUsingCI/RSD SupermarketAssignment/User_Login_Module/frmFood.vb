Public Class frmFood
    Private Sub frmFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFood.SelectedIndex = 0
        bindData()
    End Sub
    'Bind the products with category "Food" from databse
  Private Sub bindData()
        Dim name As String = txtFood.Text
        Dim category As String = cboFood.Text

        Dim db As New DBDataContext()
        If cboFood.SelectedIndex = 0 Then
            Dim rs = From product In db.Products
                     Where product.product_name.Contains(name) _
                     And product.product_catagory = "Food"


            dgvFood.DataSource = rs
        Else
            Dim rs = From product In db.Products
                     Where product.product_name.Contains(name) _
                     And product.product_catagory = "Food" _
                     And product.product_type.Contains(category)
            dgvFood.DataSource = rs
        End If

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

      Private Sub dgvFood_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFood.CellContentDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvFood.Rows(i).Cells("product_id").Value)
            frmToCart.chosenProductId = id
            frmToCart.ShowDialog()
            bindData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

 Private Sub txtFood_TextChanged(sender As Object, e As EventArgs) Handles txtFood.TextChanged
        bindData()
    End Sub
    Private Sub cboFood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFood.SelectedIndexChanged
        bindData()
    End Sub
End Class