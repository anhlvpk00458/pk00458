<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.btThem = New System.Windows.Forms.Button()
        Me.tbKhachMua = New System.Windows.Forms.TextBox()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btLoad = New System.Windows.Forms.Button()
        Me.tbMa = New System.Windows.Forms.TextBox()
        Me.lvHoaDon = New System.Windows.Forms.ListView()
        Me.clSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clKhachMua = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbMa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Khách mua :"
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(46, 98)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(61, 23)
        Me.btThem.TabIndex = 2
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'tbKhachMua
        '
        Me.tbKhachMua.Location = New System.Drawing.Point(83, 10)
        Me.tbKhachMua.Name = "tbKhachMua"
        Me.tbKhachMua.Size = New System.Drawing.Size(116, 20)
        Me.tbKhachMua.TabIndex = 3
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(46, 142)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(61, 23)
        Me.btXoa.TabIndex = 2
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(46, 182)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(61, 23)
        Me.btSua.TabIndex = 2
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(36, 222)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(80, 23)
        Me.btLoad.TabIndex = 2
        Me.btLoad.Text = "Load dữ liệu"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'tbMa
        '
        Me.tbMa.Location = New System.Drawing.Point(83, 41)
        Me.tbMa.Name = "tbMa"
        Me.tbMa.Size = New System.Drawing.Size(116, 20)
        Me.tbMa.TabIndex = 3
        '
        'lvHoaDon
        '
        Me.lvHoaDon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSTT, Me.ColumnHeader1, Me.clKhachMua})
        Me.lvHoaDon.FullRowSelect = True
        Me.lvHoaDon.GridLines = True
        Me.lvHoaDon.Location = New System.Drawing.Point(183, 79)
        Me.lvHoaDon.Name = "lvHoaDon"
        Me.lvHoaDon.Size = New System.Drawing.Size(279, 183)
        Me.lvHoaDon.TabIndex = 4
        Me.lvHoaDon.UseCompatibleStateImageBehavior = False
        Me.lvHoaDon.View = System.Windows.Forms.View.Details
        '
        'clSTT
        '
        Me.clSTT.Text = "STT"
        Me.clSTT.Width = 37
        '
        'clKhachMua
        '
        Me.clKhachMua.DisplayIndex = 2
        Me.clKhachMua.Text = "Khách mua"
        Me.clKhachMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clKhachMua.Width = 164
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Mã hóa đơn"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 73
        '
        'lbMa
        '
        Me.lbMa.AutoSize = True
        Me.lbMa.Location = New System.Drawing.Point(12, 41)
        Me.lbMa.Name = "lbMa"
        Me.lbMa.Size = New System.Drawing.Size(67, 13)
        Me.lbMa.TabIndex = 0
        Me.lbMa.Text = "Mã Hóa đơn"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 297)
        Me.Controls.Add(Me.lvHoaDon)
        Me.Controls.Add(Me.tbMa)
        Me.Controls.Add(Me.tbKhachMua)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.lbMa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btThem As System.Windows.Forms.Button
    Friend WithEvents tbKhachMua As System.Windows.Forms.TextBox
    Friend WithEvents btXoa As System.Windows.Forms.Button
    Friend WithEvents btSua As System.Windows.Forms.Button
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents tbMa As System.Windows.Forms.TextBox
    Friend WithEvents lvHoaDon As System.Windows.Forms.ListView
    Friend WithEvents clSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clKhachMua As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbMa As System.Windows.Forms.Label
End Class
