Imports System.Data.SqlClient

Public Class Room_Reservation
    Dim ID As String = GetRandom(100, 9999).ToString()
    Dim ms As String
    Dim cmd1 As SqlCommand
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_RoomID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_roomnum.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomtype.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomcap.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomstat.Text) OrElse
       String.IsNullOrWhiteSpace(txt_guestID.Text) Then
            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Private Function ValidateInputsUpdate() As Boolean
        If String.IsNullOrWhiteSpace(txt_RoomID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_roomnum.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomtype.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomcap.Text) OrElse
       String.IsNullOrWhiteSpace(cb_roomstat.Text) OrElse
       String.IsNullOrWhiteSpace(txt_guestroomID.Text) Then

            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Sub RESET()
        txt_guestroomID.Text = ""
        txt_RoomID.Text = ""
        txt_roomnum.Text = ""
        cb_roomstat.Text = ""
        cb_roomtype.Text = ""
        cb_roomcap.Text = ""
        txt_guestID.Text = ""
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub


    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs)
        Try
            If ValidateInputs() Then
                cona.Open()

                Dim InsertRoomReservation As String = "IF NOT EXISTS (SELECT * FROM Hotel_Rooms WHERE RoomID = @d1) " & "INSERT INTO Hotel_Rooms(RoomID, RoomNum, RoomType, RoomCapacity, RoomStatus, GuestID) " & "VALUES (@d1,@d2, @d3,@d4,@d5, @d6)"
                Using cmd As New SqlCommand(InsertRoomReservation, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_RoomID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_roomnum.Text)
                    cmd.Parameters.AddWithValue("@d3", cb_roomtype.Text)
                    cmd.Parameters.AddWithValue("@d4", cb_roomcap.Text)
                    cmd.Parameters.AddWithValue("@d5", cb_roomstat.Text)
                    cmd.Parameters.AddWithValue("@d6", txt_guestID.Text)

                    If cmd.ExecuteNonQuery() = 1 Then

                        MessageBox.Show("Successfully created new room!", "Room Reservation Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetRoomReservationData()
                        RESET()
                    Else
                        MessageBox.Show("Room Number already existed before!", "Room Reservation Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_roomnum.Focus()
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



    Private Sub GetRoomReservationData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Hotel_Rooms"
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
    Private Sub DGV_RoomManagement_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_RoomManagement.MouseDoubleClick
        Try

            If DGV_RoomManagement.SelectedRows.Count > 0 Then

                Dim dr As DataGridViewRow = DGV_RoomManagement.SelectedRows(0)


                If dr.Cells(1).Value IsNot Nothing AndAlso dr.Cells(1).Value.ToString() = "Booked".ToLower Then
                    MessageBox.Show("The room that you selected is already booked!", "Room Reservation Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txt_guestroomID.Text = dr.Cells(0).Value.ToString()
                    txt_guestID.Text = dr.Cells(5).Value.ToString()
                End If
            Else
                ' Display a message if no row is selected
                MessageBox.Show("Please select a row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Display error message in case of an exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection if it is open
            If cona IsNot Nothing AndAlso cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_RoomID.Text) Then
                MessageBox.Show("Please select a room to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidateInputs() Then
                cona.Open()

                Dim updateBooking As String = "UPDATE ALL_ID SET GuestRoomID = @GuestRoomID WHERE GuestRoomID = @GuestRoomID"
                Using cmdBooking As New SqlCommand(updateBooking, cona)
                    cmdBooking.Parameters.AddWithValue("@GuestRoomID", txt_RoomID.Text)
                    cmdBooking.ExecuteNonQuery()
                End Using

                ' Update Hotel_Rooms_Management table
                Dim updateHotelManagement As String = "UPDATE Hotel_Rooms_Management SET RoomNum = @RoomNum, RoomStatus = @RoomStatus, RoomType = @RoomType, RoomCapacity = @RoomCapacity WHERE RoomID = @RoomID"
                Using cmdmanagement As New SqlCommand(updateHotelManagement, cona)
                    cmdmanagement.Parameters.AddWithValue("@RoomID", txt_RoomID.Text)
                    cmdmanagement.Parameters.AddWithValue("@RoomNum", txt_roomnum.Text)
                    cmdmanagement.Parameters.AddWithValue("@RoomStatus", cb_roomstat.Text)
                    cmdmanagement.Parameters.AddWithValue("@RoomType", cb_roomtype.Text)
                    cmdmanagement.Parameters.AddWithValue("@RoomCapacity", cb_roomcap.Text)
                    cmdmanagement.ExecuteNonQuery()
                End Using

                ' Update Hotel_Rooms table
                Dim updateRoomReservation As String = "UPDATE Hotel_Rooms SET RoomNum = @d2, RoomStatus = @d3, RoomType = @d4, RoomCapacity = @d5, GuestID = @d6, RoomID = @d7 WHERE GuestRoomID = @d1"
                Using cmd As New SqlCommand(updateRoomReservation, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_guestroomID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_roomnum.Text)
                    cmd.Parameters.AddWithValue("@d3", cb_roomstat.Text)
                    cmd.Parameters.AddWithValue("@d4", cb_roomtype.Text)
                    cmd.Parameters.AddWithValue("@d5", cb_roomcap.Text)
                    cmd.Parameters.AddWithValue("@d6", txt_guestID.Text)
                    cmd.Parameters.AddWithValue("@d7", txt_RoomID.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the room!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetRoomReservationData()
                        GetRoomManagement()
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

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RoomReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRoomReservationData()
        GetRoomManagement()
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Hotel_Rooms WHERE GuestRoomID LIKE @search OR RoomStatus LIKE @search OR RoomNum LIKE @search OR RoomType LIKE @search"
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

    Private Sub TXT_searchguest_TextChanged(sender As Object, e As EventArgs) Handles TXT_searchguest.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Hotel_Rooms_Management WHERE RoomID LIKE @search OR RoomStatus LIKE @search OR RoomNum LIKE @search OR RoomType LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & TXT_searchguest.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_guest.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub


    Private Sub dgv_guest_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_guest.MouseDoubleClick
        Try
            Dim dr As DataGridViewRow = dgv_guest.SelectedRows(0)

            If dgv_guest.SelectedRows.Count > 0 Then
                If dr.Cells(1).Value IsNot Nothing AndAlso dr.Cells(1).Value.ToString() = "Booked".ToLower Then
                    MessageBox.Show("The room that you selected is already booked!", "Room Reservation Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txt_RoomID.Text = dr.Cells(0).Value.ToString()
                    txt_roomnum.Text = dr.Cells(1).Value.ToString()
                    cb_roomstat.Text = dr.Cells(2).Value.ToString()
                    cb_roomtype.Text = dr.Cells(3).Value.ToString()
                    cb_roomcap.Text = dr.Cells(4).Value.ToString()
                End If
            Else
                ' Display a message if no row is selected
                MessageBox.Show("Please select a row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Display error message in case of an exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection if it is open
            If cona IsNot Nothing AndAlso cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub
    Private Sub GetRoomManagement()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Hotel_Rooms_Management"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_guest.DataSource = dt
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

    Private Sub btn_guestIDclear_Click(sender As Object, e As EventArgs)
        txt_guestID.Clear()
    End Sub

    Private Sub BTN_DELETE_Click_1(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_RoomID.Text) Then
                MessageBox.Show("Please select a room to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ms As String
            ms = MessageBox.Show("Are you sure you want to delete the booking information?", "Delete Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ms = vbYes Then
                cona.Open()

                Dim deleteRooms As String = "DELETE FROM Hotel_Rooms WHERE RoomID = @GuestRoomID"
                Using cmdBooking As New SqlCommand(deleteRooms, cona)
                    cmdBooking.Parameters.AddWithValue("@GuestRoomID", txt_guestroomID.Text)
                    cmdBooking.ExecuteNonQuery()
                End Using

                MessageBox.Show("Deleted successfully!", "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetRoomReservationData()
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
End Class