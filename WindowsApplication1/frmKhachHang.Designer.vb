<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.lbDiachi = New System.Windows.Forms.Label()
        Me.lbSDT = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbDiachi = New System.Windows.Forms.TextBox()
        Me.tbSdt = New System.Windows.Forms.TextBox()
        Me.tbNgaysinh = New System.Windows.Forms.TextBox()
        Me.tbGioitinh = New System.Windows.Forms.TextBox()
        Me.tbThem = New System.Windows.Forms.Button()
        Me.tbXoa = New System.Windows.Forms.Button()
        Me.tbSua = New System.Windows.Forms.Button()
        Me.lvKhachHang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clMa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clSdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clNgaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GioiTinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btLoad = New System.Windows.Forms.Button()
        Me.lbMa = New System.Windows.Forms.Label()
        Me.tbMa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Location = New System.Drawing.Point(12, 11)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(29, 13)
        Me.lbTen.TabIndex = 1
        Me.lbTen.Text = "Tên:"
        '
        'lbDiachi
        '
        Me.lbDiachi.AutoSize = True
        Me.lbDiachi.Location = New System.Drawing.Point(12, 38)
        Me.lbDiachi.Name = "lbDiachi"
        Me.lbDiachi.Size = New System.Drawing.Size(43, 13)
        Me.lbDiachi.TabIndex = 2
        Me.lbDiachi.Text = "Địa chỉ:"
        '
        'lbSDT
        '
        Me.lbSDT.AutoSize = True
        Me.lbSDT.Location = New System.Drawing.Point(12, 65)
        Me.lbSDT.Name = "lbSDT"
        Me.lbSDT.Size = New System.Drawing.Size(32, 13)
        Me.lbSDT.TabIndex = 3
        Me.lbSDT.Text = "SDT:"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(12, 92)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(57, 13)
        Me.lbNgaySinh.TabIndex = 3
        Me.lbNgaySinh.Text = "Ngày sinh:"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(12, 119)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(50, 13)
        Me.lbGioiTinh.TabIndex = 3
        Me.lbGioiTinh.Text = "Giới tính:"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(69, 8)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(125, 20)
        Me.tbTen.TabIndex = 4
        '
        'tbDiachi
        '
        Me.tbDiachi.Location = New System.Drawing.Point(69, 35)
        Me.tbDiachi.Name = "tbDiachi"
        Me.tbDiachi.Size = New System.Drawing.Size(125, 20)
        Me.tbDiachi.TabIndex = 4
        '
        'tbSdt
        '
        Me.tbSdt.Location = New System.Drawing.Point(69, 62)
        Me.tbSdt.Name = "tbSdt"
        Me.tbSdt.Size = New System.Drawing.Size(125, 20)
        Me.tbSdt.TabIndex = 4
        '
        'tbNgaysinh
        '
        Me.tbNgaysinh.Location = New System.Drawing.Point(69, 89)
        Me.tbNgaysinh.Name = "tbNgaysinh"
        Me.tbNgaysinh.Size = New System.Drawing.Size(125, 20)
        Me.tbNgaysinh.TabIndex = 4
        '
        'tbGioitinh
        '
        Me.tbGioitinh.Location = New System.Drawing.Point(69, 116)
        Me.tbGioitinh.Name = "tbGioitinh"
        Me.tbGioitinh.Size = New System.Drawing.Size(125, 20)
        Me.tbGioitinh.TabIndex = 4
        '
        'tbThem
        '
        Me.tbThem.Location = New System.Drawing.Point(58, 164)
        Me.tbThem.Name = "tbThem"
        Me.tbThem.Size = New System.Drawing.Size(75, 23)
        Me.tbThem.TabIndex = 5
        Me.tbThem.Text = "Thêm"
        Me.tbThem.UseVisualStyleBackColor = True
        '
        'tbXoa
        '
        Me.tbXoa.Location = New System.Drawing.Point(58, 214)
        Me.tbXoa.Name = "tbXoa"
        Me.tbXoa.Size = New System.Drawing.Size(75, 23)
        Me.tbXoa.TabIndex = 5
        Me.tbXoa.Text = "Xóa"
        Me.tbXoa.UseVisualStyleBackColor = True
        '
        'tbSua
        '
        Me.tbSua.Location = New System.Drawing.Point(58, 262)
        Me.tbSua.Name = "tbSua"
        Me.tbSua.Size = New System.Drawing.Size(75, 23)
        Me.tbSua.TabIndex = 5
        Me.tbSua.Text = "Sửa"
        Me.tbSua.UseVisualStyleBackColor = True
        '
        'lvKhachHang
        '
        Me.lvKhachHang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.clMa, Me.clTen, Me.clDiachi, Me.clSdt, Me.clNgaysinh, Me.GioiTinh})
        Me.lvKhachHang.FullRowSelect = True
        Me.lvKhachHang.GridLines = True
        Me.lvKhachHang.Location = New System.Drawing.Point(265, 35)
        Me.lvKhachHang.Name = "lvKhachHang"
        Me.lvKhachHang.Size = New System.Drawing.Size(570, 347)
        Me.lvKhachHang.TabIndex = 6
        Me.lvKhachHang.UseCompatibleStateImageBehavior = False
        Me.lvKhachHang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clMa
        '
        Me.clMa.Text = "Mã"
        Me.clMa.Width = 53
        '
        'clTen
        '
        Me.clTen.Text = "Tên"
        Me.clTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clTen.Width = 118
        '
        'clDiachi
        '
        Me.clDiachi.Text = "Địa chỉ"
        Me.clDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clDiachi.Width = 124
        '
        'clSdt
        '
        Me.clSdt.Text = "SDT"
        Me.clSdt.Width = 91
        '
        'clNgaysinh
        '
        Me.clNgaysinh.Text = "Ngày sinh"
        Me.clNgaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GioiTinh
        '
        Me.GioiTinh.Text = "Giới tính"
        Me.GioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(58, 307)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(75, 23)
        Me.btLoad.TabIndex = 7
        Me.btLoad.Text = "Load dữ liệu"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'lbMa
        '
        Me.lbMa.AutoSize = True
        Me.lbMa.Location = New System.Drawing.Point(12, 143)
        Me.lbMa.Name = "lbMa"
        Me.lbMa.Size = New System.Drawing.Size(25, 13)
        Me.lbMa.TabIndex = 1
        Me.lbMa.Text = "Mã:"
        '
        'tbMa
        '
        Me.tbMa.Location = New System.Drawing.Point(69, 140)
        Me.tbMa.Name = "tbMa"
        Me.tbMa.Size = New System.Drawing.Size(125, 20)
        Me.tbMa.TabIndex = 4
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 412)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.lvKhachHang)
        Me.Controls.Add(Me.tbSua)
        Me.Controls.Add(Me.tbXoa)
        Me.Controls.Add(Me.tbThem)
        Me.Controls.Add(Me.tbGioitinh)
        Me.Controls.Add(Me.tbNgaysinh)
        Me.Controls.Add(Me.tbSdt)
        Me.Controls.Add(Me.tbDiachi)
        Me.Controls.Add(Me.tbMa)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbSDT)
        Me.Controls.Add(Me.lbDiachi)
        Me.Controls.Add(Me.lbMa)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbTen As System.Windows.Forms.Label
    Friend WithEvents lbDiachi As System.Windows.Forms.Label
    Friend WithEvents lbSDT As System.Windows.Forms.Label
    Friend WithEvents lbNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lbGioiTinh As System.Windows.Forms.Label
    Friend WithEvents tbTen As System.Windows.Forms.TextBox
    Friend WithEvents tbDiachi As System.Windows.Forms.TextBox
    Friend WithEvents tbSdt As System.Windows.Forms.TextBox
    Friend WithEvents tbNgaysinh As System.Windows.Forms.TextBox
    Friend WithEvents tbGioitinh As System.Windows.Forms.TextBox
    Friend WithEvents tbThem As System.Windows.Forms.Button
    Friend WithEvents tbXoa As System.Windows.Forms.Button
    Friend WithEvents tbSua As System.Windows.Forms.Button
    Friend WithEvents lvKhachHang As System.Windows.Forms.ListView
    Friend WithEvents clMa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clNgaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents GioiTinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents lbMa As System.Windows.Forms.Label
    Friend WithEvents tbMa As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
