Public Class frmClothing
    Private Sub frmClothing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClothing.SelectedIndex = 0
        bindData()
    End Sub


    'Bind the products with "Clothing" from database
    Private Sub bindData()

        Dim name As String = txtClothing.Text
        Dim category As String = cboClothing.Text

        Dim db As New DBDataContext()
        If cboClothing.SelectedIndex = 0 Then
            Dim rs = From product In db.Products
                     Where product.product_name.Contains(name) _
                     And product.product_catagory = "Clothing"

            dgvClothing.DataSource = rs
        Else
            Dim rs = From product In db.Products
                     Where product.product_name.Contains(name) _
                     And product.product_catagory = "Clothing" _
                     And product.product_type.Contains(category)


            dgvClothing.DataSource = rs
        End If




    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

      Private Sub dgvClothing_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClothing.CellContentDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvClothing.Rows(i).Cells(0).Value)
            frmToCart.chosenProductId = id
            frmToCart.ShowDialog()
            bindData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

     Private Sub txtClothing_TextChanged(sender As Object, e As EventArgs) Handles txtClothing.TextChanged
        bindData()
    End Sub
    Private Sub cboClothing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClothing.SelectedIndexChanged
        bindData()
    End Sub
End Class