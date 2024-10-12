Imports System.Runtime.InteropServices

Public Class Admin_Homepage
    Dim iscollapsed As Boolean = True
    Dim stepSize As Integer = 50
    Private highlightedButton As Button = Nothing

    Private homepageForm As New HOMEPAGE_ADMIN()
    Private guestForm As New Guest_Form_Admin()
    Private roomManagementForm As New Room_Management_Admin()
    Private bookingmanagementForm As New Booking_Admin()
    Private ID_FORM As New ID_FORM()
    Private AccountForm As New Accounts()

    Private Sub Admin_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paneldropdown.Height = 0
        iscollapsed = True
        HighlightButton(BTN_HOMEPAGE1)
        ShowForm1(homepageForm)
        lbl_adminuname.Text = LG_FORM.txt_uname.Text
    End Sub

    Private Sub HighlightButton(clickedButton As Button)
        If highlightedButton IsNot Nothing Then
            highlightedButton.BackColor = Color.Transparent
            highlightedButton.UseVisualStyleBackColor = True
        End If
        clickedButton.BackColor = Color.FromArgb(200, Color.CornflowerBlue)
        clickedButton.UseVisualStyleBackColor = False
        highlightedButton = clickedButton
        clickedButton.Focus()
    End Sub

    Private Sub ShowForm1(form As Form)
        panelshowing.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        panelshowing.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "HOMEPAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "HOMEPAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            LG_FORM.Show()
        End If
    End Sub

    Private Sub btn_reservation_Click_1(sender As Object, e As EventArgs) Handles btn_reservation.Click
        D_A_T.Start()
        If paneldropdown.Height <> 0 Then
            paneldropdown.Height = 0
            D_A_T.Enabled = False
        End If
    End Sub

    Private Sub D_A_T_Tick(sender As Object, e As EventArgs) Handles D_A_T.Tick
        paneldropdown.Height = 427
        D_A_T.Stop()
    End Sub


    Private Sub btn_guest_Click(sender As Object, e As EventArgs) Handles btn_guest.Click
        ShowForm1(guestForm)
        HighlightButton(btn_guest)
    End Sub

    Private Sub btn_RoomManagement_Click(sender As Object, e As EventArgs) Handles btn_RoomManagement.Click
        ShowForm1(roomManagementForm)
        HighlightButton(btn_RoomManagement)
    End Sub
    Private Sub btn_booking_Click(sender As Object, e As EventArgs) Handles btn_booking.Click
        ShowForm1(bookingmanagementForm)
        HighlightButton(btn_booking)
    End Sub

    Private Sub btn_ID_Click(sender As Object, e As EventArgs) Handles btn_ID.Click
        ShowForm1(ID_FORM)
        HighlightButton(btn_ID)
    End Sub

    Private Sub btn_accounts_Click(sender As Object, e As EventArgs) Handles btn_accounts.Click
        ShowForm1(AccountForm)
        HighlightButton(btn_accounts)
    End Sub

    Private Sub BTN_HOMEPAGE1_Click(sender As Object, e As EventArgs) Handles BTN_HOMEPAGE1.Click
        ShowForm1(homepageForm)
        HighlightButton(BTN_HOMEPAGE1)

    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        ShowForm1(Admin_Payment)
        HighlightButton(btn_payment)
    End Sub
End Class