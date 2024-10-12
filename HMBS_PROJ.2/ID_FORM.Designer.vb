<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ID_FORM
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_FORM))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DGV_AllID = New System.Windows.Forms.DataGridView()
        Me.txt_paymentid = New System.Windows.Forms.TextBox()
        Me.txt_AllID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_BookingID = New System.Windows.Forms.TextBox()
        Me.BTN_GEN = New System.Windows.Forms.Button()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.txt_guestroomID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_guestID = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_GUESTID = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_AllID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_search)
        Me.Panel4.Controls.Add(Me.DGV_AllID)
        Me.Panel4.Location = New System.Drawing.Point(934, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 944)
        Me.Panel4.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search ID Information"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(16, 66)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(324, 22)
        Me.txt_search.TabIndex = 11
        '
        'DGV_AllID
        '
        Me.DGV_AllID.AllowUserToAddRows = False
        Me.DGV_AllID.AllowUserToDeleteRows = False
        Me.DGV_AllID.AllowUserToResizeColumns = False
        Me.DGV_AllID.AllowUserToResizeRows = False
        Me.DGV_AllID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_AllID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_AllID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_AllID.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_AllID.Location = New System.Drawing.Point(16, 95)
        Me.DGV_AllID.MultiSelect = False
        Me.DGV_AllID.Name = "DGV_AllID"
        Me.DGV_AllID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_AllID.Size = New System.Drawing.Size(714, 690)
        Me.DGV_AllID.TabIndex = 14
        '
        'txt_paymentid
        '
        Me.txt_paymentid.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paymentid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_paymentid.Location = New System.Drawing.Point(207, 419)
        Me.txt_paymentid.Name = "txt_paymentid"
        Me.txt_paymentid.ReadOnly = True
        Me.txt_paymentid.Size = New System.Drawing.Size(324, 24)
        Me.txt_paymentid.TabIndex = 5
        '
        'txt_AllID
        '
        Me.txt_AllID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AllID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_AllID.Location = New System.Drawing.Point(207, 178)
        Me.txt_AllID.Name = "txt_AllID"
        Me.txt_AllID.ReadOnly = True
        Me.txt_AllID.Size = New System.Drawing.Size(324, 24)
        Me.txt_AllID.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_BookingID)
        Me.Panel3.Controls.Add(Me.BTN_GEN)
        Me.Panel3.Controls.Add(Me.BTN_SAVE)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BTN_DELETE)
        Me.Panel3.Controls.Add(Me.txt_guestroomID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txt_guestID)
        Me.Panel3.Controls.Add(Me.txt_paymentid)
        Me.Panel3.Controls.Add(Me.btn_clear)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.txt_AllID)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.LBL_GUESTID)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 944)
        Me.Panel3.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Booking ID:"
        '
        'txt_BookingID
        '
        Me.txt_BookingID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BookingID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_BookingID.Location = New System.Drawing.Point(207, 496)
        Me.txt_BookingID.Name = "txt_BookingID"
        Me.txt_BookingID.ReadOnly = True
        Me.txt_BookingID.Size = New System.Drawing.Size(324, 24)
        Me.txt_BookingID.TabIndex = 6
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
        Me.BTN_GEN.Location = New System.Drawing.Point(556, 174)
        Me.BTN_GEN.Name = "BTN_GEN"
        Me.BTN_GEN.Size = New System.Drawing.Size(120, 35)
        Me.BTN_GEN.TabIndex = 10
        Me.BTN_GEN.Text = "GENERATE ID"
        Me.BTN_GEN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_GEN.UseVisualStyleBackColor = True
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.FlatAppearance.BorderSize = 0
        Me.BTN_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SAVE.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.ForeColor = System.Drawing.Color.Black
        Me.BTN_SAVE.Image = CType(resources.GetObject("BTN_SAVE.Image"), System.Drawing.Image)
        Me.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_SAVE.Location = New System.Drawing.Point(153, 676)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(140, 35)
        Me.BTN_SAVE.TabIndex = 7
        Me.BTN_SAVE.Text = "SAVE ID"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Payment ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ID:"
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
        Me.BTN_DELETE.Location = New System.Drawing.Point(299, 677)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(119, 35)
        Me.BTN_DELETE.TabIndex = 8
        Me.BTN_DELETE.Text = "DELETE ID"
        Me.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'txt_guestroomID
        '
        Me.txt_guestroomID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestroomID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestroomID.Location = New System.Drawing.Point(207, 332)
        Me.txt_guestroomID.Name = "txt_guestroomID"
        Me.txt_guestroomID.ReadOnly = True
        Me.txt_guestroomID.Size = New System.Drawing.Size(324, 24)
        Me.txt_guestroomID.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Guest Room ID:"
        '
        'txt_guestID
        '
        Me.txt_guestID.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_guestID.Location = New System.Drawing.Point(207, 246)
        Me.txt_guestID.Name = "txt_guestID"
        Me.txt_guestID.ReadOnly = True
        Me.txt_guestID.Size = New System.Drawing.Size(324, 24)
        Me.txt_guestID.TabIndex = 2
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
        Me.btn_clear.Location = New System.Drawing.Point(441, 677)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(126, 35)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "REMOVE ALL"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(239, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID INFORMATION"
        '
        'LBL_GUESTID
        '
        Me.LBL_GUESTID.AutoSize = True
        Me.LBL_GUESTID.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUESTID.ForeColor = System.Drawing.Color.Black
        Me.LBL_GUESTID.Location = New System.Drawing.Point(22, 246)
        Me.LBL_GUESTID.Name = "LBL_GUESTID"
        Me.LBL_GUESTID.Size = New System.Drawing.Size(97, 24)
        Me.LBL_GUESTID.TabIndex = 5
        Me.LBL_GUESTID.Text = "Guest ID:"
        '
        'ID_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 944)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ID_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID_FORM"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_AllID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_paymentid As TextBox
    Friend WithEvents DGV_AllID As DataGridView
    Friend WithEvents txt_AllID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents txt_guestroomID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_guestID As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_GUESTID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents BTN_GEN As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_BookingID As TextBox
End Class
