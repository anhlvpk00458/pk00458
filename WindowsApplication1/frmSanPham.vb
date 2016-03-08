Public Class frmSanPham
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        lvSanPham.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from Sp")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lvSanPham.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            lvSanPham.Items.Add(item)
        Next

    End Sub

    Private Sub tbThem_Click(sender As Object, e As EventArgs) Handles tbThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into Sp(idSp,TenSp,LoaiSp,Gia,xuatxu) values(" + tbMa.Text + ",N'" + tbTen.Text + "'," + tbLoai.Text + "," + tbGia.Text + ",N'" + tbXuatxu.Text + "' )")
        LoadSanPham()
    End Sub

    Private Sub tbXoa_Click(sender As Object, e As EventArgs) Handles tbXoa.Click
        For i As Integer = lvSanPham.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = lvSanPham.SelectedIndices(i)
            Dim maCanXoa As String = lvSanPham.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from Sp where idSp = " + maCanXoa + "")

        Next
        LoadSanPham()
    End Sub

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        LoadSanPham()
    End Sub

    Private Sub lvSanPham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSanPham.SelectedIndexChanged
        If lvSanPham.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lvSanPham.SelectedItems
                tbMa.Text = List.SubItems(1).Text
                tbTen.Text = List.SubItems(2).Text
                tbLoai.Text = List.SubItems(3).Text
                tbGia.Text = List.SubItems(4).Text
                tbXuatxu.Text = List.SubItems(5).Text

            Next
        End If
    End Sub

    Private Sub tbSua_Click(sender As Object, e As EventArgs) Handles tbSua.Click
        For i As Integer = lvSanPham.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = lvSanPham.SelectedIndices(i)
            Dim tenSpcansua As String = lvSanPham.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update Sp set TenSp=N'" & tbTen.Text & "', LoaiSp=" & tbLoai.Text & ", Gia=" + tbGia.Text + ", XuatXu=N'" & tbXuatxu.Text & "' where idSp=" + tenSpcansua + "")
        Next
        LoadSanPham()
    End Sub
End Class