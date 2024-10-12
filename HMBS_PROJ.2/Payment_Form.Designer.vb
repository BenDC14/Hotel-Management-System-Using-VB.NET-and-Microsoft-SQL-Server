<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Form))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtp_paymentdate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.txt_amenitycharge = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_roomcharge = New System.Windows.Forms.TextBox()
        Me.txt_overalltotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ammount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_paymentmethod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_roomtype = New System.Windows.Forms.TextBox()
        Me.txt_paymentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_advance = New System.Windows.Forms.TextBox()
        Me.txt_days = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_roomstat = New System.Windows.Forms.ComboBox()
        Me.txt_RoomNum = New System.Windows.Forms.TextBox()
        Me.lbl_roomstatus = New System.Windows.Forms.Label()
        Me.lbl_roomtype = New System.Windows.Forms.Label()
        Me.lbl_roomnum = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dgv_roomamenity = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgv_payment = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DGV_AllID = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_roomamenity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_payment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_AllID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.dtp_paymentdate)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txt_tax)
        Me.Panel3.Controls.Add(Me.txt_amenitycharge)
        Me.Panel3.Controls.Add(Me.txt_subtotal)
        Me.Panel3.Controls.Add(Me.txt_roomcharge)
        Me.Panel3.Controls.Add(Me.txt_overalltotal)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txt_change)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txt_ammount)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cb_paymentmethod)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txt_roomtype)
        Me.Panel3.Controls.Add(Me.txt_paymentID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txt_advance)
        Me.Panel3.Controls.Add(Me.txt_days)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cb_roomstat)
        Me.Panel3.Controls.Add(Me.txt_RoomNum)
        Me.Panel3.Controls.Add(Me.lbl_roomstatus)
        Me.Panel3.Controls.Add(Me.lbl_roomtype)
        Me.Panel3.Controls.Add(Me.lbl_roomnum)
        Me.Panel3.Controls.Add(Me.txt_fullname)
        Me.Panel3.Controls.Add(Me.lbl_fname)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 944)
        Me.Panel3.TabIndex = 5
        '
        'dtp_paymentdate
        '
        Me.dtp_paymentdate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_paymentdate.Location = New System.Drawing.Point(650, 490)
        Me.dtp_paymentdate.Name = "dtp_paymentdate"
        Me.dtp_paymentdate.Size = New System.Drawing.Size(200, 25)
        Me.dtp_paymentdate.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(454, 490)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 24)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Payment Date:"
        '
        'txt_tax
        '
        Me.txt_tax.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_tax.Location = New System.Drawing.Point(216, 376)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.Size = New System.Drawing.Size(199, 24)
        Me.txt_tax.TabIndex = 45
        '
        'txt_amenitycharge
        '
        Me.txt_amenitycharge.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amenitycharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_amenitycharge.Location = New System.Drawing.Point(651, 315)
        Me.txt_amenitycharge.Name = "txt_amenitycharge"
        Me.txt_amenitycharge.Size = New System.Drawing.Size(199, 24)
        Me.txt_amenitycharge.TabIndex = 44
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_subtotal.Location = New System.Drawing.Point(215, 315)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(199, 24)
        Me.txt_subtotal.TabIndex = 43
        '
        'txt_roomcharge
        '
        Me.txt_roomcharge.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_roomcharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_roomcharge.Location = New System.Drawing.Point(651, 254)
        Me.txt_roomcharge.Name = "txt_roomcharge"
        Me.txt_roomcharge.Size = New System.Drawing.Size(199, 24)
        Me.txt_roomcharge.TabIndex = 42
        '
        'txt_overalltotal
        '
        Me.txt_overalltotal.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_overalltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_overalltotal.Location = New System.Drawing.Point(216, 434)
        Me.txt_overalltotal.Name = "txt_overalltotal"
        Me.txt_overalltotal.Size = New System.Drawing.Size(199, 24)
        Me.txt_overalltotal.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(20, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 24)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Overall Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 24)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Tax:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(19, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 24)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Sub Total:"
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(205, 611)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 38)
        Me.BTN_UPDATE.TabIndex = 8
        Me.BTN_UPDATE.Text = "UPDATE PAYMENT"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(455, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 24)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Amenity Charges:"
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
        Me.btn_clear.Location = New System.Drawing.Point(612, 611)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(126, 38)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "REMOVE ALL"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(455, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Room Charges:"
        '
        'txt_change
        '
        Me.txt_change.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_change.Location = New System.Drawing.Point(216, 493)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.Size = New System.Drawing.Size(199, 24)
        Me.txt_change.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(20, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 24)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Change:"
        '
        'txt_ammount
        '
        Me.txt_ammount.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ammount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ammount.Location = New System.Drawing.Point(650, 434)
        Me.txt_ammount.Name = "txt_ammount"
        Me.txt_ammount.Size = New System.Drawing.Size(199, 24)
        Me.txt_ammount.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(454, 432)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 24)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Payment Ammount:"
        '
        'cb_paymentmethod
        '
        Me.cb_paymentmethod.AutoCompleteCustomSource.AddRange(New String() {"Gcash", "Paymaya", "Cash"})
        Me.cb_paymentmethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_paymentmethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_paymentmethod.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_paymentmethod.FormattingEnabled = True
        Me.cb_paymentmethod.Items.AddRange(New Object() {"Gcash", "Paymaya", "Cash"})
        Me.cb_paymentmethod.Location = New System.Drawing.Point(650, 377)
        Me.cb_paymentmethod.Name = "cb_paymentmethod"
        Me.cb_paymentmethod.Size = New System.Drawing.Size(199, 26)
        Me.cb_paymentmethod.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(454, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Payment Method:"
        '
        'txt_roomtype
        '
        Me.txt_roomtype.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_roomtype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_roomtype.Location = New System.Drawing.Point(651, 203)
        Me.txt_roomtype.Name = "txt_roomtype"
        Me.txt_roomtype.Size = New System.Drawing.Size(199, 24)
        Me.txt_roomtype.TabIndex = 28
        '
        'txt_paymentID
        '
        Me.txt_paymentID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paymentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_paymentID.Location = New System.Drawing.Point(215, 104)
        Me.txt_paymentID.Name = "txt_paymentID"
        Me.txt_paymentID.Size = New System.Drawing.Size(199, 24)
        Me.txt_paymentID.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Payment ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Advance Payment:"
        '
        'txt_advance
        '
        Me.txt_advance.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_advance.Location = New System.Drawing.Point(216, 203)
        Me.txt_advance.Name = "txt_advance"
        Me.txt_advance.Size = New System.Drawing.Size(199, 24)
        Me.txt_advance.TabIndex = 24
        '
        'txt_days
        '
        Me.txt_days.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_days.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_days.Location = New System.Drawing.Point(216, 254)
        Me.txt_days.Name = "txt_days"
        Me.txt_days.Size = New System.Drawing.Size(199, 24)
        Me.txt_days.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Number of days:"
        '
        'cb_roomstat
        '
        Me.cb_roomstat.AutoCompleteCustomSource.AddRange(New String() {"Available", "Booked", "Reserved", "Out of Order", "Under Maintenance"})
        Me.cb_roomstat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_roomstat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_roomstat.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_roomstat.FormattingEnabled = True
        Me.cb_roomstat.Items.AddRange(New Object() {"Available", "Booked", "Reserved", "Out of Order", "Under Maintenance"})
        Me.cb_roomstat.Location = New System.Drawing.Point(651, 151)
        Me.cb_roomstat.Name = "cb_roomstat"
        Me.cb_roomstat.Size = New System.Drawing.Size(199, 26)
        Me.cb_roomstat.TabIndex = 11
        '
        'txt_RoomNum
        '
        Me.txt_RoomNum.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RoomNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_RoomNum.Location = New System.Drawing.Point(651, 101)
        Me.txt_RoomNum.Name = "txt_RoomNum"
        Me.txt_RoomNum.Size = New System.Drawing.Size(199, 24)
        Me.txt_RoomNum.TabIndex = 10
        '
        'lbl_roomstatus
        '
        Me.lbl_roomstatus.AutoSize = True
        Me.lbl_roomstatus.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomstatus.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomstatus.Location = New System.Drawing.Point(451, 153)
        Me.lbl_roomstatus.Name = "lbl_roomstatus"
        Me.lbl_roomstatus.Size = New System.Drawing.Size(129, 24)
        Me.lbl_roomstatus.TabIndex = 15
        Me.lbl_roomstatus.Text = "Room Status:"
        '
        'lbl_roomtype
        '
        Me.lbl_roomtype.AutoSize = True
        Me.lbl_roomtype.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomtype.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomtype.Location = New System.Drawing.Point(451, 201)
        Me.lbl_roomtype.Name = "lbl_roomtype"
        Me.lbl_roomtype.Size = New System.Drawing.Size(120, 24)
        Me.lbl_roomtype.TabIndex = 14
        Me.lbl_roomtype.Text = "Room Type:"
        '
        'lbl_roomnum
        '
        Me.lbl_roomnum.AutoSize = True
        Me.lbl_roomnum.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomnum.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomnum.Location = New System.Drawing.Point(453, 101)
        Me.lbl_roomnum.Name = "lbl_roomnum"
        Me.lbl_roomnum.Size = New System.Drawing.Size(150, 24)
        Me.lbl_roomnum.TabIndex = 13
        Me.lbl_roomnum.Text = "Room Number:"
        '
        'txt_fullname
        '
        Me.txt_fullname.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_fullname.Location = New System.Drawing.Point(215, 149)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(199, 24)
        Me.txt_fullname.TabIndex = 1
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.ForeColor = System.Drawing.Color.Black
        Me.lbl_fname.Location = New System.Drawing.Point(19, 149)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(128, 24)
        Me.lbl_fname.TabIndex = 8
        Me.lbl_fname.Text = "Guest Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(412, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(952, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Search Room Amenity Information"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(956, 63)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 16
        '
        'dgv_roomamenity
        '
        Me.dgv_roomamenity.AllowUserToAddRows = False
        Me.dgv_roomamenity.AllowUserToDeleteRows = False
        Me.dgv_roomamenity.AllowUserToResizeColumns = False
        Me.dgv_roomamenity.AllowUserToResizeRows = False
        Me.dgv_roomamenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_roomamenity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_roomamenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_roomamenity.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_roomamenity.Location = New System.Drawing.Point(956, 91)
        Me.dgv_roomamenity.MultiSelect = False
        Me.dgv_roomamenity.Name = "dgv_roomamenity"
        Me.dgv_roomamenity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_roomamenity.Size = New System.Drawing.Size(714, 216)
        Me.dgv_roomamenity.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(952, 615)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(265, 24)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Search Payment Information"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(956, 640)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 22)
        Me.TextBox1.TabIndex = 19
        '
        'dgv_payment
        '
        Me.dgv_payment.AllowUserToAddRows = False
        Me.dgv_payment.AllowUserToDeleteRows = False
        Me.dgv_payment.AllowUserToResizeColumns = False
        Me.dgv_payment.AllowUserToResizeRows = False
        Me.dgv_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_payment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_payment.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_payment.Location = New System.Drawing.Point(956, 668)
        Me.dgv_payment.MultiSelect = False
        Me.dgv_payment.Name = "dgv_payment"
        Me.dgv_payment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_payment.Size = New System.Drawing.Size(714, 216)
        Me.dgv_payment.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(952, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(210, 24)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Search ID Information"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(956, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(324, 22)
        Me.TextBox2.TabIndex = 22
        '
        'DGV_AllID
        '
        Me.DGV_AllID.AllowUserToAddRows = False
        Me.DGV_AllID.AllowUserToDeleteRows = False
        Me.DGV_AllID.AllowUserToResizeColumns = False
        Me.DGV_AllID.AllowUserToResizeRows = False
        Me.DGV_AllID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_AllID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_AllID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_AllID.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_AllID.Location = New System.Drawing.Point(956, 384)
        Me.DGV_AllID.MultiSelect = False
        Me.DGV_AllID.Name = "DGV_AllID"
        Me.DGV_AllID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_AllID.Size = New System.Drawing.Size(714, 216)
        Me.DGV_AllID.TabIndex = 23
        '
        'Payment_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DGV_AllID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgv_payment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.dgv_roomamenity)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment_Form"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_roomamenity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_payment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_AllID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dgv_roomamenity As DataGridView
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents lbl_fname As Label
    Friend WithEvents txt_days As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_roomstat As ComboBox
    Friend WithEvents txt_RoomNum As TextBox
    Friend WithEvents lbl_roomstatus As Label
    Friend WithEvents lbl_roomtype As Label
    Friend WithEvents lbl_roomnum As Label
    Friend WithEvents txt_paymentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_advance As TextBox
    Friend WithEvents txt_roomtype As TextBox
    Friend WithEvents cb_paymentmethod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ammount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_change As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_overalltotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_tax As TextBox
    Friend WithEvents txt_amenitycharge As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_roomcharge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgv_payment As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DGV_AllID As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents dtp_paymentdate As DateTimePicker
End Class
