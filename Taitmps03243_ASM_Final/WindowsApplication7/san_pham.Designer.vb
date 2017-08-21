<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class san_pham
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
        Me.lbl_masp = New System.Windows.Forms.Label()
        Me.tb_msp = New System.Windows.Forms.TextBox()
        Me.btn_xem = New System.Windows.Forms.Button()
        Me.dgv_msp = New System.Windows.Forms.DataGridView()
        Me.Btn_xemtc = New System.Windows.Forms.Button()
        Me.btn_cnsp = New System.Windows.Forms.Button()
        CType(Me.dgv_msp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_masp
        '
        Me.lbl_masp.AutoSize = True
        Me.lbl_masp.Location = New System.Drawing.Point(51, 44)
        Me.lbl_masp.Name = "lbl_masp"
        Me.lbl_masp.Size = New System.Drawing.Size(142, 25)
        Me.lbl_masp.TabIndex = 0
        Me.lbl_masp.Text = "Mã sản phẩm"
        '
        'tb_msp
        '
        Me.tb_msp.Location = New System.Drawing.Point(239, 38)
        Me.tb_msp.Name = "tb_msp"
        Me.tb_msp.Size = New System.Drawing.Size(427, 31)
        Me.tb_msp.TabIndex = 1
        '
        'btn_xem
        '
        Me.btn_xem.Location = New System.Drawing.Point(738, 32)
        Me.btn_xem.Name = "btn_xem"
        Me.btn_xem.Size = New System.Drawing.Size(128, 42)
        Me.btn_xem.TabIndex = 2
        Me.btn_xem.Text = "Xem"
        Me.btn_xem.UseVisualStyleBackColor = True
        '
        'dgv_msp
        '
        Me.dgv_msp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_msp.Location = New System.Drawing.Point(56, 113)
        Me.dgv_msp.Name = "dgv_msp"
        Me.dgv_msp.RowTemplate.Height = 33
        Me.dgv_msp.Size = New System.Drawing.Size(1045, 484)
        Me.dgv_msp.TabIndex = 3
        '
        'Btn_xemtc
        '
        Me.Btn_xemtc.Location = New System.Drawing.Point(951, 32)
        Me.Btn_xemtc.Name = "Btn_xemtc"
        Me.Btn_xemtc.Size = New System.Drawing.Size(146, 42)
        Me.Btn_xemtc.TabIndex = 2
        Me.Btn_xemtc.Text = "Xem Tất Cả"
        Me.Btn_xemtc.UseVisualStyleBackColor = True
        '
        'btn_cnsp
        '
        Me.btn_cnsp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cnsp.Location = New System.Drawing.Point(887, 624)
        Me.btn_cnsp.Name = "btn_cnsp"
        Me.btn_cnsp.Size = New System.Drawing.Size(236, 37)
        Me.btn_cnsp.TabIndex = 4
        Me.btn_cnsp.Text = "Cập nhật sản phẩm"
        Me.btn_cnsp.UseVisualStyleBackColor = True
        '
        'san_pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 673)
        Me.Controls.Add(Me.btn_cnsp)
        Me.Controls.Add(Me.dgv_msp)
        Me.Controls.Add(Me.Btn_xemtc)
        Me.Controls.Add(Me.btn_xem)
        Me.Controls.Add(Me.tb_msp)
        Me.Controls.Add(Me.lbl_masp)
        Me.Name = "san_pham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgv_msp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_masp As System.Windows.Forms.Label
    Friend WithEvents tb_msp As System.Windows.Forms.TextBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_msp.TextChanged

    End Sub
    Friend WithEvents btn_xem As System.Windows.Forms.Button
    Friend WithEvents dgv_msp As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_xemtc As System.Windows.Forms.Button
    Friend WithEvents btn_cnsp As System.Windows.Forms.Button
End Class
