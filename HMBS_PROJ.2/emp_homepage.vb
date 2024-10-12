Imports System.Net

Public Class emp_homepage
    Dim iscollapsed As Boolean = True
    Dim stepSize As Integer = 50
    Private highlightedButton As Button = Nothing

    Private homepageForm As New HOMEPAGE()
    Private guestForm As New Guest_Form()
    Private bookingForm As New Booking_Form()
    Private IDFORM As New ID_FORM()
    Private roomreserve As New Room_Reservation()

    Private Sub emp_homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paneldropdown.Height = 0
        iscollapsed = True
        HighlightButton(BTN_HOMEPAGE)
        ShowForm(homepageForm)
        lbl_empuname.Text = LG_FORM.txt_uname.Text
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

    Private Sub ShowForm(form As Form)
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

    Private Sub btn_roomreserve_Click(sender As Object, e As EventArgs) Handles btn_roomreserve.Click
        ShowForm(roomreserve)
        HighlightButton(btn_roomreserve)

    End Sub

    Private Sub btn_guest_Click(sender As Object, e As EventArgs) Handles btn_guest.Click
        ShowForm(guestForm)
        HighlightButton(btn_guest)
    End Sub

    Private Sub btn_booking_Click(sender As Object, e As EventArgs) Handles btn_booking.Click
        ShowForm(bookingForm)
        HighlightButton(btn_booking)
    End Sub



    Private Sub BTN_HOMEPAGE_Click(sender As Object, e As EventArgs) Handles BTN_HOMEPAGE.Click
        ShowForm(homepageForm)
        HighlightButton(BTN_HOMEPAGE)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ID.Click
        ShowForm(ID_FORM)
        HighlightButton(btn_ID)
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        ShowForm(Payment_Form)
        HighlightButton(btn_payment)
    End Sub
End Class