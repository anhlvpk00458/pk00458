Public Class frmChiTIet
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        lvChiTiet.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from ChiTietHoaDon")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lvChiTiet.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            lvChiTiet.Items.Add(item)
        Next

    End Sub

    Private Sub tbThem_Click(sender As Object, e As EventArgs) Handles tbThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into ChiTietHoaDon(id,HoaDon,SanPham,SoLuong) values(" + tbMa.Text + "," + tbHoaDon.Text + "," + tbSP.Text + "," + tbSl.Text + " )")
        LoadSanPham()
    End Sub

    Private Sub tbXoa_Click(sender As Object, e As EventArgs) Handles tbXoa.Click
        For i As Integer = lvChiTiet.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = lvChiTiet.SelectedIndices(i)
            Dim maCanXoa As String = lvChiTiet.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from ChiTietHoaDon where id = " + maCanXoa + "")

        Next
        LoadSanPham()
    End Sub

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        LoadSanPham()
    End Sub

    Private Sub lvChiTiet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvChiTiet.SelectedIndexChanged
        If lvChiTiet.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lvChiTiet.SelectedItems
                tbMa.Text = List.SubItems(1).Text
                tbHoaDon.Text = List.SubItems(2).Text
                tbSP.Text = List.SubItems(3).Text
                tbSl.Text = List.SubItems(4).Text

            Next
        End If
    End Sub

    Private Sub tbSua_Click(sender As Object, e As EventArgs) Handles tbSua.Click
        For i As Integer = lvChiTiet.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = lvChiTiet.SelectedIndices(i)
            Dim tenSpcansua As String = lvChiTiet.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update ChiTietHoaDon set HoaDon=" & tbHoaDon.Text & ", SanPham=" & tbSP.Text & ", SoLuong=" + tbSl.Text + " where id =" + tenSpcansua + "")
        Next
        LoadSanPham()
    End Sub
End Class