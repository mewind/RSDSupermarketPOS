Public Class frmSalesReport
    'Print Sales Report June
    Private Sub PrintSalesAug_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSalesAug.PrintPage
        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "RSD Supermarket August Sales"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Product                        Price           Quantity        Total Sales")
        body.AppendLine(" -------                        --------        ---------       -------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.MonthlySalesAugs



        For Each item In rs


            body.AppendFormat("{0,-30}   {1,-16} {2,-14}  {3,-18}" & vbNewLine, item.product_name, item.product_price, item.Total_Quantity, item.Total_Sales)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 60, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 360, 50)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 360, 100)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 110, 200)
        End With
    End Sub

    Private Sub PrintSalesJuly_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSalesJuly.PrintPage
        'Print Sales Report July



        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "RSD Supermarket July Sales"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Product                        Price           Quantity        Total Sales")
        body.AppendLine(" -------                        --------        ---------       -------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.MonthlySalesJulies



        For Each item In rs


            body.AppendFormat("{0,-30}   {1,-16} {2,-14}  {3,-18}" & vbNewLine, item.product_name, item.product_price, item.Total_Quantity, item.Total_Sales)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 80, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 380, 50)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 380, 100)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 110, 200)
        End With
    End Sub

    Private Sub PrintSalesJune_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSalesJune.PrintPage
        'Print Sales Report August


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "RSD Supermarket June Sales"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Product                        Price           Quantity        Total Sales")
        body.AppendLine(" -------                        --------        ---------       -------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.MonthlySalesJunes



        For Each item In rs


            body.AppendFormat("{0,-30}   {1,-16} {2,-14}  {3,-18}" & vbNewLine, item.product_name, item.product_price, item.Total_Quantity, item.Total_Sales)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 80, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 380, 50)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 380, 100)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 110, 200)
        End With
    End Sub

    Private Sub btnSalesJune_Click(sender As Object, e As EventArgs) Handles btnSalesJune.Click
        dlgPrintSalesJune.Document = PrintSalesJune
        dlgPrintSalesJune.ShowDialog(Me)
    End Sub

    Private Sub btnSalesJuly_Click(sender As Object, e As EventArgs) Handles btnSalesJuly.Click
        dlgPrintSalesJuly.Document = PrintSalesJuly
        dlgPrintSalesJuly.ShowDialog(Me)
    End Sub

    Private Sub btnSalesAugust_Click(sender As Object, e As EventArgs) Handles btnSalesAugust.Click
        dlgPrintSalesAug.Document = PrintSalesAug
        dlgPrintSalesAug.ShowDialog(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class