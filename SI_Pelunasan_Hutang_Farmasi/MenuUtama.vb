Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Data.SqlClient
Imports System.IO

Public Class MenuUtama
    Inherits RibbonForm
    Private myPicRow As DataRowView
    Private dsDataPegawai As DataSet
    Private bdDataPegawai As New BindingSource
    Private JumUltah As Integer
    Private fs As MemoryStream = Nothing

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Dim fs As MemoryStream = Nothing
        Dim dir As SqlDataReader
        konek()
        Dim com = New SqlCommand("SELECT kd_pegawai,Tgl_Lahir, Tempat_Lahir, nip,nama_pegawai,foto FROM Pegawai WHERE month(tgl_lahir) =(select MONTH(getdate())) AND day(tgl_lahir) =(select DAY(getdate())) AND Status_pegawai = '1'", CONN)
        dir = com.ExecuteReader
        If dir.HasRows Then
            konek()
            DA = New SqlDataAdapter("SELECT kd_pegawai,Tgl_Lahir, Tempat_Lahir, nip,nama_pegawai,foto FROM Pegawai WHERE month(tgl_lahir) =(select MONTH(getdate())) AND day(tgl_lahir) =(select DAY(getdate())) AND Status_pegawai = '1'", CONN)
            dsDataPegawai = New DataSet
            DA.Fill(dsDataPegawai, "Pegawai")
            bdDataPegawai.DataSource = dsDataPegawai
            bdDataPegawai.DataMember = "Pegawai"

            myPicRow = bdDataPegawai.Current
            Dim DataPDF() As Byte
            If IsDBNull(myPicRow.Item("Foto")) Then
                DataPDF = Nothing
                PictureBox2.Image = PictureBox3.Image
                lblNamaUltah.Text = myPicRow.Item("Nama_Pegawai").ToString
                lblTglUltah.Text = myPicRow.Item("Tempat_Lahir").ToString & ", " & Format(myPicRow.Item("Tgl_Lahir").ToString, "dd-MM-yyyy")
            Else
                DataPDF = myPicRow.Item("Foto")
                fs = New System.IO.MemoryStream(DataPDF)
                PictureBox2.Image = Image.FromStream(fs)
                lblNamaUltah.Text = myPicRow.Item("Nama_Pegawai").ToString
                lblTglUltah.Text = myPicRow.Item("Tempat_Lahir").ToString & ", " & Format(myPicRow.Item("Tgl_Lahir").ToString, "dd-MM-yyyy")
            End If
        Else
            PictureBox2.Image = PictureBox3.Image
            lblNamaUltah.Text = ""
            lblTglUltah.Text = ""
        End If
        MenuUtama_Resize(sender, e)
        btnLogout.Enabled = False
    End Sub

    Private Sub MenuUtama_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'PictureBox1.Left = Me.Width - PictureBox1.Width - 40
        'PictureBox2.Left = PictureBox1.Left - PictureBox2.Width - 5
        'lblNamaUltah.Left = PictureBox2.Left - lblNamaUltah.Width - 7
        'lblTglUltah.Left = PictureBox2.Left - lblTglUltah.Width - 7
        'lblTitle.Left = PictureBox2.Left - lblTitle.Width - 7
        'lblDepo.Left = PictureBox2.Left - lblDepo.Width - 7

        PictureBox1.Left = Me.Width - PictureBox1.Width - 20
        PictureBox2.Left = PictureBox1.Left - PictureBox2.Width - 5

        lblNamaUltah.Left = PictureBox2.Left - lblNamaUltah.Width - 10
        lblTglUltah.Left = PictureBox2.Left - lblTglUltah.Width - 10
        lblTitle.Left = PictureBox2.Left - lblTitle.Width - 10
        lblDepo.Left = PictureBox2.Left - lblDepo.Width - 10
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PanelJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        JumUltah = JumUltah + 1
        myPicRow = bdDataPegawai.Current
        If bdDataPegawai.Count > 0 Then
            Dim DataPDF() As Byte
            If IsDBNull(myPicRow.Item("Foto")) Then
                DataPDF = Nothing
                PictureBox2.Image = PictureBox3.Image
                lblNamaUltah.Text = myPicRow.Item("Nama_Pegawai").ToString
                lblTglUltah.Text = myPicRow.Item("Tempat_Lahir").ToString & ", " & Format(myPicRow.Item("Tgl_Lahir"), "dd-MM-yyyy")
            Else
                DataPDF = myPicRow.Item("Foto")
                fs = New System.IO.MemoryStream(DataPDF)
                PictureBox2.Image = Image.FromStream(fs)
                lblNamaUltah.Text = myPicRow.Item("Nama_Pegawai").ToString
                lblTglUltah.Text = myPicRow.Item("Tempat_Lahir").ToString & ", " & Format(myPicRow.Item("Tgl_Lahir"), "dd-MM-yyyy")
            End If

            If JumUltah < bdDataPegawai.Count Then
                bdDataPegawai.MoveNext()
            Else
                bdDataPegawai.MoveFirst()
                JumUltah = 0
            End If

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles logout.Click
        If MessageBox.Show("Anda yakin akan Logout ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormLogin.Close()
            FormLogin.Dispose()
            login.Enabled = True
            logout.Enabled = False
            MenuLunas.Enabled = False
            MenuKoneksi.Enabled = False
            PanelKode.Text = "Kode"
            PanelNama.Text = "Nama"
            PictureBox1.Image = PictureBox3.Image

        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles login.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()
        Dispose()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        FormKoneksi.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FormPelunasanHutang.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        FormKoneksi.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        FormEditPelunasanHutang.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        formLaporanHutang.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FormLaporanPelunasan.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        FormLaporanTandaTerima.ShowDialog()
    End Sub

    Private Sub lblTglUltah_Click(sender As Object, e As EventArgs) Handles lblTglUltah.Click
        MenuUtama_Resize(sender, e)
    End Sub
End Class


