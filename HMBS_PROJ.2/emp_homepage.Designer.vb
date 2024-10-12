<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emp_homepage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emp_homepage))
        Me.btn_loginpage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paneldropdown = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.D_A_T = New System.Windows.Forms.Timer(Me.components)
        Me.panelshowing = New System.Windows.Forms.Panel()
        Me.lbl_empuname = New System.Windows.Forms.Label()
        Me.Admin_lbl = New System.Windows.Forms.Label()
        Me.BTN_HOMEPAGE = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_reservation = New System.Windows.Forms.Button()
        Me.btn_ID = New System.Windows.Forms.Button()
        Me.btn_roomreserve = New System.Windows.Forms.Button()
        Me.btn_hoteloffers = New System.Windows.Forms.Button()
        Me.btn_guest = New System.Windows.Forms.Button()
        Me.btn_booking = New System.Windows.Forms.Button()
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.paneldropdown.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_loginpage
        '
        Me.btn_loginpage.Location = New System.Drawing.Point(878, 1000)
        Me.btn_loginpage.Name = "btn_loginpage"
        Me.btn_loginpage.Size = New System.Drawing.Size(269, 49)
        Me.btn_loginpage.TabIndex = 7
        Me.btn_loginpage.Text = "LOGIN FORM"
        Me.btn_loginpage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_empuname)
        Me.Panel1.Controls.Add(Me.Admin_lbl)
        Me.Panel1.Controls.Add(Me.BTN_HOMEPAGE)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_reservation)
        Me.Panel1.Controls.Add(Me.paneldropdown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 1061)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 60)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Madoc's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hotel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'paneldropdown
        '
        Me.paneldropdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.paneldropdown.Controls.Add(Me.btn_ID)
        Me.paneldropdown.Controls.Add(Me.btn_roomreserve)
        Me.paneldropdown.Controls.Add(Me.btn_hoteloffers)
        Me.paneldropdown.Controls.Add(Me.btn_guest)
        Me.paneldropdown.Controls.Add(Me.btn_booking)
        Me.paneldropdown.Controls.Add(Me.btn_payment)
        Me.paneldropdown.Location = New System.Drawing.Point(2, 256)
        Me.paneldropdown.Name = "paneldropdown"
        Me.paneldropdown.Size = New System.Drawing.Size(235, 427)
        Me.paneldropdown.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(238, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1682, 117)
        Me.Panel2.TabIndex = 9
        '
        'D_A_T
        '
        '
        'panelshowing
        '
        Me.panelshowing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelshowing.Location = New System.Drawing.Point(238, 117)
        Me.panelshowing.Name = "panelshowing"
        Me.panelshowing.Size = New System.Drawing.Size(1682, 944)
        Me.panelshowing.TabIndex = 10
        '
        'lbl_empuname
        '
        Me.lbl_empuname.AutoSize = True
        Me.lbl_empuname.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empuname.Location = New System.Drawing.Point(111, 92)
        Me.lbl_empuname.Name = "lbl_empuname"
        Me.lbl_empuname.Size = New System.Drawing.Size(98, 21)
        Me.lbl_empuname.TabIndex = 94
        Me.lbl_empuname.Text = "USERNAME"
        '
        'Admin_lbl
        '
        Me.Admin_lbl.AutoSize = True
        Me.Admin_lbl.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_lbl.Location = New System.Drawing.Point(9, 93)
        Me.Admin_lbl.Name = "Admin_lbl"
        Me.Admin_lbl.Size = New System.Drawing.Size(96, 21)
        Me.Admin_lbl.TabIndex = 93
        Me.Admin_lbl.Text = "EMPLOYEE:"
        '
        'BTN_HOMEPAGE
        '
        Me.BTN_HOMEPAGE.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTN_HOMEPAGE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BTN_HOMEPAGE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BTN_HOMEPAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_HOMEPAGE.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_HOMEPAGE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_HOMEPAGE.Image = CType(resources.GetObject("BTN_HOMEPAGE.Image"), System.Drawing.Image)
        Me.BTN_HOMEPAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_HOMEPAGE.Location = New System.Drawing.Point(1, 116)
        Me.BTN_HOMEPAGE.Name = "BTN_HOMEPAGE"
        Me.BTN_HOMEPAGE.Size = New System.Drawing.Size(236, 70)
        Me.BTN_HOMEPAGE.TabIndex = 1
        Me.BTN_HOMEPAGE.Text = "HOMEPAGE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTN_HOMEPAGE.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(1, 752)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(236, 70)
        Me.btn_exit.TabIndex = 10
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(1, 682)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(236, 70)
        Me.btn_logout.TabIndex = 9
        Me.btn_logout.Text = "LOG OUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btn_reservation
        '
        Me.btn_reservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_reservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_reservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reservation.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reservation.Image = CType(resources.GetObject("btn_reservation.Image"), System.Drawing.Image)
        Me.btn_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reservation.Location = New System.Drawing.Point(1, 186)
        Me.btn_reservation.Name = "btn_reservation"
        Me.btn_reservation.Size = New System.Drawing.Size(236, 70)
        Me.btn_reservation.TabIndex = 2
        Me.btn_reservation.Text = "RESERVATION"
        Me.btn_reservation.UseVisualStyleBackColor = False
        '
        'btn_ID
        '
        Me.btn_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_ID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_ID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ID.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ID.Image = CType(resources.GetObject("btn_ID.Image"), System.Drawing.Image)
        Me.btn_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ID.Location = New System.Drawing.Point(0, 0)
        Me.btn_ID.Name = "btn_ID"
        Me.btn_ID.Size = New System.Drawing.Size(235, 70)
        Me.btn_ID.TabIndex = 3
        Me.btn_ID.Text = "GENERATE ID"
        Me.btn_ID.UseVisualStyleBackColor = False
        '
        'btn_roomreserve
        '
        Me.btn_roomreserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_roomreserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_roomreserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_roomreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_roomreserve.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_roomreserve.Image = CType(resources.GetObject("btn_roomreserve.Image"), System.Drawing.Image)
        Me.btn_roomreserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_roomreserve.Location = New System.Drawing.Point(-1, 355)
        Me.btn_roomreserve.Name = "btn_roomreserve"
        Me.btn_roomreserve.Size = New System.Drawing.Size(235, 70)
        Me.btn_roomreserve.TabIndex = 7
        Me.btn_roomreserve.Text = "ROOM RESERVATION"
        Me.btn_roomreserve.UseVisualStyleBackColor = False
        '
        'btn_hoteloffers
        '
        Me.btn_hoteloffers.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_hoteloffers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_hoteloffers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_hoteloffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hoteloffers.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hoteloffers.Image = CType(resources.GetObject("btn_hoteloffers.Image"), System.Drawing.Image)
        Me.btn_hoteloffers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hoteloffers.Location = New System.Drawing.Point(0, 212)
        Me.btn_hoteloffers.Name = "btn_hoteloffers"
        Me.btn_hoteloffers.Size = New System.Drawing.Size(235, 70)
        Me.btn_hoteloffers.TabIndex = 5
        Me.btn_hoteloffers.Text = "HOTEL OFFERS"
        Me.btn_hoteloffers.UseVisualStyleBackColor = False
        '
        'btn_guest
        '
        Me.btn_guest.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_guest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_guest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guest.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guest.Image = CType(resources.GetObject("btn_guest.Image"), System.Drawing.Image)
        Me.btn_guest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guest.Location = New System.Drawing.Point(-1, 141)
        Me.btn_guest.Name = "btn_guest"
        Me.btn_guest.Size = New System.Drawing.Size(235, 70)
        Me.btn_guest.TabIndex = 4
        Me.btn_guest.Text = "GUEST INFORMATION"
        Me.btn_guest.UseVisualStyleBackColor = False
        '
        'btn_booking
        '
        Me.btn_booking.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_booking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_booking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_booking.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_booking.Image = CType(resources.GetObject("btn_booking.Image"), System.Drawing.Image)
        Me.btn_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_booking.Location = New System.Drawing.Point(0, 70)
        Me.btn_booking.Name = "btn_booking"
        Me.btn_booking.Size = New System.Drawing.Size(235, 70)
        Me.btn_booking.TabIndex = 3
        Me.btn_booking.Text = "BOOKING"
        Me.btn_booking.UseVisualStyleBackColor = False
        '
        'btn_payment
        '
        Me.btn_payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payment.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.Image = CType(resources.GetObject("btn_payment.Image"), System.Drawing.Image)
        Me.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_payment.Location = New System.Drawing.Point(0, 284)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(235, 70)
        Me.btn_payment.TabIndex = 6
        Me.btn_payment.Text = "PAYMENT"
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'emp_homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.panelshowing)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_loginpage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "emp_homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "emp_homepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.paneldropdown.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_loginpage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents D_A_T As Timer
    Friend WithEvents btn_booking As Button
    Friend WithEvents btn_payment As Button
    Friend WithEvents btn_guest As Button
    Friend WithEvents btn_roomreserve As Button
    Friend WithEvents btn_reservation As Button
    Friend WithEvents paneldropdown As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelshowing As Panel
    Friend WithEvents btn_hoteloffers As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents BTN_HOMEPAGE As Button
    Friend WithEvents btn_ID As Button
    Friend WithEvents lbl_empuname As Label
    Friend WithEvents Admin_lbl As Label
End Class
