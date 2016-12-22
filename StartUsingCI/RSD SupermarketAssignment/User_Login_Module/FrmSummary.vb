Public Class FrmSummary
    Private Sub PrintCardJune_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCardJune.PrintPage
        '----print card usage June


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "          RSD Supermarket" &
                                vbNewLine & "Card Company Transactions" &
                                vbNewLine & "                    in June"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Card Type       Card Company               Number of Transactions")
        body.AppendLine(" -----------     ------------              ------------------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.CardCompnyUsageJunes



        For Each item In rs


            body.AppendFormat("{0,-15}   {1,-30} {2,5}" & vbNewLine, item.user_cardtype, item.user_ccompany, item.NUMBER_OF_USERS)

        Next


        body.AppendLine()

        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 90, 60, 280, 160)
            .DrawString(header, fontHeader, Brushes.DarkRed, 390, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 390, 160)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 155, 260)
        End With
    End Sub

    Private Sub PrintCardJuly_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCardJuly.PrintPage
        '----print card usage July


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "          RSD Supermarket" &
                                vbNewLine & "Card Company Transactions" &
                                vbNewLine & "                    in July"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Card Type       Card Company               Number of Transactions")
        body.AppendLine(" -----------     ------------              ------------------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.CardCompnyUsageJulies



        For Each item In rs


            body.AppendFormat("{0,-15}   {1,-30} {2,5}" & vbNewLine, item.user_cardtype, item.user_ccompany, item.NUMBER_OF_USERS)

        Next


        body.AppendLine()

        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 90, 60, 280, 160)
            .DrawString(header, fontHeader, Brushes.DarkRed, 390, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 390, 160)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 155, 260)
        End With
    End Sub

    Private Sub PrintCardAug_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCardAug.PrintPage
        '----print card usage August


        'Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontsubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        'prepare header and subheader
        Dim header As String = "          RSD Supermarket" &
                                vbNewLine & "Card Company Transactions" &
                                vbNewLine & "                 in August"
        Dim subHeader As String = String.Format(
            "Kampus Utama, Jalan Genting Kelang" & vbNewLine & " 53300 Kuala Lumpur" & vbNewLine & "Malaysia" & vbNewLine &
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}", DateTime.Now)


        'prepare body
        Dim body As New System.Text.StringBuilder()
        body.AppendLine(" Card Type       Card Company               Number of Transactions")
        body.AppendLine(" -----------     ------------              ------------------------")


        Dim db As New DBDataContext
        Dim rs = From product In db.CardCompnyUsageAugs



        For Each item In rs


            body.AppendFormat("{0,-15}   {1,-30} {2,5}" & vbNewLine, item.user_cardtype, item.user_ccompany, item.NUMBER_OF_USERS)

        Next


        body.AppendLine()

        'print
        With e.Graphics
            .DrawImage(My.Resources.RSDsupermarketCrop, 90, 60, 280, 160)
            .DrawString(header, fontHeader, Brushes.DarkRed, 390, 40)
            .DrawString(subHeader, fontsubHeader, Brushes.Black, 390, 160)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 155, 260)
        End With
    End Sub


    Private Sub btnSummaryJune_Click(sender As Object, e As EventArgs) Handles btnSummaryJune.Click
        dlgPrintCardJune.Document = PrintCardJune
        dlgPrintCardJune.ShowDialog(Me)
    End Sub

    Private Sub btnSummaryJuly_Click(sender As Object, e As EventArgs) Handles btnSummaryJuly.Click
        dlgPrintCardJuly.Document = PrintCardJuly
        dlgPrintCardJuly.ShowDialog(Me)
    End Sub

    Private Sub btnSummaryAugust_Click(sender As Object, e As EventArgs) Handles btnSummaryAugust.Click
        dlgPrintCardAug.Document = PrintCardAug
        dlgPrintCardAug.ShowDialog(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class