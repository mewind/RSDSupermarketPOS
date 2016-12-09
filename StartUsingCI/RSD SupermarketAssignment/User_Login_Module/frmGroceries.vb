﻿Public Class frmGroceries
    Private Sub frmGroceries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bindData()
    End Sub

    'Bind the products with category "Groceries" from databse
    Private Sub bindData()


        Dim db As New DBDataContext()

        Dim rs = From product In db.Products
                 Where product.product_catagory = "Groceries"


        dgvGroceries.DataSource = rs




    End Sub

    Private Sub txtGroceries_TextChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub
    Private Sub cboGroceries_SelectedIndexChanged(sender As Object, e As EventArgs)
        bindData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

 Private Sub dgvGroceries_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroceries.CellContentDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvGroceries.Rows(i).Cells(0).Value)
            frmToCart.chosenProductId = id
            frmToCart.ShowDialog()
            bindData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class