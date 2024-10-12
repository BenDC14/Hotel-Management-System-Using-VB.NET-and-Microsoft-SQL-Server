<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_adminID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.CB_Admin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_uname = New System.Windows.Forms.Label()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_ACOOUNTS = New System.Windows.Forms.DataGridView()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.seepass_cb = New System.Windows.Forms.CheckBox()
        Me.btn_generate1 = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_SaveAccount = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_ACOOUNTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BTN_DELETE)
        Me.Panel3.Controls.Add(Me.seepass_cb)
        Me.Panel3.Controls.Add(Me.btn_generate1)
        Me.Panel3.Controls.Add(Me.btn_generate)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txt_adminID)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txt_number)
        Me.Panel3.Controls.Add(Me.CB_Admin)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txt_Email)
        Me.Panel3.Controls.Add(Me.lbl_uname)
        Me.Panel3.Controls.Add(Me.txt_uname)
        Me.Panel3.Controls.Add(Me.btn_SaveAccount)
        Me.Panel3.Controls.Add(Me.lbl_pass)
        Me.Panel3.Controls.Add(Me.lbl_lname)
        Me.Panel3.Controls.Add(Me.lbl_ID)
        Me.Panel3.Controls.Add(Me.lbl_fname)
        Me.Panel3.Controls.Add(Me.txt_pass)
        Me.Panel3.Controls.Add(Me.txt_lname)
        Me.Panel3.Controls.Add(Me.txt_fname)
        Me.Panel3.Controls.Add(Me.txt_empID)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 946)
        Me.Panel3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 617)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "ADMIN ID:"
        '
        'txt_adminID
        '
        Me.txt_adminID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adminID.Location = New System.Drawing.Point(140, 612)
        Me.txt_adminID.Name = "txt_adminID"
        Me.txt_adminID.ReadOnly = True
        Me.txt_adminID.Size = New System.Drawing.Size(575, 26)
        Me.txt_adminID.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "NUMBER:"
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.Location = New System.Drawing.Point(140, 321)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(575, 26)
        Me.txt_number.TabIndex = 4
        '
        'CB_Admin
        '
        Me.CB_Admin.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Admin.FormattingEnabled = True
        Me.CB_Admin.Items.AddRange(New Object() {"Yes", "No"})
        Me.CB_Admin.Location = New System.Drawing.Point(140, 554)
        Me.CB_Admin.Name = "CB_Admin"
        Me.CB_Admin.Size = New System.Drawing.Size(575, 27)
        Me.CB_Admin.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 559)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "ADMIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "EMAIL:"
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(140, 380)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(575, 26)
        Me.txt_Email.TabIndex = 5
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname.Location = New System.Drawing.Point(22, 445)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(96, 19)
        Me.lbl_uname.TabIndex = 62
        Me.lbl_uname.Text = "USERNAME:"
        '
        'txt_uname
        '
        Me.txt_uname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.Location = New System.Drawing.Point(140, 440)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(575, 26)
        Me.txt_uname.TabIndex = 6
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(22, 503)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(96, 19)
        Me.lbl_pass.TabIndex = 61
        Me.lbl_pass.Text = "PASSWORD:"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.Location = New System.Drawing.Point(24, 266)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(98, 19)
        Me.lbl_lname.TabIndex = 60
        Me.lbl_lname.Text = "LAST NAME:"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(24, 157)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(115, 19)
        Me.lbl_ID.TabIndex = 58
        Me.lbl_ID.Text = "EMPLOYEE ID:"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.Location = New System.Drawing.Point(24, 211)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(105, 19)
        Me.lbl_fname.TabIndex = 59
        Me.lbl_fname.Text = "FIRST NAME:"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(140, 498)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(575, 26)
        Me.txt_pass.TabIndex = 7
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(140, 266)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(575, 26)
        Me.txt_lname.TabIndex = 3
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(140, 211)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(575, 26)
        Me.txt_fname.TabIndex = 2
        '
        'txt_empID
        '
        Me.txt_empID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empID.Location = New System.Drawing.Point(140, 153)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.ReadOnly = True
        Me.txt_empID.Size = New System.Drawing.Size(575, 26)
        Me.txt_empID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACCOUNTS INFORMATION"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_ACOOUNTS)
        Me.Panel4.Location = New System.Drawing.Point(934, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 946)
        Me.Panel4.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search Accounts Information"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 66)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 13
        '
        'DGV_ACOOUNTS
        '
        Me.DGV_ACOOUNTS.AllowUserToAddRows = False
        Me.DGV_ACOOUNTS.AllowUserToDeleteRows = False
        Me.DGV_ACOOUNTS.AllowUserToResizeColumns = False
        Me.DGV_ACOOUNTS.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ACOOUNTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ACOOUNTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ACOOUNTS.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ACOOUNTS.Location = New System.Drawing.Point(16, 95)
        Me.DGV_ACOOUNTS.MultiSelect = False
        Me.DGV_ACOOUNTS.Name = "DGV_ACOOUNTS"
        Me.DGV_ACOOUNTS.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_ACOOUNTS.Size = New System.Drawing.Size(714, 690)
        Me.DGV_ACOOUNTS.TabIndex = 14
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
        Me.BTN_DELETE.Location = New System.Drawing.Point(456, 718)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(119, 35)
        Me.BTN_DELETE.TabIndex = 67
        Me.BTN_DELETE.Text = "DELETE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'seepass_cb
        '
        Me.seepass_cb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seepass_cb.Appearance = System.Windows.Forms.Appearance.Button
        Me.seepass_cb.AutoSize = True
        Me.seepass_cb.FlatAppearance.BorderSize = 0
        Me.seepass_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seepass_cb.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seepass_cb.Image = Global.HMBS_PROJ._2.My.Resources.Resources.hidden
        Me.seepass_cb.Location = New System.Drawing.Point(721, 497)
        Me.seepass_cb.Name = "seepass_cb"
        Me.seepass_cb.Size = New System.Drawing.Size(30, 30)
        Me.seepass_cb.TabIndex = 11
        Me.seepass_cb.Tag = ""
        Me.seepass_cb.UseVisualStyleBackColor = True
        '
        'btn_generate1
        '
        Me.btn_generate1.BackColor = System.Drawing.Color.Transparent
        Me.btn_generate1.FlatAppearance.BorderSize = 0
        Me.btn_generate1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_generate1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_generate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate1.Image = CType(resources.GetObject("btn_generate1.Image"), System.Drawing.Image)
        Me.btn_generate1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generate1.Location = New System.Drawing.Point(721, 609)
        Me.btn_generate1.Name = "btn_generate1"
        Me.btn_generate1.Size = New System.Drawing.Size(94, 30)
        Me.btn_generate1.TabIndex = 12
        Me.btn_generate1.Text = "Generate"
        Me.btn_generate1.UseVisualStyleBackColor = False
        '
        'btn_generate
        '
        Me.btn_generate.BackColor = System.Drawing.Color.Transparent
        Me.btn_generate.FlatAppearance.BorderSize = 0
        Me.btn_generate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_generate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Image = CType(resources.GetObject("btn_generate.Image"), System.Drawing.Image)
        Me.btn_generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generate.Location = New System.Drawing.Point(721, 149)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(94, 30)
        Me.btn_generate.TabIndex = 10
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = False
        '
        'btn_SaveAccount
        '
        Me.btn_SaveAccount.BackColor = System.Drawing.Color.Transparent
        Me.btn_SaveAccount.FlatAppearance.BorderSize = 0
        Me.btn_SaveAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_SaveAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_SaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SaveAccount.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveAccount.Image = CType(resources.GetObject("btn_SaveAccount.Image"), System.Drawing.Image)
        Me.btn_SaveAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SaveAccount.Location = New System.Drawing.Point(140, 706)
        Me.btn_SaveAccount.Name = "btn_SaveAccount"
        Me.btn_SaveAccount.Size = New System.Drawing.Size(136, 58)
        Me.btn_SaveAccount.TabIndex = 13
        Me.btn_SaveAccount.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.btn_SaveAccount.UseVisualStyleBackColor = False
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
        Me.btn_clear.Location = New System.Drawing.Point(622, 717)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(93, 38)
        Me.btn_clear.TabIndex = 15
        Me.btn_clear.Text = "CLEAR"
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(309, 716)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 38)
        Me.BTN_UPDATE.TabIndex = 14
        Me.BTN_UPDATE.Text = "UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_ACOOUNTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents seepass_cb As CheckBox
    Friend WithEvents btn_generate1 As Button
    Friend WithEvents btn_generate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_adminID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_number As TextBox
    Friend WithEvents CB_Admin As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_uname As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents btn_SaveAccount As Button
    Friend WithEvents lbl_pass As Label
    Friend WithEvents lbl_lname As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_fname As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_empID As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DGV_ACOOUNTS As DataGridView
    Friend WithEvents BTN_DELETE As Button
End Class
