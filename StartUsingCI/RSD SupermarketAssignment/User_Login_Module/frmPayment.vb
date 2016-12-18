Public Class frmPayment
   Public PrintTotal As Decimal
    Public PrintSubtotal As Decimal
    Public PrintTaxtotal As Decimal
    Public PrintDiscount As Decimal


    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        If btnYes.Enabled = True Then

            dlgReceiptPreview.Document = Receipt
            dlgReceiptPreview.ShowDialog(Me)

            frmToCart.chosenProductId = Nothing


            
            'GO BACK THE LOGIN FORM TO ALLOW THE NEXT USER TO LOGIN
            MessageBox.Show("Thank you for your purchase. Please come again.", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.None)
            frmUserLogin.Show()
            Me.Close()


        End If

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        If btnNo.Enabled = True Then
            'CLICKED NO BUTTON MAY CAUSE THE RESET OF "ATTEMPT", THIS IS TO ENSURE THE NEXT USER CAN GET THE ANOTHER 3 ATTEMPTS OF LOGIN
            frmUserLogin.attempt = 0
            frmToCart.chosenProductId = Nothing

            'GO BACK THE LOGIN FORM TO ALLOW THE NEXT USER TO LOGIN
            frmUserLogin.Show()


            Me.Close()
        End If
    End Sub

    '--------PRINT RECEIPT--------------
    Private Sub Receipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Receipt.PrintPage

        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "RSD Supermarket Receipt"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now & vbNewLine &
            ("User ID: " + frmUserLogin.LoginUserID) + " | " + frmUserLogin.LoginUser)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" No       Items                    Quantity        Price")
        body.AppendLine(" --       --------                ---------       -------")


        Dim db As New DBDataContext()
        db.GetTable(Of Sale)()
        db.GetTable(Of Product)()
        db.GetTable(Of User)()


        'USE LINQ TO SQL TO RETRIEVE THE RECORD THE MEETS THE CONDITION
        Dim rs = From sales In db.Sales, products In db.Products, users In db.Users
                 Where sales.user_id = users.user_id And
                       sales.user_id = frmUserLogin.LoginUserID And
                       sales.product_id = products.product_id And
                       sales.sales_id = FrmPaymentUpdate.CurrentSalesId

        Dim cnt As Integer
        For Each product In rs
            cnt += 1
            body.AppendFormat("{0,2} {1,-35} {2,3} {3,13}" & vbNewLine, cnt, product.products.product_name, product.sales.quantity, product.products.product_price)

        Next



        body.AppendLine()
        body.AppendFormat("{0,2} Item(s)", cnt)
        body.AppendLine(vbNewLine & "------------------------------------------------------------------------------------")
        body.AppendLine("                                        SUBTOTAL    : RM " + (PrintSubtotal).ToString("0.00"))
        body.AppendLine("                                        DISCOUNT    : RM " + (PrintDiscount * PrintSubtotal).ToString("0.00"))
        body.AppendLine("                                        GST(6%)     : RM " + (PrintTaxtotal).ToString("0.00"))
        body.AppendLine("                                        GRAND TOTAL : RM " + (PrintTotal).ToString("0.00"))

        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 80, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 380, 50)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 380, 100)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 110, 250)
        End With
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblEncouragement.Left -= 5
        If lblEncouragement.Left < -Width Then
            lblEncouragement.Left = Width

        End If
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGrandTotal.Text = PrintTotal.ToString("RM0.00")

        Dim db As New DBDataContext()
        lblDateTime.Text = "Date and time:" & (DateTime.Now).ToString("dd/MM/yyyy hh:mm:ss tt")

        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = "RSD00011")
        lblCardCompany.Text = user.user_ccompany
    End Sub
End Class