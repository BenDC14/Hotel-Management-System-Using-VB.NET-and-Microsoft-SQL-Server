<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room_Reservation
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_Reservation))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_roomcap = New System.Windows.Forms.ComboBox()
        Me.cb_roomtype = New System.Windows.Forms.ComboBox()
        Me.txt_guestroomID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_guestID = New System.Windows.Forms.TextBox()
        Me.cb_roomstat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_roomnum = New System.Windows.Forms.TextBox()
        Me.txt_RoomID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_roomstatus = New System.Windows.Forms.Label()
        Me.lbl_roomcap = New System.Windows.Forms.Label()
        Me.lbl_roomtype = New System.Windows.Forms.Label()
        Me.lbl_roomnum = New System.Windows.Forms.Label()
        Me.LBL_GUESTID = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_searchguest = New System.Windows.Forms.TextBox()
        Me.dgv_guest = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_RoomManagement = New System.Windows.Forms.DataGridView()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_guest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_RoomManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cb_roomcap)
        Me.Panel3.Controls.Add(Me.cb_roomtype)
        Me.Panel3.Controls.Add(Me.BTN_DELETE)
        Me.Panel3.Controls.Add(Me.txt_guestroomID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txt_guestID)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.cb_roomstat)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.txt_roomnum)
        Me.Panel3.Controls.Add(Me.txt_RoomID)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_roomstatus)
        Me.Panel3.Controls.Add(Me.lbl_roomcap)
        Me.Panel3.Controls.Add(Me.lbl_roomtype)
        Me.Panel3.Controls.Add(Me.lbl_roomnum)
        Me.Panel3.Controls.Add(Me.LBL_GUESTID)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 944)
        Me.Panel3.TabIndex = 4
        '
        'cb_roomcap
        '
        Me.cb_roomcap.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_roomcap.FormattingEnabled = True
        Me.cb_roomcap.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cb_roomcap.Location = New System.Drawing.Point(178, 435)
        Me.cb_roomcap.Name = "cb_roomcap"
        Me.cb_roomcap.Size = New System.Drawing.Size(324, 26)
        Me.cb_roomcap.TabIndex = 4
        '
        'cb_roomtype
        '
        Me.cb_roomtype.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_roomtype.FormattingEnabled = True
        Me.cb_roomtype.Items.AddRange(New Object() {"Single Room", "Double Single Room", "Deluxe Room", "Junior Suite Room", "Exclusive Suite Room", "Presidential Suite Room"})
        Me.cb_roomtype.Location = New System.Drawing.Point(178, 343)
        Me.cb_roomtype.Name = "cb_roomtype"
        Me.cb_roomtype.Size = New System.Drawing.Size(324, 26)
        Me.cb_roomtype.TabIndex = 3
        '
        'txt_guestroomID
        '
        Me.txt_guestroomID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestroomID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestroomID.Location = New System.Drawing.Point(178, 172)
        Me.txt_guestroomID.Name = "txt_guestroomID"
        Me.txt_guestroomID.ReadOnly = True
        Me.txt_guestroomID.Size = New System.Drawing.Size(324, 24)
        Me.txt_guestroomID.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Guest Room ID:"
        '
        'txt_guestID
        '
        Me.txt_guestID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestID.Location = New System.Drawing.Point(178, 601)
        Me.txt_guestID.Name = "txt_guestID"
        Me.txt_guestID.ReadOnly = True
        Me.txt_guestID.Size = New System.Drawing.Size(324, 24)
        Me.txt_guestID.TabIndex = 6
        '
        'cb_roomstat
        '
        Me.cb_roomstat.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_roomstat.FormattingEnabled = True
        Me.cb_roomstat.Location = New System.Drawing.Point(178, 519)
        Me.cb_roomstat.Name = "cb_roomstat"
        Me.cb_roomstat.Size = New System.Drawing.Size(324, 26)
        Me.cb_roomstat.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOM RESERVATION"
        '
        'txt_roomnum
        '
        Me.txt_roomnum.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_roomnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_roomnum.Location = New System.Drawing.Point(178, 255)
        Me.txt_roomnum.Name = "txt_roomnum"
        Me.txt_roomnum.ReadOnly = True
        Me.txt_roomnum.Size = New System.Drawing.Size(324, 24)
        Me.txt_roomnum.TabIndex = 2
        '
        'txt_RoomID
        '
        Me.txt_RoomID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RoomID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_RoomID.Location = New System.Drawing.Point(178, 683)
        Me.txt_RoomID.Name = "txt_RoomID"
        Me.txt_RoomID.ReadOnly = True
        Me.txt_RoomID.Size = New System.Drawing.Size(324, 24)
        Me.txt_RoomID.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 681)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Room ID:"
        '
        'lbl_roomstatus
        '
        Me.lbl_roomstatus.AutoSize = True
        Me.lbl_roomstatus.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomstatus.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomstatus.Location = New System.Drawing.Point(22, 518)
        Me.lbl_roomstatus.Name = "lbl_roomstatus"
        Me.lbl_roomstatus.Size = New System.Drawing.Size(129, 24)
        Me.lbl_roomstatus.TabIndex = 9
        Me.lbl_roomstatus.Text = "Room Status:"
        '
        'lbl_roomcap
        '
        Me.lbl_roomcap.AutoSize = True
        Me.lbl_roomcap.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomcap.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomcap.Location = New System.Drawing.Point(22, 437)
        Me.lbl_roomcap.Name = "lbl_roomcap"
        Me.lbl_roomcap.Size = New System.Drawing.Size(153, 24)
        Me.lbl_roomcap.TabIndex = 8
        Me.lbl_roomcap.Text = "Room Capacity:"
        '
        'lbl_roomtype
        '
        Me.lbl_roomtype.AutoSize = True
        Me.lbl_roomtype.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomtype.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomtype.Location = New System.Drawing.Point(22, 345)
        Me.lbl_roomtype.Name = "lbl_roomtype"
        Me.lbl_roomtype.Size = New System.Drawing.Size(120, 24)
        Me.lbl_roomtype.TabIndex = 7
        Me.lbl_roomtype.Text = "Room Type:"
        '
        'lbl_roomnum
        '
        Me.lbl_roomnum.AutoSize = True
        Me.lbl_roomnum.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomnum.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomnum.Location = New System.Drawing.Point(22, 255)
        Me.lbl_roomnum.Name = "lbl_roomnum"
        Me.lbl_roomnum.Size = New System.Drawing.Size(150, 24)
        Me.lbl_roomnum.TabIndex = 6
        Me.lbl_roomnum.Text = "Room Number:"
        '
        'LBL_GUESTID
        '
        Me.LBL_GUESTID.AutoSize = True
        Me.LBL_GUESTID.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUESTID.ForeColor = System.Drawing.Color.Black
        Me.LBL_GUESTID.Location = New System.Drawing.Point(22, 602)
        Me.LBL_GUESTID.Name = "LBL_GUESTID"
        Me.LBL_GUESTID.Size = New System.Drawing.Size(97, 24)
        Me.LBL_GUESTID.TabIndex = 5
        Me.LBL_GUESTID.Text = "Guest ID:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TXT_searchguest)
        Me.Panel4.Controls.Add(Me.dgv_guest)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_RoomManagement)
        Me.Panel4.Location = New System.Drawing.Point(934, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 948)
        Me.Panel4.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Search Guest ID:"
        '
        'TXT_searchguest
        '
        Me.TXT_searchguest.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_searchguest.Location = New System.Drawing.Point(16, 516)
        Me.TXT_searchguest.Name = "TXT_searchguest"
        Me.TXT_searchguest.Size = New System.Drawing.Size(324, 22)
        Me.TXT_searchguest.TabIndex = 12
        '
        'dgv_guest
        '
        Me.dgv_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_guest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_guest.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_guest.Location = New System.Drawing.Point(16, 548)
        Me.dgv_guest.MultiSelect = False
        Me.dgv_guest.Name = "dgv_guest"
        Me.dgv_guest.Size = New System.Drawing.Size(714, 324)
        Me.dgv_guest.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Rooms:"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 71)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 11
        '
        'DGV_RoomManagement
        '
        Me.DGV_RoomManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_RoomManagement.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_RoomManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_RoomManagement.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_RoomManagement.Location = New System.Drawing.Point(16, 103)
        Me.DGV_RoomManagement.MultiSelect = False
        Me.DGV_RoomManagement.Name = "DGV_RoomManagement"
        Me.DGV_RoomManagement.Size = New System.Drawing.Size(714, 324)
        Me.DGV_RoomManagement.TabIndex = 13
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_DELETE.FlatAppearance.BorderSize = 0
        Me.BTN_DELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DELETE.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.ForeColor = System.Drawing.Color.Black
        Me.BTN_DELETE.Image = CType(resources.GetObject("BTN_DELETE.Image"), System.Drawing.Image)
        Me.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_DELETE.Location = New System.Drawing.Point(370, 783)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(132, 38)
        Me.BTN_DELETE.TabIndex = 9
        Me.BTN_DELETE.Text = "DELETE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ROOMS"
        Me.BTN_DELETE.UseVisualStyleBackColor = True
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
        Me.btn_clear.Location = New System.Drawing.Point(523, 783)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(126, 38)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "REMOVE ALL"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(178, 783)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(186, 38)
        Me.BTN_UPDATE.TabIndex = 8
        Me.BTN_UPDATE.Text = "UPDATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ROOMS"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'Room_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room_Reservation"
        Me.Text = "RoomReservation"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_guest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_RoomManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents cb_roomstat As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_roomstatus As Label
    Friend WithEvents lbl_roomcap As Label
    Friend WithEvents lbl_roomtype As Label
    Friend WithEvents lbl_roomnum As Label
    Friend WithEvents LBL_GUESTID As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DGV_RoomManagement As DataGridView
    Friend WithEvents txt_roomnum As TextBox
    Friend WithEvents txt_RoomID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_searchguest As TextBox
    Friend WithEvents dgv_guest As DataGridView
    Friend WithEvents txt_guestID As TextBox
    Friend WithEvents txt_guestroomID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents cb_roomcap As ComboBox
    Friend WithEvents cb_roomtype As ComboBox
End Class
