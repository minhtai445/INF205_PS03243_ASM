<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class khach_hang
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
        Me.lbl_mkh = New System.Windows.Forms.Label()
        Me.tb_ma = New System.Windows.Forms.TextBox()
        Me.tbn_xem = New System.Windows.Forms.Button()
        Me.tbn_xemtc = New System.Windows.Forms.Button()
        Me.dgv_kh = New System.Windows.Forms.DataGridView()
        Me.tbn_cnkh = New System.Windows.Forms.Button()
        CType(Me.dgv_kh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_mkh
        '
        Me.lbl_mkh.Location = New System.Drawing.Point(56, 51)
        Me.lbl_mkh.Name = "lbl_mkh"
        Me.lbl_mkh.Size = New System.Drawing.Size(203, 41)
        Me.lbl_mkh.TabIndex = 0
        Me.lbl_mkh.Text = "Mã Khách Hàng"
        '
        'tb_ma
        '
        Me.tb_ma.Location = New System.Drawing.Point(289, 51)
        Me.tb_ma.Name = "tb_ma"
        Me.tb_ma.Size = New System.Drawing.Size(322, 31)
        Me.tb_ma.TabIndex = 1
        '
        'tbn_xem
        '
        Me.tbn_xem.Location = New System.Drawing.Point(677, 51)
        Me.tbn_xem.Name = "tbn_xem"
        Me.tbn_xem.Size = New System.Drawing.Size(174, 41)
        Me.tbn_xem.TabIndex = 2
        Me.tbn_xem.Text = "Xem"
        Me.tbn_xem.UseVisualStyleBackColor = True
        '
        'tbn_xemtc
        '
        Me.tbn_xemtc.Location = New System.Drawing.Point(912, 51)
        Me.tbn_xemtc.Name = "tbn_xemtc"
        Me.tbn_xemtc.Size = New System.Drawing.Size(187, 41)
        Me.tbn_xemtc.TabIndex = 2
        Me.tbn_xemtc.Text = "Xem tất cả"
        Me.tbn_xemtc.UseVisualStyleBackColor = True
        '
        'dgv_kh
        '
        Me.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kh.Location = New System.Drawing.Point(61, 149)
        Me.dgv_kh.Name = "dgv_kh"
        Me.dgv_kh.RowTemplate.Height = 33
        Me.dgv_kh.Size = New System.Drawing.Size(1038, 504)
        Me.dgv_kh.TabIndex = 3
        '
        'tbn_cnkh
        '
        Me.tbn_cnkh.ForeColor = System.Drawing.SystemColors.Highlight
        Me.tbn_cnkh.Location = New System.Drawing.Point(930, 690)
        Me.tbn_cnkh.Name = "tbn_cnkh"
        Me.tbn_cnkh.Size = New System.Drawing.Size(258, 41)
        Me.tbn_cnkh.TabIndex = 4
        Me.tbn_cnkh.Text = "Cập nhật khách hàng"
        Me.tbn_cnkh.UseVisualStyleBackColor = True
        '
        'khach_hang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 743)
        Me.Controls.Add(Me.tbn_cnkh)
        Me.Controls.Add(Me.dgv_kh)
        Me.Controls.Add(Me.tbn_xemtc)
        Me.Controls.Add(Me.tbn_xem)
        Me.Controls.Add(Me.tb_ma)
        Me.Controls.Add(Me.lbl_mkh)
        Me.Name = "khach_hang"
        Me.Text = "Khách Hàng"
        CType(Me.dgv_kh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_mkh As System.Windows.Forms.Label
    Friend WithEvents tb_ma As System.Windows.Forms.TextBox
    Friend WithEvents tbn_xem As System.Windows.Forms.Button
    Friend WithEvents tbn_xemtc As System.Windows.Forms.Button
    Friend WithEvents dgv_kh As System.Windows.Forms.DataGridView
    Friend WithEvents tbn_cnkh As System.Windows.Forms.Button
End Class
