Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class employee_registration
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public cmd1 As SqlCommand
    Public rd As SqlDataReader
    Dim ms As String
    Dim ID As String = GetRandom(1, 9999).ToString()

    Sub openconnect()
        con = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        con.Open()
    End Sub

    Private Sub btn_SaveAccount_Click(sender As Object, e As EventArgs) Handles btn_SaveAccount.Click
        Try
            Dim email As String = txt_Email.Text
            Dim pass As String = txt_pass.Text
            Dim num As String = txt_number.Text

            If txt_empID.Text <> "" AndAlso txt_fname.Text <> "" AndAlso txt_lname.Text <> "" AndAlso txt_pass.Text <> "" AndAlso txt_uname.Text <> "" AndAlso txt_number.Text <> "" AndAlso txt_Email.Text <> "" AndAlso CB_Admin.Text <> "" Then
                Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|GMAIL\.COM)$"
                If Regex.IsMatch(email, emailPattern) Then
                    Dim passwordPattern As String = "^(?=.*[a-zA-Z])(?=.*\d).{8,}$"
                    If Regex.IsMatch(pass, passwordPattern) Then
                        If num.Length = 11 AndAlso IsNumeric(num) Then
                            Dim isAdmin As Boolean = CB_Admin.Text.ToLower() = "yes"
                            openconnect()

                            ' Insert Employee
                            Dim insertEmployee As String = "IF NOT EXISTS (SELECT * FROM Employee WHERE EmployeeID = @d1) " &
                                                       "INSERT INTO Employee(EmployeeID, FirstName, LastName, PhoneNumber, Email, Uname, Password, IsAdmin) " &
                                                       "VALUES (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)"
                            Using cmd As New SqlCommand(insertEmployee, con)
                                cmd.Parameters.AddWithValue("@d1", txt_empID.Text)
                                cmd.Parameters.AddWithValue("@d2", txt_fname.Text)
                                cmd.Parameters.AddWithValue("@d3", txt_lname.Text)
                                cmd.Parameters.AddWithValue("@d4", txt_number.Text)
                                cmd.Parameters.AddWithValue("@d5", txt_Email.Text)
                                cmd.Parameters.AddWithValue("@d6", txt_uname.Text)
                                cmd.Parameters.AddWithValue("@d7", txt_pass.Text)
                                cmd.Parameters.AddWithValue("@d8", CB_Admin.Text)

                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                                If rowsAffected = 1 Then
                                    If isAdmin Then
                                        ' Insert Admin
                                        Dim insertAdmin As String = "IF NOT EXISTS (SELECT * FROM Admin WHERE AdminID = @AdminID) " &
                                                                "INSERT INTO Admin(AdminID, EmployeeID) VALUES (@AdminID, @EmployeeID)"
                                        Using cmdAdmin As New SqlCommand(insertAdmin, con)
                                            cmdAdmin.Parameters.AddWithValue("@AdminID", txt_adminID.Text)
                                            cmdAdmin.Parameters.AddWithValue("@EmployeeID", txt_empID.Text)

                                            Dim adminRowsAffected As Integer = cmdAdmin.ExecuteNonQuery()

                                            If adminRowsAffected = 1 Then
                                                ms = MessageBox.Show("SUCCESSFULLY CREATED NEW ADMIN ACCOUNT!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                RESET()
                                                LG_FORM.Show()
                                                Me.Hide()
                                            Else
                                                MessageBox.Show("ADMIN ID ALREADY EXISTED BEFORE!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txt_adminID.Focus()
                                            End If
                                        End Using
                                    Else
                                        ms = MessageBox.Show("SUCCESSFULLY CREATED NEW EMPLOYEE ACCOUNT!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        RESET()
                                        LG_FORM.Show()
                                        Me.Hide()
                                    End If
                                Else
                                    MessageBox.Show("EMPLOYEE ID ALREADY EXISTED BEFORE!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txt_empID.Focus()
                                End If
                            End Using
                        Else
                            MessageBox.Show("Phone number must be exactly 11 digits.", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txt_number.Focus()
                        End If
                    Else
                        MessageBox.Show("Password must contain at least 8 characters including letters and numbers.", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txt_pass.Focus()
                    End If
                Else
                    MessageBox.Show("Improper Email! Only @gmail.com, @yahoo.com, or @GMAIL.COM are allowed.", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_Email.Focus()
                End If
            Else
                ms = MessageBox.Show("PLEASE INPUT SOME DETAILS!!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Sub RESET()
        txt_empID.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        txt_pass.Text = ""
        txt_uname.Text = ""
        txt_Email.Text = ""
        txt_adminID.Text = ""
        txt_number.Text = ""
        CB_Admin.Text = ""


    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
        Dim ID As String = GetRandom(1, 9999).ToString()
    End Function
    Private Sub btn_generate1_Click(sender As Object, e As EventArgs) Handles btn_generate1.Click
        txt_adminID.Text = "ADMIN" & ID
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        txt_empID.Text = "EMP" & ID
    End Sub

    Private Sub employee_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_generate1.Visible = False
    End Sub



    Private Sub CB_Admin_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Admin.SelectedValueChanged
        Try
            If CB_Admin.SelectedIndex = 0 Then
                btn_generate1.Visible = True
                btn_generate1.Enabled = True
            Else
                btn_generate1.Visible = False
                btn_generate1.Enabled = False
                txt_adminID.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub seepass_cb_CheckedChanged(sender As Object, e As EventArgs) Handles seepass_cb.CheckedChanged
        Try
            If seepass_cb.Checked Then
                txt_pass.UseSystemPasswordChar = False
                seepass_cb.Image = My.Resources.showpass
            Else
                txt_pass.UseSystemPasswordChar = True
                seepass_cb.Image = My.Resources.hidden

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class