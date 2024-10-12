Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class ForgetPass
    Dim cone As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim count As Integer = 0
    Dim MS As String
    Private Const con As String = "Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False"

    Sub Disable()
        TXTCONFIRM.Enabled = False
        TXTNEW.Enabled = False
        TXTUSER.Enabled = False
        btn_SaveAccount.Enabled = False
        CheckBox1.Enabled = False
    End Sub

    Sub enable()
        TXTCONFIRM.Enabled = True
        TXTNEW.Enabled = True
        btn_SaveAccount.Enabled = True
        CheckBox1.Enabled = True
    End Sub


    Private Sub ForgetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNSRCH.Focus()
        Disable()
    End Sub


    Sub CLEAR()
        TXTNEW.Clear()
        TXTCONFIRM.Clear()
        TXTUSER.Clear()
    End Sub

    Private Sub btn_SaveAccount_Click(sender As Object, e As EventArgs) Handles btn_SaveAccount.Click
        Try
            If String.IsNullOrWhiteSpace(TXTUSER.Text) OrElse String.IsNullOrWhiteSpace(TXTNEW.Text) OrElse String.IsNullOrWhiteSpace(TXTCONFIRM.Text) Then
                MessageBox.Show("Please enter all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If TXTNEW.Text <> TXTCONFIRM.Text Then
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to change your password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                cone = New SqlConnection(con)
                cone.Open()
                Dim query As String = "UPDATE Employee SET Password = @Password WHERE Uname = @Uname"
                cmd = New SqlCommand(query, cone)
                cmd.Parameters.AddWithValue("@Password", TXTNEW.Text)
                cmd.Parameters.AddWithValue("@Uname", TXTUSER.Text)
                cmd.ExecuteNonQuery()
                cone.Close()

                MessageBox.Show("Your password has been updated successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                lblmatch.Visible = False
                LG_FORM.Show()
                Me.Hide()
            Else
                Me.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If cone IsNot Nothing AndAlso cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub
    Sub ClearFields()
        TXTNEW.Clear()
        TXTCONFIRM.Clear()
        TXTUSER.Clear()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TXTCONFIRM.UseSystemPasswordChar = False
            TXTNEW.UseSystemPasswordChar = False
        Else
            TXTCONFIRM.UseSystemPasswordChar = True
            TXTNEW.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BTNSRCH_Click(sender As Object, e As EventArgs) Handles BTNSRCH.Click
        Try
            Dim struser As String = InputBox("Enter USERNAME:")
            If String.IsNullOrWhiteSpace(struser) Then
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            cone = New SqlConnection(con)
            cone.Open()

            Dim query As String = "SELECT * FROM Employee WHERE Uname = @Uname"
            cmd = New SqlCommand(query, cone)
            cmd.Parameters.AddWithValue("@Uname", struser)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TXTUSER.Text = struser
                enable()
            Else
                MessageBox.Show("Wrong username.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Disable()
            End If

            dr.Close()
            cone.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Error: " & ex.Message)
            If cone IsNot Nothing AndAlso cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub TXTCONFIRM_TextChanged(sender As Object, e As EventArgs) Handles TXTCONFIRM.TextChanged
        If TXTNEW.Text = TXTCONFIRM.Text Then
            lblmatch.Text = "MATCHED"
            lblmatch.ForeColor = Color.CadetBlue
        Else
            lblmatch.Text = "WRONG"
            lblmatch.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim ms As String = MessageBox.Show("Do you want to go back to log-in form?", "FORGET PASSWORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ms = vbYes Then
            Me.Hide()
            LG_FORM.Show()
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ms As String = MessageBox.Show("Do you want to exit the account?", "FORGET PASSWORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ms = vbYes Then
            Me.Close()
        End If

    End Sub
End Class