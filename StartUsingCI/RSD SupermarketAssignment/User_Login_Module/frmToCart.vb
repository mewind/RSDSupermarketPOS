Public Class frmToCart
    Public chosenProductId As String

  
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtQuantity.Clear()
        txtQuantity.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Dim quantity As Integer

        Try
            quantity = CInt(txtQuantity.Text)

        Catch ex As Exception
            MessageBox.Show("Only Numbers are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'New sales id 
        Dim salesid = "S" + (Date.Now).ToString("ddMM") + "0" + ((frmUserLogin.SCount)).ToString()

        Dim db As New DBDataContext()
        Dim product As Product = db.Products.SingleOrDefault(Function(p) p.product_id = chosenProductId)
        Dim sales As New Sale

        'Check quantity 
        If product.product_quantity - quantity < 0 Then
            MessageBox.Show("Product is out of stock or not enough to fulfill the order.", "Insufficient Product", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Validate whether quantity input >0
        ElseIf quantity = 0 Then
            MessageBox.Show("Please enter a quantity which is more than 0")

        Else

            sales.product_id = chosenProductId
            sales.user_id = frmUserLogin.LoginUserID
            sales.quantity = quantity
            sales.sales_id = salesid
            sales.purchase_date = DateTime.Parse((Date.Now).ToString("dd/MM/yyyy hh:mm:ss tt"))

            db.Sales.InsertOnSubmit(sales)
            db.SubmitChanges()
            MessageBox.Show("Item added to cart successfully!")
            Me.Close()
        End If



        'PASS CURRENT SALES ID
       FrmPaymentUpdate.CurrentSalesId = sales.sales_id


    End Sub
    Private Sub frmToCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQuantity.Text = ""
        Dim db As New DBDataContext()
        Dim product As Product = db.Products.SingleOrDefault(Function(p) p.product_id = chosenProductId)

        lblId.Text = product.product_id
        lblName.Text = product.product_name
        txtQuantity.Focus()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmToCart_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtQuantity.Text = ""
        Dim db As New DBDataContext()
        Dim product As Product = db.Products.SingleOrDefault(Function(p) p.product_id = chosenProductId)

        lblId.Text = product.product_id
        lblName.Text = product.product_name
        txtQuantity.Focus()

    End Sub
End Class