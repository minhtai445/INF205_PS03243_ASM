
Imports System.Data.SqlClient
Imports System.Data
Public Class khach_hang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=taitmps03243.mssql.somee.com;packet size=4096;user id=taitmps03243_SQLLogin_1;pwd=xqire1l7ph;data source=taitmps03243.mssql.somee.com;persist security info=False;initial catalog=taitmps03243"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_ma.TextChanged

    End Sub

    Private Sub tbn_xem_click(sender As Object, e As EventArgs) Handles tbn_xem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select ID_KH as 'Mã KH' ,Ten_KH as 'Tên Khách Hàng', DChi_KH as 'Địa chỉ', SDT_KH as 'SĐT' from Khach_Hang where ID_KH='" & tb_ma.Text & "'", connect)
        Try
            If tb_ma.Text = "" Then
                MessageBox.Show("Bạn cần nhập ID_KH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgv_kh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgv_kh.DataSource = db.DefaultView
                    tb_ma.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    tb_ma.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub dgv_kh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_kh.CellContentClick

    End Sub




    Private Sub tbn_xemtc_Click(sender As Object, e As EventArgs) Handles tbn_xemtc.Click
        dgv_kh.DataSource = Loadkhachang.Tables(0)
    End Sub

    Private Sub tbn_cnkh_Click(sender As Object, e As EventArgs) Handles tbn_cnkh.Click
        cap_nhat_KH.Show()
    End Sub

    Private Sub khach_hang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class