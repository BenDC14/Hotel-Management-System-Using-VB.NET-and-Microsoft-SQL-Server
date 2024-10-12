Imports System.Data.SqlClient

Public Class ID_FORM
    Dim ID As String = GetRandom(100, 9999).ToString()
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
    Sub RESET()
        txt_AllID.Text = ""
        txt_BookingID.Text = ""
        txt_BookingID.Text = ""
        txt_guestID.Text = ""
        txt_paymentid.Text = ""
        txt_guestroomID.Text = ""
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub BTN_GEN_Click(sender As Object, e As EventArgs) Handles BTN_GEN.Click
        txt_AllID.Text = "ALLID" & ID
        txt_BookingID.Text = "BOOKING" & ID
        txt_guestID.Text = "GUEST" & ID
        txt_paymentid.Text = "PAYMENT" & ID
        txt_guestroomID.Text = "GUESTROOM" & ID
    End Sub
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_BookingID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_guestID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_paymentid.Text) OrElse
       String.IsNullOrWhiteSpace(txt_guestroomID.Text) Then
            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM ALL_ID WHERE ALL_ID LIKE @search OR GuestID LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_AllID.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub
    Private Sub GetALLIDData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM ALL_ID"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_AllID.DataSource = dt
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


    Private Sub DGV_AllID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_AllID.MouseDoubleClick
        Try
            If DGV_AllID.SelectedRows.Count > 0 Then
                Dim dr = DGV_AllID.SelectedRows(0)
                txt_AllID.Text = dr.Cells(0).Value.ToString()
                txt_guestID.Text = dr.Cells(1).Value.ToString()
                txt_guestroomID.Text = dr.Cells(2).Value.ToString()
                txt_paymentid.Text = dr.Cells(3).Value.ToString()
                txt_BookingID.Text = dr.Cells(4).Value.ToString()
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Try
            If ValidateInputs() Then
                cona.Open()

                Dim checkroomamenity As String = "IF NOT EXISTS (SELECT * FROM Room_Amenity WHERE GuestRoomID = @GuestRoomID) " &
                                   "INSERT INTO Room_Amenity(GuestRoomID) VALUES (@GuestRoomID)"
                Using cmdCheckGuest As New SqlCommand(checkroomamenity, cona)
                    cmdCheckGuest.Parameters.AddWithValue("@GuestRoomID", txt_guestID.Text)
                    cmdCheckGuest.ExecuteNonQuery()
                End Using
                ' Check and insert GuestID if it does not exist
                Dim checkGuest As String = "IF NOT EXISTS (SELECT * FROM Guest WHERE GuestID = @GuestID) " &
                                   "INSERT INTO Guest(GuestID) VALUES (@GuestID)"
                Using cmdCheckGuest As New SqlCommand(checkGuest, cona)
                    cmdCheckGuest.Parameters.AddWithValue("@GuestID", txt_guestID.Text)
                    cmdCheckGuest.ExecuteNonQuery()
                End Using

                ' Check and insert RoomID if it does not exist
                Dim checkRoom As String = "IF NOT EXISTS (SELECT * FROM Hotel_Rooms WHERE GuestRoomID = @GuestRoomID) " &
                                  "INSERT INTO Hotel_Rooms(GuestRoomID,GuestID) VALUES (@GuestRoomID,@GuestID)"
                Using cmdCheckRoom As New SqlCommand(checkRoom, cona)
                    cmdCheckRoom.Parameters.AddWithValue("@GuestRoomID", txt_guestroomID.Text)
                    cmdCheckRoom.Parameters.AddWithValue("@GuestID", txt_guestID.Text)
                    cmdCheckRoom.ExecuteNonQuery()
                End Using

                ' Check and insert PaymentID if it does not exist
                Dim checkPayment As String = "IF NOT EXISTS (SELECT * FROM Payment WHERE PaymentID = @PaymentID) " &
                                     "INSERT INTO Payment(PaymentID) VALUES (@PaymentID)"
                Using cmdCheckPayment As New SqlCommand(checkPayment, cona)
                    cmdCheckPayment.Parameters.AddWithValue("@PaymentID", txt_paymentid.Text)
                    cmdCheckPayment.ExecuteNonQuery()
                End Using


                Dim checkbooking As String = "IF NOT EXISTS (SELECT * FROM Booking WHERE BookingID = @BookingID) " &
                                     "INSERT INTO Booking(BookingID) VALUES (@BookingID)"
                Using cmdCheckAmenity As New SqlCommand(checkbooking, cona)
                    cmdCheckAmenity.Parameters.AddWithValue("@BookingID", txt_BookingID.Text)
                    cmdCheckAmenity.ExecuteNonQuery()
                End Using

                ' Insert booking
                Dim insertallid As String = "IF NOT EXISTS (SELECT * FROM ALL_ID WHERE All_ID = @All_ID) " &
                                      "INSERT INTO ALL_ID(All_ID, GuestID, GuestRoomID, PaymentID, BookingID) " &
                                      "VALUES (@All_ID, @GuestID, @GuestRoomID, @PaymentID,@BookingID)"
                Using cmdInsertallid As New SqlCommand(insertallid, cona)
                    cmdInsertallid.Parameters.AddWithValue("@All_ID", txt_AllID.Text)
                    cmdInsertallid.Parameters.AddWithValue("@GuestID", txt_guestID.Text)
                    cmdInsertallid.Parameters.AddWithValue("@GuestRoomID", txt_guestroomID.Text)
                    cmdInsertallid.Parameters.AddWithValue("@PaymentID", txt_paymentid.Text)
                    cmdInsertallid.Parameters.AddWithValue("@BookingID", txt_BookingID.Text)
                    Dim rowsAffected As Integer = cmdInsertallid.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show("Successfully created new ID!", "Booking Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetALLIDData()
                        Reset()
                    Else
                        MessageBox.Show("ID already existed before!", "Booking Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_BookingID.Focus()
                    End If
                End Using
            Else
                MessageBox.Show("Failed to create ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If Not String.IsNullOrWhiteSpace(txt_BookingID.Text) Then
                cona.Open()
                Dim transaction As SqlTransaction = cona.BeginTransaction()
                Dim ms As String
                ms = MessageBox.Show("Are you sure you want to delete the Guest Information?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If ms = vbYes Then
                    Try
                        ' Retrieve GuestID, RoomID, PaymentID, and AmenityID associated with the AllID
                        Dim selectALLID As String = "SELECT GuestID, AmenityID, GuestRoomID, PaymentID, BookingID FROM ALL_ID WHERE All_ID = @All_ID"
                        Dim guestID As String = String.Empty
                        Dim guestroomID As String = String.Empty
                        Dim paymentID As String = String.Empty
                        Dim amenityID As String = String.Empty
                        Dim bookingID As String = String.Empty

                        Using cmdSelectALLIDDetails As New SqlCommand(selectALLID, cona, transaction)
                            cmdSelectALLIDDetails.Parameters.AddWithValue("@All_ID", txt_AllID.Text)
                            Using reader As SqlDataReader = cmdSelectALLIDDetails.ExecuteReader()
                                If reader.Read() Then
                                    guestID = reader("GuestID").ToString()
                                    guestroomID = reader("GuestRoomID").ToString()
                                    paymentID = reader("PaymentID").ToString()
                                    amenityID = reader("AmenityID").ToString()
                                    bookingID = reader("BookingID").ToString()
                                End If
                            End Using
                        End Using

                        ' Delete Booking record
                        Dim deleteALLiD As String = "DELETE FROM ALL_ID WHERE All_ID = @All_ID"
                        Using cmdDeleteid As New SqlCommand(deleteALLiD, cona, transaction)
                            cmdDeleteid.Parameters.AddWithValue("@All_ID", txt_AllID.Text)
                            Dim rowsAffectedBooking As Integer = cmdDeleteid.ExecuteNonQuery()

                            If rowsAffectedBooking > 0 Then
                                ' Delete Guest record
                                Dim deleteGuest As String = "DELETE FROM Guest WHERE GuestID = @GuestID"
                                Using cmdDeleteGuest As New SqlCommand(deleteGuest, cona, transaction)
                                    cmdDeleteGuest.Parameters.AddWithValue("@GuestID", guestID)
                                    cmdDeleteGuest.ExecuteNonQuery()
                                End Using

                                ' Delete Room record
                                Dim deleteRoom As String = "DELETE FROM Hotel_Rooms WHERE GuestRoomID = @GuestRoomID"
                                Using cmdDeleteRoom As New SqlCommand(deleteRoom, cona, transaction)
                                    cmdDeleteRoom.Parameters.AddWithValue("@GuestRoomID", guestroomID)
                                    cmdDeleteRoom.ExecuteNonQuery()
                                End Using

                                ' Delete Payment record
                                Dim deletePayment As String = "DELETE FROM Payment WHERE PaymentID = @PaymentID"
                                Using cmdDeletePayment As New SqlCommand(deletePayment, cona, transaction)
                                    cmdDeletePayment.Parameters.AddWithValue("@PaymentID", paymentID)
                                    cmdDeletePayment.ExecuteNonQuery()
                                End Using

                                ' Delete Amenity record
                                Dim deleteAmenity As String = "DELETE FROM Amenity WHERE AmenityID = @AmenityID"
                                Using cmdDeleteAmenity As New SqlCommand(deleteAmenity, cona, transaction)
                                    cmdDeleteAmenity.Parameters.AddWithValue("@AmenityID", amenityID)
                                    cmdDeleteAmenity.ExecuteNonQuery()
                                End Using

                                Dim deleteBooking As String = "DELETE FROM Booking WHERE BookingID = @BookingID"
                                Using cmdDeleteBooking As New SqlCommand(deleteBooking, cona, transaction)
                                    cmdDeleteBooking.Parameters.AddWithValue("@BookingID", txt_BookingID.Text)
                                    cmdDeleteBooking.ExecuteNonQuery()
                                End Using

                                ' Commit the transaction
                                transaction.Commit()
                                MessageBox.Show("Successfully deleted ID and related records!", "Booking Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GetALLIDData()
                                Reset()
                            Else
                                MessageBox.Show("Failed to delete ID. ID may not exist or it is already deleted.", "Booking Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txt_BookingID.Focus()
                            End If
                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error deleting ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    Reset()
                End If

            Else
                MessageBox.Show("Please select a ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub ID_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetALLIDData()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub
End Class