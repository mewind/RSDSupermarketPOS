Public Class frmHome
    'Declare the original color for the TAB
    Dim OriColor As New Color

    '<<<<------------------------------------TAB EDITING---------------------------------------->>>>

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        TabControl1.SelectTab(0)

        'Reset all the colors
        btnMembership.BackColor = OriColor
        btnReport.BackColor = OriColor
        btnProduct.BackColor = OriColor
        btnPayment.BackColor = OriColor

        'clicked color
        btnMembership.BackColor = Color.Black

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        TabControl1.SelectTab(3)

        'Reset all the colors
        btnMembership.BackColor = OriColor
        btnReport.BackColor = OriColor
        btnProduct.BackColor = OriColor
        btnPayment.BackColor = OriColor

        'clicked color
        btnPayment.BackColor = Color.Black

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        TabControl1.SelectTab(2)

        'Reset all the colors
        btnMembership.BackColor = OriColor
        btnReport.BackColor = OriColor
        btnProduct.BackColor = OriColor
        btnPayment.BackColor = OriColor
        'clicked color
        btnProduct.BackColor = Color.Black
    End Sub

    '<<<<-------------------------------END OF TAB EDITING---------------------------------------->>>>


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        TabControl1.SelectTab(1)
        'Reset all the colors
        btnMembership.BackColor = OriColor
        btnReport.BackColor = OriColor
        btnProduct.BackColor = OriColor
        btnPayment.BackColor = OriColor
        'clicked color
        btnReport.BackColor = Color.Black

    End Sub

    'LOAD FORM
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the original colour of the TAB
        OriColor = btnPayment.BackColor
    End Sub

    'LOGOUT BUTTON
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'SHOW FORM LOGIN AND HIDE HOME
        Me.Hide()
        frmUserLogin.ShowDialog(Me)
    End Sub


End Class