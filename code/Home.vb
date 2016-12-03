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
        
        'Show logged in User
        Dim db As New DBDataContext()
        Dim user As User = db.Users.SingleOrDefault(Function(u) u.user_id = frmUserLogin.LoginUserID)

        If (user.staff_id <> Nothing) Then

            lblGreeting.Text = "Hi, " & frmUserLogin.LoginUser & " | Staff"
            lblID.Text = "Staff ID:" & user.staff_id


        ElseIf (user.member_id <> Nothing) Then

            lblGreeting.Text = "Hi, " & frmUserLogin.LoginUser & " | Member"
            lblID.Text = "Member ID:" & user.member_id

            'DISABLE SOME FUNCTION FOR MEMBER
            btnReport.Enabled = False
            btnSearchMember.Enabled = False
            btnRegister.Enabled = False


        Else
            lblGreeting.Text = "Hi, " & frmUserLogin.LoginUser
            lblID.Text = " "

            'DISABLE SOME FUNCTION FOR NON MEMBER
            btnReport.Enabled = False
            btnSearchMember.Enabled = False
            btnRegister.Enabled = True
            btnViewDetails.Enabled = False


        End If

        'BIND DATA
        BindData()
            
    End Sub

    'LOGOUT BUTTON
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'SHOW FORM LOGIN AND HIDE HOME
        Me.Hide()
        frmUserLogin.ShowDialog(Me)
    End Sub

    '<<<<<<<<<<<<-------------------FORMAT CODE----------------------------------------------------------->>>>>

    'Membership 
    Private Sub btnSearchMember_MouseHover(sender As Object, e As EventArgs) Handles btnSearchMember.MouseHover
        'Change to coloured image wheh mouse hover
        btnSearchMember.Image = My.Resources.search2
    End Sub

    Private Sub btnViewDetails_MouseHover(sender As Object, e As EventArgs) Handles btnViewDetails.MouseHover
        'Change to coloured image wheh mouse hover
        btnViewDetails.Image = My.Resources.view2
    End Sub

    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        'Change to coloured image wheh mouse hover
        btnRegister.Image = My.Resources.add2
    End Sub

    Private Sub btnViewDetails_MouseLeave(sender As Object, e As EventArgs) Handles btnViewDetails.MouseLeave
        'Change to sepia image wheh mouse leave
        btnViewDetails.Image = My.Resources.view1_3
    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        'Change to sepia image wheh mouse leave
        btnRegister.Image = My.Resources.add1

    End Sub

    Private Sub btnSearchMember_MouseLeave(sender As Object, e As EventArgs) Handles btnSearchMember.MouseLeave
        'Change to sepia image wheh mouse leave
        btnSearchMember.Image = My.Resources.search1
    End Sub

    'Products
    Private Sub btnStationary_MouseHover(sender As Object, e As EventArgs) Handles btnStationary.MouseHover
        'Change to coloured image wheh mouse hover
        btnStationary.Image = My.Resources.stationary2
    End Sub

    Private Sub btnGroceries_MouseHover(sender As Object, e As EventArgs) Handles btnGroceries.MouseHover
        'Change to coloured image wheh mouse hover
        btnGroceries.Image = My.Resources.groceries2
    End Sub

    Private Sub btnClothes_MouseHover(sender As Object, e As EventArgs) Handles btnClothes.MouseHover
        'Change to coloured image wheh mouse hover
        btnClothes.Image = My.Resources.clothes2
    End Sub

    Private Sub btnFood_MouseHover(sender As Object, e As EventArgs) Handles btnFood.MouseHover
        'Change to coloured image wheh mouse hover
        btnFood.Image = My.Resources.food2
    End Sub

    Private Sub btnFood_MouseLeave(sender As Object, e As EventArgs) Handles btnFood.MouseLeave
        'Change to sepia image wheh mouse leave
        btnFood.Image = My.Resources.food1
    End Sub

    Private Sub btnClothes_MouseLeave(sender As Object, e As EventArgs) Handles btnClothes.MouseLeave
        'Change to sepia image wheh mouse leave
        btnClothes.Image = My.Resources.clothes1
    End Sub

    Private Sub btnGroceries_MouseLeave(sender As Object, e As EventArgs) Handles btnGroceries.MouseLeave
        'Change to sepia image wheh mouse leave
        btnGroceries.Image = My.Resources.groceries1
    End Sub

    Private Sub btnStationary_MouseLeave(sender As Object, e As EventArgs) Handles btnStationary.MouseLeave
        'Change to sepia image wheh mouse leave
        btnStationary.Image = My.Resources.stationary1
    End Sub

    'Report tab
    Private Sub btnSalesReport_MouseHover(sender As Object, e As EventArgs) Handles btnSalesReport.MouseHover
        'Change to coloured image wheh mouse hover
        btnSalesReport.Image = My.Resources.dollar2
    End Sub

    Private Sub btnSalesReport_MouseLeave(sender As Object, e As EventArgs) Handles btnSalesReport.MouseLeave
        'Change to sepia image wheh mouse leave
        btnSalesReport.Image = My.Resources.dollar1
    End Sub

    Private Sub btnExceptionReport_MouseHover(sender As Object, e As EventArgs) Handles btnExceptionReport.MouseHover
        'Change to coloured image wheh mouse hover
        btnExceptionReport.Image = My.Resources.exception2
    End Sub

    Private Sub btnExceptionReport_MouseLeave(sender As Object, e As EventArgs) Handles btnExceptionReport.MouseLeave
        'Change to sepia image wheh mouse leave
        btnExceptionReport.Image = My.Resources.exception1
    End Sub

    Private Sub btnSummaryReport_MouseHover(sender As Object, e As EventArgs) Handles btnSummaryReport.MouseHover
        'Change to coloured image wheh mouse hover
        btnSummaryReport.Image = My.Resources.summary2
    End Sub

    Private Sub btnSummaryReport_MouseLeave(sender As Object, e As EventArgs) Handles btnSummaryReport.MouseLeave
        'Change to sepia image wheh mouse leave
        btnSummaryReport.Image = My.Resources.summary1
    End Sub
    '<<<<<<<<<<<<-------------------End FORMAT CODE----------------------------------------------------------->>>>>

End Class
