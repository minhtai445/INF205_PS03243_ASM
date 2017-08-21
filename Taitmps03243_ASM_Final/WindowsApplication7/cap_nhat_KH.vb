Public Class cap_nhat_KH
    Private Sub Fillkhachhang()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACH_HANG
            </sql>
        Fill(Sql, "khach_hang")
        bds.DataSource = ds.Tables("khach_hang")
        dgv_cn.DataSource = bds
        bds.ResetBindings(False)
    End Sub
    Private Sub cap_nhat_KH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillkhachhang()
    End Sub


    Private Sub dgv_cn_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_cn.SelectionChanged
        Try
            Dim RowView As DataRowView = bds.Current
            Dim Row As DataRow = RowView.Row

            TextBox1.Text = Row("ID_KH")
            TextBox2.Text = Row("TEN_KH")
            TextBox3.Text = Row("DCHI_KH")
            TextBox4.Text = Row("SDT_KH")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim Sql As String =
                 <sql>
                        INSERT INTO KHACH_HANG (ID_KH, TEN_KH, DCHI_KH, SDT_KH)
                        VALUES (N'{0}', N'{1}', N'{2}', N'{3}')
                    </sql>
        Sql = String.Format(Sql, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)

        ExecuteNonQuery(Sql)

        Fillkhachhang()
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim Sql As String = <sql>
                                DELETE FROM KHACH_HANG
                                WHERE        (ID_kh = N'{0}')
                            </sql>
        Sql = String.Format(Sql, TextBox1.Text)
        ExecuteNonQuery(Sql)

        Fillkhachhang()
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim Sql As String =
                 <sql>
                        UPDATE KHACH_HANG
                        SET  ten_KH = N'{0}', DCHI_KH = '{1}', SDT_KH = '{2}'
                        WHERE ID_KH = N'{3}'
                    </sql>
        Sql = String.Format(Sql, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox1.Text)

        ExecuteNonQuery(Sql)

        Fillkhachhang()
    End Sub

End Class