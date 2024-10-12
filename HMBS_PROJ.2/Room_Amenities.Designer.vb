<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room_Amenities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_Amenities))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_addquantity = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lv_amenity = New System.Windows.Forms.ListView()
        Me.Amenity_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amenity_Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amenity_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.txt_guestroomID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_roomamentity = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_roomnum = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dgv_roomamenity = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_searchguest = New System.Windows.Forms.TextBox()
        Me.dgv_amenity = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_totalprice = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_roomamenity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_amenity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txt_totalprice)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btn_addquantity)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txt_Quantity)
        Me.Panel3.Controls.Add(Me.txt_ID)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.lv_amenity)
        Me.Panel3.Controls.Add(Me.BTN_DELETE)
        Me.Panel3.Controls.Add(Me.txt_guestroomID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btn_remove)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_roomamentity)
        Me.Panel3.Controls.Add(Me.txt_price)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_roomnum)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 944)
        Me.Panel3.TabIndex = 5
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(84, 554)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 35)
        Me.BTN_UPDATE.TabIndex = 26
        Me.BTN_UPDATE.Text = "UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AMENITY"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(229, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_addquantity
        '
        Me.btn_addquantity.FlatAppearance.BorderSize = 0
        Me.btn_addquantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_addquantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_addquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addquantity.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addquantity.ForeColor = System.Drawing.Color.Black
        Me.btn_addquantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addquantity.Location = New System.Drawing.Point(855, 135)
        Me.btn_addquantity.Name = "btn_addquantity"
        Me.btn_addquantity.Size = New System.Drawing.Size(54, 25)
        Me.btn_addquantity.TabIndex = 23
        Me.btn_addquantity.Text = "ADD"
        Me.btn_addquantity.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(580, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Quantity:"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_Quantity.Location = New System.Drawing.Point(682, 136)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(167, 24)
        Me.txt_Quantity.TabIndex = 21
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(129, 87)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(24, 20)
        Me.txt_ID.TabIndex = 20
        Me.txt_ID.Visible = False
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
        Me.btn_clear.Location = New System.Drawing.Point(782, 547)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(126, 38)
        Me.btn_clear.TabIndex = 19
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'lv_amenity
        '
        Me.lv_amenity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_amenity.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Amenity_ID, Me.Amenity_Price, Me.Amenity_Name, Me.Quantity})
        Me.lv_amenity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_amenity.HideSelection = False
        Me.lv_amenity.Location = New System.Drawing.Point(584, 166)
        Me.lv_amenity.Name = "lv_amenity"
        Me.lv_amenity.Scrollable = False
        Me.lv_amenity.Size = New System.Drawing.Size(325, 375)
        Me.lv_amenity.TabIndex = 18
        Me.lv_amenity.UseCompatibleStateImageBehavior = False
        Me.lv_amenity.View = System.Windows.Forms.View.Details
        '
        'Amenity_ID
        '
        Me.Amenity_ID.Text = "Amenity ID"
        Me.Amenity_ID.Width = 80
        '
        'Amenity_Price
        '
        Me.Amenity_Price.Text = "Amenity Price"
        Me.Amenity_Price.Width = 80
        '
        'Amenity_Name
        '
        Me.Amenity_Name.Text = "Amenity Name"
        Me.Amenity_Name.Width = 80
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 91
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
        Me.BTN_DELETE.Location = New System.Drawing.Point(245, 551)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(105, 38)
        Me.BTN_DELETE.TabIndex = 9
        Me.BTN_DELETE.Text = "DELETE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'txt_guestroomID
        '
        Me.txt_guestroomID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestroomID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestroomID.Location = New System.Drawing.Point(229, 166)
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
        Me.Label5.Location = New System.Drawing.Point(44, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Guest Room ID:"
        '
        'btn_remove
        '
        Me.btn_remove.FlatAppearance.BorderSize = 0
        Me.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.Black
        Me.btn_remove.Image = CType(resources.GetObject("btn_remove.Image"), System.Drawing.Image)
        Me.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_remove.Location = New System.Drawing.Point(414, 551)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(126, 38)
        Me.btn_remove.TabIndex = 10
        Me.btn_remove.Text = "REMOVE ALL"
        Me.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_remove.UseVisualStyleBackColor = True
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
        'txt_roomamentity
        '
        Me.txt_roomamentity.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_roomamentity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_roomamentity.Location = New System.Drawing.Point(229, 271)
        Me.txt_roomamentity.Name = "txt_roomamentity"
        Me.txt_roomamentity.ReadOnly = True
        Me.txt_roomamentity.Size = New System.Drawing.Size(324, 24)
        Me.txt_roomamentity.TabIndex = 2
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_price.Location = New System.Drawing.Point(229, 411)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(324, 24)
        Me.txt_price.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Price:"
        '
        'lbl_roomnum
        '
        Me.lbl_roomnum.AutoSize = True
        Me.lbl_roomnum.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomnum.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomnum.Location = New System.Drawing.Point(44, 271)
        Me.lbl_roomnum.Name = "lbl_roomnum"
        Me.lbl_roomnum.Size = New System.Drawing.Size(179, 24)
        Me.lbl_roomnum.TabIndex = 6
        Me.lbl_roomnum.Text = "Room Amenity ID:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.dgv_roomamenity)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.TXT_searchguest)
        Me.Panel4.Controls.Add(Me.dgv_amenity)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(934, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 948)
        Me.Panel4.TabIndex = 18
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(22, 519)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 18
        '
        'dgv_roomamenity
        '
        Me.dgv_roomamenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_roomamenity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_roomamenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_roomamenity.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_roomamenity.Location = New System.Drawing.Point(22, 551)
        Me.dgv_roomamenity.MultiSelect = False
        Me.dgv_roomamenity.Name = "dgv_roomamenity"
        Me.dgv_roomamenity.Size = New System.Drawing.Size(714, 373)
        Me.dgv_roomamenity.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(18, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Search Rooms Amenity:"
        '
        'TXT_searchguest
        '
        Me.TXT_searchguest.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_searchguest.Location = New System.Drawing.Point(22, 55)
        Me.TXT_searchguest.Name = "TXT_searchguest"
        Me.TXT_searchguest.Size = New System.Drawing.Size(324, 22)
        Me.TXT_searchguest.TabIndex = 12
        '
        'dgv_amenity
        '
        Me.dgv_amenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_amenity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_amenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_amenity.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_amenity.Location = New System.Drawing.Point(22, 87)
        Me.dgv_amenity.MultiSelect = False
        Me.dgv_amenity.Name = "dgv_amenity"
        Me.dgv_amenity.Size = New System.Drawing.Size(714, 373)
        Me.dgv_amenity.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Amenity:"
        '
        'txt_totalprice
        '
        Me.txt_totalprice.FlatAppearance.BorderSize = 0
        Me.txt_totalprice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_totalprice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_totalprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_totalprice.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.ForeColor = System.Drawing.Color.Black
        Me.txt_totalprice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txt_totalprice.Location = New System.Drawing.Point(606, 558)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(93, 25)
        Me.txt_totalprice.TabIndex = 27
        Me.txt_totalprice.Text = "Total Price"
        Me.txt_totalprice.UseVisualStyleBackColor = True
        '
        'Room_Amenities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room_Amenities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room_Amenities"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_roomamenity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_amenity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents txt_guestroomID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_remove As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_roomamentity As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_roomnum As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TXT_searchguest As TextBox
    Friend WithEvents dgv_amenity As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dgv_roomamenity As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents btn_addquantity As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents lv_amenity As ListView
    Friend WithEvents Amenity_ID As ColumnHeader
    Friend WithEvents Amenity_Price As ColumnHeader
    Friend WithEvents Amenity_Name As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents txt_totalprice As Button
End Class
