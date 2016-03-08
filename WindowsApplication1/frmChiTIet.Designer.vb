<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTIet
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
        Me.tbThem = New System.Windows.Forms.Button()
        Me.tbSl = New System.Windows.Forms.TextBox()
        Me.tbSP = New System.Windows.Forms.TextBox()
        Me.lvChiTiet = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clMa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clSdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbSua = New System.Windows.Forms.Button()
        Me.tbMa = New System.Windows.Forms.TextBox()
        Me.tbHoaDon = New System.Windows.Forms.TextBox()
        Me.lbSDT = New System.Windows.Forms.Label()
        Me.lbDiachi = New System.Windows.Forms.Label()
        Me.lbMa = New System.Windows.Forms.Label()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(64, 348)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(75, 23)
        Me.btLoad.TabIndex = 41
        Me.btLoad.Text = "Load dữ liệu"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'tbXoa
        '
        Me.tbXoa.Location = New System.Drawing.Point(64, 261)
        Me.tbXoa.Name = "tbXoa"
        Me.tbXoa.Size = New System.Drawing.Size(75, 23)
        Me.tbXoa.TabIndex = 39
        Me.tbXoa.Text = "Xóa"
        Me.tbXoa.UseVisualStyleBackColor = True
        '
        'tbThem
        '
        Me.tbThem.Location = New System.Drawing.Point(64, 217)
        Me.tbThem.Name = "tbThem"
        Me.tbThem.Size = New System.Drawing.Size(75, 23)
        Me.tbThem.TabIndex = 38
        Me.tbThem.Text = "Thêm"
        Me.tbThem.UseVisualStyleBackColor = True
        '
        'tbSl
        '
        Me.tbSl.Location = New System.Drawing.Point(96, 134)
        Me.tbSl.Name = "tbSl"
        Me.tbSl.Size = New System.Drawing.Size(125, 20)
        Me.tbSl.TabIndex = 33
        '
        'tbSP
        '
        Me.tbSP.Location = New System.Drawing.Point(96, 107)
        Me.tbSP.Name = "tbSP"
        Me.tbSP.Size = New System.Drawing.Size(125, 20)
        Me.tbSP.TabIndex = 34
        '
        'lvChiTiet
        '
        Me.lvChiTiet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.clMa, Me.clTen, Me.clDiachi, Me.clSdt})
        Me.lvChiTiet.FullRowSelect = True
        Me.lvChiTiet.GridLines = True
        Me.lvChiTiet.Location = New System.Drawing.Point(271, 76)
        Me.lvChiTiet.Name = "lvChiTiet"
        Me.lvChiTiet.Size = New System.Drawing.Size(450, 347)
        Me.lvChiTiet.TabIndex = 40
        Me.lvChiTiet.UseCompatibleStateImageBehavior = False
        Me.lvChiTiet.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'clMa
        '
        Me.clMa.Text = "Mã"
        Me.clMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clMa.Width = 53
        '
        'clTen
        '
        Me.clTen.Text = "Hóa đơn"
        Me.clTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clTen.Width = 118
        '
        'clDiachi
        '
        Me.clDiachi.Text = "Sản phẩm"
        Me.clDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clDiachi.Width = 124
        '
        'clSdt
        '
        Me.clSdt.Text = "Số lượng"
        Me.clSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clSdt.Width = 91
        '
        'tbSua
        '
        Me.tbSua.Location = New System.Drawing.Point(64, 303)
        Me.tbSua.Name = "tbSua"
        Me.tbSua.Size = New System.Drawing.Size(75, 23)
        Me.tbSua.TabIndex = 37
        Me.tbSua.Text = "Sửa"
        Me.tbSua.UseVisualStyleBackColor = True
        '
        'tbMa
        '
        Me.tbMa.Location = New System.Drawing.Point(96, 54)
        Me.tbMa.Name = "tbMa"
        Me.tbMa.Size = New System.Drawing.Size(125, 20)
        Me.tbMa.TabIndex = 35
        '
        'tbHoaDon
        '
        Me.tbHoaDon.Location = New System.Drawing.Point(96, 80)
        Me.tbHoaDon.Name = "tbHoaDon"
        Me.tbHoaDon.Size = New System.Drawing.Size(125, 20)
        Me.tbHoaDon.TabIndex = 36
        '
        'lbSDT
        '
        Me.lbSDT.AutoSize = True
        Me.lbSDT.Location = New System.Drawing.Point(39, 137)
        Me.lbSDT.Name = "lbSDT"
        Me.lbSDT.Size = New System.Drawing.Size(49, 13)
        Me.lbSDT.TabIndex = 30
        Me.lbSDT.Text = "Số lượng"
        '
        'lbDiachi
        '
        Me.lbDiachi.AutoSize = True
        Me.lbDiachi.Location = New System.Drawing.Point(39, 110)
        Me.lbDiachi.Name = "lbDiachi"
        Me.lbDiachi.Size = New System.Drawing.Size(58, 13)
        Me.lbDiachi.TabIndex = 29
        Me.lbDiachi.Text = "Sản phẩm:"
        '
        'lbMa
        '
        Me.lbMa.AutoSize = True
        Me.lbMa.Location = New System.Drawing.Point(39, 57)
        Me.lbMa.Name = "lbMa"
        Me.lbMa.Size = New System.Drawing.Size(25, 13)
        Me.lbMa.TabIndex = 27
        Me.lbMa.Text = "Mã:"
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Location = New System.Drawing.Point(39, 83)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(52, 13)
        Me.lbTen.TabIndex = 28
        Me.lbTen.Text = "Hóa đơn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 26
        '
        'frmChiTIet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 477)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.tbXoa)
        Me.Controls.Add(Me.tbThem)
        Me.Controls.Add(Me.tbSl)
        Me.Controls.Add(Me.tbSP)
        Me.Controls.Add(Me.lvChiTiet)
        Me.Controls.Add(Me.tbSua)
        Me.Controls.Add(Me.tbMa)
        Me.Controls.Add(Me.tbHoaDon)
        Me.Controls.Add(Me.lbSDT)
        Me.Controls.Add(Me.lbDiachi)
        Me.Controls.Add(Me.lbMa)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChiTIet"
        Me.Text = "Chi tiết hóa đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents tbXoa As System.Windows.Forms.Button
    Friend WithEvents tbThem As System.Windows.Forms.Button
    Friend WithEvents tbSl As System.Windows.Forms.TextBox
    Friend WithEvents tbSP As System.Windows.Forms.TextBox
    Friend WithEvents lvChiTiet As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents clMa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbSua As System.Windows.Forms.Button
    Friend WithEvents tbMa As System.Windows.Forms.TextBox
    Friend WithEvents tbHoaDon As System.Windows.Forms.TextBox
    Friend WithEvents lbSDT As System.Windows.Forms.Label
    Friend WithEvents lbDiachi As System.Windows.Forms.Label
    Friend WithEvents lbMa As System.Windows.Forms.Label
    Friend WithEvents lbTen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
