
Imports System.Data.SqlClient

Public Class FormPelunasanHutang
    Dim BDSupplier, BDNotaBeli, BDLunas As New BindingSource
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
            .Columns.Add("notaBeli", "Nota Beli")
            .Columns(5).Visible = False
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
        End With
    End Sub

    Sub TampilSupplier()
        Try
            konek()
            DA = New SqlDataAdapter("select kdsuplier, nmsuplier, alamat, telpon from ap_suplier order by nmsuplier", CONN)
            DS = New DataSet
            DA.Fill(DS, "Supplier")
            BDSupplier.DataSource = DS
            BDSupplier.DataMember = "Supplier"

            With gridSupplier
                .DataSource = Nothing
                .DataSource = BDSupplier
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "Kode Supplier"
                .Columns(1).Width = 50
                .Columns(2).HeaderText = "Nama Supplier"
                .Columns(2).Width = 150
                .Columns(3).HeaderText = "Alamat"
                .Columns(3).Width = 240
                .Columns(4).HeaderText = "No Telepon"
                .Columns(4).Width = 150
                .ReadOnly = True
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
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
                '.Columns(3).Width = 200
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
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
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
        BDLunas.EndEdit()

        gridPelunasan.Columns.Clear()
        gridPelunasan.DataSource = Nothing
        gridPelunasan.DataSource = BDLunas

        AturGrid()
        TotalHarga()
        txtQty.DecimalValue = gridPelunasan.Rows.Count()
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

    Private Sub FormPelunasanHutang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Sub CariSPM()
        konek()
        CMD = New SqlCommand("SELECT * FROM ap_anghutang_header WHERE nobayar='" & Trim(txtSPM.Text) & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Sub TampilRekanan()
        Try
            konek()
            DA = New SqlDataAdapter("select * from Rekanan", CONN)
            DS = New DataSet
            DA.Fill(DS, "Rekanan")
            BDSupplier.DataSource = DS
            BDSupplier.DataMember = "Rekanan"

            With gridSupplier
                .DataSource = Nothing
                .DataSource = BDSupplier
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Nama"
                .Columns(3).HeaderText = "Pimpinan"
                .Columns(4).HeaderText = "Alamat"
                .Columns(0).Width = 30
                .Columns(2).Width = 150
                .Columns(3).Width = 150
                .Columns(4).Width = 240
                .Columns(5).Visible = False
                .BackgroundColor = Color.Azure
                .DefaultCellStyle.SelectionBackColor = Color.LightBlue
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Black
                .RowHeadersDefaultCellStyle.BackColor = Color.Black
                .ReadOnly = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormPelunasanHutang_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PanelSupplier.Top = txtKodeSupplier.Top + 22
        PanelSupplier.Left = txtKodeSupplier.Left + 0
        PanelNotaBeli.Top = txtNotaBeli.Top + 135
        PanelNotaBeli.Left = txtNotaBeli.Left + 0
    End Sub

    Private Sub DTPTanggalTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPTanggalTrans.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSPM.Focus()
        End If
    End Sub

    Private Sub txtSPM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSPM.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtKeterangan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKodeSupplier.Focus()
        End If
    End Sub

    Private Sub txtKodeSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            PanelSupplier.Width = 683
            PanelSupplier.Height = 318
            PanelSupplier.Top = 98
            PanelSupplier.Left = 104

            TampilSupplier()
            PanelSupplier.Visible = True
            txtCariSupplier.Clear()
            txtCariSupplier.Focus()
        End If
    End Sub

    Private Sub txtKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtKodeSupplier.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelSupplier.Visible = False
    End Sub

    Private Sub txtCariSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariSupplier.KeyDown
        If e.KeyCode = Keys.Down Then
            gridSupplier.Focus()
        End If
    End Sub

    Private Sub txtCariSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSupplier.KeyPress
    End Sub

    Private Sub txtCariSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtCariSupplier.TextChanged
        Try
            BDSupplier.Filter = "nmsuplier like '%" & txtCariSupplier.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSupplier.CellContentClick
        If e.ColumnIndex = 0 Then
            If Not IsDBNull(gridSupplier.Rows(e.RowIndex).Cells(1).Value) Then
                txtSupplier.Text = gridSupplier.Rows(e.RowIndex).Cells("nmsuplier").Value
                txtKodeSupplier.Text = gridSupplier.Rows(e.RowIndex).Cells("kdsuplier").Value
                PanelSupplier.Visible = False
                txtSupplier.Focus()
            End If
        End If
    End Sub

    Private Sub txtKeterangan_LostFocus(sender As Object, e As EventArgs) Handles txtKeterangan.LostFocus
        If txtKeterangan.Text = "" Then
            txtKeterangan.Text = "-"
        End If
    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub

    Private Sub gridSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gridSupplier.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim i = gridSupplier.CurrentRow.Index - 1
            If Not IsDBNull(gridSupplier.Rows(i).Cells(1).Value) Then
                txtSupplier.Text = gridSupplier.Rows(i).Cells("nmsuplier").Value
                txtKodeSupplier.Text = gridSupplier.Rows(i).Cells("kdsuplier").Value
                PanelSupplier.Visible = False
                txtSupplier.Focus()
            End If
        End If
    End Sub

    Private Sub txtSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNotaBeli.Focus()
        End If
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged

    End Sub

    Private Sub txtNotaBeli_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotaBeli.KeyDown
        If e.KeyCode = Keys.Enter Then
            PanelNotaBeli.Top = 135
            PanelNotaBeli.Left = 104
            PanelNotaBeli.Width = 733
            PanelNotaBeli.Height = 314
            TampilNotaBeli()
            PanelNotaBeli.Visible = True
            txtCariFaktur.Clear()
            txtCariFaktur.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelNotaBeli.Visible = False
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

    Private Sub txtJumlahBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJumlahBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtA2.Focus()
        End If
    End Sub

    Private Sub txtJumlahBayar_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahBayar.TextChanged

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

    Private Sub FormPelunasanHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kosongkanDetail()
        kosongkanHeader()
    End Sub

    Private Sub gridPelunasan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridPelunasan.CellContentClick

    End Sub

    Private Sub gridPelunasan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridPelunasan.CellFormatting
        gridPelunasan.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub cmdHapusBaris_Click(sender As Object, e As EventArgs) Handles cmdHapusBaris.Click
        If MessageBox.Show("Yakin Akan Dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                If gridPelunasan.CurrentRow.Index <> gridPelunasan.NewRowIndex Then
                    gridPelunasan.Rows.RemoveAt(gridPelunasan.CurrentRow.Index)
                End If
                txtQty.DecimalValue = gridPelunasan.Rows.Count()
                TotalHarga()
                btnAdd.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dispose()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        kosongkanDetail()
        kosongkanHeader()
    End Sub

    Private Sub txtSPM_LostFocus(sender As Object, e As EventArgs) Handles txtSPM.LostFocus
        If txtSPM.Text <> "" Then
            CariSPM()
            If DR.HasRows Then
                MsgBox("No SPM sudah ada", vbInformation, "Informasi")
                txtSPM.Focus()
            End If
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtQty.DecimalValue = 0 Then
            MsgBox("Data belum masuk", vbInformation, "Informasi")
            Exit Sub
        End If
        If MessageBox.Show("Data pelunasan sudah benar ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim sqlSimpan As String = ""
            TglServer()
            konek()
            Trans = CONN.BeginTransaction(IsolationLevel.ReadCommitted)
            CMD.Connection = CONN
            CMD.Transaction = Trans
            Try
                sqlSimpan = "insert into ap_anghutang_header(tglbayar,nobayar,totalbayar,totalbayarbulat) values ('" & Format(DTPTanggalTrans.Value, "yyyy/MM/dd") & "', '" & Trim(txtSPM.Text) & "', '" & Num_En_US(txtGrandJumlahHarga.DecimalValue) & "', '" & Num_En_US(txtGrandJumlahHargaBulat.DecimalValue) & "')"

                For i = 0 To gridPelunasan.RowCount - 1
                    sqlSimpan = sqlSimpan + vbCrLf + "insert into ap_anghutang (kdkasir, nmkasir, tglbayar, nobayar, keterangan, 
nomer, kdsuplier, nmsuplier, notabeli, tglfaktur, nofaktur, jmlangsur, posting, a2) values (" &
                                "'" & sesiAplikasi.sesiUID & "', " &
                                "'" & sesiAplikasi.sesiNamaUser & "', " &
                                "'" & Format(DTPTanggalTrans.Value, "yyyy/MM/dd") & "', " &
                                "'" & Trim(txtSPM.Text) & "', " &
                                "'" & Trim(txtKeterangan.Text) & "', " &
                                "" & i + 1 & ", " &
                                "'" & Trim(txtKodeSupplier.Text) & "', " &
                                "'" & Trim(txtSupplier.Text) & "', '" &
                                "" & Trim(gridPelunasan.Rows(i).Cells("notaBeli").Value) & "', " &
                                "'" & Format(gridPelunasan.Rows(i).Cells("tglFaktur").Value, "yyyy/MM/dd") & "'," &
                                "'" & Trim(gridPelunasan.Rows(i).Cells("noFaktur").Value) & "',  " &
                                "'" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & "','1', " &
                                "'" & Trim(gridPelunasan.Rows(i).Cells("a2").Value) & "')"
                Next

                For i = 0 To gridPelunasan.RowCount - 2
                    sqlSimpan = sqlSimpan + vbCrLf + "UPDATE ap_beli1 SET jmlangsur=jmlangsur+" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & ", sisahtg=sisahtg-" & Num_En_US(gridPelunasan.Rows(i).Cells("jmlBayar").Value) & " WHERE kdsuplier='" & Trim(txtKodeSupplier.Text) & "' AND notabeli='" & Trim(gridPelunasan.Rows(i).Cells("notaBeli").Value) & "'"
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

    Private Sub DTPTanggalTrans_ValueChanged(sender As Object, e As EventArgs) Handles DTPTanggalTrans.ValueChanged

    End Sub

    Private Sub FormPelunasanHutang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            btnSimpan.PerformClick()
        ElseIf e.KeyCode = Keys.F10 Then
            btnBaru.PerformClick()
        End If
    End Sub

    Private Sub txtSPM_TextChanged(sender As Object, e As EventArgs) Handles txtSPM.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtA2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtA2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub

    Private Sub txtA2_TextChanged(sender As Object, e As EventArgs) Handles txtA2.TextChanged

    End Sub

    Private Sub txtSPM_RightToLeftChanged(sender As Object, e As EventArgs) Handles txtSPM.RightToLeftChanged

    End Sub

    Private Sub txtSPM_SystemColorsChanged(sender As Object, e As EventArgs) Handles txtSPM.SystemColorsChanged

    End Sub
End Class
