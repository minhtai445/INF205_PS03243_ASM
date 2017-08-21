
Imports System.Data.SqlClient
Imports System.Data
Public Class san_pham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=taitmps03243.mssql.somee.com;packet size=4096;user id=taitmps03243_SQLLogin_1;pwd=xqire1l7ph;data source=taitmps03243.mssql.somee.com;persist security info=False;initial catalog=taitmps03243"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btn_xem_Click(sender As Object, e As EventArgs) Handles btn_xem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.ID_SP as 'Mã sản phẩm',SAN_PHAM.TEN_SP as 'Tên sản phẩm', LOAI_SAN_PHAM.ID_LSP as 'Mã Loại', LOAI_SAN_PHAM.Loai_SP as 'Tên Loại' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.ID_LSP = LOAI_SAN_PHAM.ID_LSP where SAN_PHAM.ID_SP='" & tb_msp.Text & "' ", connect)
        Try
            If tb_msp.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgv_msp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgv_msp.DataSource = db.DefaultView
                    tb_msp.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    tb_msp.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_xemtc_Click(sender As Object, e As EventArgs) Handles Btn_xemtc.Click

        dgv_msp.DataSource = Loadsanpham.Tables(0)
    End Sub

    Private Sub san_pham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cnsp_Click(sender As Object, e As EventArgs) Handles btn_cnsp.Click
        cap_nhat_san_pham.Show()
    End Sub
End Class