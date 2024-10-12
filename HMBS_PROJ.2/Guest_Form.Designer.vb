<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Guest_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guest_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_city = New System.Windows.Forms.ComboBox()
        Me.cb_municipality = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.txt_streetnum = New System.Windows.Forms.TextBox()
        Me.txt_streetname = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_guestID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.LBL_GUESTID = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_Guest = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_Guest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GUEST INFORMATION"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cb_city)
        Me.Panel3.Controls.Add(Me.cb_municipality)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.txt_streetnum)
        Me.Panel3.Controls.Add(Me.txt_streetname)
        Me.Panel3.Controls.Add(Me.txt_email)
        Me.Panel3.Controls.Add(Me.txt_phone)
        Me.Panel3.Controls.Add(Me.txt_fname)
        Me.Panel3.Controls.Add(Me.txt_lname)
        Me.Panel3.Controls.Add(Me.txt_guestID)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lbl_email)
        Me.Panel3.Controls.Add(Me.lbl_phone)
        Me.Panel3.Controls.Add(Me.lbl_lname)
        Me.Panel3.Controls.Add(Me.lbl_fname)
        Me.Panel3.Controls.Add(Me.LBL_GUESTID)
        Me.Panel3.Location = New System.Drawing.Point(0, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 946)
        Me.Panel3.TabIndex = 2
        '
        'cb_city
        '
        Me.cb_city.AutoCompleteCustomSource.AddRange(New String() {"Cavite", "Rizal", "Laguna", "Bulacan", "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela", "Quezon"})
        Me.cb_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_city.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_city.FormattingEnabled = True
        Me.cb_city.Items.AddRange(New Object() {"Cavite", "", "Rizal", "", "Laguna", "", "Bulacan", "", "Caloocan", "", "Las Piñas", "", "Makati", "", "Malabon", "", "Mandaluyong", "", "Manila", "", "Marikina", "", "Muntinlupa", "", "Navotas", "", "Parañaque", "", "Pasay", "", "Pasig", "", "Pateros", "", "Quezon City", "", "San Juan", "", "Taguig", "", "Valenzuela", "", "Quezon"})
        Me.cb_city.Location = New System.Drawing.Point(178, 576)
        Me.cb_city.Name = "cb_city"
        Me.cb_city.Size = New System.Drawing.Size(324, 26)
        Me.cb_city.TabIndex = 8
        '
        'cb_municipality
        '
        Me.cb_municipality.AutoCompleteCustomSource.AddRange(New String() {"Bacoor", "Carmona", "Dasmariñas", "Gen. Mariano Alvarez", "Gen. Trias", "Imus", "Kawit", "Noveleta", "Rosario", "Silang", "Tanza", "Angono", "Binangonan", "Cainta", "Cardona", "Morong", "Pililla", "Rodriguez", "San Mateo", "Tanay", "Taytay", "Teresa", "Biñan", "Cabuyao", "Calamba", "San Pedro", "Santa Rosa", "Balagtas", "Bocaue", "Bulakan", "Calumpit", "Guiguinto", "Hagonoy", "Marilao", "Meycauayan", "Obando", "Pandi", "Plaridel", "Pulilan", "San Ildefonso", "San Miguel", "San Rafael", "Santa Maria", "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela", "Agdangan", "Alabat", "Buenavista", "Catanauan", "Dolores", "General Luna", "General Nakar", "Guinayangan", "nfanta", "Jomalig", "Lopez", "Lucban", "Lucena City", "Macalelon", "Mauban", "Mulanay", "Padre Burgos", "Pagbilao", "Pitogo", "Plaridel", "Quezon", "Real", "Sariaya", "Tagkawayan", "Unisan"})
        Me.cb_municipality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_municipality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_municipality.Enabled = False
        Me.cb_municipality.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_municipality.FormattingEnabled = True
        Me.cb_municipality.Location = New System.Drawing.Point(178, 634)
        Me.cb_municipality.Name = "cb_municipality"
        Me.cb_municipality.Size = New System.Drawing.Size(324, 26)
        Me.cb_municipality.TabIndex = 9
        Me.cb_municipality.Visible = False
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
        Me.btn_clear.Location = New System.Drawing.Point(409, 716)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(93, 38)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 71)
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(178, 716)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 38)
        Me.BTN_UPDATE.TabIndex = 10
        Me.BTN_UPDATE.Text = "UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'txt_streetnum
        '
        Me.txt_streetnum.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_streetnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_streetnum.Location = New System.Drawing.Point(178, 518)
        Me.txt_streetnum.Name = "txt_streetnum"
        Me.txt_streetnum.Size = New System.Drawing.Size(324, 24)
        Me.txt_streetnum.TabIndex = 7
        '
        'txt_streetname
        '
        Me.txt_streetname.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_streetname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_streetname.Location = New System.Drawing.Point(178, 458)
        Me.txt_streetname.Name = "txt_streetname"
        Me.txt_streetname.Size = New System.Drawing.Size(324, 24)
        Me.txt_streetname.TabIndex = 6
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_email.Location = New System.Drawing.Point(178, 399)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(324, 24)
        Me.txt_email.TabIndex = 5
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_phone.Location = New System.Drawing.Point(178, 345)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(324, 24)
        Me.txt_phone.TabIndex = 4
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_fname.Location = New System.Drawing.Point(178, 228)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(324, 24)
        Me.txt_fname.TabIndex = 2
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_lname.Location = New System.Drawing.Point(178, 288)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(324, 24)
        Me.txt_lname.TabIndex = 3
        '
        'txt_guestID
        '
        Me.txt_guestID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestID.Location = New System.Drawing.Point(178, 171)
        Me.txt_guestID.Name = "txt_guestID"
        Me.txt_guestID.ReadOnly = True
        Me.txt_guestID.Size = New System.Drawing.Size(324, 24)
        Me.txt_guestID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 578)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 636)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Municipality:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Street Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Street Name:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(22, 399)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(68, 24)
        Me.lbl_email.TabIndex = 9
        Me.lbl_email.Text = "Email:"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.Black
        Me.lbl_phone.Location = New System.Drawing.Point(22, 345)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(154, 24)
        Me.lbl_phone.TabIndex = 8
        Me.lbl_phone.Text = "Phone Number:"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.ForeColor = System.Drawing.Color.Black
        Me.lbl_lname.Location = New System.Drawing.Point(22, 288)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(114, 24)
        Me.lbl_lname.TabIndex = 7
        Me.lbl_lname.Text = "Last Name:"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.ForeColor = System.Drawing.Color.Black
        Me.lbl_fname.Location = New System.Drawing.Point(22, 228)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(117, 24)
        Me.lbl_fname.TabIndex = 6
        Me.lbl_fname.Text = "First Name:"
        '
        'LBL_GUESTID
        '
        Me.LBL_GUESTID.AutoSize = True
        Me.LBL_GUESTID.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUESTID.ForeColor = System.Drawing.Color.Black
        Me.LBL_GUESTID.Location = New System.Drawing.Point(22, 171)
        Me.LBL_GUESTID.Name = "LBL_GUESTID"
        Me.LBL_GUESTID.Size = New System.Drawing.Size(97, 24)
        Me.LBL_GUESTID.TabIndex = 5
        Me.LBL_GUESTID.Text = "Guest ID:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_Guest)
        Me.Panel4.Location = New System.Drawing.Point(919, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 948)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Guest"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 71)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 12
        '
        'DGV_Guest
        '
        Me.DGV_Guest.AllowUserToAddRows = False
        Me.DGV_Guest.AllowUserToDeleteRows = False
        Me.DGV_Guest.AllowUserToResizeColumns = False
        Me.DGV_Guest.AllowUserToResizeRows = False
        Me.DGV_Guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Guest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Guest.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Guest.Location = New System.Drawing.Point(16, 103)
        Me.DGV_Guest.MultiSelect = False
        Me.DGV_Guest.Name = "DGV_Guest"
        Me.DGV_Guest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Guest.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Guest.ShowCellErrors = False
        Me.DGV_Guest.ShowCellToolTips = False
        Me.DGV_Guest.ShowEditingIcon = False
        Me.DGV_Guest.ShowRowErrors = False
        Me.DGV_Guest.Size = New System.Drawing.Size(714, 748)
        Me.DGV_Guest.TabIndex = 13
        '
        'Guest_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guest_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest_Form"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_Guest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DGV_Guest As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_lname As Label
    Friend WithEvents lbl_fname As Label
    Friend WithEvents LBL_GUESTID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_streetnum As TextBox
    Friend WithEvents txt_streetname As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_guestID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents cb_city As ComboBox
    Friend WithEvents cb_municipality As ComboBox
End Class
