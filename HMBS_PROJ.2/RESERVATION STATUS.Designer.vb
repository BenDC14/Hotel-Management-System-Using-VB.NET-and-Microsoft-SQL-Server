<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESERVATION_STATUS
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ButtonGENERATE = New Button()
        ButtonSUBMIT = New Button()
        Label2 = New Label()
        TextBoxROOMSEARCH = New TextBox()
        LabelROOMSEARCH = New Label()
        DataGridViewROOMSTATUS = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        LabelLASTNAME = New Label()
        LabelFIRSTNAME = New Label()
        Label6 = New Label()
        TextBoxGURSTID = New TextBox()
        TextBoxFIRSTNUMBER = New TextBox()
        TextBoxROOMTYPE = New TextBox()
        ComboBoxROOMCAPACITY = New ComboBox()
        LabelGUESTID = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        LabelSTREETNUMBER = New Label()
        LabelSTREETNAME = New Label()
        LabelCITY = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        LabelMUNICIPALITY = New Label()
        TextBox5 = New TextBox()
        CType(DataGridViewROOMSTATUS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonGENERATE
        ' 
        ButtonGENERATE.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonGENERATE.Font = New Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonGENERATE.Location = New Point(405, 526)
        ButtonGENERATE.Name = "ButtonGENERATE"
        ButtonGENERATE.Size = New Size(130, 34)
        ButtonGENERATE.TabIndex = 26
        ButtonGENERATE.Text = "GENERATE"
        ButtonGENERATE.UseVisualStyleBackColor = True
        ' 
        ' ButtonSUBMIT
        ' 
        ButtonSUBMIT.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonSUBMIT.Font = New Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSUBMIT.Location = New Point(88, 526)
        ButtonSUBMIT.Name = "ButtonSUBMIT"
        ButtonSUBMIT.Size = New Size(130, 34)
        ButtonSUBMIT.TabIndex = 25
        ButtonSUBMIT.Text = "SUBMIT"
        ButtonSUBMIT.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(57, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(503, 57)
        Label2.TabIndex = 17
        Label2.Text = "GUEST INFORMATION"
        ' 
        ' TextBoxROOMSEARCH
        ' 
        TextBoxROOMSEARCH.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxROOMSEARCH.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxROOMSEARCH.Location = New Point(834, 28)
        TextBoxROOMSEARCH.Name = "TextBoxROOMSEARCH"
        TextBoxROOMSEARCH.Size = New Size(411, 32)
        TextBoxROOMSEARCH.TabIndex = 16
        ' 
        ' LabelROOMSEARCH
        ' 
        LabelROOMSEARCH.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelROOMSEARCH.AutoSize = True
        LabelROOMSEARCH.BackColor = Color.Transparent
        LabelROOMSEARCH.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelROOMSEARCH.Location = New Point(653, 31)
        LabelROOMSEARCH.Name = "LabelROOMSEARCH"
        LabelROOMSEARCH.Size = New Size(161, 25)
        LabelROOMSEARCH.TabIndex = 15
        LabelROOMSEARCH.Text = "ROOM SEARCH:"
        ' 
        ' DataGridViewROOMSTATUS
        ' 
        DataGridViewROOMSTATUS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewROOMSTATUS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewROOMSTATUS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewROOMSTATUS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewROOMSTATUS.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewROOMSTATUS.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewROOMSTATUS.Location = New Point(653, 89)
        DataGridViewROOMSTATUS.Name = "DataGridViewROOMSTATUS"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridViewROOMSTATUS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewROOMSTATUS.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewROOMSTATUS.Size = New Size(592, 519)
        DataGridViewROOMSTATUS.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "GuestID"
        Column1.Name = "Column1"
        Column1.Width = 99
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "FirstName"
        Column2.Name = "Column2"
        Column2.Width = 122
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "LastName"
        Column3.Name = "Column3"
        Column3.Width = 115
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "City"
        Column4.Name = "Column4"
        Column4.Width = 69
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Municipality"
        Column5.Name = "Column5"
        Column5.Width = 145
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "StreetName"
        Column6.Name = "Column6"
        Column6.Width = 135
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "ReservationStatus"
        Column7.Name = "Column7"
        Column7.Width = 199
        ' 
        ' LabelLASTNAME
        ' 
        LabelLASTNAME.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelLASTNAME.AutoSize = True
        LabelLASTNAME.BackColor = Color.Transparent
        LabelLASTNAME.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelLASTNAME.Location = New Point(57, 208)
        LabelLASTNAME.Name = "LabelLASTNAME"
        LabelLASTNAME.Size = New Size(127, 25)
        LabelLASTNAME.TabIndex = 18
        LabelLASTNAME.Text = "LAST NAME:"
        ' 
        ' LabelFIRSTNAME
        ' 
        LabelFIRSTNAME.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelFIRSTNAME.AutoSize = True
        LabelFIRSTNAME.BackColor = Color.Transparent
        LabelFIRSTNAME.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFIRSTNAME.Location = New Point(57, 170)
        LabelFIRSTNAME.Name = "LabelFIRSTNAME"
        LabelFIRSTNAME.Size = New Size(138, 25)
        LabelFIRSTNAME.TabIndex = 19
        LabelFIRSTNAME.Text = "FIRST NAME:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(57, 248)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 25)
        Label6.TabIndex = 20
        Label6.Text = "PHONE NUMBER:"
        ' 
        ' TextBoxGURSTID
        ' 
        TextBoxGURSTID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxGURSTID.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxGURSTID.Location = New Point(277, 131)
        TextBoxGURSTID.Name = "TextBoxGURSTID"
        TextBoxGURSTID.Size = New Size(258, 32)
        TextBoxGURSTID.TabIndex = 21
        ' 
        ' TextBoxFIRSTNUMBER
        ' 
        TextBoxFIRSTNUMBER.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxFIRSTNUMBER.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxFIRSTNUMBER.Location = New Point(277, 170)
        TextBoxFIRSTNUMBER.Name = "TextBoxFIRSTNUMBER"
        TextBoxFIRSTNUMBER.Size = New Size(258, 32)
        TextBoxFIRSTNUMBER.TabIndex = 22
        ' 
        ' TextBoxROOMTYPE
        ' 
        TextBoxROOMTYPE.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxROOMTYPE.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxROOMTYPE.Location = New Point(277, 208)
        TextBoxROOMTYPE.Name = "TextBoxROOMTYPE"
        TextBoxROOMTYPE.Size = New Size(258, 32)
        TextBoxROOMTYPE.TabIndex = 23
        ' 
        ' ComboBoxROOMCAPACITY
        ' 
        ComboBoxROOMCAPACITY.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBoxROOMCAPACITY.AutoCompleteCustomSource.AddRange(New String() {"---SELECT---", "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela"})
        ComboBoxROOMCAPACITY.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxROOMCAPACITY.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxROOMCAPACITY.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxROOMCAPACITY.FormattingEnabled = True
        ComboBoxROOMCAPACITY.Items.AddRange(New Object() {"---SELECT---", "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela"})
        ComboBoxROOMCAPACITY.Location = New Point(277, 456)
        ComboBoxROOMCAPACITY.Name = "ComboBoxROOMCAPACITY"
        ComboBoxROOMCAPACITY.Size = New Size(258, 33)
        ComboBoxROOMCAPACITY.TabIndex = 24
        ' 
        ' LabelGUESTID
        ' 
        LabelGUESTID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelGUESTID.AutoSize = True
        LabelGUESTID.BackColor = Color.Transparent
        LabelGUESTID.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelGUESTID.Location = New Point(57, 131)
        LabelGUESTID.Name = "LabelGUESTID"
        LabelGUESTID.Size = New Size(109, 25)
        LabelGUESTID.TabIndex = 27
        LabelGUESTID.Text = "GUEST ID:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(277, 248)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(258, 32)
        TextBox1.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 290)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 25)
        Label3.TabIndex = 29
        Label3.Text = "EMAIL:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(277, 290)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(258, 32)
        TextBox2.TabIndex = 30
        ' 
        ' LabelSTREETNUMBER
        ' 
        LabelSTREETNUMBER.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelSTREETNUMBER.AutoSize = True
        LabelSTREETNUMBER.BackColor = Color.Transparent
        LabelSTREETNUMBER.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSTREETNUMBER.Location = New Point(57, 335)
        LabelSTREETNUMBER.Name = "LabelSTREETNUMBER"
        LabelSTREETNUMBER.Size = New Size(184, 25)
        LabelSTREETNUMBER.TabIndex = 31
        LabelSTREETNUMBER.Text = "STREET NUMBER:"
        ' 
        ' LabelSTREETNAME
        ' 
        LabelSTREETNAME.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelSTREETNAME.AutoSize = True
        LabelSTREETNAME.BackColor = Color.Transparent
        LabelSTREETNAME.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSTREETNAME.Location = New Point(57, 373)
        LabelSTREETNAME.Name = "LabelSTREETNAME"
        LabelSTREETNAME.Size = New Size(154, 25)
        LabelSTREETNAME.TabIndex = 32
        LabelSTREETNAME.Text = "STREET NAME:"
        ' 
        ' LabelCITY
        ' 
        LabelCITY.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelCITY.AutoSize = True
        LabelCITY.BackColor = Color.Transparent
        LabelCITY.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCITY.Location = New Point(57, 416)
        LabelCITY.Name = "LabelCITY"
        LabelCITY.Size = New Size(64, 25)
        LabelCITY.TabIndex = 33
        LabelCITY.Text = "CITY:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(277, 328)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(258, 32)
        TextBox3.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(550, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 13)
        Label7.TabIndex = 35
        Label7.Text = "OPTIONAL"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(277, 373)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(258, 32)
        TextBox4.TabIndex = 36
        ' 
        ' LabelMUNICIPALITY
        ' 
        LabelMUNICIPALITY.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelMUNICIPALITY.AutoSize = True
        LabelMUNICIPALITY.BackColor = Color.Transparent
        LabelMUNICIPALITY.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMUNICIPALITY.Location = New Point(57, 456)
        LabelMUNICIPALITY.Name = "LabelMUNICIPALITY"
        LabelMUNICIPALITY.Size = New Size(161, 25)
        LabelMUNICIPALITY.TabIndex = 37
        LabelMUNICIPALITY.Text = "MUNICIPALITY:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(277, 413)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(258, 32)
        TextBox5.TabIndex = 38
        ' 
        ' RESERVATION_STATUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1302, 637)
        Controls.Add(TextBox5)
        Controls.Add(LabelMUNICIPALITY)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(LabelCITY)
        Controls.Add(LabelSTREETNAME)
        Controls.Add(LabelSTREETNUMBER)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(LabelGUESTID)
        Controls.Add(ButtonGENERATE)
        Controls.Add(ButtonSUBMIT)
        Controls.Add(ComboBoxROOMCAPACITY)
        Controls.Add(TextBoxROOMTYPE)
        Controls.Add(TextBoxFIRSTNUMBER)
        Controls.Add(TextBoxGURSTID)
        Controls.Add(Label6)
        Controls.Add(LabelFIRSTNAME)
        Controls.Add(LabelLASTNAME)
        Controls.Add(Label2)
        Controls.Add(TextBoxROOMSEARCH)
        Controls.Add(LabelROOMSEARCH)
        Controls.Add(DataGridViewROOMSTATUS)
        FormBorderStyle = FormBorderStyle.None
        Name = "RESERVATION_STATUS"
        RightToLeft = RightToLeft.No
        Text = "RESERVATION_STATUS"
        CType(DataGridViewROOMSTATUS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonGENERATE As Button
    Friend WithEvents ButtonSUBMIT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxROOMSEARCH As TextBox
    Friend WithEvents LabelROOMSEARCH As Label
    Friend WithEvents DataGridViewROOMSTATUS As DataGridView
    Friend WithEvents LabelLASTNAME As Label
    Friend WithEvents LabelFIRSTNAME As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxGURSTID As TextBox
    Friend WithEvents TextBoxFIRSTNUMBER As TextBox
    Friend WithEvents TextBoxROOMTYPE As TextBox
    Friend WithEvents ComboBoxROOMCAPACITY As ComboBox
    Friend WithEvents LabelGUESTID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelSTREETNUMBER As Label
    Friend WithEvents LabelSTREETNAME As Label
    Friend WithEvents LabelCITY As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LabelMUNICIPALITY As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
