Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Payment_Form
    Dim cmd As SqlCommand
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
    Dim ADDITIONALCHARGES, SUBTOTAL, TAX, OVERALLTOTAL As Decimal
    Dim CHANGE As Decimal
    Dim CASH As Decimal
    Dim SINGLE_ROOM As Integer = 5000
    Dim TWO_SINGLE_BED_ROOM As Integer = 7000
    Dim DELUXE_ROOM As Integer = 10000
    Dim JUNIOR_SUITE As Integer = 15000
    Dim EXECUTIVE_SUITE As Integer = 20000
    Dim PRESIDENTIAL_SUITE As Integer = 25000
    Const TAX_RATE = 0.02
    Dim CHARGES As Decimal

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM ALL_ID WHERE All_ID LIKE @search OR GuestID LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_roomamenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub GetALLIDData()
        Try
            cona.Open()
            Dim sql As String = "SELECT * FROM ALL_ID"
            Using cmd As New SqlCommand(sql, cona)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        DGV_AllID.DataSource = dt
                    Else
                        MessageBox.Show("No records found in ALL_ID table.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub DGV_AllID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_AllID.MouseDoubleClick
        Try
            If DGV_AllID.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DGV_AllID.SelectedRows(0)
                Dim allID As String = selectedRow.Cells("All_ID").Value.ToString()
                MessageBox.Show("Selected All_ID: " & allID)

                Using con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
                    con.Open()

                    ' Retrieve Guest information
                    Dim queryGuest As String = "SELECT FirstName, LastName FROM Guest WHERE GuestID = (SELECT GuestID FROM ALL_ID WHERE All_ID = @All_ID)"
                    Using cmdGuest As New SqlCommand(queryGuest, con)
                        cmdGuest.Parameters.AddWithValue("@All_ID", allID)
                        Using reader As SqlDataReader = cmdGuest.ExecuteReader()
                            If reader.Read() Then
                                txt_fullname.Text = If(IsDBNull(reader("FirstName")), String.Empty, reader("FirstName").ToString()) & " " &
                                                If(IsDBNull(reader("LastName")), String.Empty, reader("LastName").ToString())
                            Else
                                MessageBox.Show("No guest found for the selected All_ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End Using

                    ' Retrieve Booking information
                    Dim queryBooking As String = "SELECT CheckInDate, CheckOutDate, AdvancePayment FROM Booking WHERE BookingID = (SELECT BookingID FROM ALL_ID WHERE All_ID = @All_ID)"
                    Using cmdBooking As New SqlCommand(queryBooking, con)
                        cmdBooking.Parameters.AddWithValue("@All_ID", allID)
                        Using reader As SqlDataReader = cmdBooking.ExecuteReader()
                            If reader.Read() Then
                                If Not IsDBNull(reader("CheckInDate")) AndAlso Not IsDBNull(reader("CheckOutDate")) Then
                                    Dim checkInDate As DateTime = Convert.ToDateTime(reader("CheckInDate"))
                                    Dim checkOutDate As DateTime = Convert.ToDateTime(reader("CheckOutDate"))
                                    Dim totalDays As Integer = (checkOutDate - checkInDate).Days
                                    txt_days.Text = totalDays.ToString()
                                End If
                                txt_advance.Text = If(IsDBNull(reader("AdvancePayment")), String.Empty, reader("AdvancePayment").ToString())
                            Else
                                MessageBox.Show("No booking found for the selected All_ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End Using

                    ' Retrieve GuestRoom information
                    Dim queryGuestRoom As String = "SELECT RoomNum, RoomStatus, RoomType FROM Hotel_Rooms WHERE GuestRoomID = (SELECT GuestRoomID FROM ALL_ID WHERE All_ID = @All_ID)"
                    Using cmdGuestRoom As New SqlCommand(queryGuestRoom, con)
                        cmdGuestRoom.Parameters.AddWithValue("@All_ID", allID)
                        Using reader As SqlDataReader = cmdGuestRoom.ExecuteReader()
                            If reader.Read() Then
                                txt_RoomNum.Text = If(IsDBNull(reader("RoomNum")), String.Empty, reader("RoomNum").ToString())
                                cb_roomstat.Text = If(IsDBNull(reader("RoomStatus")), String.Empty, reader("RoomStatus").ToString())
                                txt_roomtype.Text = If(IsDBNull(reader("RoomType")), String.Empty, reader("RoomType").ToString())

                                ' Call ROOMCHARGE after setting room type and number of days
                                ROOMCHARGE()
                            Else
                                MessageBox.Show("No guest room found for the selected All_ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End Using
                End Using
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub GetPaymentData()
        Try
            ' Open connection only if it's not already open
            If cona.State <> ConnectionState.Open Then
                cona.Open()
            End If

            Dim sql As String = "SELECT * FROM Payment"
            Using cmd As New SqlCommand(sql, cona)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_payment.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub

    Private Sub dgv_payment_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_payment.MouseDoubleClick
        Try
            If dgv_payment.SelectedRows.Count > 0 Then
                Dim dr = dgv_payment.SelectedRows(0)
                txt_paymentID.Text = dr.Cells(0).Value.ToString()
                cb_paymentmethod.Text = dr.Cells(1).Value.ToString()
                txt_ammount.Text = dr.Cells(2).Value.ToString()
                If Not IsDBNull(dr.Cells(3).Value) Then
                    dtp_paymentdate.Value = Convert.ToDateTime(dr.Cells(3).Value)
                Else
                    dtp_paymentdate.Value = DateTime.Now
                End If
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPaymentData()
        GetALLIDData()
        GetRoomAmenityData()
    End Sub
    Public Sub ROOMCHARGE()
        Dim inputRoomType As String = txt_roomtype.Text.Trim()
        Dim numofdays As String = txt_days.Text

        If Not String.IsNullOrEmpty(inputRoomType) AndAlso Not String.IsNullOrEmpty(numofdays) Then
            Dim days As Integer
            If Integer.TryParse(numofdays, days) Then
                Select Case inputRoomType
                    Case "Single Room"
                        CHARGES = days * SINGLE_ROOM
                    Case "Two Single Bed Room"
                        CHARGES = days * TWO_SINGLE_BED_ROOM
                    Case "Deluxe Room"
                        CHARGES = days * DELUXE_ROOM
                    Case "Junior Suite"
                        CHARGES = days * JUNIOR_SUITE
                    Case "Executive Suite"
                        CHARGES = days * EXECUTIVE_SUITE
                    Case "Presidential Suite"
                        CHARGES = days * PRESIDENTIAL_SUITE
                    Case Else
                        CHARGES = 0 ' Default charge if room type is not recognized
                End Select
                txt_roomcharge.Text = CHARGES.ToString("F2")
                UpdateSubtotal() ' Update subtotal after calculating room charges
            Else
                MessageBox.Show("Invalid number of days.")
            End If
        Else
            MessageBox.Show("Please ensure both room type and number of days are entered.")
        End If
    End Sub

    Private Sub dgv_roomamenity_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_roomamenity.MouseDoubleClick
        Try
            If dgv_roomamenity.SelectedRows.Count > 0 Then
                Dim dr = dgv_roomamenity.SelectedRows(0)
                Dim amenityPriceString As String = dr.Cells(2).Value.ToString() ' Trim any extra whitespace
                Dim amenityPrice As Decimal
                If Not String.IsNullOrEmpty(amenityPriceString) Then
                    If Decimal.TryParse(amenityPriceString, amenityPrice) Then
                        txt_amenitycharge.Text = amenityPrice.ToString("F2")
                        UpdateSubtotal() ' Update subtotal after setting amenity charges
                    Else
                        MsgBox("Invalid amenity price format.", MsgBoxStyle.Exclamation, "Error")
                    End If
                Else
                    MsgBox("Amenity price is empty.", MsgBoxStyle.Exclamation, "Error")
                End If
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cona.Close()
        End Try
    End Sub
    Private Sub GetRoomAmenityData()
        Try
            cona.Open()
            Dim sql As String = "SELECT GuestRoomID, RoomAmenityID, Price FROM Room_Amenity"
            Using cmd As New SqlCommand(sql, cona)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_roomamenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving Room Amenity data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cona.State = ConnectionState.Open Then
                cona.Close()
            End If
        End Try
    End Sub
    Private Sub UpdateSubtotal()
        Dim roomCharge As Decimal
        Dim amenityCharge As Decimal

        If Decimal.TryParse(txt_roomcharge.Text, roomCharge) AndAlso Decimal.TryParse(txt_amenitycharge.Text, amenityCharge) Then
            Dim subtotal As Decimal = roomCharge + amenityCharge
            txt_subtotal.Text = subtotal.ToString("F2")

            Dim tax As Decimal = subtotal * TAX_RATE
            txt_tax.Text = tax.ToString("F2")

            Dim overallTotal As Decimal = subtotal + tax
            txt_overalltotal.Text = overallTotal.ToString("F2")
        Else
            txt_subtotal.Text = "0.00"
            txt_tax.Text = "0.00"
            txt_overalltotal.Text = "0.00"
        End If
    End Sub
    Private Sub txt_change_TextChanged(sender As Object, e As EventArgs) Handles txt_change.TextChanged
        UpdateSubtotal()
    End Sub

    Private Sub txt_amenitycharge_TextChanged(sender As Object, e As EventArgs) Handles txt_amenitycharge.TextChanged
        UpdateSubtotal()
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        If String.IsNullOrWhiteSpace(txt_paymentID.Text) Then
            MessageBox.Show("Please select a payment to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateInputs() Then
            Try
                cona.Open()
                Dim updateRoomManagement As String = "UPDATE Payment SET PaymentMethod = @d2, PaymentAmmount = @d3, PaymentDate = @d4 WHERE PaymentID = @d1"
                Using cmd As New SqlCommand(updateRoomManagement, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_paymentID.Text)
                    cmd.Parameters.AddWithValue("@d2", cb_paymentmethod.Text)
                    cmd.Parameters.AddWithValue("@d3", txt_ammount.Text)
                    cmd.Parameters.AddWithValue("@d4", dtp_paymentdate.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected = 1 Then
                        MessageBox.Show("Successfully updated the payment!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetPaymentData() ' Refresh the payment data
                        ResetForm() ' Clear the form after update
                    Else
                        MessageBox.Show("No payment record was updated. Please check the Payment ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As SqlException
                MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error updating payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If cona.State = ConnectionState.Open Then
                    cona.Close()
                End If
            End Try
        End If
    End Sub
    Private Sub ResetForm()
        ' Clear text boxes
        txt_paymentID.Clear()
        txt_RoomNum.Clear()
        txt_roomtype.Clear()
        txt_fullname.Clear()
        txt_days.Clear()
        txt_advance.Clear()
        txt_ammount.Clear()
        txt_change.Clear()
        txt_roomcharge.Clear()
        txt_amenitycharge.Clear()
        txt_subtotal.Clear()
        txt_tax.Clear()
        txt_overalltotal.Clear()
        cb_paymentmethod.SelectedIndex = -1
        cb_roomstat.SelectedIndex = -1
        dtp_paymentdate.Value = DateTime.Now

        GetPaymentData() ' Refresh the payment data grid
        GetALLIDData()   ' Refresh the ALL_ID data grid
        GetRoomAmenityData() ' Refresh the room amenity data grid

        ' Set focus to the first input field
        txt_search.Focus()
    End Sub
    Private Sub txt_advance_TextChanged(sender As Object, e As EventArgs) Handles txt_advance.TextChanged
        UpdateSubtotal()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ResetForm()
    End Sub

    Private Sub txt_ammount_TextChanged(sender As Object, e As EventArgs) Handles txt_ammount.TextChanged
        UpdateSubtotal()
        CalculateChange()
    End Sub

    Private Sub CalculateChange()
        Dim amountPaid As Decimal
        Dim overallTotal As Decimal

        ' Try to parse the amount paid and overall total
        If Decimal.TryParse(txt_ammount.Text, amountPaid) AndAlso Decimal.TryParse(txt_overalltotal.Text, overallTotal) Then
            Dim change As Decimal = amountPaid - overallTotal
            txt_change.Text = change.ToString("F2")
        Else
            txt_change.Text = "0.00" ' Reset change if input is invalid
        End If
    End Sub
    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Full Name
        If String.IsNullOrWhiteSpace(txt_fullname.Text) Then
            errorMessage &= "Full Name is required." & Environment.NewLine
            isValid = False
        End If

        ' Validate Number of Days
        Dim numDays As Integer
        If Not Integer.TryParse(txt_days.Text, numDays) OrElse numDays <= 0 Then
            errorMessage &= "Please enter a valid number of days." & Environment.NewLine
            isValid = False
        End If

        ' Validate Room Charges
        If String.IsNullOrWhiteSpace(txt_roomcharge.Text) OrElse txt_roomcharge.Text = "0.00" Then
            errorMessage &= "Room charges must be calculated." & Environment.NewLine
            isValid = False
        End If

        ' Validate Amenity Charges
        If String.IsNullOrWhiteSpace(txt_amenitycharge.Text) OrElse txt_amenitycharge.Text = "0.00" Then
            errorMessage &= "Amenity charges must be entered." & Environment.NewLine
            isValid = False
        End If

        ' Validate Overall Total
        If String.IsNullOrWhiteSpace(txt_overalltotal.Text) OrElse txt_overalltotal.Text = "0.00" Then
            errorMessage &= "Overall total must be calculated." & Environment.NewLine
            isValid = False
        End If

        ' Validate Amount Paid
        Dim amountPaid As Decimal
        If Not Decimal.TryParse(txt_ammount.Text, amountPaid) OrElse amountPaid <= 0 Then
            errorMessage &= "Please enter a valid amount paid." & Environment.NewLine
            isValid = False
        End If

        ' Show error messages if any
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return isValid
    End Function
End Class