Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class FormLaporanTandaTerima
    Inherits MetroForm
    Dim BDLaporan As New BindingSource

    Sub Kosongkan()
        TglServer()
        DTPTanggalAwalTab1.Value = TanggalServer
        DTPTanggalAkhirTab1.Value = TanggalServer
        GridLaporan.DataSource = Nothing
        gridKosong()
        cmbSupplier.Text = ""
        cmbSupplier.Enabled = False
        cmbJenisBarang.Text = ""
        cmbJenisBarang.Enabled = False
        cmbStsDifakturkan.Enabled = False
        cmbStsDifakturkan.Text = ""
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        btnBaruTab1.Enabled = False
        btnExcelTab1.Enabled = False
        btnProsesTab1.Enabled = True
        DTPTanggalAwalTab1.Focus()
    End Sub

    Sub gridKosong()
        With GridLaporan
            .Columns.Add("0", "Tanggal")
            .Columns(0).Width = 75
            .Columns.Add("1", "No Terima")
            .Columns(1).Width = 85
            .Columns.Add("2", "Nama Supplier")
            .Columns(2).Width = 200
            .Columns.Add("3", "No Tanda Terima")
            .Columns(3).Width = 85
            .Columns.Add("4", "Nama Barang")
            .Columns(4).Width = 200
            .Columns.Add("5", "Jumlah (Satuan Besar)")
            .Columns(5).Width = 80
            .Columns.Add("6", "Satuan")
            .Columns(6).Width = 80
            .Columns.Add("7", "Jumlah (Satuan Kecil")
            .Columns(7).Width = 80
            .Columns.Add("8", "Satuan")
            .Columns(8).Width = 80
            .Columns.Add("9", "Harga")
            .Columns(9).Width = 80
            .Columns.Add("10", "Jumlah Harga")
            .Columns(10).Width = 80
            .Columns.Add("11", "Tanggal EXP")
            .Columns(11).Width = 75
            .Columns.Add("12", "No Batch")
            .Columns(12).Width = 75
            .Columns.Add("13", "Status Difakturkan")
            .Columns(13).Width = 70
        End With
    End Sub

    Sub tampilLaporan()
        Try
            konek()
            DA = New SqlDataAdapter("SELECT tanggal, noterima, RTRIM(LTRIM(nmsuplier)) AS nmsuplier, notatt, RTRIM(LTRIM(nama_barang)) AS nama_barang, jmlbeli1, RTRIM(LTRIM(satuan1)) AS satuan1, jmlbeli, RTRIM(LTRIM(satuan)) AS satuan, hrgnet, jmlbeli*hrgnet AS jmlhrg, tglexp, RTRIM(LTRIM(nobatch)) AS nobatch, CASE stsdifakturkan WHEN '1' THEN 'Belum' ELSE 'Sudah' END AS stsdifakturkan, nofaktur, kd_jns_obat, kdsuplier from ap_belitt WHERE tanggal>='" & Format(DTPTanggalAwalTab1.Value, "yyyy/MM/dd") & "' and tanggal<='" & Format(DTPTanggalAkhirTab1.Value, "yyyy/MM/dd") & "' order by tanggal, kdsuplier, noterima", CONN)
            DS = New DataSet
            DA.Fill(DS, "Laporan")
            BDLaporan.DataSource = DS
            BDLaporan.DataMember = "Laporan"
            With GridLaporan
                .Columns.Clear()
                .DataSource = Nothing
                .DataSource = BDLaporan
                .Columns(0).HeaderText = "Tanggal"
                .Columns(0).Width = 75
                .Columns(1).HeaderText = "No Terima"
                .Columns(1).Width = 85
                .Columns(2).HeaderText = "Nama Supplier"
                .Columns(2).Width = 200
                .Columns(3).HeaderText = "No Tanda Terima"
                .Columns(3).Width = 85
                .Columns(4).HeaderText = "Nama Barang"
                .Columns(4).Width = 200
                .Columns(5).HeaderText = "Jumlah (Satuan Besar)"
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).Width = 80
                .Columns(6).HeaderText = "Satuan"
                .Columns(6).Width = 80
                .Columns(7).HeaderText = "Jumlah (Satuan Kecil)"
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).Width = 80
                .Columns(8).HeaderText = "Satuan"
                .Columns(8).Width = 80
                .Columns(9).HeaderText = "Harga"
                .Columns(9).DefaultCellStyle.Format = "N2"
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(9).Width = 80
                .Columns(10).HeaderText = "Jumlah Harga"
                .Columns(10).DefaultCellStyle.Format = "N2"
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).Width = 80
                .Columns(11).HeaderText = "Tanggal EXP"
                .Columns(11).Width = 75
                .Columns(12).HeaderText = "No Batch"
                .Columns(12).Width = 75
                .Columns(13).HeaderText = "Status Difakturkan"
                .Columns(13).Width = 70
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .ReadOnly = True
                TotalHarga()
                BDLaporan.RemoveFilter()
            End With
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TotalHarga()
        txtQty.DecimalValue = GridLaporan.Rows.Count() - 1
        Dim HitungTotal As Decimal = 0
        For baris As Integer = 0 To GridLaporan.RowCount - 1
            HitungTotal = HitungTotal + GridLaporan.Rows(baris).Cells("jmlhrg").Value
        Next
        txtTotalHarga.DecimalValue = HitungTotal
    End Sub
    Sub ListSupllier()
        konek()
        DA = New SqlDataAdapter("Select nmsuplier, kdsuplier from ap_suplier order by nmsuplier", CONN)
        DT = New DataTable
        DA.Fill(DT)
        cmbSupplier.DataSource = DT
        cmbSupplier.DisplayMember = "nmsuplier"
        cmbSupplier.ValueMember = "kdsuplier"
        cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Sub ListJenisBarang()
        konek()
        DA = New SqlDataAdapter("select jns_obat, kd_jns_obat from Jenis_Obat where stsaktif=1", CONN)
        DT = New DataTable
        DA.Fill(DT)
        cmbJenisBarang.DataSource = DT
        cmbJenisBarang.DisplayMember = "jns_obat"
        cmbJenisBarang.ValueMember = "kd_jns_obat"
        cmbJenisBarang.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbJenisBarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Sub GridWarna()
        For i As Integer = 0 To GridLaporan.RowCount - 1
            If GridLaporan.Rows(i).Cells("stsdifakturkan").Value = "Belum" Then
                GridLaporan.Rows(i).Cells("tanggal").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("noterima").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("nmsuplier").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("notatt").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("nama_barang").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("jmlbeli1").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("satuan1").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("jmlbeli").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("satuan").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("hrgnet").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("jmlhrg").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("tglexp").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("nobatch").Style.BackColor = Color.Aquamarine
                GridLaporan.Rows(i).Cells("stsdifakturkan").Style.BackColor = Color.Aquamarine
            End If
        Next
    End Sub

    Private Sub FromLaporanTandaTerima_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub FromLaporanTandaTerima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListSupllier()
        ListJenisBarang()
        Kosongkan()
    End Sub

    Private Sub btnProsesTab1_Click(sender As Object, e As EventArgs) Handles btnProsesTab1.Click
        tampilLaporan()
        GridWarna()
        cmbSupplier.Enabled = True
        cmbJenisBarang.Enabled = True
        cmbStsDifakturkan.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        btnExcelTab1.Enabled = True
        btnProsesTab1.Enabled = False
        btnBaruTab1.Enabled = True
    End Sub

    Private Sub btnBaruTab1_Click(sender As Object, e As EventArgs) Handles btnBaruTab1.Click
        Kosongkan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbSupplier.Text <> "" Then
            BDLaporan.RemoveFilter()
            BDLaporan.Filter = "kdsuplier = '" & Trim(cmbSupplier.SelectedValue.ToString) & "'"
            TotalHarga()
            GridWarna()
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BDLaporan.Filter = "kd_jns_obat = '" & Trim(cmbJenisBarang.SelectedValue.ToString) & "'"
        TotalHarga()
        GridWarna()
        MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmbJenisBarang.Text = ""
        cmbSupplier.Text = ""
        cmbStsDifakturkan.Text = ""
        BDLaporan.RemoveFilter()
        TotalHarga()
        GridWarna()
    End Sub

    Private Sub btnExcelTab1_Click(sender As Object, e As EventArgs) Handles btnExcelTab1.Click
        If MessageBox.Show("Apakah data akan di eksport ke excel?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim dtXls As New DataTable
                With dtXls
                    .Columns.Add("tanggal")
                    .Columns.Add("noterima")
                    .Columns.Add("nmsuplier")
                    .Columns.Add("notatt")
                    .Columns.Add("nama_barang")
                    .Columns.Add("jmlbeli1")
                    .Columns.Add("satuan1")
                    .Columns.Add("jmlbeli")
                    .Columns.Add("satuan")
                    .Columns.Add("hrgnet")
                    .Columns.Add("jmlhrg")
                    .Columns.Add("tglexp")
                    .Columns.Add("nobatch")
                    .Columns.Add("stsdifakturkan")
                End With

                For i = 0 To GridLaporan.RowCount - 2
                    If Not IsDBNull(GridLaporan.Rows(i).Cells(0).Value) Then
                        dtXls.Rows.Add(GridLaporan.Rows(i).Cells("tanggal").Value, GridLaporan.Rows(i).Cells("noterima").Value, GridLaporan.Rows(i).Cells("nmsuplier").Value, GridLaporan.Rows(i).Cells("notatt").Value, GridLaporan.Rows(i).Cells("nama_barang").Value, GridLaporan.Rows(i).Cells("jmlbeli1").Value, GridLaporan.Rows(i).Cells("satuan1").Value, GridLaporan.Rows(i).Cells("jmlbeli").Value, GridLaporan.Rows(i).Cells("satuan").Value, GridLaporan.Rows(i).Cells("hrgnet").Value, GridLaporan.Rows(i).Cells("jmlhrg").Value, GridLaporan.Rows(i).Cells("tglexp").Value, GridLaporan.Rows(i).Cells("nobatch").Value, GridLaporan.Rows(i).Cells("stsdifakturkan").Value)
                    End If
                Next

                Dim excelEngine As New ExcelEngine
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2007
                Dim workbook As IWorkbook = excelEngine.Excel.Workbooks.Open(Application.StartupPath & "\Report\LaporanTandaTerimaXLSIO.xlsx")
                Dim sheet As IWorksheet = workbook.Worksheets(0)
                Dim marker As ITemplateMarkersProcessor = workbook.CreateTemplateMarkersProcessor
                marker.AddVariable("Data", dtXls)
                marker.ApplyMarkers()
                workbook.Version = ExcelVersion.Excel2007
                workbook.SaveAs("LaporanTandaTerima_VerISN.xlsx")
                workbook.Close()
                excelEngine.Dispose()
                System.Diagnostics.Process.Start("LaporanTandaTerima_VerISN.xlsx")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BDLaporan.Filter = "stsdifakturkan = '" & Trim(cmbStsDifakturkan.Text) & "'"
        TotalHarga()
        GridWarna()
        MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
    End Sub
End Class
