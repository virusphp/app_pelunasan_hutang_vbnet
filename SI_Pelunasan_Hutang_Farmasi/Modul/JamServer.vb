Imports System.Data.SqlClient

Module JamServer
    Public TanggalServer As Date

    Public Sub TglServer()
        konek()
        CMD = New SqlCommand("Select GETDATE() AS TanggalJam", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        On Error Resume Next
        TanggalServer = DR.Item("TanggalJam")
    End Sub

End Module
