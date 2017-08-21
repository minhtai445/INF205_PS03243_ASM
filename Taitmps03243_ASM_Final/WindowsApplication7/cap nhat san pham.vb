
Imports System.Data.SqlClient
Imports System.Data
Public Class cap_nhat_san_pham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=taitmps03243.mssql.somee.com;packet size=4096;user id=taitmps03243_SQLLogin_1;pwd=xqire1l7ph;data source=taitmps03243.mssql.somee.com;persist security info=False;initial catalog=taitmps03243"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub cap_nhat_san_pham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSANPHAM()
    End Sub
    Private Sub FillSANPHAM()
        Dim Sql As String =
            <sql>
  
            select SAN_PHAM.ID_SP, SAN_PHAM.TEN_SP, LOAI_SAN_PHAM.ID_LSP, LOAI_SAN_PHAM.Loai_SP,san_pham.gia_SP from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.ID_LSP = LOAI_SAN_PHAM.ID_LSP
            </sql>
        Fill(Sql, "SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.ID_LSP = LOAI_SAN_PHAM.ID_LSP")
        bds.DataSource = ds.Tables("SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.ID_LSP = LOAI_SAN_PHAM.ID_LSP")
        dgv_cnsp.DataSource = bds()
        bds.ResetBindings(False)
    End Sub
    Private Sub dgv_cnsp_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_cnsp.SelectionChanged
        Try
            Dim RowView As DataRowView = bds.Current
            Dim Row As DataRow = RowView.Row

            tbt_masp.Text = Row("ID_SP")
            tbt_tensp.Text = Row("TEN_SP")
            tbt_maloai.Text = Row("ID_LSP")
            tbt_tenloai.Text = Row("loai_SP")
            tbt_giá.Text = Row("gia_SP")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
       
        Dim Sql As String =
                  <sql>
                       INSERT INTO LOAI_SAN_PHAM (ID_LSP, LOAI_SP)
                      VALUES (N'{0}', N'{1}')
                 </sql>
        Sql = String.Format(Sql, tbt_maloai.Text, tbt_tenloai.Text)

        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
                   <sql>
                        INSERT INTO SAN_PHAM (ID_SP, Ten_SP, ID_LSP, LOAI_SP,gia_SP)
                        VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')
                    </sql>
        Sql1 = String.Format(Sql1, tbt_masp.Text, tbt_tensp.Text, tbt_maloai.Text, tbt_tenloai, tbt_giá)

        ExecuteNonQuery(Sql1)

        FillSANPHAM()
    End Sub


    

  
    Private Sub Btn_xoa_Click(sender As Object, e As EventArgs) Handles Btn_xoa.Click
        Dim Sql As String = <SQL>
            DELETE FROM SAN_PHAM  
                WHERE        (ID_LSP = N'{0}')
        </SQL>
        Sql = String.Format(Sql, tbt_maloai.Text)

        ExecuteNonQuery(Sql)

        FillSANPHAM()
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim Sql As String =
                   <sql>
                        UPDATE SANPHAM
                        SET ID_SP = N'{0}', ten_SP = N'{1}', loai_PS = '{2}', gia_SP= '{3}'
                        WHERE ID_LSP = N'{4}'
                    </sql>
        Sql = String.Format(Sql, tbt_masp.Text, tbt_tensp.Text, tbt_tenloai, tbt_giá, tbt_maloai.Text)

        ExecuteNonQuery(Sql)

        FillSANPHAM()
    End Sub
End Class