Public Class frmLoaiSp

    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        lvLoai.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from LoaiSp")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lvLoai.Items.Count + 1)
            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            lvLoai.Items.Add(item)
        Next

    End Sub

    Private Sub btThemLoai_Click(sender As Object, e As EventArgs) Handles btThemLoai.Click
        sqlConnect.ExecuteNoneQuery("Insert into LoaiSp(idLoai,TenLoai) values(" + tbMaLoai.Text + ",N'" + tbTenLoai.Text + "' )")
        LoadSanPham()
    End Sub

    Private Sub btLoadLoai_Click(sender As Object, e As EventArgs) Handles btLoadLoai.Click
        LoadSanPham()
    End Sub

    Private Sub btXoaLoai_Click(sender As Object, e As EventArgs) Handles btXoaLoai.Click
        For i As Integer = lvLoai.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = lvLoai.SelectedIndices(i)
            Dim TenCanXoa As String = lvLoai.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from LoaiSp where idLoai = " + TenCanXoa + "")

        Next
        LoadSanPham()
    End Sub

    Private Sub lvLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvLoai.SelectedIndexChanged
        If lvLoai.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lvLoai.SelectedItems
                tbMaLoai.Text = List.SubItems(1).Text
                tbTenLoai.Text = List.SubItems(2).Text
            Next
        End If
    End Sub

    Private Sub btSuaLoai_Click(sender As Object, e As EventArgs) Handles btSuaLoai.Click
        For i As Integer = lvLoai.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = lvLoai.SelectedIndices(i)
            Dim macansua As String = lvLoai.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update LoaiSp set TenLoai=N'" & tbTenLoai.Text & "' where idLoai=" + macansua + "")
        Next
        LoadSanPham()
    End Sub
End Class