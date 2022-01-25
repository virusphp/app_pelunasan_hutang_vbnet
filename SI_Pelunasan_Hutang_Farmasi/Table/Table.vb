Public Class Table

    Public Shared Function BuatTabelPelunasanHutang(Optional ByVal NamaTabel As String = "Table1") As DataSet
        Dim dsLunas As DataSet = New DataSet
        Dim dtLunas As DataTable = New DataTable(NamaTabel)
        Dim nmSupplier As New DataColumn("nmSupplier")
        Dim tglFaktur As New DataColumn("tglFaktur")
        Dim noFaktur As New DataColumn("noFaktur")
        Dim a2 As New DataColumn("a2")
        Dim jmlBayar As New DataColumn("jmlBayar")
        Dim notaBeli As New DataColumn("notaBeli")
        Dim kdSuplier As New DataColumn("kdSuplier")
        Try
            nmSupplier.DataType = GetType(String)
            tglFaktur.DataType = GetType(DateTime)
            noFaktur.DataType = GetType(String)
            a2.DataType = GetType(String)
            jmlBayar.DataType = GetType(Decimal)
            notaBeli.DataType = GetType(String)
            kdSuplier.DataType = GetType(String)
            With dsLunas
                .Tables.Add(dtLunas)
                .Tables(0).Columns.Add(nmSupplier)
                .Tables(0).Columns.Add(tglFaktur)
                .Tables(0).Columns.Add(noFaktur)
                .Tables(0).Columns.Add(a2)
                .Tables(0).Columns.Add(jmlBayar)
                .Tables(0).Columns.Add(notaBeli)
                .Tables(0).Columns.Add(kdSuplier)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ExecuteQuery")
        End Try
        Return dsLunas
    End Function

End Class
