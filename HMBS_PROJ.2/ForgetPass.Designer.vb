<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgetPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgetPass))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.lblmatch = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCONFIRM = New System.Windows.Forms.TextBox()
        Me.TXTNEW = New System.Windows.Forms.TextBox()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNSRCH = New System.Windows.Forms.Button()
        Me.tmrLock = New System.Windows.Forms.Timer(Me.components)
        Me.btn_SaveAccount = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.VerLabel)
        Me.Panel1.Controls.Add(Me.Button18)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 38)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'VerLabel
        '
        Me.VerLabel.AutoSize = True
        Me.VerLabel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerLabel.ForeColor = System.Drawing.Color.Black
        Me.VerLabel.Location = New System.Drawing.Point(81, 8)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(221, 28)
        Me.VerLabel.TabIndex = 51
        Me.VerLabel.Text = "FORGET PASSWORD"
        '
        'Button18
        '
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.Location = New System.Drawing.Point(437, 3)
        Me.Button18.Name = "Button18"
        Me.Button18.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button18.Size = New System.Drawing.Size(99, 32)
        Me.Button18.TabIndex = 50
        Me.Button18.Text = "LOG-IN"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.Location = New System.Drawing.Point(527, 3)
        Me.Button17.Name = "Button17"
        Me.Button17.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button17.Size = New System.Drawing.Size(94, 33)
        Me.Button17.TabIndex = 49
        Me.Button17.Text = "CLOSE"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button17.UseVisualStyleBackColor = True
        '
        'lblmatch
        '
        Me.lblmatch.AutoSize = True
        Me.lblmatch.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatch.Location = New System.Drawing.Point(554, 150)
        Me.lblmatch.Name = "lblmatch"
        Me.lblmatch.Size = New System.Drawing.Size(0, 14)
        Me.lblmatch.TabIndex = 38
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(243, 171)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 18)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "SHOW PASSWORD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 14)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "CONFIRM PASSWORD:"
        '
        'TXTCONFIRM
        '
        Me.TXTCONFIRM.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCONFIRM.Location = New System.Drawing.Point(243, 149)
        Me.TXTCONFIRM.Name = "TXTCONFIRM"
        Me.TXTCONFIRM.Size = New System.Drawing.Size(289, 22)
        Me.TXTCONFIRM.TabIndex = 34
        Me.TXTCONFIRM.UseSystemPasswordChar = True
        '
        'TXTNEW
        '
        Me.TXTNEW.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNEW.Location = New System.Drawing.Point(243, 113)
        Me.TXTNEW.Name = "TXTNEW"
        Me.TXTNEW.Size = New System.Drawing.Size(289, 22)
        Me.TXTNEW.TabIndex = 33
        Me.TXTNEW.UseSystemPasswordChar = True
        '
        'TXTUSER
        '
        Me.TXTUSER.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUSER.Location = New System.Drawing.Point(244, 80)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(289, 22)
        Me.TXTUSER.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NEW PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "USERNAME:"
        '
        'BTNSRCH
        '
        Me.BTNSRCH.FlatAppearance.BorderSize = 0
        Me.BTNSRCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSRCH.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSRCH.Image = CType(resources.GetObject("BTNSRCH.Image"), System.Drawing.Image)
        Me.BTNSRCH.Location = New System.Drawing.Point(539, 78)
        Me.BTNSRCH.Name = "BTNSRCH"
        Me.BTNSRCH.Size = New System.Drawing.Size(48, 29)
        Me.BTNSRCH.TabIndex = 29
        Me.BTNSRCH.UseVisualStyleBackColor = True
        '
        'btn_SaveAccount
        '
        Me.btn_SaveAccount.BackColor = System.Drawing.Color.Transparent
        Me.btn_SaveAccount.FlatAppearance.BorderSize = 0
        Me.btn_SaveAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_SaveAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_SaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SaveAccount.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveAccount.Image = CType(resources.GetObject("btn_SaveAccount.Image"), System.Drawing.Image)
        Me.btn_SaveAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SaveAccount.Location = New System.Drawing.Point(301, 203)
        Me.btn_SaveAccount.Name = "btn_SaveAccount"
        Me.btn_SaveAccount.Size = New System.Drawing.Size(138, 62)
        Me.btn_SaveAccount.TabIndex = 53
        Me.btn_SaveAccount.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACCOUNT"
        Me.btn_SaveAccount.UseVisualStyleBackColor = False
        '
        'ForgetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 289)
        Me.Controls.Add(Me.btn_SaveAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblmatch)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTCONFIRM)
        Me.Controls.Add(Me.TXTNEW)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSRCH)
        Me.Font = New System.Drawing.Font("Garamond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgetPass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VerLabel As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents lblmatch As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCONFIRM As TextBox
    Friend WithEvents TXTNEW As TextBox
    Friend WithEvents TXTUSER As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNSRCH As Button
    Friend WithEvents tmrLock As Timer
    Friend WithEvents btn_SaveAccount As Button
End Class
