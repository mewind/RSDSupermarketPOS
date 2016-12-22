Public Class FrmException
    Private Sub PrintLeastSaleJune_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintLeastSaleJune.PrintPage
        '----print least sale JUNE


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "      RSD Supermarket" & vbNewLine & "Top 3 Least Sales in June"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine("      Product Name                    Category          Amount")
        body.AppendLine(" --------------------------           ---------        ----------")


        Dim db As New DBDataContext
        Dim rs = From product In db.LeastSaleJunes



        For Each item In rs


            body.AppendFormat("{0,-36}   {1,-18} {2,-14}" & vbNewLine, item.product_name, item.product_catagory, item.Total_Quantity)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 100, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 400, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 400, 120)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 160, 220)
        End With

    End Sub

    Private Sub PrintLeastSaleJuly_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintLeastSaleJuly.PrintPage
        '----print least sale JULY


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "      RSD Supermarket" & vbNewLine & "Top 3 Least Sales in July"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine("      Product Name                    Category          Amount")
        body.AppendLine(" --------------------------           ---------        ----------")


        Dim db As New DBDataContext
        Dim rs = From product In db.LeastSaleJulies



        For Each item In rs


            body.AppendFormat("{0,-36}   {1,-18} {2,-14}" & vbNewLine, item.product_name, item.product_catagory, item.Total_Quantity)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 100, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 400, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 400, 120)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 160, 220)
        End With

    End Sub

    Private Sub PrintLeastSaleAug_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintLeastSaleAug.PrintPage
        '----print least sale AUGUST


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "         RSD Supermarket" & vbNewLine & "Top 3 Least Sales in August"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine("      Product Name                    Category          Amount")
        body.AppendLine(" --------------------------           ---------        ----------")


        Dim db As New DBDataContext
        Dim rs = From product In db.LeastSaleAugs



        For Each item In rs


            body.AppendFormat("{0,-36}   {1,-18} {2,-14}" & vbNewLine, item.product_name, item.product_catagory, item.Total_Quantity)

        Next


        body.AppendLine()



        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 80, 50, 280, 140)
            .DrawString(header, fontHeader, Brushes.DarkRed, 380, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 380, 120)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 160, 220)
        End With

    End Sub

    Private Sub btnExpJune_Click(sender As Object, e As EventArgs) Handles btnExpJune.Click
        dlgLeastSalesJune.Document = PrintLeastSaleJune
        dlgLeastSalesJune.ShowDialog(Me)
    End Sub

    Private Sub btnExpJuly_Click(sender As Object, e As EventArgs) Handles btnExpJuly.Click
        dlgLeastSalesJuly.Document = PrintLeastSaleJuly
        dlgLeastSalesJuly.ShowDialog(Me)
    End Sub

    Private Sub btnExpAugust_Click(sender As Object, e As EventArgs) Handles btnExpAugust.Click
        dlgLeastSalesAug.Document = PrintLeastSaleAug
        dlgLeastSalesAug.ShowDialog(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class