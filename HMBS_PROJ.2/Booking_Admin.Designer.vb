﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking_Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking_Admin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_Booking = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_PRINT = New System.Windows.Forms.Button()
        Me.prtdocu_booking = New System.Drawing.Printing.PrintDocument()
        Me.prtpre_booking = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_bookingstat = New System.Windows.Forms.ComboBox()
        Me.txt_advance = New System.Windows.Forms.TextBox()
        Me.lbl_Booking = New System.Windows.Forms.Label()
        Me.dtp_checkout = New System.Windows.Forms.DateTimePicker()
        Me.dtp_checkin = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.txt_BookingID = New System.Windows.Forms.TextBox()
        Me.lbl_bookingID = New System.Windows.Forms.Label()
        Me.lbl_checkout = New System.Windows.Forms.Label()
        Me.lbl_checkin = New System.Windows.Forms.Label()
        CType(Me.DGV_Booking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Booking Information"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 71)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 13
        '
        'DGV_Booking
        '
        Me.DGV_Booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Booking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Booking.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Booking.Location = New System.Drawing.Point(16, 103)
        Me.DGV_Booking.MultiSelect = False
        Me.DGV_Booking.Name = "DGV_Booking"
        Me.DGV_Booking.Size = New System.Drawing.Size(714, 748)
        Me.DGV_Booking.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BTN_PRINT)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_Booking)
        Me.Panel4.Location = New System.Drawing.Point(926, -20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(756, 964)
        Me.Panel4.TabIndex = 9
        '
        'BTN_PRINT
        '
        Me.BTN_PRINT.FlatAppearance.BorderSize = 0
        Me.BTN_PRINT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_PRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PRINT.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PRINT.ForeColor = System.Drawing.Color.Black
        Me.BTN_PRINT.Image = CType(resources.GetObject("BTN_PRINT.Image"), System.Drawing.Image)
        Me.BTN_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_PRINT.Location = New System.Drawing.Point(353, 883)
        Me.BTN_PRINT.Name = "BTN_PRINT"
        Me.BTN_PRINT.Size = New System.Drawing.Size(159, 35)
        Me.BTN_PRINT.TabIndex = 22
        Me.BTN_PRINT.Text = "PRINT"
        Me.BTN_PRINT.UseVisualStyleBackColor = True
        '
        'prtdocu_booking
        '
        '
        'prtpre_booking
        '
        Me.prtpre_booking.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prtpre_booking.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prtpre_booking.ClientSize = New System.Drawing.Size(400, 300)
        Me.prtpre_booking.Document = Me.prtdocu_booking
        Me.prtpre_booking.Enabled = True
        Me.prtpre_booking.Icon = CType(resources.GetObject("prtpre_booking.Icon"), System.Drawing.Icon)
        Me.prtpre_booking.Name = "prtpre_guest"
        Me.prtpre_booking.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cb_bookingstat)
        Me.Panel3.Controls.Add(Me.txt_advance)
        Me.Panel3.Controls.Add(Me.lbl_Booking)
        Me.Panel3.Controls.Add(Me.dtp_checkout)
        Me.Panel3.Controls.Add(Me.dtp_checkin)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.txt_BookingID)
        Me.Panel3.Controls.Add(Me.lbl_bookingID)
        Me.Panel3.Controls.Add(Me.lbl_checkout)
        Me.Panel3.Controls.Add(Me.lbl_checkin)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 946)
        Me.Panel3.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Advance Payment:"
        '
        'cb_bookingstat
        '
        Me.cb_bookingstat.AutoCompleteCustomSource.AddRange(New String() {"Pending", "Confirmed", "Checked-In", "Checked-Out", "Canceled", "No-Show", "In Progress", "Completed", "On Hold", "Waiting for Payment"})
        Me.cb_bookingstat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_bookingstat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_bookingstat.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_bookingstat.FormattingEnabled = True
        Me.cb_bookingstat.Items.AddRange(New Object() {"Pending", "Confirmed", "Checked-In", "Checked-Out", "Canceled", "No-Show", "In Progress", "Completed", "On Hold", "Waiting for Payment"})
        Me.cb_bookingstat.Location = New System.Drawing.Point(225, 401)
        Me.cb_bookingstat.Name = "cb_bookingstat"
        Me.cb_bookingstat.Size = New System.Drawing.Size(324, 26)
        Me.cb_bookingstat.TabIndex = 4
        '
        'txt_advance
        '
        Me.txt_advance.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_advance.Location = New System.Drawing.Point(225, 473)
        Me.txt_advance.Name = "txt_advance"
        Me.txt_advance.Size = New System.Drawing.Size(324, 24)
        Me.txt_advance.TabIndex = 24
        '
        'lbl_Booking
        '
        Me.lbl_Booking.AutoSize = True
        Me.lbl_Booking.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Booking.ForeColor = System.Drawing.Color.Black
        Me.lbl_Booking.Location = New System.Drawing.Point(22, 400)
        Me.lbl_Booking.Name = "lbl_Booking"
        Me.lbl_Booking.Size = New System.Drawing.Size(146, 24)
        Me.lbl_Booking.TabIndex = 21
        Me.lbl_Booking.Text = "Booking Status"
        '
        'dtp_checkout
        '
        Me.dtp_checkout.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.dtp_checkout.CalendarFont = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_checkout.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dtp_checkout.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtp_checkout.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dtp_checkout.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtp_checkout.Location = New System.Drawing.Point(225, 324)
        Me.dtp_checkout.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtp_checkout.Name = "dtp_checkout"
        Me.dtp_checkout.Size = New System.Drawing.Size(324, 20)
        Me.dtp_checkout.TabIndex = 3
        '
        'dtp_checkin
        '
        Me.dtp_checkin.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.dtp_checkin.CalendarFont = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_checkin.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dtp_checkin.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtp_checkin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dtp_checkin.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtp_checkin.Location = New System.Drawing.Point(225, 244)
        Me.dtp_checkin.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtp_checkin.Name = "dtp_checkin"
        Me.dtp_checkin.Size = New System.Drawing.Size(324, 20)
        Me.dtp_checkin.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_clear
        '
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(456, 603)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(93, 38)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOKING FORM"
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.FlatAppearance.BorderSize = 0
        Me.BTN_UPDATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_UPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.ForeColor = System.Drawing.Color.Black
        Me.BTN_UPDATE.Image = CType(resources.GetObject("BTN_UPDATE.Image"), System.Drawing.Image)
        Me.BTN_UPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_UPDATE.Location = New System.Drawing.Point(129, 603)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 38)
        Me.BTN_UPDATE.TabIndex = 9
        Me.BTN_UPDATE.Text = "UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & "BOOKING"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'txt_BookingID
        '
        Me.txt_BookingID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BookingID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_BookingID.Location = New System.Drawing.Point(225, 171)
        Me.txt_BookingID.Name = "txt_BookingID"
        Me.txt_BookingID.ReadOnly = True
        Me.txt_BookingID.Size = New System.Drawing.Size(324, 24)
        Me.txt_BookingID.TabIndex = 1
        '
        'lbl_bookingID
        '
        Me.lbl_bookingID.AutoSize = True
        Me.lbl_bookingID.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookingID.ForeColor = System.Drawing.Color.Black
        Me.lbl_bookingID.Location = New System.Drawing.Point(22, 169)
        Me.lbl_bookingID.Name = "lbl_bookingID"
        Me.lbl_bookingID.Size = New System.Drawing.Size(120, 24)
        Me.lbl_bookingID.TabIndex = 10
        Me.lbl_bookingID.Text = "Booking ID:"
        '
        'lbl_checkout
        '
        Me.lbl_checkout.AutoSize = True
        Me.lbl_checkout.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_checkout.ForeColor = System.Drawing.Color.Black
        Me.lbl_checkout.Location = New System.Drawing.Point(22, 320)
        Me.lbl_checkout.Name = "lbl_checkout"
        Me.lbl_checkout.Size = New System.Drawing.Size(110, 24)
        Me.lbl_checkout.TabIndex = 7
        Me.lbl_checkout.Text = "Check-Out"
        '
        'lbl_checkin
        '
        Me.lbl_checkin.AutoSize = True
        Me.lbl_checkin.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_checkin.ForeColor = System.Drawing.Color.Black
        Me.lbl_checkin.Location = New System.Drawing.Point(22, 240)
        Me.lbl_checkin.Name = "lbl_checkin"
        Me.lbl_checkin.Size = New System.Drawing.Size(99, 24)
        Me.lbl_checkin.TabIndex = 6
        Me.lbl_checkin.Text = "Check-In:"
        '
        'Booking_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking_Admin"
        CType(Me.DGV_Booking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DGV_Booking As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTN_PRINT As Button
    Friend WithEvents prtdocu_booking As Printing.PrintDocument
    Friend WithEvents prtpre_booking As PrintPreviewDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cb_bookingstat As ComboBox
    Friend WithEvents lbl_Booking As Label
    Friend WithEvents dtp_checkout As DateTimePicker
    Friend WithEvents dtp_checkin As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents txt_BookingID As TextBox
    Friend WithEvents lbl_bookingID As Label
    Friend WithEvents lbl_checkout As Label
    Friend WithEvents lbl_checkin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_advance As TextBox
End Class
