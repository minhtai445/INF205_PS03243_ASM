<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap_nhat_san_pham
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
        Me.components = New System.ComponentModel.Container()
        Me.tbt_masp = New System.Windows.Forms.TextBox()
        Me.lbl_msp = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.tbt_tensp = New System.Windows.Forms.TextBox()
        Me.lbl_tensp = New System.Windows.Forms.Label()
        Me.tbt_maloai = New System.Windows.Forms.TextBox()
        Me.lbl_maloai = New System.Windows.Forms.Label()
        Me.tbt_tenloai = New System.Windows.Forms.TextBox()
        Me.lbl_tenloai = New System.Windows.Forms.Label()
        Me.dgv_cnsp = New System.Windows.Forms.DataGridView()
        Me.Btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.bds = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbt_giá = New System.Windows.Forms.TextBox()
        Me.Giá = New System.Windows.Forms.Label()
        CType(Me.dgv_cnsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbt_masp
        '
        Me.tbt_masp.Location = New System.Drawing.Point(215, 52)
        Me.tbt_masp.Name = "tbt_masp"
        Me.tbt_masp.Size = New System.Drawing.Size(432, 31)
        Me.tbt_masp.TabIndex = 0
        '
        'lbl_msp
        '
        Me.lbl_msp.AutoSize = True
        Me.lbl_msp.Location = New System.Drawing.Point(64, 52)
        Me.lbl_msp.Name = "lbl_msp"
        Me.lbl_msp.Size = New System.Drawing.Size(76, 25)
        Me.lbl_msp.TabIndex = 1
        Me.lbl_msp.Text = "Mã SP"
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(702, 119)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(83, 61)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'tbt_tensp
        '
        Me.tbt_tensp.Location = New System.Drawing.Point(215, 103)
        Me.tbt_tensp.Name = "tbt_tensp"
        Me.tbt_tensp.Size = New System.Drawing.Size(432, 31)
        Me.tbt_tensp.TabIndex = 0
        '
        'lbl_tensp
        '
        Me.lbl_tensp.AutoSize = True
        Me.lbl_tensp.Location = New System.Drawing.Point(64, 103)
        Me.lbl_tensp.Name = "lbl_tensp"
        Me.lbl_tensp.Size = New System.Drawing.Size(83, 25)
        Me.lbl_tensp.TabIndex = 1
        Me.lbl_tensp.Text = "Tên SP"
        '
        'tbt_maloai
        '
        Me.tbt_maloai.Location = New System.Drawing.Point(215, 155)
        Me.tbt_maloai.Name = "tbt_maloai"
        Me.tbt_maloai.Size = New System.Drawing.Size(432, 31)
        Me.tbt_maloai.TabIndex = 0
        '
        'lbl_maloai
        '
        Me.lbl_maloai.AutoSize = True
        Me.lbl_maloai.Location = New System.Drawing.Point(64, 155)
        Me.lbl_maloai.Name = "lbl_maloai"
        Me.lbl_maloai.Size = New System.Drawing.Size(89, 25)
        Me.lbl_maloai.TabIndex = 1
        Me.lbl_maloai.Text = "Mã Loại"
        '
        'tbt_tenloai
        '
        Me.tbt_tenloai.Location = New System.Drawing.Point(215, 207)
        Me.tbt_tenloai.Name = "tbt_tenloai"
        Me.tbt_tenloai.Size = New System.Drawing.Size(432, 31)
        Me.tbt_tenloai.TabIndex = 0
        '
        'lbl_tenloai
        '
        Me.lbl_tenloai.AutoSize = True
        Me.lbl_tenloai.Location = New System.Drawing.Point(64, 207)
        Me.lbl_tenloai.Name = "lbl_tenloai"
        Me.lbl_tenloai.Size = New System.Drawing.Size(89, 25)
        Me.lbl_tenloai.TabIndex = 1
        Me.lbl_tenloai.Text = "Tên loại"
        '
        'dgv_cnsp
        '
        Me.dgv_cnsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cnsp.Location = New System.Drawing.Point(69, 338)
        Me.dgv_cnsp.Name = "dgv_cnsp"
        Me.dgv_cnsp.RowTemplate.Height = 33
        Me.dgv_cnsp.Size = New System.Drawing.Size(990, 379)
        Me.dgv_cnsp.TabIndex = 3
        '
        'Btn_xoa
        '
        Me.Btn_xoa.Location = New System.Drawing.Point(825, 119)
        Me.Btn_xoa.Name = "Btn_xoa"
        Me.Btn_xoa.Size = New System.Drawing.Size(89, 61)
        Me.Btn_xoa.TabIndex = 2
        Me.Btn_xoa.Text = "Xóa"
        Me.Btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(956, 119)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(88, 61)
        Me.btn_sua.TabIndex = 2
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'tbt_giá
        '
        Me.tbt_giá.Location = New System.Drawing.Point(215, 259)
        Me.tbt_giá.Name = "tbt_giá"
        Me.tbt_giá.Size = New System.Drawing.Size(432, 31)
        Me.tbt_giá.TabIndex = 0
        '
        'Giá
        '
        Me.Giá.AutoSize = True
        Me.Giá.Location = New System.Drawing.Point(64, 259)
        Me.Giá.Name = "Giá"
        Me.Giá.Size = New System.Drawing.Size(45, 25)
        Me.Giá.TabIndex = 1
        Me.Giá.Text = "Giá"
        '
        'cap_nhat_san_pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 753)
        Me.Controls.Add(Me.dgv_cnsp)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.Btn_xoa)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.Giá)
        Me.Controls.Add(Me.lbl_tenloai)
        Me.Controls.Add(Me.lbl_tensp)
        Me.Controls.Add(Me.tbt_giá)
        Me.Controls.Add(Me.tbt_tenloai)
        Me.Controls.Add(Me.tbt_tensp)
        Me.Controls.Add(Me.lbl_maloai)
        Me.Controls.Add(Me.tbt_maloai)
        Me.Controls.Add(Me.lbl_msp)
        Me.Controls.Add(Me.tbt_masp)
        Me.Name = "cap_nhat_san_pham"
        Me.Text = "Cập nhật sản phẩm"
        CType(Me.dgv_cnsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbt_masp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_msp As System.Windows.Forms.Label
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents tbt_tensp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tensp As System.Windows.Forms.Label
    Friend WithEvents tbt_maloai As System.Windows.Forms.TextBox
    Friend WithEvents lbl_maloai As System.Windows.Forms.Label
    Friend WithEvents tbt_tenloai As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tenloai As System.Windows.Forms.Label
    Friend WithEvents dgv_cnsp As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents bds As System.Windows.Forms.BindingSource
    Friend WithEvents tbt_giá As System.Windows.Forms.TextBox
    Friend WithEvents Giá As System.Windows.Forms.Label
End Class
