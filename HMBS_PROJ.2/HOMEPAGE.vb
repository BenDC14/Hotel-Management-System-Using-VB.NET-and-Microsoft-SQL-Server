Public Class HOMEPAGE
    Private Sub HOMEPAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(184, 194, 230)
        Me.TransparencyKey = BackColor
        pic_reserve.BackColor = Color.FromArgb(200, 0, 0, 0)
        pic_offers.BackColor = Color.FromArgb(200, 0, 0, 0)
        pic_aboutus.BackColor = Color.FromArgb(200, 0, 0, 0)

        Me.Show()
    End Sub
    Private Sub ShowFormInPanel(frm As Form, controls As Control.ControlCollection)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        controls.Clear()
        controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub ShowFormInPanel(frm As Form)
        btn_hotel_offers.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        btn_hotel_offers.Controls.Add(frm)
        frm.Show()
    End Sub



End Class