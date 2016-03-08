Public Class frmMain

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmKhachHang.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmLoaiSp.Show()
    End Sub


    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
    End Sub

    Private Sub SaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaToolStripMenuItem.Click
        frmSanPham.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmChiTIet.Show()
    End Sub
End Class
