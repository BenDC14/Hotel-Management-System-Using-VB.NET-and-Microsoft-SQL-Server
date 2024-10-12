Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.Policy
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Guest_Form_Admin
    Private cityMunicipalities As New Dictionary(Of String, List(Of String)) From {
        {"Cavite", New List(Of String) From {"Bacoor", "Carmona", "Dasmariñas", "Gen. Mariano Alvarez", "Gen. Trias", "Imus", "Kawit", "Noveleta", "Rosario", "Silang", "Tanza"}},
        {"Rizal", New List(Of String) From {"Angono", "Binangonan", "Cainta", "Cardona", "Morong", "Pililla", "Rodriguez", "San Mateo", "Tanay", "Taytay", "Teresa"}},
        {"Laguna", New List(Of String) From {"Biñan", "Cabuyao", "Calamba", "San Pedro", "Santa Rosa"}},
        {"Bulacan", New List(Of String) From {"Balagtas", "Bocaue", "Bulakan", "Calumpit", "Guiguinto", "Hagonoy", "Marilao", "Meycauayan", "Obando", "Pandi", "Plaridel", "Pulilan", "San Ildefonso", "San Miguel", "San Rafael", "Santa Maria"}},
        {"Caloocan", New List(Of String) From {"Caloocan"}},
        {"Las Piñas", New List(Of String) From {"Las Piñas"}},
        {"Makati", New List(Of String) From {"Makati"}},
        {"Malabon", New List(Of String) From {"Malabon"}},
        {"Mandaluyong", New List(Of String) From {"Mandaluyong"}},
        {"Manila", New List(Of String) From {"Manila"}},
        {"Marikina", New List(Of String) From {"Marikina"}},
        {"Muntinlupa", New List(Of String) From {"Muntinlupa"}},
        {"Navotas", New List(Of String) From {"Navotas"}},
        {"Parañaque", New List(Of String) From {"Parañaque"}},
        {"Pasay", New List(Of String) From {"Pasay"}},
        {"Pasig", New List(Of String) From {"Pasig"}},
        {"Pateros", New List(Of String) From {"Pateros"}},
        {"Quezon City", New List(Of String) From {"Quezon City"}},
        {"San Juan", New List(Of String) From {"San Juan"}},
        {"Taguig", New List(Of String) From {"Taguig"}},
        {"Valenzuela", New List(Of String) From {"Valenzuela"}},
         {"Quezon", New List(Of String) From {"Agdangan", "Alabat", "Buenavista", "Catanauan", "Dolores", "General Luna", "General Nakar", "Guinayangan", "Infanta", "Jomalig", "Lopez", "Lucban", "Lucena City", "Macalelon", "Mauban", "Mulanay", "Padre Burgos", "Pagbilao", "Pitogo", "Plaridel", "Quezon", "Real", "Sariaya", "Tagkawayan", "Unisan"}}
    }
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
    Private Sub GetGuestData()
        Try
            If cona.State = ConnectionState.Closed Then
                cona.Open()
            End If
            Dim sql As String = "SELECT * FROM Guest"
            Using cmd As New SqlCommand(sql, cona)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_Guest.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RESET()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            If cona.State = ConnectionState.Closed Then
                cona.Open()
            End If
            Dim inquery = "SELECT * FROM Guest WHERE GuestID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")

                Using da As New SqlDataAdapter(cmd)
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            DGV_Guest.DataSource = dt
                        Else
                            DGV_Guest.DataSource = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cona IsNot Nothing AndAlso cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub Guest_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetGuestData()
    End Sub



    Private Sub DGV_Guest_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_Guest.MouseDoubleClick
        Try

            If DGV_Guest.SelectedRows.Count > 0 Then

                Dim dr = DGV_Guest.SelectedRows(0)
                txt_guestID.Text = dr.Cells(0).Value.ToString
                txt_fname.Text = dr.Cells(1).Value.ToString
                txt_lname.Text = dr.Cells(2).Value.ToString
                cb_city.Text = dr.Cells(3).Value.ToString
                cb_municipality.Text = dr.Cells(4).Value.ToString
                txt_streetname.Text = dr.Cells(5).Value.ToString
                txt_streetnum.Text = dr.Cells(6).Value.ToString
                txt_phone.Text = dr.Cells(7).Value.ToString
                txt_email.Text = dr.Cells(8).Value.ToString
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cona.Close()
        End Try
    End Sub
    Sub RESET()
        txt_guestID.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        txt_phone.Text = ""
        txt_email.Text = ""
        txt_streetname.Text = ""
        cb_municipality.Text = ""
        cb_city.Text = ""
        txt_streetnum.Text = ""
    End Sub




    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_guestID.Text) OrElse
           String.IsNullOrWhiteSpace(txt_fname.Text) OrElse
           String.IsNullOrWhiteSpace(txt_lname.Text) OrElse
           String.IsNullOrWhiteSpace(cb_city.Text) OrElse
           String.IsNullOrWhiteSpace(cb_municipality.Text) OrElse
           String.IsNullOrWhiteSpace(txt_streetname.Text) OrElse
           String.IsNullOrWhiteSpace(txt_streetnum.Text) OrElse
           String.IsNullOrWhiteSpace(txt_phone.Text) OrElse
           String.IsNullOrWhiteSpace(txt_email.Text) Then
            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Regex.IsMatch(txt_email.Text, "^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|GMAIL\.COM)$") Then
            MessageBox.Show("Invalid email format. Only @gmail.com, @yahoo.com, or @GMAIL.COM are allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If txt_phone.Text.Length <> 11 OrElse Not IsNumeric(txt_phone.Text) Then
            MessageBox.Show("Phone number must be exactly 11 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_guestID.Text) Then
                MessageBox.Show("Please select a guest to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If ValidateInputs() Then
                cona.Open()
                Dim updateGuest As String = "UPDATE Guest SET FirstName=@d2, LastName=@d3, City=@d4, Municipality=@d5, Street_Name=@d6, Street_Number=@d7, Phone_Number=@d8, Email=@d9 WHERE GuestID=@d1"
                Using cmd As New SqlCommand(updateGuest, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_guestID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_fname.Text)
                    cmd.Parameters.AddWithValue("@d3", txt_lname.Text)
                    cmd.Parameters.AddWithValue("@d4", cb_city.Text)
                    cmd.Parameters.AddWithValue("@d5", cb_municipality.Text)
                    cmd.Parameters.AddWithValue("@d6", txt_streetname.Text)
                    cmd.Parameters.AddWithValue("@d7", txt_streetnum.Text)
                    cmd.Parameters.AddWithValue("@d8", txt_phone.Text)
                    cmd.Parameters.AddWithValue("@d9", txt_email.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the guest account!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetGuestData()
                        RESET()
                    Else
                        MessageBox.Show("Failed to update guest account.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub
    Private Sub HOMEPAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(184, 194, 230)

        Me.TransparencyKey = BackColor
        Me.Show()
    End Sub
    Private Sub ShowFormInPanel(frm As Form, controls As Control.ControlCollection)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        controls.Clear()
        controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub BTN_PRINT_Click(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
        prtpre_guest.Document = prtdocu_guest
        prtpre_guest.WindowState = FormWindowState.Maximized
        prtpre_guest.ShowDialog()
    End Sub
    Private mrow As Integer = 0
    Private newpage As Boolean = True
    Private Sub prtdocu_booking_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prtdocu_guest.PrintPage
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        Dim font As New Font("Century Gothic", 20) ' Remove FontStyle.Regular
        Dim pageWidth As Integer = e.PageBounds.Width

        ' Draw the header text
        e.Graphics.DrawString("Booking Information", font, Brushes.Black, New Point(pageWidth / 2, 20), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = (pageWidth - DGV_Guest.Width) / 2 ' Center the table horizontally on the page
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        ' Print the header row
        If newpage Then
            row = DGV_Guest.Rows(mrow)
            x = (pageWidth - DGV_Guest.Columns.Cast(Of DataGridViewColumn).Where(Function(c) c.Visible).Sum(Function(c) c.Width)) / 2
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    e.Graphics.DrawString(DGV_Guest.Columns(cell.ColumnIndex).HeaderText, DGV_Guest.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newpage = False

        ' Print the data rows
        For displayNow As Integer = mrow To DGV_Guest.RowCount - 1
            row = DGV_Guest.Rows(displayNow)
            x = (pageWidth - DGV_Guest.Columns.Cast(Of DataGridViewColumn).Where(Function(c) c.Visible).Sum(Function(c) c.Width)) / 2
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(cell.FormattedValue.ToString(), DGV_Guest.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        Next
    End Sub

    Private Sub HOMEPAGE_ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(184, 194, 230)

        Me.TransparencyKey = BackColor
        Me.Show()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub
    Private Sub cb_city_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_city.SelectedIndexChanged
        Dim selectedcity As String = cb_city.SelectedItem.ToString()

        If cityMunicipalities.ContainsKey(selectedcity) Then
            cb_municipality.DataSource = cityMunicipalities(selectedcity)
        End If
        cb_municipality.Enabled = True
        cb_municipality.Visible = True
    End Sub
End Class