Imports System.Data.SqlClient
Module Module1
    Dim chuoiketnoi As String = "workstation id=taitmps03243.mssql.somee.com;packet size=4096;user id=taitmps03243_SQLLogin_1;pwd=xqire1l7ph;data source=taitmps03243.mssql.somee.com;persist security info=False;initial catalog=taitmps03243"
    Public User As DataRow

    Public ds As New DataSet()
    Public Function Loadkhachang() As DataSet
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select ID_KH as 'Mã KH' ,Ten_KH as 'Tên Khách Hàng', DChi_KH as 'Địa chỉ', SDT_KH as 'SĐT' from Khach_Hang", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadsanpham() As DataSet
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SAN_PHAM.ID_SP as 'Mã sản phẩm',SAN_PHAM.TEN_SP as 'Tên sản phẩm', LOAI_SAN_PHAM.ID_LSP as 'Mã Loại', LOAI_SAN_PHAM.Loai_SP as 'Tên Loại' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.ID_LSP = LOAI_SAN_PHAM.ID_LSP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Sub ExecuteNonQuery(sql As String)
        Dim Connection As New SqlConnection(chuoiketnoi)
        Dim Command As New SqlCommand(sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()

    End Sub
    Public Sub Fill(Sql As String, tablename As String)
        Dim Connection As New SqlConnection(chuoiketnoi)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub
End Module
