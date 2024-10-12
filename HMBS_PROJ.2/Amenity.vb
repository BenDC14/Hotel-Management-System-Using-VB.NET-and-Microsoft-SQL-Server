Imports System.Data.SqlClient

Public Class Amenity
    Dim ID As String = GetRandom(100, 9999).ToString()
    Dim ms As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim cona As SqlConnection = New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")


    Private Sub GetAmenityData()
        Dim con As New SqlConnection("Data Source=DESKTOP-9EC3AKU\SQLEXPRESS01;Initial Catalog=HMBS_Project;Integrated Security=True;Encrypt=False")
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM Amenity"
            Using cmd As New SqlCommand(sql, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_Amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving amenity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub BTN_GEN_Click(sender As Object, e As EventArgs) Handles BTN_GEN.Click
        txt_AmenityID.Text = "AMEDITY" & ID
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            cona.Open()
            Dim inquery As String = "SELECT * FROM Amenity WHERE AmenityID LIKE @search OR AmenityName LIKE @search"
            Using cmd As New SqlCommand(inquery, cona)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_Amenity.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cona.Close()
        End Try
    End Sub



    Private Sub DGV_Amenity_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGV_Amenity.MouseDoubleClick
        Try

            If DGV_Amenity.SelectedRows.Count > 0 Then

                Dim dr = DGV_Amenity.SelectedRows(0)
                txt_AmenityID.Text = dr.Cells(0).Value.ToString
                txt_AmenityName.Text = dr.Cells(1).Value.ToString
                txt_Amenity_Price.Text = dr.Cells(2).Value.ToString
                txt_Amenity_Description.Text = dr.Cells(3).Value.ToString
                txt_amenity_quantity.Text = dr.Cells(4).Value.ToString

            Else
                MsgBox("Please select a row.", MsgBoxStyle.Information, "No Row Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cona.Close()
        End Try
    End Sub
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt_AmenityID.Text) OrElse
       String.IsNullOrWhiteSpace(txt_AmenityName.Text) OrElse
       String.IsNullOrWhiteSpace(txt_Amenity_Price.Text) OrElse
       String.IsNullOrWhiteSpace(txt_Amenity_Description.Text) OrElse
       String.IsNullOrWhiteSpace(txt_amenity_quantity.Text) Then
            MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Sub RESET()
        txt_AmenityID.Text = ""
        txt_AmenityName.Text = ""
        txt_Amenity_Price.Text = ""
        txt_Amenity_Description.Text = ""
        txt_amenity_quantity.Text = ""
    End Sub

    Private Sub Amenity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAmenityData()
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If String.IsNullOrWhiteSpace(txt_AmenityID.Text) Then
                MessageBox.Show("Please select a amenity to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidateInputs() Then
                cona.Open()
                Dim updateRoomManagement As String = "UPDATE Amenity SET AmenityName = @d2, AmenityPrice=@d3, AmenityDescription=@d4, AmenityQuantity=@d5 WHERE AmenityID=@d1"
                Using cmd As New SqlCommand(updateRoomManagement, cona)
                    cmd.Parameters.AddWithValue("@d1", txt_AmenityID.Text)
                    cmd.Parameters.AddWithValue("@d2", txt_AmenityName.Text)
                    cmd.Parameters.AddWithValue("@d3", txt_Amenity_Price.Text)
                    cmd.Parameters.AddWithValue("@d4", txt_Amenity_Description.Text)
                    cmd.Parameters.AddWithValue("@d5", txt_amenity_quantity.Text)

                    If cmd.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Successfully updated the amenity!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetAmenityData()
                        RESET()
                        cona.Close()
                    Else
                        MessageBox.Show("Failed to update amenity.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Try
            If ValidateInputs() Then
                cona.Open()

                Dim insertHotelRoomsManagement As String = "IF NOT EXISTS (SELECT * FROM Amenity WHERE AmenityID = @AmenityID) " &
                                                   "INSERT INTO Amenity(AmenityID, AmenityName, AmenityPrice, AmenityDescription, AmenityQuantity) " &
                                                   "VALUES (@AmenityID, @AmenityName, @AmenityPrice, @AmenityDescription, @AmenityQuantity)"
                Using cmd As New SqlCommand(insertHotelRoomsManagement, cona)
                    cmd.Parameters.AddWithValue("@AmenityID", txt_AmenityID.Text)
                    cmd.Parameters.AddWithValue("@AmenityName", txt_AmenityName.Text)
                    cmd.Parameters.AddWithValue("@AmenityPrice", txt_Amenity_Price.Text)
                    cmd.Parameters.AddWithValue("@AmenityDescription", txt_Amenity_Description.Text)
                    cmd.Parameters.AddWithValue("@AmenityQuantity", txt_amenity_quantity.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show("Successfully created new amenity!", "Amenity Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetAmenityData()
                        RESET()
                    Else
                        MessageBox.Show("Amenity ID already existed before in Hotel_Rooms_Management!", "Amenity Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_AmenityID.Focus()
                    End If
                End Using
            Else
                MessageBox.Show("Failed to create new amenity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If String.IsNullOrWhiteSpace(txt_AmenityID.Text) Then
                MessageBox.Show("Please select a amenity to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ms As String
            ms = MessageBox.Show("Are you sure you want to delete the amenity?", "Delete Amenity", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ms = vbYes Then
                cona.Open()

                Dim deleteRoomManagement As String = "DELETE FROM Amenity WHERE AmenityID= @AmenityID"
                Using cmdBooking As New SqlCommand(deleteRoomManagement, cona)
                    cmdBooking.Parameters.AddWithValue("@AmenityID", txt_AmenityID.Text)
                    cmdBooking.ExecuteNonQuery()
                End Using
                MessageBox.Show("Deleted successfully!", "Delete Amenity", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetAmenityData()
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

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        RESET()
    End Sub


End Class