Imports System.Data.SqlClient

Public Class LG_FORM
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public rd As SqlDataReader
    Dim ms As String
    Sub openconnect()
        con = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        con.Open()
    End Sub

    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click
        openconnect()
        Try
            cmd = New SqlCommand("select * from Employee where Uname ='" & txt_uname.Text & "' and Password ='" & txt_pass.Text & "' ", con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim tb As DataTable = New DataTable()
            da.Fill(tb)
            If (tb.Rows.Count > 0) And (tb.Rows(0)(7) = "No") Then
                ms = MessageBox.Show("LOGIN COMPLETE!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim e_homepage As New emp_homepage
                e_homepage.Show()
                Me.Hide()
                txt_uname.Text = ""
                txt_pass.Text = ""

            ElseIf (tb.Rows.Count > 0) And (tb.Rows(0)(7) = "Yes") Then
                ms = MessageBox.Show("LOGIN COMPLETE!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim a_homepage As New Admin_Homepage
                a_homepage.Show()
                Me.Hide()
                txt_uname.Text = ""
                txt_pass.Text = ""
            ElseIf txt_uname.Text.Length = 0 And txt_pass.Text.Length = 0 Then
                ms = MessageBox.Show("PLEASE INPUT SOME DETAILS", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_uname.Text = ""
                txt_pass.Text = ""
            ElseIf txt_uname.Text.Length >= 1 And txt_pass.Text.Length = 0 Then
                ms = MessageBox.Show("PLEASE ENTER SOME PASSWORD", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_uname.Text = ""
                txt_pass.Text = ""
            ElseIf txt_uname.Text.Length = 0 And txt_pass.Text.Length >= 1 Then
                ms = MessageBox.Show("PLEASE ENTER SOME USERNAME", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_uname.Text = ""
                txt_pass.Text = ""
            Else
                ms = MessageBox.Show("WRONG USERNAME OR PASSWORD!!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_uname.Text = ""
                txt_pass.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_register_Click_1(sender As Object, e As EventArgs)
        employee_registration.Show()
        Me.Hide()
    End Sub

    Private Sub seepass_cb_CheckedChanged(sender As Object, e As EventArgs) Handles seepass_cb.CheckedChanged
        If seepass_cb.Checked Then
            txt_pass.UseSystemPasswordChar = False
            seepass_cb.Image = My.Resources.showpass
        Else
            txt_pass.UseSystemPasswordChar = True
            seepass_cb.Image = My.Resources.hidden

        End If
    End Sub

    Private Sub lbl_reg_Click(sender As Object, e As EventArgs) Handles lbl_reg.Click
        employee_registration.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit the application?", "HOMEPAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub lbl_forgot_Click(sender As Object, e As EventArgs) Handles lbl_forgot.Click
        Me.Hide()
        ForgetPass.Show()
    End Sub
End Class