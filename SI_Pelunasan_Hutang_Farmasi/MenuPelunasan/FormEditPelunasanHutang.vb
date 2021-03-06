Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient

Public Class FormEditPelunasanHutang
    Inherits MetroForm
    Dim BDNoSPM, BDNotaBeli, BDLunas As New BindingSource
    Dim DSLunas As New DataSet
    Dim DRWLunas As DataRowView
    Dim Trans As SqlTransaction

    Sub kosongkanHeader()
        DSLunas = Table.BuatTabelPelunasanHutang("Lunas")
        gridPelunasan.DataSource = Nothing
        DSLunas.Clear()
        gridKosong()
        TglServer()
        DTPTanggalTrans.Value = TanggalServer
        txtSPM.Clear()
        txtKeterangan.Clear()
        txtKodeSupplier.Clear()
        txtSupplier.Clear()
        txtGrandJumlahHarga.Clear()
        txtGrandJumlahHargaBulat.Clear()
        txtQty.Clear()
        GBHeader.Enabled = True
        DTPTanggalTrans.Focus()
    End Sub

    Sub kosongkanDetail()
        TglServer()
        txtNotaBeli.Clear()
        txtNoFaktur.Clear()
        DTPTanggalFaktur.Value = TanggalServer
        txtHutang.Clear()
        txtRetur.Clear()
        txtAngsur.Clear()
        txtSisaHutang.Clear()
        txtJumlahBayar.Clear()
        txtA2.Clear()
        btnAdd.Enabled = False
        txtNotaBeli.Focus()
    End Sub

    Sub gridKosong()
        With gridPelunasan
            .Columns.Add("0", "Nama Supplier")
            .Columns(0).Width = 400
            .Columns.Add("1", "Tanggal Faktur")
            .Columns(1).Width = 100
            .Columns.Add("2", "No Faktur")
            .Columns(2).Width = 100
            .Columns.Add("3", "No A2")
            .Columns(3).Width = 80
            .Columns.Add("4", "Jumlah Bayar")
            .Columns(4).Width = 140
        End With
    End Sub

    Sub TampilSPM()
        Try
            konek()
            DA = New SqlDataAdapter("SELECT distinct ap_anghutang_header.tglbayar, ap_anghutang.nmsuplier, ap_anghutang_header.nobayar, ap_anghutang_header.totalbayar, ap_anghutang.kdsuplier, ap_anghutang.keterangan FROM ap_anghutang_header INNER JOIN ap_anghutang ON ap_anghutang_header.nobayar = ap_anghutang.nobayar WHERE ap_anghutang_header.tglbayar = '" & Format(DTPTanggalTrans.Value, "yyyy/MM/dd") & "'", CONN)
            DS = New DataSet
            DA.Fill(DS, "NoSPM")
            BDNoSPM.DataSource = DS
            BDNoSPM.DataMember = "NoSPM"

            With gridSPM
                .DataSource = Nothing
                .DataSource = BDNoSPM
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "Tanggal Bayar"
                .Columns(1).Width = 75
                .Columns(2).HeaderText = "Nama Supplier"
                .Columns(2).Width = 200
                .Columns(3).HeaderText = "Nomor SPM"
                .Columns(3).Width = 150
                .Columns(4).HeaderText = "Total Bayar"
                .Columns(4).Width = 100
                .Columns(4).DefaultCellStyle.Format = "N2"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TampilDetail()
        Try
            konek()
            DA = New SqlDataAdapter("SELECT nmsuplier as nmSupplier, tglfaktur, nofaktur, a2, jmlangsur as jmlBayar, notabeli, kdsuplier FROM ap_anghutang WHERE nobayar='" & Trim(txtSPM.Text) & "' order by nomer", CONN)
            DSLunas = New DataSet

            DA.Fill(DSLunas, "Lunas")
            BDLunas.DataSource = DSLunas
            BDLunas.DataMember = "Lunas"
            With gridPelunasan
                .DataSource = Nothing
                .DataSource = BDLunas
            End With

            AturGrid()
            TotalHarga()
            txtQty.DecimalValue = gridPelunasan.Rows.Count() - 1

            DS = New DataSet '''''''''''''''' Bantu Tambahan
            DA.Fill(DS) ''''''''''''''''''''' Bantu Tambahan
            With gridAwal
                .DataSource = Nothing
                .DataSource = DS.Tables(0)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TampilNotaBeli()
        Try
            konek()
            DA = New SqlDataAdapter("select tanggal,notabeli,nmsuplier,nofaktur,stsfakhutang,tgltempo,hrgbeli,jmlangsur,jmlretur,sisahtg from ap_beli1 where kdsuplier='" & Trim(txtKodeSupplier.Text) & "' and sisahtg>0 order by tanggal, notabeli", CONN)
            DS = New DataSet
            DA.Fill(DS, "NotaBeli")
            BDNotaBeli.DataSource = DS
            BDNotaBeli.DataMember = "NotaBeli"

            With gridNotaBeli
                .DataSource = Nothing
                .DataSource = BDNotaBeli
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "Tanggal"
                .Columns(1).Width = 75
                .Columns(2).HeaderText = "Nota Beli"
                .Columns(2).Width = 65
                .Columns(3).Visible = False
                .Columns(4).HeaderText = "No Faktur"
                .Columns(4).Width = 80
                .Columns(5).Visible = False
                .Columns(6).HeaderText = "Tanggal Tempo"
                .Columns(6).Width = 75
                .Columns(7).HeaderText = "Jumlah Total"
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).Width = 85
                .Columns(8).HeaderText = "Jumlah Angsur/ Bayar"
                .Columns(8).DefaultCellStyle.Format = "N2"
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).Width = 85
                .Columns(9).HeaderText = "Jumlah Retur"
                .Columns(9).DefaultCellStyle.Format = "N2"
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(9).Width = 85
                .Columns(10).HeaderText = "Sisa Hutang"
                .Columns(10).DefaultCellStyle.Format = "N2"
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).Width = 85

                .ReadOnly = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub addFaktur()

        BDLunas.DataSource = DSLunas
        BDLunas.DataMember = "Lunas"

        BDLunas.AddNew()
        DRWLunas = BDLunas.Current
        DRWLunas("nmSupplier") = Trim(txtSupplier.Text)
        DRWLunas("tglFaktur") = DTPTanggalFaktur.Value
        DRWLunas("noFaktur") = Trim(txtNoFaktur.Text)
        DRWLunas("a2") = Trim(txtA2.Text)
        DRWLunas("jmlBayar") = txtJumlahBayar.DecimalValue
        DRWLunas("notaBeli") = txtNotaBeli.Text
        DRWLunas("kdSuplier") = txtKodeSupplier.Text
        BDLunas.EndEdit()

        gridPelunasan.Columns.Clear()
        gridPelunasan.DataSource = Nothing
        gridPelunasan.DataSource = BDLunas

        AturGrid()
        TotalHarga()
        txtQty.DecimalValue = gridPelunasan.Rows.Count() - 1
    End Sub


    Sub AturGrid()
        With gridPelunasan
            .Columns(0).HeaderText = "Nama Supplier"
            .Columns(0).Width = 400
            .Columns(1).HeaderText = "Tanggal Faktur"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "No Faktur"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "No A2"
            .Columns(3).Width = 80
            .Columns(4).HeaderText = "Jumlah Bayar"
            .Columns(4).Width = 140
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .ReadOnly = True
        End With
    End Sub

    Sub TotalHarga()
        Dim HitungTotal As Decimal = 0
        For baris As Integer = 0 To gridPelunasan.RowCount - 1
            HitungTotal = HitungTotal + gridPelunasan.Rows(baris).Cells("jmlBayar").Value
        Next
        txtGrandJumlahHarga.DecimalValue = HitungTotal
        txtGrandJumlahHargaBulat.DecimalValue = buletin(txtGrandJumlahHarga.DecimalValue, 1)
    End Sub

    Private Sub FormEditPelunasanHutang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            btnSimpan.PerformClick()
        ElseIf e.KeyCode = Keys.F10 Then
            btnBaru.PerformClick()
        End If
    End Sub


    Private Sub FormEditPelunasanHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kosongkanDetail()
        kosongkanHeader()
    End Sub

    Private Sub DTPTanggalTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPTanggalTrans.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSPM.Focus()
        End If
    End Sub

    Private Sub DTPTanggalTrans_ValueChanged(sender As Object, e As EventArgs) Handles DTPTanggalTrans.ValueChanged

    End Sub

    Private Sub FormEditPelunasanHutang_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PanelSPM.Top = txtSPM.Top + 22
        PanelSPM.Left = txtSPM.Left + 0
        PanelNotaBeli.Top = txtNotaBeli.Top + 135
        PanelNotaBeli.Left = txtNotaBeli.Left + 0
    End Sub

    Private Sub txtSPM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSPM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TampilSPM()
            PanelSPM.Visible = True
            txtCariSPM.Clear()
            txtCariSPM.Focus()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelSPM.Visible = False
    End Sub

    Private Sub txtCariSPM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariSPM.KeyDown
        If e.KeyCode = Keys.Down Then
            gridSPM.Focus()
        End If
    End Sub

    Private Sub txtCariSPM_TextChanged(sender As Object, e As EventArgs) Handles txtCariSPM.TextChanged
        Try
            BDNoSPM.Filter = "nobayar like '%" & txtCariSPM.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridSPM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSPM.CellContentClick
        If e.ColumnIndex = 0 Then
            If Not IsDBNull(gridSPM.Rows(e.RowIndex).Cells(1).Value) Then
                txtSPM.Text = Trim(gridSPM.Rows(e.RowIndex).Cells("nobayar").Value)
                txtKodeSupplier.Text = Trim(gridSPM.Rows(e.RowIndex).Cells("kdsuplier").Value)
                txtSupplier.Text = Trim(gridSPM.Rows(e.RowIndex).Cells("nmsuplier").Value)
                txtKeterangan.Text = Trim(gridSPM.Rows(e.RowIndex).Cells("keterangan").Value)
                gridPelunasan.Columns.Clear()
                TampilDetail()

                PanelSPM.Visible = False
                GBHeader.Enabled = False
                txtNotaBeli.Focus()
            End If
        End If
    End Sub

    Private Sub gridSPM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gridSPM.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim i = gridSPM.CurrentRow.Index - 1
            If Not IsDBNull(gridSPM.Rows(i).Cells(1).Value) Then
                txtSPM.Text = Trim(gridSPM.Rows(i).Cells("nobayar").Value)
                txtKodeSupplier.Text = Trim(gridSPM.Rows(i).Cells("kdsuplier").Value)
                txtSupplier.Text = Trim(gridSPM.Rows(i).Cells("nmsuplier").Value)
                txtKeterangan.Text = Trim(gridSPM.Rows(i).Cells("keterangan").Value)
                gridPelunasan.Columns.Clear()
                TampilDetail()
                PanelSPM.Visible = False
                GBHeader.Enabled = False
                txtNotaBeli.Focus()
            End If
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dispose()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        kosongkanDetail()
        kosongkanHeader()
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        If MessageBox.Show("Yakin Akan Dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                If gridPelunasan.CurrentRow.Index <> gridPelunasan.NewRowIndex Then
                    gridPelunasan.Rows.RemoveAt(gridPelunasan.CurrentRow.Index)
                End If
                txtQty.DecimalValue = gridPelunasan.Rows.Count() - 1
                TotalHarga()
                btnAdd.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub gridPelunasan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridPelunasan.CellFormatting
        gridPelunasan.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub txtNotaBeli_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotaBeli.KeyDown
        If e.KeyCode = Keys.Enter Then
            TampilNotaBeli()
            PanelNotaBeli.Visible = True
            txtCariFaktur.Clear()
            txtCariFaktur.Focus()
        End If
    End Sub

    Private Sub txtNotaBeli_TextChanged(sender As Object, e As EventArgs) Handles txtNotaBeli.TextChanged

    End Sub

    Private Sub gridNotaBeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridNotaBeli.CellContentClick
        If e.ColumnIndex = 0 Then
            If Not IsDBNull(gridNotaBeli.Rows(e.RowIndex).Cells(1).Value) Then
                txtNotaBeli.Text = gridNotaBeli.Rows(e.RowIndex).Cells("notabeli").Value
                DTPTanggalFaktur.Value = gridNotaBeli.Rows(e.RowIndex).Cells("tanggal").Value
                txtNoFaktur.Text = gridNotaBeli.Rows(e.RowIndex).Cells("nofaktur").Value
                txtHutang.DecimalValue = gridNotaBeli.Rows(e.RowIndex).Cells("hrgbeli").Value
                txtRetur.DecimalValue = gridNotaBeli.Rows(e.RowIndex).Cells("jmlretur").Value
                txtSisaHutang.DecimalValue = gridNotaBeli.Rows(e.RowIndex).Cells("sisahtg").Value
                txtJumlahBayar.DecimalValue = txtSisaHutang.DecimalValue
                PanelNotaBeli.Visible = False
                btnAdd.Enabled = True
                txtJumlahBayar.Focus()
            End If
        End If
    End Sub

    Private Sub gridNotaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gridNotaBeli.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim i = gridNotaBeli.CurrentRow.Index - 1
            If Not IsDBNull(gridNotaBeli.Rows(i).Cells(1).Value) Then
                txtNotaBeli.Text = gridNotaBeli.Rows(i).Cells("notabeli").Value
                DTPTanggalFaktur.Value = gridNotaBeli.Rows(i).Cells("tanggal").Value
                txtNoFaktur.Text = gridNotaBeli.Rows(i).Cells("nofaktur").Value
                txtHutang.DecimalValue = gridNotaBeli.Rows(i).Cells("hrgbeli").Value
                txtRetur.DecimalValue = gridNotaBeli.Rows(i).Cells("jmlretur").Value
                txtSisaHutang.DecimalValue = gridNotaBeli.Rows(i).Cells("sisahtg").Value
                txtJumlahBayar.DecimalValue = txtSisaHutang.DecimalValue
                PanelNotaBeli.Visible = False
                btnAdd.Enabled = True
                txtJumlahBayar.Focus()
            End If
        End If
    End Sub

    Private Sub txtCariFaktur_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariFaktur.KeyDown
        If e.KeyCode = Keys.Down Then
            gridNotaBeli.Focus()
        End If
    End Sub

    Private Sub txtCariFaktur_TextChanged(sender As Object, e As EventArgs) Handles txtCariFaktur.TextChanged
        Try
            BDNotaBeli.Filter = "nofaktur like '%" & txtCariFaktur.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtJumlahBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJumlahBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtA2.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSPM.Text = "" Then
            MsgBox("No SPM masih kosong", vbInformation, "Informasi")
            Exit Sub
        End If
        If txtNotaBeli.Text = "" Or txtJumlahBayar.DecimalValue = 0 Or txtA2.Text = "" Then
            MsgBox("Data belum lengkap", vbInformation, "Informasi")
            Exit Sub
        End If
        For barisGrid As Integer = 0 To gridPelunasan.RowCount - 1
            If Trim(txtNotaBeli.Text) = gridPelunasan.Rows(barisGrid).Cells("notaBeli").Value Then
                MsgBox("Nota Beli " & Trim(txtNotaBeli.Text) & " Dengan No Faktur " & Trim(txtNoFaktur.Text) & " Sudah Dientry", vbInformation, "Informasi")
                kosongkanDetail()
                txtNotaBeli.Focus()
                Exit Sub
            End If
        Next
        addFaktur()
        kosongkanDetail()
        GBHeader.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelNotaBeli.Visible = False
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MessageBox.Show("Data pelunasan sudah benar ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim sqlSimpan As String = ""
            TglServer()
            konek()
            Trans = CONN.BeginTransaction(IsolationLevel.ReadCommitted)
            CMD.Connection = CONN
            CMD.Transaction = Trans
            Try
                sqlSimpan = "DELETE FROM ap_anghutang_header where nobayar='" & Trim(txtSPM.Text) & "'"
                sqlSimpan = sqlSimpan + vbCrLf + "DELETE FROM ap_anghutang where nobayar='" & Trim(txtSPM.Text) & "'"
                For i = 0 To gridAwal.RowCount - 2
                    sqlSimpan = sqlSimpan + vbCrLf + "UPDATE ap_beli1 SET jmlangsur=jmlangsur-" & Num_En_US(gridAwal.Rows(i).Cells("jmlBayar").Value) & ", sisahtg=sisahtg+" & Num_En_US(gridAwal.Rows(i).Cells("jmlBayar").Value) & " WHERE kdsuplier='" & Trim(gridAwal.Rows(i).Cells("kdsuplier").Value) & "' AND notabeli='" & Trim(gridAwal.Rows(i).Cells("notaBeli").Value) & "'"
                Next

                sqlSimpan = sqlSimpan + vbCrLf + "insert into ap_anghutang_header(tglbayar,nobayar,totalbayar,totalbayarbulat) values ('" & Format(DTPTanggalTrans.Value, "yyyy/MM/dd") & "', '" & Trim(txtSPM.Text) & "', '" & Num_En_US(txtGrandJumlahHarga.DecimalValue) & "', '" & Num_En_US(txtGrandJumlahHargaBulat.DecimalValue) & "')"

                For i = 0 To gridPelunasan.RowCount - 2
                    sqlSimpan = sqlSimpan + vbCrLf + "insert into ap_anghutang (kdkasir, nmkasir, tglbayar, nobayar, keterangan, nomer, kdsuplier, nmsuplier, notabeli, tglfaktur, nofaktur, jmlangsur, posting, a2) values ('" & Trim(FormLogin.LabelKode.Text) & "', '" & Trim(FormLogin.LabelNama.Text) & "', '" & Format(DTPTanggalTrans.Value, "yyyy/MM/dd") & "', '" & Trim(txtSPM.Text) & "', '" & Trim(txtKeterangan.Text) & "', " & i + 1 & ", '" & Trim(gridPelunasan.Rows(i).Cells("kdSuplier").Value) & "', '" & Trim(gridPelunasan.Rows(i).Cells("nmSupplier").Value) & "', '" & Trim(gridPelunasan.Rows(i).Cells("notaBeli").Value) & "', '" & Format(gridPelunasan.Rows(i).Cells("tglFaktur").Value, "yyyy/MM/dd") & "', '" & Trim(gridPelunasan.Rows(i).Cells("noFaktur").Value) & "',  '" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & "','1', '" & Trim(gridPelunasan.Rows(i).Cells("a2").Value) & "')"
                Next

                For i = 0 To gridPelunasan.RowCount - 2
                    sqlSimpan = sqlSimpan + vbCrLf + "UPDATE ap_beli1  SET jmlangsur=jmlangsur+" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & ", sisahtg=sisahtg-" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & " WHERE kdsuplier='" & Trim(gridPelunasan.Rows(i).Cells("kdsuplier").Value) & "' AND notabeli='" & Trim(gridPelunasan.Rows(i).Cells("notaBeli").Value) & "'"
                Next

                CMD.CommandText = sqlSimpan
                CMD.ExecuteNonQuery()
                Trans.Commit()
                MsgBox("Pelunasan berhasil disimpan", vbInformation, "Informasi")
                btnBaru.PerformClick()

            Catch ex As Exception
                MsgBox(" Commit Exception Type: {0}" & ex.GetType.ToString, vbCritical, "Kesalahan")
                MsgBox(" Message: {0}" & ex.Message, vbCritical, "Kesalahan")
                Try
                    Trans.Rollback()
                Catch ex2 As Exception
                    MsgBox(" Rollback Exception Type: {0}" & ex.GetType.ToString, vbCritical, "Kesalahan")
                    MsgBox(" Message: {0}" & ex.Message, vbCritical, "Kesalahan")
                End Try
            End Try
        End If
    End Sub

    Private Sub btnHapusNota_Click(sender As Object, e As EventArgs) Handles btnHapusNota.Click
        If MessageBox.Show("Benar data akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim slqHapus As String = ""
            TglServer()
            konek()
            Trans = CONN.BeginTransaction(IsolationLevel.ReadCommitted)
            CMD.Connection = CONN
            CMD.Transaction = Trans
            Try
                slqHapus = "DELETE FROM ap_anghutang_header where nobayar='" & Trim(txtSPM.Text) & "'"
                slqHapus = slqHapus + vbCrLf + "DELETE FROM ap_anghutang where nobayar='" & Trim(txtSPM.Text) & "'"
                For i = 0 To gridAwal.RowCount - 2
                    slqHapus = slqHapus + vbCrLf + "UPDATE ap_beli1 SET jmlangsur=jmlangsur-" & Num_En_US(gridAwal.Rows(i).Cells("jmlBayar").Value) & ", sisahtg=sisahtg+" & Num_En_US(gridAwal.Rows(i).Cells("jmlBayar").Value) & " WHERE kdsuplier='" & Trim(gridAwal.Rows(i).Cells("kdsuplier").Value) & "' AND notabeli='" & Trim(gridAwal.Rows(i).Cells("notaBeli").Value) & "'"
                Next

                CMD.CommandText = slqHapus
                CMD.ExecuteNonQuery()
                Trans.Commit()
                btnBaru.PerformClick()

            Catch ex As Exception
                MsgBox(" Commit Exception Type: {0}" & ex.GetType.ToString, vbCritical, "Kesalahan")
                MsgBox(" Message: {0}" & ex.Message, vbCritical, "Kesalahan")
                Try
                    Trans.Rollback()
                Catch ex2 As Exception
                    MsgBox(" Rollback Exception Type: {0}" & ex.GetType.ToString, vbCritical, "Kesalahan")
                    MsgBox(" Message: {0}" & ex.Message, vbCritical, "Kesalahan")
                End Try
            End Try
        End If
    End Sub

    Private Sub txtJumlahBayar_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahBayar.TextChanged

    End Sub

    Private Sub txtA2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtA2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub

    Private Sub txtA2_TextChanged(sender As Object, e As EventArgs) Handles txtA2.TextChanged

    End Sub
End Class
