Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Room_Amenities
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
    Dim ID As String = GetRandom(1, 9999).ToString()

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
        Dim ID As String = GetRandom(1, 9999).ToString()
    End Function

    Private Sub GetRoomAmentyData()
        Try
            If cona.State = ConnectionState.Closed Then
                cona.Open()
            End If
            Dim sql As String = "SELECT * FROM Room_Amenity"
            Using cmd As New SqlCommand(sql, cona)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        reset()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Room_Amenity WHERE RoomAmenityID LIKE @search OR GuestRoomID LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub GetAmentyData()
        Try
            If cona.State = ConnectionState.Closed Then
                cona.Open()
            End If
            Dim sql As String = "SELECT * FROM Amenity"
            Using cmd As New SqlCommand(sql, cona)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub DGV_Amenity_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_amenity.MouseDoubleClick
        Try
            If dgv_amenity.SelectedRows.Count > 0 Then
                Dim dr = dgv_amenity.SelectedRows(0)

                Dim amenityID As String = dr.Cells(0).Value.ToString()
                Dim amenityName As String = dr.Cells(1).Value.ToString()
                Dim amenityPriceString As String = dr.Cells(2).Value.ToString() ' Trim any extra whitespace
                Dim amenityPrice As Decimal

                ' Debugging line to check the retrieved price
                MessageBox.Show($"Retrieved Amenity Price String: '{amenityPriceString}'")

                ' Check if the price string is not empty or null
                If Not String.IsNullOrEmpty(amenityPriceString) Then
                    If Decimal.TryParse(amenityPriceString, amenityPrice) Then
                        ' Create a new ListViewItem with the retrieved data
                        Dim listViewItem As New ListViewItem(amenityID)
                        listViewItem.SubItems.Add(amenityName)
                        listViewItem.SubItems.Add(amenityPrice.ToString("F2")) ' Format price to 2 decimal places
                        listViewItem.SubItems.Add("") ' Leave the quantity column empty

                        ' Add the new item to the ListView
                        lv_amenity.Items.Add(listViewItem)
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


    Private Sub Room_Amenities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRoomAmentyData()
        GetAmentyData()
    End Sub

    Public Sub reset()
        txt_guestroomID.Clear()
        txt_roomamentity.Clear()
        txt_price.Clear()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        reset()
    End Sub

    Private Sub TXT_searchguest_TextChanged(sender As Object, e As EventArgs) Handles TXT_searchguest.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Amenity WHERE AmenityID LIKE @search OR AmenityName LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Room_Amenity WHERE GuestRoomID LIKE @search OR RoomAmenityID LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub btn_AddQuantity_Click(sender As Object, e As EventArgs) Handles btn_addquantity.Click
        Try
            If lv_amenity.SelectedItems.Count > 0 Then
                For Each selectedItem As ListViewItem In lv_amenity.SelectedItems
                    ' Get the new quantity from the TextBox
                    Dim newQuantity As Integer
                    If Integer.TryParse(txt_Quantity.Text, newQuantity) Then
                        selectedItem.SubItems(3).Text = newQuantity.ToString()
                    Else
                        MsgBox("Please enter a valid number for the quantity.", MsgBoxStyle.Exclamation, "Invalid Input")
                        Return ' Exit if quantity input is invalid
                    End If
                Next

                txt_Quantity.Clear()
            Else
                MsgBox("Please select an item from the list.", MsgBoxStyle.Information, "No Item Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgv_roomamenity_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_roomamenity.MouseDoubleClick
        btn_addquantity.Enabled = False
        txt_price.ReadOnly = False
        Try
            If dgv_roomamenity.SelectedRows.Count > 0 Then
                Dim dr = dgv_roomamenity.SelectedRows(0)
                txt_ID.Text = dr.Cells(0).Value.ToString
                txt_guestroomID.Text = dr.Cells(1).Value.ToString
                txt_roomamentity.Text = dr.Cells(2).Value.ToString
                txt_price.Text = dr.Cells(3).Value.ToString()
            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txt_roomamentity.Text = "ROOMAME" & ID
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate if all fields are filled
        If String.IsNullOrWhiteSpace(txt_ID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_guestroomID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_roomamentity.Text) OrElse
       String.IsNullOrWhiteSpace(txt_price.Text) Then
            MessageBox.Show("Please input all details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_Quantity.Clear()
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            If ValidateInputs() Then
                MessageBox.Show("Please select a amenity to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ms As String
            ms = MessageBox.Show("Are you sure you want to delete the amenity?", "Delete Amenity", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ms = vbYes Then
                cona.Open()

                Dim deleteRoomManagement As String = "DELETE FROM Room_Amenity WHERE ID= @ID"
                Using cmdBooking As New SqlCommand(deleteRoomManagement, cona)
                    cmdBooking.Parameters.AddWithValue("@AmenityID", txt_ID.Text)
                    cmdBooking.ExecuteNonQuery()
                End Using
                MessageBox.Show("Deleted successfully!", "Delete Amenity", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetRoomAmentyData()
                reset()
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

        ' Your update logic here
        Try
            If String.IsNullOrWhiteSpace(txt_ID.Text) Then
                MessageBox.Show("Please select an amenity to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidateInputs() Then
                cona.Open()
                Dim updateRoomManagement As String = "UPDATE Room_Amenity SET GuestRoomID = @d2, RoomAmenityID=@d3, Price=@d4 WHERE ID=@d1"
                Using cmd As New SqlCommand(updateRoomManagement, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_ID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_guestroomID.Text)
                    cmd.Parameters.AddWithValue("@d3", txt_roomamentity.Text)
                    cmd.Parameters.AddWithValue("@d4", txt_price.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the amenity!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetRoomAmentyData()
                        reset()
                        lv_amenity.Items.Clear()
                        btn_addquantity.Enabled = True
                        txt_price.ReadOnly = True
                    Else
                        MessageBox.Show("Failed to update the amenity.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles txt_totalprice.Click
        Try
            Dim totalAmount As Decimal = 0 ' Initialize total amount
            For Each selectedItem As ListViewItem In lv_amenity.SelectedItems
                Dim newQuantityString As String = selectedItem.SubItems(3).Text
                Dim newQuantity As Integer
                If Integer.TryParse(newQuantityString, newQuantity) Then
                    Dim unitPriceString As String = selectedItem.SubItems(2).Text
                    Dim unitPrice As Decimal

                    If Decimal.TryParse(unitPriceString, unitPrice) Then
                        Dim totalPrice As Decimal = unitPrice * newQuantity
                        totalAmount += totalPrice ' Accumulate the total price
                    Else
                        MsgBox("The unit price format is invalid for item: " & selectedItem.Text, MsgBoxStyle.Exclamation, "Invalid Price Format")
                    End If
                Else
                    MsgBox("Invalid quantity for item: " & selectedItem.Text, MsgBoxStyle.Exclamation, "Invalid Quantity")
                End If
            Next

            txt_price.Text = totalAmount.ToString("F2") ' Display total price formatted to 2 decimal places
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class