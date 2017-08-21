<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap_nhat_KH
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
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.dgv_cn = New System.Windows.Forms.DataGridView()
        Me.bds = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_cn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(779, 118)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(106, 78)
        Me.btn_them.TabIndex = 0
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã khách hàng"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(249, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(460, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(249, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(460, 31)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SĐT"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(249, 171)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(460, 31)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(249, 239)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(460, 31)
        Me.TextBox4.TabIndex = 2
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(941, 118)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(106, 78)
        Me.btn_xoa.TabIndex = 0
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(1106, 118)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(106, 78)
        Me.btn_sua.TabIndex = 0
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'dgv_cn
        '
        Me.dgv_cn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cn.Location = New System.Drawing.Point(54, 337)
        Me.dgv_cn.Name = "dgv_cn"
        Me.dgv_cn.RowTemplate.Height = 33
        Me.dgv_cn.Size = New System.Drawing.Size(1187, 375)
        Me.dgv_cn.TabIndex = 3
        '
        'cap_nhat_KH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 762)
        Me.Controls.Add(Me.dgv_cn)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_them)
        Me.Name = "cap_nhat_KH"
        Me.Text = "Cập nhật Khách Hàng"
        CType(Me.dgv_cn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents dgv_cn As System.Windows.Forms.DataGridView
    Friend WithEvents bds As System.Windows.Forms.BindingSource
End Class
