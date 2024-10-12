Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Accounts
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

            If ValidateInputs() Then
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
                                    GetAccountData()
                                Else
                                    MessageBox.Show("ADMIN ID ALREADY EXISTED BEFORE!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txt_adminID.Focus()
                                End If
                            End Using
                        Else
                            ms = MessageBox.Show("SUCCESSFULLY CREATED NEW EMPLOYEE ACCOUNT!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            RESET()

                        End If
                    Else
                        MessageBox.Show("EMPLOYEE ID ALREADY EXISTED BEFORE!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_empID.Focus()
                    End If
                End Using
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
    Private Function ValidateInputs() As Boolean
        ' Validate if all fields are filled
        If String.IsNullOrWhiteSpace(txt_empID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_fname.Text) OrElse
       String.IsNullOrWhiteSpace(txt_lname.Text) OrElse
       String.IsNullOrWhiteSpace(txt_pass.Text) OrElse
       String.IsNullOrWhiteSpace(txt_uname.Text) OrElse
       String.IsNullOrWhiteSpace(txt_number.Text) OrElse
       String.IsNullOrWhiteSpace(txt_Email.Text) OrElse
       String.IsNullOrWhiteSpace(CB_Admin.Text) Then
            MessageBox.Show("Please input all details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate email format
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|GMAIL\.COM)$"
        If Not Regex.IsMatch(txt_Email.Text, emailPattern) Then
            MessageBox.Show("Improper Email! Only @gmail.com, @yahoo.com, or @GMAIL.COM are allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Email.Focus()
            Return False
        End If

        ' Validate password strength
        Dim passwordPattern As String = "^(?=.*[a-zA-Z])(?=.*\d).{8,}$"
        If Not Regex.IsMatch(txt_pass.Text, passwordPattern) Then
            MessageBox.Show("Password must contain at least 8 characters including letters and numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_pass.Focus()
            Return False
        End If

        ' Validate phone number format
        If txt_number.Text.Length <> 11 OrElse Not IsNumeric(txt_number.Text) Then
            MessageBox.Show("Phone number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_number.Focus()
            Return False
        End If

        Return True
    End Function

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

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_generate1.Visible = False
        GetAccountData()
        txt_pass.UseSystemPasswordChar = True
    End Sub



    Private Sub DGV_AllID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_ACOOUNTS.MouseDoubleClick
        Try
            If DGV_ACOOUNTS.SelectedRows.Count > 0 Then
                Dim dr = DGV_ACOOUNTS.SelectedRows(0)
                txt_empID.Text = dr.Cells(0).Value.ToString()
                txt_fname.Text = dr.Cells(1).Value.ToString()
                txt_lname.Text = dr.Cells(2).Value.ToString()
                txt_number.Text = dr.Cells(3).Value.ToString()
                txt_Email.Text = dr.Cells(4).Value.ToString()
                txt_uname.Text = dr.Cells(5).Value.ToString()
                txt_pass.Text = dr.Cells(6).Value.ToString()
                CB_Admin.Text = dr.Cells(7).Value.ToString()
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GetAccountData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Employee"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_ACOOUNTS.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving booking data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            con.Open()
            Dim inquery As String = "SELECT * FROM Employee WHERE EmployeeID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search"
            Using cmd As New SqlCommand(inquery, con)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_ACOOUNTS.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            Dim isAdmin As Boolean = CB_Admin.Text.ToLower() = "yes"
            If String.IsNullOrWhiteSpace(txt_empID.Text) Then
                MessageBox.Show("Please select a employee to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            openconnect()
            Dim updateGuest As String = "UPDATE Employee SET FirstName=@d2, LastName=@d3, PhoneNumber=@d4, Email=@d5, Uname=@d6, Password=@d7, IsAdmin=@d8 WHERE EmployeeID=@d1"
            Using cmd As New SqlCommand(updateGuest, con)
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
                    ms = MessageBox.Show("SUCCESSFULLY CREATED NEW EMPLOYEE ACCOUNT!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RESET()
                    GetAccountData()
                Else
                    MessageBox.Show("EMPLOYEE ID ALREADY EXISTED BEFORE!", "REGISTRATION FORM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_empID.Focus()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_empID.Text) Then
                MessageBox.Show("Please select the Employee ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim empID As String = txt_empID.Text
            Dim ms As String = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ms = vbYes Then
                openconnect()

                Dim deleteAdmin As String = "DELETE FROM Admin WHERE EmployeeID = @EmployeeID"
                Using cmdAdmin As New SqlCommand(deleteAdmin, con)
                    cmdAdmin.Parameters.AddWithValue("@EmployeeID", empID)
                    cmdAdmin.ExecuteNonQuery()
                End Using

                Dim deleteEmployee As String = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID"
                Using cmd As New SqlCommand(deleteEmployee, con)
                    cmd.Parameters.AddWithValue("@EmployeeID", empID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show("Successfully deleted the employee!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RESET()
                        GetAccountData()
                    Else
                        MessageBox.Show("Employee ID does not exist!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub

    Private Sub CB_Admin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Admin.SelectedIndexChanged
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


End Class