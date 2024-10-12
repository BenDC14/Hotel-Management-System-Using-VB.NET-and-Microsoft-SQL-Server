<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Homepage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_adminuname = New System.Windows.Forms.Label()
        Me.Admin_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paneldropdown = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelshowing = New System.Windows.Forms.Panel()
        Me.D_A_T = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_HOMEPAGE1 = New System.Windows.Forms.Button()
        Me.btn_reservation = New System.Windows.Forms.Button()
        Me.btn_accounts = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_ID = New System.Windows.Forms.Button()
        Me.btn_RoomManagement = New System.Windows.Forms.Button()
        Me.btn_hoteloffers = New System.Windows.Forms.Button()
        Me.btn_guest = New System.Windows.Forms.Button()
        Me.btn_booking = New System.Windows.Forms.Button()
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.paneldropdown.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BTN_HOMEPAGE1)
        Me.Panel1.Controls.Add(Me.btn_reservation)
        Me.Panel1.Controls.Add(Me.lbl_adminuname)
        Me.Panel1.Controls.Add(Me.Admin_lbl)
        Me.Panel1.Controls.Add(Me.btn_accounts)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.paneldropdown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 1061)
        Me.Panel1.TabIndex = 9
        '
        'lbl_adminuname
        '
        Me.lbl_adminuname.AutoSize = True
        Me.lbl_adminuname.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adminuname.Location = New System.Drawing.Point(71, 91)
        Me.lbl_adminuname.Name = "lbl_adminuname"
        Me.lbl_adminuname.Size = New System.Drawing.Size(98, 21)
        Me.lbl_adminuname.TabIndex = 92
        Me.lbl_adminuname.Text = "USERNAME"
        '
        'Admin_lbl
        '
        Me.Admin_lbl.AutoSize = True
        Me.Admin_lbl.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_lbl.Location = New System.Drawing.Point(3, 92)
        Me.Admin_lbl.Name = "Admin_lbl"
        Me.Admin_lbl.Size = New System.Drawing.Size(70, 21)
        Me.Admin_lbl.TabIndex = 91
        Me.Admin_lbl.Text = "ADMIN:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 60)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Madoc's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hotel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'paneldropdown
        '
        Me.paneldropdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.paneldropdown.Controls.Add(Me.btn_ID)
        Me.paneldropdown.Controls.Add(Me.btn_RoomManagement)
        Me.paneldropdown.Controls.Add(Me.btn_hoteloffers)
        Me.paneldropdown.Controls.Add(Me.btn_guest)
        Me.paneldropdown.Controls.Add(Me.btn_booking)
        Me.paneldropdown.Controls.Add(Me.btn_payment)
        Me.paneldropdown.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Panel2.TabIndex = 10
        '
        'panelshowing
        '
        Me.panelshowing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelshowing.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelshowing.Location = New System.Drawing.Point(238, 117)
        Me.panelshowing.Name = "panelshowing"
        Me.panelshowing.Size = New System.Drawing.Size(1682, 944)
        Me.panelshowing.TabIndex = 11
        '
        'D_A_T
        '
        '
        'BTN_HOMEPAGE1
        '
        Me.BTN_HOMEPAGE1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTN_HOMEPAGE1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BTN_HOMEPAGE1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BTN_HOMEPAGE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_HOMEPAGE1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_HOMEPAGE1.Image = CType(resources.GetObject("BTN_HOMEPAGE1.Image"), System.Drawing.Image)
        Me.BTN_HOMEPAGE1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_HOMEPAGE1.Location = New System.Drawing.Point(1, 116)
        Me.BTN_HOMEPAGE1.Name = "BTN_HOMEPAGE1"
        Me.BTN_HOMEPAGE1.Size = New System.Drawing.Size(236, 70)
        Me.BTN_HOMEPAGE1.TabIndex = 93
        Me.BTN_HOMEPAGE1.Text = "HOMEPAGE"
        Me.BTN_HOMEPAGE1.UseVisualStyleBackColor = False
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
        Me.btn_reservation.Location = New System.Drawing.Point(2, 186)
        Me.btn_reservation.Name = "btn_reservation"
        Me.btn_reservation.Size = New System.Drawing.Size(236, 70)
        Me.btn_reservation.TabIndex = 2
        Me.btn_reservation.Text = "RESERVATION"
        Me.btn_reservation.UseVisualStyleBackColor = False
        '
        'btn_accounts
        '
        Me.btn_accounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_accounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_accounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_accounts.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accounts.Image = CType(resources.GetObject("btn_accounts.Image"), System.Drawing.Image)
        Me.btn_accounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_accounts.Location = New System.Drawing.Point(1, 683)
        Me.btn_accounts.Name = "btn_accounts"
        Me.btn_accounts.Size = New System.Drawing.Size(236, 70)
        Me.btn_accounts.TabIndex = 9
        Me.btn_accounts.Tag = ""
        Me.btn_accounts.Text = "ACCOUNTS"
        Me.btn_accounts.UseVisualStyleBackColor = False
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
        Me.btn_exit.Location = New System.Drawing.Point(2, 823)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(236, 70)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.Tag = ""
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
        Me.btn_logout.Location = New System.Drawing.Point(2, 753)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(236, 70)
        Me.btn_logout.TabIndex = 11
        Me.btn_logout.Tag = ""
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
        'btn_RoomManagement
        '
        Me.btn_RoomManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btn_RoomManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_RoomManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_RoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RoomManagement.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RoomManagement.Image = CType(resources.GetObject("btn_RoomManagement.Image"), System.Drawing.Image)
        Me.btn_RoomManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RoomManagement.Location = New System.Drawing.Point(0, 356)
        Me.btn_RoomManagement.Name = "btn_RoomManagement"
        Me.btn_RoomManagement.Size = New System.Drawing.Size(235, 70)
        Me.btn_RoomManagement.TabIndex = 8
        Me.btn_RoomManagement.Tag = ""
        Me.btn_RoomManagement.Text = "ROOM MANAGEMENT"
        Me.btn_RoomManagement.UseVisualStyleBackColor = False
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
        Me.btn_hoteloffers.Location = New System.Drawing.Point(0, 213)
        Me.btn_hoteloffers.Name = "btn_hoteloffers"
        Me.btn_hoteloffers.Size = New System.Drawing.Size(235, 70)
        Me.btn_hoteloffers.TabIndex = 6
        Me.btn_hoteloffers.Tag = ""
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
        Me.btn_guest.Location = New System.Drawing.Point(-1, 142)
        Me.btn_guest.Name = "btn_guest"
        Me.btn_guest.Size = New System.Drawing.Size(235, 70)
        Me.btn_guest.TabIndex = 5
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
        Me.btn_booking.Location = New System.Drawing.Point(0, 71)
        Me.btn_booking.Name = "btn_booking"
        Me.btn_booking.Size = New System.Drawing.Size(235, 70)
        Me.btn_booking.TabIndex = 4
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
        Me.btn_payment.Location = New System.Drawing.Point(0, 285)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(235, 70)
        Me.btn_payment.TabIndex = 7
        Me.btn_payment.Tag = ""
        Me.btn_payment.Text = "PAYMENT"
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'Admin_Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.panelshowing)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Homepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.paneldropdown.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents paneldropdown As Panel
    Friend WithEvents btn_RoomManagement As Button
    Friend WithEvents btn_hoteloffers As Button
    Friend WithEvents btn_guest As Button
    Friend WithEvents btn_booking As Button
    Friend WithEvents btn_payment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_accounts As Button
    Friend WithEvents panelshowing As Panel
    Friend WithEvents lbl_adminuname As Label
    Friend WithEvents Admin_lbl As Label
    Friend WithEvents D_A_T As Timer
    Friend WithEvents btn_reservation As Button
    Friend WithEvents btn_ID As Button
    Friend WithEvents BTN_HOMEPAGE1 As Button
End Class
