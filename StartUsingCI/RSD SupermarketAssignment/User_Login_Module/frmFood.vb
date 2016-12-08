Public Class frmFood
    Private Sub frmFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bindData()
    End Sub
    'Bind the products with category "Food" from databse
    Private Sub bindData()


        Dim db As New DBDataContext()

        Dim rs = From product In db.Products
                 Where product.product_catagory = "Food"


        dgvFood.DataSource = rs

    End Sub
    Private Sub txtFood_TextChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub
    Private Sub cboFood_SelectedIndexChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class