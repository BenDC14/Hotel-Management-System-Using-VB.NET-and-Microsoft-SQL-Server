Imports System.Data.SqlClient

Public Class Booking_Form
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_BookingID.Text) OrElse
       String.IsNullOrWhiteSpace(dtp_checkin.Text) OrElse
       String.IsNullOrWhiteSpace(dtp_checkout.Text) OrElse
       String.IsNullOrWhiteSpace(cb_bookingstat.Text) OrElse
       String.IsNullOrWhiteSpace(txt_advance.Text) Then


            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function


    Sub RESET()
        txt_BookingID.Text = ""
        dtp_checkin.Text = ""
        dtp_checkout.Text = ""
        cb_bookingstat.Text = ""
        txt_advance.Text = ""
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub
    Private Sub Booking_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBookingData()
    End Sub


    Private Sub GetBookingData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Booking"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_Booking.DataSource = dt
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
            Dim inquery As String = "SELECT * FROM Booking WHERE BookingID LIKE @search OR BookingStatues LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_Booking.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub



    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_BookingID.Text) Then
                MessageBox.Show("Please select a booking to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidateInputs() Then
                cona.Open()
                Dim updateBooking As String = "UPDATE Booking SET CheckInDate=@CheckInDate, CheckOutDate=@CheckOutDate, BookingStatus=@BookingStatus, AdvancePayment=@AdvancePayment WHERE BookingID=@BookingID"
                Using cmd As New SqlCommand(updateBooking, cona)
                    cmd.Parameters.AddWithValue("@BookingID", txt_BookingID.Text)
                    cmd.Parameters.AddWithValue("@CheckInDate", dtp_checkin.Value)
                    cmd.Parameters.AddWithValue("@CheckOutDate", dtp_checkout.Value)
                    cmd.Parameters.AddWithValue("@BookingStatus", cb_bookingstat.Text)
                    cmd.Parameters.AddWithValue("@AdvancePayment", txt_advance.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the booking!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetBookingData()
                        RESET()
                    Else
                        MessageBox.Show("Failed to update booking.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub DGV_Booking_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_Booking.MouseDoubleClick
        Try
            If DGV_Booking.SelectedRows.Count > 0 Then
                Dim dr = DGV_Booking.SelectedRows(0)
                txt_BookingID.Text = dr.Cells(0).Value.ToString()


                If Not IsDBNull(dr.Cells(1).Value) Then
                    dtp_checkin.Value = Convert.ToDateTime(dr.Cells(1).Value)
                Else
                    dtp_checkin.Value = DateTime.Now
                End If


                If Not IsDBNull(dr.Cells(2).Value) Then
                    dtp_checkout.Value = Convert.ToDateTime(dr.Cells(2).Value)
                Else
                    dtp_checkout.Value = DateTime.Now
                End If

                cb_bookingstat.Text = dr.Cells(3).Value.ToString()
                txt_advance.Text = dr.Cells(4).Value.ToString()
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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


End Class