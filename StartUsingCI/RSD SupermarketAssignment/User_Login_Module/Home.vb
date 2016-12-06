Public Class frmHome
    'Declare the original color for the TAB
    Dim OriColor As New Color

    'PRODUCT
    'Public SalesCount As Integer = 0

    'PAYMENT VARIABLE
    Const GST As Decimal = 0.06
    Public TaxTotal As Decimal
    Public Subtotal As Double
    Public Grandtotal As Decimal
    Public Discount As Decimal
    Public DiscountTotal As Decimal



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

    '<<<<-------------------------------END OF TAB EDITING---------------------------------------->>>>


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



    End Sub
    'FORM ACTIVATED
    Private Sub frmHome_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated



    End Sub
    'FORM SHOWN
    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown




    End Sub

    'LOGOUT BUTTON
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Hide this form and go back to LOGIN form
        frmUserLogin.attempt = 0


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

    '<<<<<<<<<<<<-------------------END OF FORMAT CODE----------------------------------------------------------->>>>>



    '<<<------------------------------------------MEMBERSHIP FUNCTION------------------------------------>>>>
    Private Sub btnSearchMember_Click(sender As Object, e As EventArgs) Handles btnSearchMember.Click
        frmSearch.ShowDialog(Me)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegisterMember.ShowDialog(Me)
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        frmViewDetails.ShowDialog(Me)
    End Sub

    '<<<-----------------------------------END OF MEMBERSHIP FUNCTION------------------------------------>>>>








End Class