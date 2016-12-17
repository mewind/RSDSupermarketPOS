Public Class FrmPaymentUpdate
    'TO USE IN OTHER FORMS
    Public ProductUpdate As String
    Public DatePurchase As DateTime
    Public CurrentSalesId As String

    'LOAD FORM
    Private Sub FrmPaymentUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetform()
    End Sub

    'CLOSE FORM
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'FORM SHOWN
    Private Sub FrmPaymentUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'RESET THE FORM EVERYTIME THE FORM IS SHOWN
        resetform()

        Dim db As New DBDataContext()

        'SELECT THE RECORD WITH THE SELECTED PRODUCT AND PURCHASE DATE
        Try
            Dim sales As Sale = db.Sales.SingleOrDefault(Function(s) s.product_id = ProductUpdate AndAlso s.purchase_date = DatePurchase AndAlso s.user_id = frmUserLogin.LoginUserID)

            Dim product As Product = db.Products.SingleOrDefault(Function(p) p.product_id = ProductUpdate)

            'IF THERE'S NOTHING IN THE DATABASE
            If sales Is Nothing Then
                MessageBox.Show("We're sorry, please select an item to update", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            'DISPLAY THE OUTPUT
            lblProductID.Text = sales.product_id
            lblProductDes.Text = product.product_name
            lblPrice.Text = product.product_price

        Catch exception As Exception
            MessageBox.Show("Please select an item to update", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    'VALIDATE 
    Private Sub txtQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQuantity.Validating


        Dim quantity As String = If(txtQuantity.Text, " ")

        If quantity = "" Then
            err.SetError(txtQuantity, "Please enter quantity")
            e.Cancel = True
        Else
            err.SetError(txtQuantity, Nothing)

        End If
    End Sub



    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If Me.ValidateChildren = False Then
            Return
        End If
        'SELECT RECORD THAT MEETS THE CONDITION

        Dim db As New DBDataContext()
        Dim sales As Sale = db.Sales.SingleOrDefault(Function(s) s.product_id = ProductUpdate AndAlso s.user_id = frmUserLogin.LoginUserID AndAlso s.purchase_date = DatePurchase)
        Dim product As Product = db.Products.SingleOrDefault(Function(p) p.product_id = ProductUpdate)
       
        
        'If sales Is Nothing Then
        '    MessageBox.Show("We're sorry, we couldn't found anything in your cart.", "Error",
        '                    MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End If



        ' IF USER ENTER 0 WHEN UPDATING THE QUANTITY OF PURCHASE, THAT MEANS THEY WANT TO DELETE THE RECORD
        ' THEREFORE, WE DO THE DELETION FOR THE PARTICULAR ITEM

        If txtQuantity.Text = 0 Then

            db.Sales.DeleteOnSubmit(sales)
            db.SubmitChanges()

            MessageBox.Show("Updated with your latest purchase! Enjoy Shopping! ")
            Me.Close()

        ElseIf product.product_quantity - Integer.parse(txtQuantity.Text) < 0 Then
            MessageBox.Show("Product is out of stock or not enough to fulfill the order.", "Insufficient Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()

        Else

            'ELSE, WE UPDATE THE PURCHASE QUANTITY WITH THE QUANTITY THAT USER INPUT
            sales.quantity = Integer.Parse(txtQuantity.Text)

            db.Sales.DeleteOnSubmit(sales)
            db.Sales.InsertOnSubmit(sales)

            db.SubmitChanges()
            MessageBox.Show("Updated with your latest purchase! Enjoy Shopping! ")
            Me.Close()


        End If


    End Sub

    Private Sub resetform()
        lblPrice.Text = ""
        lblProductDes.Text = ""
        txtQuantity.Text = ""
        lblProductID.Text = ""
        txtQuantity.Focus()
    End Sub

    Private Sub FrmPaymentUpdate_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        resetform()
    End Sub
End Class