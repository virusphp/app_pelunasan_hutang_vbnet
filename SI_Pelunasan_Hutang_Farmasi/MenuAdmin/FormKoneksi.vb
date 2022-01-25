Imports Syncfusion.Windows.Forms

Public Class FormKoneksi
    Inherits MetroForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DatabaseConnected(txtDbServer.Text, txtDbUser.Text, _
                             txtDbPassword.Text, txtDbName.Text) = True Then
            With My.Settings
                .dbServer = txtDbServer.Text
                .dbUser = txtDbUser.Text
                .dbPassword = Enkripsi.Enkrip(txtDbPassword.Text)
                .dbName = txtDbName.Text
                .Save()
            End With
            GetDatabaseSetting()
            MsgBox("KONEKSI KE DATABASE BERHASIL")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            GetDatabaseSetting()
            MsgBox("KONEKSI KE DATABASE GAGAL")
        End If
    End Sub

    Private Sub FormKoneksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDatabaseSetting()
        txtDbServer.Text = dbServer
        txtDbUser.Text = dbUser
        txtDbPassword.Text = dbPassword
        txtDbName.Text = dbName
    End Sub
End Class
