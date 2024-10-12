<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Amenity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Amenity))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_PRINT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_Amenity = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_amenity_quantity = New System.Windows.Forms.TextBox()
        Me.txt_Amenity_Price = New System.Windows.Forms.TextBox()
        Me.txt_Amenity_Description = New System.Windows.Forms.TextBox()
        Me.BTN_GEN = New System.Windows.Forms.Button()
        Me.txt_AmenityID = New System.Windows.Forms.TextBox()
        Me.lbl_RoomID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.txt_AmenityName = New System.Windows.Forms.TextBox()
        Me.lbl_roomstatus = New System.Windows.Forms.Label()
        Me.lbl_roomcap = New System.Windows.Forms.Label()
        Me.lbl_roomtype = New System.Windows.Forms.Label()
        Me.lbl_roomnum = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_Amenity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BTN_PRINT)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_Amenity)
        Me.Panel4.Location = New System.Drawing.Point(933, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 948)
        Me.Panel4.TabIndex = 13
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
        Me.BTN_PRINT.TabIndex = 13
        Me.BTN_PRINT.Text = "PRINT"
        Me.BTN_PRINT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Amenity:"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 66)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 12
        '
        'DGV_Amenity
        '
        Me.DGV_Amenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Amenity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Amenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Amenity.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Amenity.Location = New System.Drawing.Point(16, 95)
        Me.DGV_Amenity.MultiSelect = False
        Me.DGV_Amenity.Name = "DGV_Amenity"
        Me.DGV_Amenity.Size = New System.Drawing.Size(714, 690)
        Me.DGV_Amenity.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txt_amenity_quantity)
        Me.Panel3.Controls.Add(Me.txt_Amenity_Price)
        Me.Panel3.Controls.Add(Me.txt_Amenity_Description)
        Me.Panel3.Controls.Add(Me.BTN_GEN)
        Me.Panel3.Controls.Add(Me.txt_AmenityID)
        Me.Panel3.Controls.Add(Me.lbl_RoomID)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.BTN_DELETE)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTN_UPDATE)
        Me.Panel3.Controls.Add(Me.BTN_SAVE)
        Me.Panel3.Controls.Add(Me.txt_AmenityName)
        Me.Panel3.Controls.Add(Me.lbl_roomstatus)
        Me.Panel3.Controls.Add(Me.lbl_roomcap)
        Me.Panel3.Controls.Add(Me.lbl_roomtype)
        Me.Panel3.Controls.Add(Me.lbl_roomnum)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 947)
        Me.Panel3.TabIndex = 12
        '
        'txt_amenity_quantity
        '
        Me.txt_amenity_quantity.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amenity_quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_amenity_quantity.Location = New System.Drawing.Point(236, 512)
        Me.txt_amenity_quantity.Name = "txt_amenity_quantity"
        Me.txt_amenity_quantity.Size = New System.Drawing.Size(324, 24)
        Me.txt_amenity_quantity.TabIndex = 16
        '
        'txt_Amenity_Price
        '
        Me.txt_Amenity_Price.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amenity_Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_Amenity_Price.Location = New System.Drawing.Point(236, 339)
        Me.txt_Amenity_Price.Name = "txt_Amenity_Price"
        Me.txt_Amenity_Price.Size = New System.Drawing.Size(324, 24)
        Me.txt_Amenity_Price.TabIndex = 15
        '
        'txt_Amenity_Description
        '
        Me.txt_Amenity_Description.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amenity_Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_Amenity_Description.Location = New System.Drawing.Point(236, 425)
        Me.txt_Amenity_Description.Name = "txt_Amenity_Description"
        Me.txt_Amenity_Description.Size = New System.Drawing.Size(324, 24)
        Me.txt_Amenity_Description.TabIndex = 14
        '
        'BTN_GEN
        '
        Me.BTN_GEN.FlatAppearance.BorderSize = 0
        Me.BTN_GEN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_GEN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_GEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GEN.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GEN.ForeColor = System.Drawing.Color.Black
        Me.BTN_GEN.Image = CType(resources.GetObject("BTN_GEN.Image"), System.Drawing.Image)
        Me.BTN_GEN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_GEN.Location = New System.Drawing.Point(584, 182)
        Me.BTN_GEN.Name = "BTN_GEN"
        Me.BTN_GEN.Size = New System.Drawing.Size(103, 38)
        Me.BTN_GEN.TabIndex = 6
        Me.BTN_GEN.Text = "GENERATE"
        Me.BTN_GEN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_GEN.UseVisualStyleBackColor = True
        '
        'txt_AmenityID
        '
        Me.txt_AmenityID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmenityID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_AmenityID.Location = New System.Drawing.Point(236, 188)
        Me.txt_AmenityID.Name = "txt_AmenityID"
        Me.txt_AmenityID.Size = New System.Drawing.Size(324, 24)
        Me.txt_AmenityID.TabIndex = 1
        '
        'lbl_RoomID
        '
        Me.lbl_RoomID.AutoSize = True
        Me.lbl_RoomID.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RoomID.ForeColor = System.Drawing.Color.Black
        Me.lbl_RoomID.Location = New System.Drawing.Point(23, 186)
        Me.lbl_RoomID.Name = "lbl_RoomID"
        Me.lbl_RoomID.Size = New System.Drawing.Size(120, 24)
        Me.lbl_RoomID.TabIndex = 13
        Me.lbl_RoomID.Text = "Amenity ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 59)
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
        Me.btn_clear.Location = New System.Drawing.Point(584, 732)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(93, 35)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.FlatAppearance.BorderSize = 0
        Me.BTN_DELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DELETE.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.ForeColor = System.Drawing.Color.Black
        Me.BTN_DELETE.Image = CType(resources.GetObject("BTN_DELETE.Image"), System.Drawing.Image)
        Me.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_DELETE.Location = New System.Drawing.Point(427, 732)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(105, 35)
        Me.BTN_DELETE.TabIndex = 9
        Me.BTN_DELETE.Text = "DELETE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AMENITY"
        Me.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOM MANAGEMENT"
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
        Me.BTN_UPDATE.Location = New System.Drawing.Point(258, 732)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(104, 35)
        Me.BTN_UPDATE.TabIndex = 8
        Me.BTN_UPDATE.Text = "UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AMENITY"
        Me.BTN_UPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.FlatAppearance.BorderSize = 0
        Me.BTN_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SAVE.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.ForeColor = System.Drawing.Color.Black
        Me.BTN_SAVE.Image = CType(resources.GetObject("BTN_SAVE.Image"), System.Drawing.Image)
        Me.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_SAVE.Location = New System.Drawing.Point(100, 732)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(133, 35)
        Me.BTN_SAVE.TabIndex = 7
        Me.BTN_SAVE.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AMENITY"
        Me.BTN_SAVE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'txt_AmenityName
        '
        Me.txt_AmenityName.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmenityName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_AmenityName.Location = New System.Drawing.Point(236, 265)
        Me.txt_AmenityName.Name = "txt_AmenityName"
        Me.txt_AmenityName.Size = New System.Drawing.Size(324, 24)
        Me.txt_AmenityName.TabIndex = 2
        '
        'lbl_roomstatus
        '
        Me.lbl_roomstatus.AutoSize = True
        Me.lbl_roomstatus.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomstatus.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomstatus.Location = New System.Drawing.Point(23, 337)
        Me.lbl_roomstatus.Name = "lbl_roomstatus"
        Me.lbl_roomstatus.Size = New System.Drawing.Size(142, 24)
        Me.lbl_roomstatus.TabIndex = 9
        Me.lbl_roomstatus.Text = "Amenity Price:"
        '
        'lbl_roomcap
        '
        Me.lbl_roomcap.AutoSize = True
        Me.lbl_roomcap.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomcap.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomcap.Location = New System.Drawing.Point(23, 510)
        Me.lbl_roomcap.Name = "lbl_roomcap"
        Me.lbl_roomcap.Size = New System.Drawing.Size(177, 24)
        Me.lbl_roomcap.TabIndex = 8
        Me.lbl_roomcap.Text = "Amenity Quantity:"
        '
        'lbl_roomtype
        '
        Me.lbl_roomtype.AutoSize = True
        Me.lbl_roomtype.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomtype.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomtype.Location = New System.Drawing.Point(23, 425)
        Me.lbl_roomtype.Name = "lbl_roomtype"
        Me.lbl_roomtype.Size = New System.Drawing.Size(202, 24)
        Me.lbl_roomtype.TabIndex = 7
        Me.lbl_roomtype.Text = "Amenity Description:"
        '
        'lbl_roomnum
        '
        Me.lbl_roomnum.AutoSize = True
        Me.lbl_roomnum.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomnum.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomnum.Location = New System.Drawing.Point(23, 263)
        Me.lbl_roomnum.Name = "lbl_roomnum"
        Me.lbl_roomnum.Size = New System.Drawing.Size(151, 24)
        Me.lbl_roomnum.TabIndex = 6
        Me.lbl_roomnum.Text = "Amenity Name:"
        '
        'Amenity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1715, 944)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Amenity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amenity"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_Amenity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTN_PRINT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DGV_Amenity As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_GEN As Button
    Friend WithEvents txt_AmenityID As TextBox
    Friend WithEvents lbl_RoomID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents txt_AmenityName As TextBox
    Friend WithEvents lbl_roomstatus As Label
    Friend WithEvents lbl_roomcap As Label
    Friend WithEvents lbl_roomtype As Label
    Friend WithEvents lbl_roomnum As Label
    Friend WithEvents txt_amenity_quantity As TextBox
    Friend WithEvents txt_Amenity_Price As TextBox
    Friend WithEvents txt_Amenity_Description As TextBox
End Class
