Public Class frmKhachHang
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        lvKhachHang.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from KhachHang")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lvKhachHang.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            item.SubItems.Add(dt.Rows(i).ItemArray(5))
            lvKhachHang.Items.Add(item)
        Next

    End Sub

    Private Sub tbThem_Click(sender As Object, e As EventArgs) Handles tbThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into KhachHang(idKhach,TenKhach,DiaChi,sdt,NgaySinh,GioiTinh) values(" + tbMa.Text + ",N'" + tbTen.Text + "',N'" + tbDiachi.Text + "'," + tbSdt.Text + "," + tbNgaysinh.Text + ",N'" + tbGioitinh.Text + "' )")
        LoadSanPham()
    End Sub

    Private Sub tbXoa_Click(sender As Object, e As EventArgs) Handles tbXoa.Click
        For i As Integer = lvKhachHang.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = lvKhachHang.SelectedIndices(i)
            Dim maCanXoa As String = lvKhachHang.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from KhachHang where idKhach = " + maCanXoa + "")

        Next
        LoadSanPham()
    End Sub

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        LoadSanPham()
    End Sub
    Private Sub lvKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKhachHang.SelectedIndexChanged
        If lvKhachHang.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lvKhachHang.SelectedItems
                tbMa.Text = List.SubItems(1).Text
                tbTen.Text = List.SubItems(2).Text
                tbDiachi.Text = List.SubItems(3).Text
                tbSdt.Text = List.SubItems(4).Text
                tbNgaysinh.Text = List.SubItems(5).Text
                tbGioitinh.Text = List.SubItems(6).Text

            Next
        End If
    End Sub

    Private Sub tbSua_Click(sender As Object, e As EventArgs) Handles tbSua.Click
        For i As Integer = lvKhachHang.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = lvKhachHang.SelectedIndices(i)
            Dim tenSpcansua As String = lvKhachHang.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update KhachHang set TenKhach=N'" & tbTen.Text & "', DiaChi=N'" & tbDiachi.Text & "', sdt=" + tbSdt.Text + ", NgaySinh=" & tbNgaysinh.Text & ", GioiTinh=N'" & tbGioitinh.Text & "' where idKhach=" + tenSpcansua + "")
        Next
        LoadSanPham()
    End Sub
End Class