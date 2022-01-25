Imports System.Data.SqlClient

Module koneksi
    Public dbServer As String
    Public dbUser As String
    Public dbPassword As String
    Public dbName As String
    Public sLocalConn As String
    Public CONN As SqlConnection
    Public DA As SqlDataAdapter
    Public DS As New DataSet
    Public CMD As SqlCommand
    Public DR As SqlDataReader
    Public DT As DataTable
    Public DV As DataView
    Public BD As New BindingSource
    Public FormPemanggil As String

    Public Sub GetDatabaseSetting()
        dbServer = My.Settings.dbServer
        dbUser = My.Settings.dbUser
        dbPassword = Enkripsi.Dekrip(My.Settings.dbPassword)
        dbName = My.Settings.dbName
        sLocalConn = "server=" & dbServer & ";user id=" & dbUser & ";" & _
                     "password=" & dbPassword & ";database=" & dbName
    End Sub

    Public Function DatabaseConnected(Optional ByVal Server As String = "", _
            Optional ByVal User As String = "", _
            Optional ByVal Password As String = "", _
            Optional ByVal DatabaseName As String = "") As Boolean

        CONN = New SqlConnection()
        If Server = "" And User = "" And Password = "" And DatabaseName = "" Then
            CONN.ConnectionString = sLocalConn
        Else
            CONN.ConnectionString = "server=" & Server & ";user id=" & _
                                    User & ";password=" & Password & _
                                    ";database=" & DatabaseName
        End If
        Try
            CONN.Open()
            CONN.Close()
            Return True
        Catch myerror As SqlException
            Return False
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            'CONN.Dispose()
        End Try
        Return False
    End Function

    Public Sub konek()
        Try
            GetDatabaseSetting()
            CONN = New SqlConnection()
            CONN.ConnectionString = "server=" & dbServer & ";user id=" & dbUser & ";" & _
                         "password=" & dbPassword & ";database=" & dbName

            CONN.Open()
        Catch ex As Exception
            MsgBox("KONEKSI KE DATABASE GAGAL")
            FormKoneksi.ShowDialog()
        End Try
        Exit Sub
    End Sub

End Module


