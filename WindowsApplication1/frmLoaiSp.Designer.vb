<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSp
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
        Me.lvLoai = New System.Windows.Forms.ListView()
        Me.clStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clTenLoai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbTenLoai = New System.Windows.Forms.TextBox()
        Me.btLoadLoai = New System.Windows.Forms.Button()
        Me.btSuaLoai = New System.Windows.Forms.Button()
        Me.btXoaLoai = New System.Windows.Forms.Button()
        Me.btThemLoai = New System.Windows.Forms.Button()
        Me.lbTenLoai = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaLoai = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lvLoai
        '
        Me.lvLoai.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clStt, Me.ColumnHeader1, Me.clTenLoai})
        Me.lvLoai.FullRowSelect = True
        Me.lvLoai.GridLines = True
        Me.lvLoai.Location = New System.Drawing.Point(139, 71)
        Me.lvLoai.Name = "lvLoai"
        Me.lvLoai.Size = New System.Drawing.Size(259, 142)
        Me.lvLoai.TabIndex = 10
        Me.lvLoai.UseCompatibleStateImageBehavior = False
        Me.lvLoai.View = System.Windows.Forms.View.Details
        '
        'clStt
        '
        Me.clStt.Text = "STT"
        Me.clStt.Width = 64
        '
        'clTenLoai
        '
        Me.clTenLoai.Text = "Tên Loại"
        Me.clTenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clTenLoai.Width = 131
        '
        'tbTenLoai
        '
        Me.tbTenLoai.Location = New System.Drawing.Point(77, 22)
        Me.tbTenLoai.Name = "tbTenLoai"
        Me.tbTenLoai.Size = New System.Drawing.Size(100, 20)
        Me.tbTenLoai.TabIndex = 9
        '
        'btLoadLoai
        '
        Me.btLoadLoai.Location = New System.Drawing.Point(22, 190)
        Me.btLoadLoai.Name = "btLoadLoai"
        Me.btLoadLoai.Size = New System.Drawing.Size(75, 23)
        Me.btLoadLoai.TabIndex = 5
        Me.btLoadLoai.Text = "Load dữ liệu"
        Me.btLoadLoai.UseVisualStyleBackColor = True
        '
        'btSuaLoai
        '
        Me.btSuaLoai.Location = New System.Drawing.Point(22, 151)
        Me.btSuaLoai.Name = "btSuaLoai"
        Me.btSuaLoai.Size = New System.Drawing.Size(75, 23)
        Me.btSuaLoai.TabIndex = 6
        Me.btSuaLoai.Text = "Sửa"
        Me.btSuaLoai.UseVisualStyleBackColor = True
        '
        'btXoaLoai
        '
        Me.btXoaLoai.Location = New System.Drawing.Point(22, 111)
        Me.btXoaLoai.Name = "btXoaLoai"
        Me.btXoaLoai.Size = New System.Drawing.Size(75, 23)
        Me.btXoaLoai.TabIndex = 7
        Me.btXoaLoai.Text = "Xóa"
        Me.btXoaLoai.UseVisualStyleBackColor = True
        '
        'btThemLoai
        '
        Me.btThemLoai.Location = New System.Drawing.Point(22, 71)
        Me.btThemLoai.Name = "btThemLoai"
        Me.btThemLoai.Size = New System.Drawing.Size(75, 23)
        Me.btThemLoai.TabIndex = 8
        Me.btThemLoai.Text = "Thêm"
        Me.btThemLoai.UseVisualStyleBackColor = True
        '
        'lbTenLoai
        '
        Me.lbTenLoai.AutoSize = True
        Me.lbTenLoai.Location = New System.Drawing.Point(22, 25)
        Me.lbTenLoai.Name = "lbTenLoai"
        Me.lbTenLoai.Size = New System.Drawing.Size(52, 13)
        Me.lbTenLoai.TabIndex = 4
        Me.lbTenLoai.Text = "Tên Loại:"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã loại"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã Loại:"
        '
        'tbMaLoai
        '
        Me.tbMaLoai.Location = New System.Drawing.Point(251, 22)
        Me.tbMaLoai.Name = "tbMaLoai"
        Me.tbMaLoai.Size = New System.Drawing.Size(100, 20)
        Me.tbMaLoai.TabIndex = 9
        '
        'frmLoaiSp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 236)
        Me.Controls.Add(Me.lvLoai)
        Me.Controls.Add(Me.tbMaLoai)
        Me.Controls.Add(Me.tbTenLoai)
        Me.Controls.Add(Me.btLoadLoai)
        Me.Controls.Add(Me.btSuaLoai)
        Me.Controls.Add(Me.btXoaLoai)
        Me.Controls.Add(Me.btThemLoai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTenLoai)
        Me.Name = "frmLoaiSp"
        Me.Text = "Loại sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvLoai As System.Windows.Forms.ListView
    Friend WithEvents clStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clTenLoai As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbTenLoai As System.Windows.Forms.TextBox
    Friend WithEvents btLoadLoai As System.Windows.Forms.Button
    Friend WithEvents btSuaLoai As System.Windows.Forms.Button
    Friend WithEvents btXoaLoai As System.Windows.Forms.Button
    Friend WithEvents btThemLoai As System.Windows.Forms.Button
    Friend WithEvents lbTenLoai As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMaLoai As System.Windows.Forms.TextBox
End Class
