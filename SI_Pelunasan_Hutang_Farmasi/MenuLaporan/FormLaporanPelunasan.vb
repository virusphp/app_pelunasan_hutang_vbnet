Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class FormLaporanPelunasan
    Inherits MetroForm
    Dim BDLaporan As New BindingSource

    Sub Kosongkan()
        TglServer()
        DTPTanggalAwalTab1.Value = TanggalServer
        DTPTanggalAkhirTab1.Value = TanggalServer
        GridLaporan.DataSource = Nothing
        ' gridKosong()
        cmbSupplier.Text = ""
        cmbValidasi.Text = ""
        cmbJenisBarang.Text = ""
        cmbValidasi.Enabled = False
        Button3.Enabled = False
        txtNota.Clear()
        txtTotalBayar.Clear()
        cmbSupplier.Enabled = False
        cmbJenisBarang.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        btnBaruTab1.Enabled = False
        btnExcelTab1.Enabled = False
        btnProsesTab1.Enabled = True
        DTPTanggalAwalTab1.Focus()
    End Sub

    Sub gridKosong()
        With GridLaporan
            .Columns.Add("0", "Tanggal")
            .Columns(0).Width = 85
            .Columns.Add("1", "No SPM")
            .Columns(1).Width = 120
            .Columns.Add("2", "Keterangan")
            .Columns(2).Width = 180
            .Columns.Add("3", "Nama Supplier")
            .Columns(3).Width = 200
            .Columns.Add("4", "No Faktur")
            .Columns(4).Width = 85
            .Columns.Add("5", "Nota Beli")
            .Columns(5).Width = 85
            .Columns.Add("6", "Tanggal Faktur")
            .Columns(6).Width = 85
            .Columns.Add("7", "Jumlah Bayar")
            .Columns(7).Width = 100
        End With
    End Sub

    Sub GridWarna()
        For i As Integer = 0 To GridLaporan.RowCount - 1
            If GridLaporan.Rows(i).Cells("posting").Value = "Sudah" Then
                GridLaporan.Rows(i).Cells(2).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(3).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(5).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(6).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(7).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(8).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(9).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(10).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(11).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(12).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(13).Style.BackColor = Color.Yellow
                GridLaporan.Rows(i).Cells(14).Style.BackColor = Color.Yellow
            Else
                GridLaporan.Rows(i).Cells(2).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(3).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(4).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(5).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(6).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(7).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(8).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(9).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(10).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(11).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(12).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(13).Style.BackColor = Color.White
                GridLaporan.Rows(i).Cells(14).Style.BackColor = Color.White
            End If
        Next
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

    Sub tampilLaporan()
        Try
            konek()
            DA = New SqlDataAdapter("SELECT ap_anghutang.tglbayar, ap_anghutang.nobayar, ap_anghutang.keterangan, 
RTRIM(LTRIM(ap_anghutang.nmsuplier)) AS nmsuplier, ap_anghutang.nofaktur, ap_anghutang.a2, ap_anghutang.notabeli, 
ap_anghutang.tglfaktur, ap_beli1.hrgbeli, ap_beli1.jmlretur, ap_anghutang.jmlangsur, ap_beli1.sisahtg, ap_anghutang.kdsuplier, 
CASE ap_anghutang.posting WHEN '1' THEN 'Belum' ELSE 'Sudah' END AS posting, ap_beli1.kd_jns_obat FROM ap_anghutang 
INNER JOIN ap_beli1 ON ap_anghutang.notabeli = ap_beli1.notabeli 
WHERE ap_anghutang.tglbayar>='" & Format(DTPTanggalAwalTab1.Value, "yyyy/MM/dd") &
"' and ap_anghutang.tglbayar<='" & Format(DTPTanggalAkhirTab1.Value, "yyyy/MM/dd") &
"' order by ap_anghutang.tglbayar, ap_anghutang.nobayar", CONN)

            'DA = New SqlDataAdapter("SELECT ap_anghutang.tglbayar, ap_anghutang.nobayar, ap_anghutang.keterangan, RTRIM(LTRIM(ap_anghutang.nmsuplier)) AS nmsuplier, ap_anghutang.nofaktur, ap_anghutang.a2, ap_anghutang.notabeli, ap_anghutang.tglfaktur, ap_beli1.hrgbeli, ap_beli1.jmlretur, ap_anghutang.jmlangsur, ap_beli1.sisahtg, ap_anghutang.kdsuplier, CASE ap_anghutang.posting WHEN '1' THEN 'Belum' ELSE 'Sudah' END AS posting, ap_beli1.kd_jns_obat FROM ap_anghutang INNER JOIN ap_beli1 ON ap_anghutang.notabeli = ap_beli1.notabeli WHERE ap_beli1.tglfaktur>='" & Format(DTPTanggalAwalTab1.Value, "yyyy/MM/dd") & "' and ap_beli1.tglfaktur<='" & Format(DTPTanggalAkhirTab1.Value, "yyyy/MM/dd") & "' order by ap_anghutang.tglbayar, ap_anghutang.nobayar", CONN)
            DS = New DataSet
            DA.Fill(DS, "Laporan")
            BDLaporan.DataSource = DS
            BDLaporan.DataMember = "Laporan"
            With GridLaporan
                ' .Columns.Clear()
                .DataSource = Nothing
                .DataSource = BDLaporan
                .Columns(0).Width = 50
                .Columns(1).Width = 50
                .Columns(2).HeaderText = "Tanggal"
                .Columns(2).Width = 85
                .Columns(3).HeaderText = "No SPM"
                .Columns(3).Width = 120
                .Columns(4).HeaderText = "Keterangan"
                .Columns(4).Width = 180
                .Columns(5).HeaderText = "Nama Supplier"
                .Columns(5).Width = 200
                .Columns(6).HeaderText = "No Faktur"
                .Columns(6).Width = 85
                .Columns(7).HeaderText = "No A2"
                .Columns(7).Width = 85
                .Columns(8).HeaderText = "Nota Beli"
                .Columns(8).Width = 85
                .Columns(9).HeaderText = "Tanggal Faktur"
                .Columns(9).Width = 85
                .Columns(10).HeaderText = "Jumlah Beli"
                .Columns(10).DefaultCellStyle.Format = "N2"
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).Width = 100
                .Columns(11).HeaderText = "Jumlah Retur"
                .Columns(11).DefaultCellStyle.Format = "N2"
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(11).Width = 100
                .Columns(12).HeaderText = "Jumlah Bayar"
                .Columns(12).DefaultCellStyle.Format = "N2"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(12).Width = 100
                .Columns(13).HeaderText = "Sisa Hutang"
                .Columns(13).DefaultCellStyle.Format = "N2"
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(13).Width = 100
                .Columns(14).Visible = False
                .Columns(15).HeaderText = "Validasi"
                .Columns(15).Width = 70
                .Columns(16).Visible = False
                .ReadOnly = True
                'BDLaporan.RemoveFilter()
                txtNota.DecimalValue = GridLaporan.Rows.Count() - 1
                TotalBayar()
            End With
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TotalBayar()
        Dim HitungTotal As Decimal = 0
        For baris As Integer = 0 To GridLaporan.RowCount - 1
            HitungTotal = HitungTotal + GridLaporan.Rows(baris).Cells("jmlangsur").Value
        Next
        txtTotalBayar.DecimalValue = HitungTotal
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

    Private Sub FormLaporanPelunasan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub btnProsesTab1_Click(sender As Object, e As EventArgs) Handles btnProsesTab1.Click
        tampilLaporan()
        GridWarna()
        cmbSupplier.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = True
        btnExcelTab1.Enabled = True
        btnProsesTab1.Enabled = False
        btnBaruTab1.Enabled = True
        cmbValidasi.Enabled = True
        cmbJenisBarang.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub DTPTanggalAwalTab1_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPTanggalAwalTab1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPTanggalAkhirTab1.Focus()
        End If
    End Sub

    Private Sub DTPTanggalAwalTab1_ValueChanged(sender As Object, e As EventArgs) Handles DTPTanggalAwalTab1.ValueChanged

    End Sub

    Private Sub DTPTanggalAkhirTab1_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPTanggalAkhirTab1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnProsesTab1.Focus()
        End If
    End Sub

    Private Sub DTPTanggalAkhirTab1_ValueChanged(sender As Object, e As EventArgs) Handles DTPTanggalAkhirTab1.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbSupplier.Text <> "" Then
            BDLaporan.RemoveFilter()
            BDLaporan.Filter = "kdsuplier = '" & Trim(cmbSupplier.SelectedValue.ToString) & "'"
            txtNota.DecimalValue = GridLaporan.Rows.Count() - 1
            TotalBayar()
            GridWarna()
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If cmbSupplier.Text <> "" Then
        BDLaporan.RemoveFilter()
        TotalBayar()
        cmbSupplier.Text = ""
        cmbValidasi.Text = ""
        cmbJenisBarang.Text = ""
        GridWarna()
        MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        'End If
    End Sub

    Private Sub FormLaporanPelunasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListSupllier()
        ListJenisBarang()
        Kosongkan()
    End Sub

    Private Sub btnBaruTab1_Click(sender As Object, e As EventArgs) Handles btnBaruTab1.Click
        Kosongkan()
    End Sub

    Private Sub btnExcelTab1_Click(sender As Object, e As EventArgs) Handles btnExcelTab1.Click
        If MessageBox.Show("Apakah data akan di eksport ke excel?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim dtXls As New DataTable
                With dtXls
                    .Columns.Add("tglbayar")
                    .Columns.Add("nobayar")
                    .Columns.Add("keterangan")
                    .Columns.Add("nmsuplier")
                    .Columns.Add("nofaktur")
                    .Columns.Add("a2")
                    .Columns.Add("notabeli")
                    .Columns.Add("tglfaktur")
                    .Columns.Add("jmlangsur")
                    .Columns.Add("hrgbeli")
                    .Columns.Add("jmlretur")
                    .Columns.Add("sisahtg")
                End With

                For i = 0 To GridLaporan.RowCount - 2
                    If Not IsDBNull(GridLaporan.Rows(i).Cells(0).Value) Then
                        dtXls.Rows.Add(GridLaporan.Rows(i).Cells("tglbayar").Value, GridLaporan.Rows(i).Cells("nobayar").Value, GridLaporan.Rows(i).Cells("keterangan").Value, GridLaporan.Rows(i).Cells("nmsuplier").Value, GridLaporan.Rows(i).Cells("nofaktur").Value, GridLaporan.Rows(i).Cells("a2").Value, GridLaporan.Rows(i).Cells("notabeli").Value, GridLaporan.Rows(i).Cells("tglfaktur").Value, GridLaporan.Rows(i).Cells("jmlangsur").Value, GridLaporan.Rows(i).Cells("hrgbeli").Value, GridLaporan.Rows(i).Cells("jmlretur").Value, GridLaporan.Rows(i).Cells("sisahtg").Value)
                    End If
                Next

                Dim excelEngine As New ExcelEngine
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2007
                Dim workbook As IWorkbook = excelEngine.Excel.Workbooks.Open(Application.StartupPath & "\Report\LaporanPelunasanXLSIO.xlsx")
                Dim sheet As IWorksheet = workbook.Worksheets(0)
                Dim marker As ITemplateMarkersProcessor = workbook.CreateTemplateMarkersProcessor
                marker.AddVariable("Data", dtXls)
                marker.ApplyMarkers()
                workbook.Version = ExcelVersion.Excel2007
                workbook.SaveAs("LaporanPelunasan_VerISN.xlsx")
                workbook.Close()
                excelEngine.Dispose()
                System.Diagnostics.Process.Start("LaporanPelunasan_VerISN.xlsx")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GridLaporan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridLaporan.CellContentClick
        If e.ColumnIndex = 0 Then
            If Not IsDBNull(GridLaporan.Rows(e.RowIndex).Cells(2).Value) Then
                Try
                    konek()
                    Dim validasi As String = "UPDATE ap_anghutang SET posting='2' WHERE notabeli='" & GridLaporan.Rows(e.RowIndex).Cells("notabeli").Value & "' "
                    CMD = New SqlCommand(validasi, CONN)
                    CMD.ExecuteNonQuery()
                    GridLaporan.Rows(e.RowIndex).Cells("posting").Value = "Sudah"
                    GridWarna()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        If e.ColumnIndex = 1 Then
            If Not IsDBNull(GridLaporan.Rows(e.RowIndex).Cells(2).Value) Then
                Try
                    konek()
                    Dim batal As String = "UPDATE ap_anghutang SET posting='1' WHERE notabeli='" & GridLaporan.Rows(e.RowIndex).Cells("notabeli").Value & "' "
                    CMD = New SqlCommand(batal, CONN)
                    CMD.ExecuteNonQuery()
                    GridLaporan.Rows(e.RowIndex).Cells("posting").Value = "Belum"
                    GridWarna()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cmbValidasi.Text <> "" Then
            BDLaporan.RemoveFilter()
            BDLaporan.Filter = "posting = '" & cmbValidasi.Text & "'"
            txtNota.DecimalValue = GridLaporan.Rows.Count() - 1
            TotalBayar()
            GridWarna()
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cmbJenisBarang.Text <> "" Then
            BDLaporan.RemoveFilter()
            BDLaporan.Filter = "kd_jns_obat = '" & cmbJenisBarang.SelectedValue.ToString & "'"
            txtNota.DecimalValue = GridLaporan.Rows.Count() - 1
            TotalBayar()
            GridWarna()
            MsgBox("Data sudah ditampilkan", vbInformation, "Informasi")
        End If
    End Sub
End Class
