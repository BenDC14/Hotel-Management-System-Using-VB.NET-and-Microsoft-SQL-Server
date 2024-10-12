Imports System.Data.SqlClient

Public Class Room_Management_Admin
    Dim ID As String = GetRandom(100, 9999).ToString()
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_RoomNum.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomstat.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomtype.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomcap.Text) Then
            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function


    Sub RESET()
        txt_RoomID.Text = ""
        txt_RoomNum.Text = ""
        cb_roomstat.Text = ""
        cb_roomtype.Text = ""
        cb_roomcap.Text = ""
    End Sub



    Private Sub BTN_PRINT_Click(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
        prtpre_roommanagement.Document = prtdocu_roommanagement
        prtpre_roommanagement.WindowState = FormWindowState.Maximized
        prtpre_roommanagement.ShowDialog()
    End Sub
    Private mrow As Integer = 0
    Private newpage As Boolean = True
    Private Sub prtdocu_booking_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prtdocu_roommanagement.PrintPage
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
        Dim x As Integer = (pageWidth - DGV_RoomManagement.Width) / 2 ' Center the table horizontally on the page
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        ' Print the header row
        If newpage Then
            row = DGV_RoomManagement.Rows(mrow)
            x = (pageWidth - DGV_RoomManagement.Columns.Cast(Of DataGridViewColumn).Where(Function(c) c.Visible).Sum(Function(c) c.Width)) / 2
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    e.Graphics.DrawString(DGV_RoomManagement.Columns(cell.ColumnIndex).HeaderText, DGV_RoomManagement.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newpage = False

        ' Print the data rows
        For displayNow As Integer = mrow To DGV_RoomManagement.RowCount - 1
            row = DGV_RoomManagement.Rows(displayNow)
            x = (pageWidth - DGV_RoomManagement.Columns.Cast(Of DataGridViewColumn).Where(Function(c) c.Visible).Sum(Function(c) c.Width)) / 2
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(cell.FormattedValue.ToString(), DGV_RoomManagement.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        Next
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub
    Private Sub Room_Management_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRoomManagementData()
    End Sub
    Private Sub GetRoomManagementData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Hotel_Rooms_Management"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_RoomManagement.DataSource = dt
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
            cona.Open()
            Dim inquery As String = "SELECT * FROM Hotel_Rooms_Management WHERE RoomID LIKE @search OR RoomStatus LIKE @search OR RoomNum LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_RoomManagement.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub DGV_RoomManagement_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_RoomManagement.MouseDoubleClick
        Try

            If DGV_RoomManagement.SelectedRows.Count > 0 Then

                Dim dr = DGV_RoomManagement.SelectedRows(0)
                txt_RoomID.Text = dr.Cells(0).Value.ToString
                txt_RoomNum.Text = dr.Cells(1).Value.ToString
                cb_roomstat.Text = dr.Cells(2).Value.ToString
                cb_roomtype.Text = dr.Cells(3).Value.ToString
                cb_roomcap.Text = dr.Cells(4).Value.ToString

            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cona.Close()
        End Try
    End Sub
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Try
            If ValidateInputs() Then
                cona.Open()

                ' Insert into Hotel_Rooms_Management
                Dim insertHotelRoomsManagement As String = "IF NOT EXISTS (SELECT * FROM Hotel_Rooms_Management WHERE RoomID = @RoomID) " &
                                                   "INSERT INTO Hotel_Rooms_Management(RoomID, RoomNum, RoomStatus, RoomType, RoomCapacity) " &
                                                   "VALUES (@RoomID, @RoomNum, @RoomStatus, @RoomType, @RoomCapacity)"
                Using cmd As New SqlCommand(insertHotelRoomsManagement, cona)
                    cmd.Parameters.AddWithValue("@RoomID", txt_RoomID.Text)
                    cmd.Parameters.AddWithValue("@RoomNum", txt_RoomNum.Text)
                    cmd.Parameters.AddWithValue("@RoomStatus", cb_roomstat.Text)
                    cmd.Parameters.AddWithValue("@RoomType", cb_roomtype.Text)
                    cmd.Parameters.AddWithValue("@RoomCapacity", cb_roomcap.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show("Successfully created new room!", "Room Management Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetRoomManagementData()
                        RESET()
                    Else
                        MessageBox.Show("Room Number already existed before in Hotel_Rooms_Management!", "Room Management Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_RoomNum.Focus()
                    End If
                End Using
            Else
                MessageBox.Show("Failed to create new room status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_RoomNum.Text) Then
                MessageBox.Show("Please select a room to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidateInputs() Then
                cona.Open()
                Dim updateRoomManagement As String = "UPDATE Hotel_Rooms_Management SET RoomNum = @d2, RoomStatus=@d3, RoomType=@d4, RoomCapacity=@d5 WHERE RoomID=@d1"
                Using cmd As New SqlCommand(updateRoomManagement, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_RoomID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_RoomNum.Text)
                    cmd.Parameters.AddWithValue("@d3", cb_roomstat.Text)
                    cmd.Parameters.AddWithValue("@d4", cb_roomtype.Text)
                    cmd.Parameters.AddWithValue("@d5", cb_roomcap.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the room!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetRoomManagementData()
                        RESET()
                        cona.Close()
                    Else
                        MessageBox.Show("Failed to update room.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_RoomNum.Text) Then
                MessageBox.Show("Please select a booking to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ms As String
            ms = MessageBox.Show("Are you sure you want to delete the booking information?", "Delete Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ms = vbYes Then
                cona.Open()

                Dim deleteRoomManagement As String = "DELETE FROM Hotel_Rooms_Management WHERE RoomID= @RoomID"
                Using cmdBooking As New SqlCommand(deleteRoomManagement, cona)
                    cmdBooking.Parameters.AddWithValue("@RoomID", txt_RoomID.Text)
                    cmdBooking.ExecuteNonQuery()
                End Using


                Dim deleteRoom As String = "DELETE FROM Hotel_Rooms WHERE RoomID = @RoomID"
                Using cmdRoom As New SqlCommand(deleteRoom, cona)
                    cmdRoom.Parameters.AddWithValue("@RoomID", txt_RoomID.Text)
                    cmdRoom.Parameters.AddWithValue("@RoomNum", txt_RoomNum.Text)
                    cmdRoom.Parameters.AddWithValue("@RoomStatus", cb_roomstat.Text)
                    cmdRoom.Parameters.AddWithValue("@RoomType", cb_roomtype.Text)
                    cmdRoom.Parameters.AddWithValue("@RoomCap", cb_roomcap.Text)
                    cmdRoom.ExecuteNonQuery()
                End Using

                MessageBox.Show("Deleted successfully!", "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetRoomManagementData()
                RESET()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_GEN_Click(sender As Object, e As EventArgs) Handles BTN_GEN.Click
        txt_RoomID.Text = "ROOM" & ID
    End Sub


End Class