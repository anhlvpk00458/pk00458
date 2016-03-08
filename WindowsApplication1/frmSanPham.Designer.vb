<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btLoad = New System.Windows.Forms.Button()
        Me.tbXoa = New System.Windows.Forms.Button()
        Me.clNgaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clSdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbThem = New System.Windows.Forms.Button()
        Me.tbXuatxu = New System.Windows.Forms.TextBox()
        Me.tbGia = New System.Windows.Forms.TextBox()
        Me.tbLoai = New System.Windows.Forms.TextBox()
        Me.clMa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvSanPham = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbSua = New System.Windows.Forms.Button()
        Me.tbMa = New System.Windows.Forms.TextBox()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbSDT = New System.Windows.Forms.Label()
        Me.lbDiachi = New System.Windows.Forms.Label()
        Me.lbMa = New System.Windows.Forms.Label()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(52, 338)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(75, 23)
        Me.btLoad.TabIndex = 25
        Me.btLoad.Text = "Load dữ liệu"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'tbXoa
        '
        Me.tbXoa.Location = New System.Drawing.Point(52, 251)
        Me.tbXoa.Name = "tbXoa"
        Me.tbXoa.Size = New System.Drawing.Size(75, 23)
        Me.tbXoa.TabIndex = 23
        Me.tbXoa.Text = "Xóa"
        Me.tbXoa.UseVisualStyleBackColor = True
        '
        'clNgaysinh
        '
        Me.clNgaysinh.Text = "Xuất xứ"
        Me.clNgaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clSdt
        '
        Me.clSdt.Text = "Giá"
        Me.clSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clSdt.Width = 91
        '
        'clDiachi
        '
        Me.clDiachi.Text = "Loại"
        Me.clDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clDiachi.Width = 124
        '
        'clTen
        '
        Me.clTen.Text = "Tên SP"
        Me.clTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clTen.Width = 118
        '
        'tbThem
        '
        Me.tbThem.Location = New System.Drawing.Point(52, 207)
        Me.tbThem.Name = "tbThem"
        Me.tbThem.Size = New System.Drawing.Size(75, 23)
        Me.tbThem.TabIndex = 22
        Me.tbThem.Text = "Thêm"
        Me.tbThem.UseVisualStyleBackColor = True
        '
        'tbXuatxu
        '
        Me.tbXuatxu.Location = New System.Drawing.Point(84, 151)
        Me.tbXuatxu.Name = "tbXuatxu"
        Me.tbXuatxu.Size = New System.Drawing.Size(125, 20)
        Me.tbXuatxu.TabIndex = 16
        '
        'tbGia
        '
        Me.tbGia.Location = New System.Drawing.Point(84, 124)
        Me.tbGia.Name = "tbGia"
        Me.tbGia.Size = New System.Drawing.Size(125, 20)
        Me.tbGia.TabIndex = 17
        '
        'tbLoai
        '
        Me.tbLoai.Location = New System.Drawing.Point(84, 97)
        Me.tbLoai.Name = "tbLoai"
        Me.tbLoai.Size = New System.Drawing.Size(125, 20)
        Me.tbLoai.TabIndex = 18
        '
        'clMa
        '
        Me.clMa.Text = "Mã"
        Me.clMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clMa.Width = 53
        '
        'lvSanPham
        '
        Me.lvSanPham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.clMa, Me.clTen, Me.clDiachi, Me.clSdt, Me.clNgaysinh})
        Me.lvSanPham.FullRowSelect = True
        Me.lvSanPham.GridLines = True
        Me.lvSanPham.Location = New System.Drawing.Point(259, 66)
        Me.lvSanPham.Name = "lvSanPham"
        Me.lvSanPham.Size = New System.Drawing.Size(511, 347)
        Me.lvSanPham.TabIndex = 24
        Me.lvSanPham.UseCompatibleStateImageBehavior = False
        Me.lvSanPham.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'tbSua
        '
        Me.tbSua.Location = New System.Drawing.Point(52, 293)
        Me.tbSua.Name = "tbSua"
        Me.tbSua.Size = New System.Drawing.Size(75, 23)
        Me.tbSua.TabIndex = 21
        Me.tbSua.Text = "Sửa"
        Me.tbSua.UseVisualStyleBackColor = True
        '
        'tbMa
        '
        Me.tbMa.Location = New System.Drawing.Point(84, 44)
        Me.tbMa.Name = "tbMa"
        Me.tbMa.Size = New System.Drawing.Size(125, 20)
        Me.tbMa.TabIndex = 19
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(84, 70)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(125, 20)
        Me.tbTen.TabIndex = 20
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(27, 154)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(46, 13)
        Me.lbNgaySinh.TabIndex = 14
        Me.lbNgaySinh.Text = "Xuất xứ:"
        '
        'lbSDT
        '
        Me.lbSDT.AutoSize = True
        Me.lbSDT.Location = New System.Drawing.Point(27, 127)
        Me.lbSDT.Name = "lbSDT"
        Me.lbSDT.Size = New System.Drawing.Size(29, 13)
        Me.lbSDT.TabIndex = 12
        Me.lbSDT.Text = "Giá :"
        '
        'lbDiachi
        '
        Me.lbDiachi.AutoSize = True
        Me.lbDiachi.Location = New System.Drawing.Point(27, 100)
        Me.lbDiachi.Name = "lbDiachi"
        Me.lbDiachi.Size = New System.Drawing.Size(33, 13)
        Me.lbDiachi.TabIndex = 11
        Me.lbDiachi.Text = "Loại :"
        '
        'lbMa
        '
        Me.lbMa.AutoSize = True
        Me.lbMa.Location = New System.Drawing.Point(27, 47)
        Me.lbMa.Name = "lbMa"
        Me.lbMa.Size = New System.Drawing.Size(25, 13)
        Me.lbMa.TabIndex = 9
        Me.lbMa.Text = "Mã:"
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Location = New System.Drawing.Point(27, 73)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(46, 13)
        Me.lbTen.TabIndex = 10
        Me.lbTen.Text = "Tên SP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 453)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.tbXoa)
        Me.Controls.Add(Me.tbThem)
        Me.Controls.Add(Me.tbXuatxu)
        Me.Controls.Add(Me.tbGia)
        Me.Controls.Add(Me.tbLoai)
        Me.Controls.Add(Me.lvSanPham)
        Me.Controls.Add(Me.tbSua)
        Me.Controls.Add(Me.tbMa)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbSDT)
        Me.Controls.Add(Me.lbDiachi)
        Me.Controls.Add(Me.lbMa)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSanPham"
        Me.Text = "Sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents tbXoa As System.Windows.Forms.Button
    Friend WithEvents clNgaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbThem As System.Windows.Forms.Button
    Friend WithEvents tbXuatxu As System.Windows.Forms.TextBox
    Friend WithEvents tbGia As System.Windows.Forms.TextBox
    Friend WithEvents tbLoai As System.Windows.Forms.TextBox
    Friend WithEvents clMa As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSanPham As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbSua As System.Windows.Forms.Button
    Friend WithEvents tbMa As System.Windows.Forms.TextBox
    Friend WithEvents tbTen As System.Windows.Forms.TextBox
    Friend WithEvents lbNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lbSDT As System.Windows.Forms.Label
    Friend WithEvents lbDiachi As System.Windows.Forms.Label
    Friend WithEvents lbMa As System.Windows.Forms.Label
    Friend WithEvents lbTen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
