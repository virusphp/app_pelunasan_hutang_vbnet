Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient

Public Class FormLogin

    Function PrevInstance() As Boolean
        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub CariKode()
        konek()
        CMD = New SqlCommand("SELECT * FROM ap_pas_farmasi WHERE pasword='" & txtPassword.Text & "' AND uid='" & txtUserID.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Up Then
            txtUserID.Focus()
        End If
    End Sub

    Private Sub TextBoxExt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonAdv1.PerformClick()
        End If

    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PrevInstance() = True Then
            MsgBox("Aplikasi SI Apotek Pelayanan Sudah Berjalan", vbExclamation, "Warning")
            If MsgBox("Apakah akan mengeluarkan secara paksa aplikasi SI Apotek Pelayanan yang berjalan?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                Shell("Taskkill /f /im SI_Apotek_Pelayanan.exe")
            Else
                End
            End If
        End If
        Call konek()
        txtUserID.Text = "00000001"
        txtPassword.Text = "2222"
    End Sub

    Private Sub TextBoxExt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
            'pass()
        End If
    End Sub

    Private Sub TextBoxExt1_LostFocus(sender As Object, e As EventArgs) Handles txtUserID.LostFocus
        If txtUserID.Text <> "" Then
            Dim myMs As New IO.MemoryStream
            Dim dri As SqlDataReader
            Dim dri2 As SqlDataReader
            Dim arrimage As Byte()
            Call konek()
            Try
                Dim com As New SqlCommand("SELECT foto,nama_pegawai,nip FROM Pegawai where kd_pegawai = '" & txtUserID.Text & "'", CONN)
                dri = com.ExecuteReader
                If dri.HasRows Then
                    dri.Read()
                    If IsDBNull(dri.Item(0)) Then
                        Call konek()
                        Dim com2 As New SqlCommand("SELECT nama_pegawai,nip FROM Pegawai where kd_pegawai = '" & txtUserID.Text & "'", CONN)
                        dri2 = com2.ExecuteReader
                        dri2.Read()
                        Me.lblNama.Text = dri2.Item(0)
                        Me.lblNip.Text = dri2.Item(1)
                    Else
                        'While dri.Read
                        arrimage = dri(0)
                        For Each ar As Byte In arrimage
                            myMs.WriteByte(ar)
                        Next
                        Me.PictureBox1.Image = System.Drawing.Image.FromStream(myMs)
                        Me.lblNama.Text = dri.Item(1)
                        Me.lblNip.Text = dri.Item(2)
                        'End While
                        PictureBox1.Visible = True
                        PictureBox2.Visible = False

                    End If
                Else
                    MsgBox("User ID tidak ditemukan", vbCritical, "Kesalahan")
                    txtUserID.Clear()
                    Exit Sub
                End If

                With PictureBox1
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With

            Catch ex As Exception

            End Try
            txtPassword.Focus()
        End If
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click
        CariKode()
        If DR.HasRows Then
            'MenuUtama.Show()\
            MenuUtama.MenuLunas.Enabled = True
            MenuUtama.MenuKoneksi.Enabled = True
            MenuUtama.PictureBox1.Image = PictureBox1.Image
            LabelNama.Text = Trim(DR.Item("nmkasir"))
            LabelKode.Text = Trim(DR.Item("kdkasir"))

            sesiAplikasi.sesiUID = Trim(DR.Item("kdkasir"))
            sesiAplikasi.sesiNamaUser = Trim(DR.Item("nmkasir"))

            MenuUtama.PanelKode.Text = txtUserID.Text
            MenuUtama.PanelNama.Text = lblNama.Text
            MenuUtama.login.Enabled = False
            MenuUtama.logout.Enabled = True
            TglServer()
            MenuUtama.PanelTanggal.Text = Format(TanggalServer, "dddd, dd MMMM yyyy")
            Me.Visible = False
        Else
            MsgBox("Password atau User ID salah", vbCritical, "Kesalahan")
            Exit Sub
        End If

    End Sub

End Class
