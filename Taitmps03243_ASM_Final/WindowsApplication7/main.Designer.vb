<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.tbn_kh = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbn_kh
        '
        Me.tbn_kh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbn_kh.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbn_kh.Location = New System.Drawing.Point(97, 86)
        Me.tbn_kh.Name = "tbn_kh"
        Me.tbn_kh.Size = New System.Drawing.Size(289, 133)
        Me.tbn_kh.TabIndex = 0
        Me.tbn_kh.Text = "Khách Hàng"
        Me.tbn_kh.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(463, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(289, 133)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Sản Phẩm"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(880, 354)
        Me.Controls.Add(Me.tbn_kh)
        Me.Controls.Add(Me.Button4)
        Me.Name = "main"
        Me.Text = "Quản Lý Bán Hàng"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbn_kh As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
