Public Class RESERVATION_STATUS
    Private Sub RESERVATION_STATUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(150, Color.White)
        Me.TransparencyKey = BackColor
    End Sub
End Class