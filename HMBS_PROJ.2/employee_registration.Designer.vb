<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee_registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee_registration))
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
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.CB_Admin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_adminID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.seepass_cb = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_generate1 = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_SaveAccount = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname.Location = New System.Drawing.Point(0, 291)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(96, 19)
        Me.lbl_uname.TabIndex = 32
        Me.lbl_uname.Text = "USERNAME:"
        '
        'txt_uname
        '
        Me.txt_uname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.Location = New System.Drawing.Point(118, 286)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(575, 26)
        Me.txt_uname.TabIndex = 6
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(0, 331)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(96, 19)
        Me.lbl_pass.TabIndex = 29
        Me.lbl_pass.Text = "PASSWORD:"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.Location = New System.Drawing.Point(2, 161)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(98, 19)
        Me.lbl_lname.TabIndex = 28
        Me.lbl_lname.Text = "LAST NAME:"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(2, 79)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(115, 19)
        Me.lbl_ID.TabIndex = 26
        Me.lbl_ID.Text = "EMPLOYEE ID:"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.Location = New System.Drawing.Point(2, 118)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(105, 19)
        Me.lbl_fname.TabIndex = 27
        Me.lbl_fname.Text = "FIRST NAME:"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(118, 326)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(575, 26)
        Me.txt_pass.TabIndex = 7
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(118, 161)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(575, 26)
        Me.txt_lname.TabIndex = 3
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(118, 118)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(575, 26)
        Me.txt_fname.TabIndex = 2
        '
        'txt_empID
        '
        Me.txt_empID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empID.Location = New System.Drawing.Point(118, 75)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.ReadOnly = True
        Me.txt_empID.Size = New System.Drawing.Size(575, 26)
        Me.txt_empID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "EMAIL:"
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(118, 248)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(575, 26)
        Me.txt_Email.TabIndex = 5
        '
        'CB_Admin
        '
        Me.CB_Admin.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Admin.FormattingEnabled = True
        Me.CB_Admin.Items.AddRange(New Object() {"Yes", "No"})
        Me.CB_Admin.Location = New System.Drawing.Point(118, 370)
        Me.CB_Admin.Name = "CB_Admin"
        Me.CB_Admin.Size = New System.Drawing.Size(575, 27)
        Me.CB_Admin.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ADMIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "NUMBER:"
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.Location = New System.Drawing.Point(118, 200)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(575, 26)
        Me.txt_number.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "ADMIN ID:"
        '
        'txt_adminID
        '
        Me.txt_adminID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adminID.Location = New System.Drawing.Point(118, 415)
        Me.txt_adminID.Name = "txt_adminID"
        Me.txt_adminID.ReadOnly = True
        Me.txt_adminID.Size = New System.Drawing.Size(575, 26)
        Me.txt_adminID.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(390, 37)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "REGISTER NEW ACCOUNT"
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
        Me.seepass_cb.Location = New System.Drawing.Point(699, 322)
        Me.seepass_cb.Name = "seepass_cb"
        Me.seepass_cb.Size = New System.Drawing.Size(30, 30)
        Me.seepass_cb.TabIndex = 12
        Me.seepass_cb.Tag = ""
        Me.seepass_cb.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(158, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
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
        Me.btn_generate1.Location = New System.Drawing.Point(699, 412)
        Me.btn_generate1.Name = "btn_generate1"
        Me.btn_generate1.Size = New System.Drawing.Size(94, 30)
        Me.btn_generate1.TabIndex = 13
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
        Me.btn_generate.Location = New System.Drawing.Point(699, 71)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(94, 30)
        Me.btn_generate.TabIndex = 11
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
        Me.btn_SaveAccount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveAccount.Image = CType(resources.GetObject("btn_SaveAccount.Image"), System.Drawing.Image)
        Me.btn_SaveAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SaveAccount.Location = New System.Drawing.Point(263, 481)
        Me.btn_SaveAccount.Name = "btn_SaveAccount"
        Me.btn_SaveAccount.Size = New System.Drawing.Size(256, 58)
        Me.btn_SaveAccount.TabIndex = 10
        Me.btn_SaveAccount.Text = "SAVE ACCOUNT"
        Me.btn_SaveAccount.UseVisualStyleBackColor = False
        '
        'employee_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 558)
        Me.Controls.Add(Me.seepass_cb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_generate1)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_adminID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.CB_Admin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.lbl_uname)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.btn_SaveAccount)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.txt_empID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "employee_registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employee_registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents CB_Admin As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_number As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_adminID As TextBox
    Friend WithEvents btn_generate As Button
    Friend WithEvents btn_generate1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seepass_cb As CheckBox
End Class
