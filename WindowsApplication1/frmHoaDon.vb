Public Class frmHoaDon
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        lvHoaDon.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from HoaDon")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lvHoaDon.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            lvHoaDon.Items.Add(item)
        Next
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into HoaDon(idHoadon,KhachMua) values(" + tbMa.Text + "," + tbKhachMua.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        For i As Integer = lvHoaDon.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = lvHoaDon.SelectedIndices(i)
            Dim maCanXoa As String = lvHoaDon.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from HoaDon where idHoadon = " + maCanXoa)

        Next
        LoadSanPham()
    End Sub

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        LoadSanPham()
    End Sub
    Private Sub lvHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvHoaDon.SelectedIndexChanged
        If lvHoaDon.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lvHoaDon.SelectedItems
                tbMa.Text = List.SubItems(1).Text
                tbKhachMua.Text = List.SubItems(2).Text
            Next
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        For i As Integer = lvHoaDon.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = lvHoaDon.SelectedIndices(i)
            Dim macansua As String = lvHoaDon.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update HoaDon set KhachMua=N'" & tbKhachMua.Text & "' where idHoaDon=" + macansua + "")
        Next
        LoadSanPham()
    End Sub
End Class