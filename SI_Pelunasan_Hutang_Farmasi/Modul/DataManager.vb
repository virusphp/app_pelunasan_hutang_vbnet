Imports System.Data.OleDb

Public Class DataManager

    Public Shared Function OpenConnection(ByVal ConnectionString As String, Optional ByVal JenisKoneksi As String = "SIMRS") As OleDbConnection
        Dim Koneksi As OleDbConnection = New OleDbConnection(ConnectionString)
        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Kesalahan Koneksi")
            If JenisKoneksi = "SIMRS" Then
                FormKoneksi.ShowDialog()
            End If
        End Try
        OpenConnection = Koneksi
    End Function

    Public Shared Function ExecuteQuery(ByVal Koneksi As OleDbConnection, ByVal query As String, Optional ByVal NamaTabel As String = "Table1") As DataSet
        Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(query, Koneksi)
        Dim ds As DataSet = New DataSet
        Try
            dataAdapter.Fill(ds, NamaTabel)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DataManager-ExecuteQuery")
        End Try
        Return ds
    End Function
    Public Shared Function ExecuteNonQuery(ByVal Koneksi As OleDbConnection, ByVal query As String) As Boolean
        Try
            Dim dataCommand As New OleDbCommand(query, Koneksi)
            dataCommand.ExecuteNonQuery()
            ExecuteNonQuery = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ExecuteNonQuery = False
        End Try
    End Function

    Public Shared Sub CloseConnection(ByVal Koneksi As OleDbConnection)
        Try
            If Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
