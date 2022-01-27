Imports System.Globalization

Module ModulAplikasi
    Public Sub addImegeOnGrid(e As DataGridViewCellPaintingEventArgs, ByVal colIndex As Integer, ByVal image As Image)
        If e.ColumnIndex = colIndex AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim bm As New Drawing.Bitmap(image)
            e.Graphics.DrawImage(bm, CInt((e.CellBounds.Width / 2) - (bm.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (bm.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Public Function buletin(ByVal Number As Double, Optional range As Integer = 10) As Double
        buletin = (Math.Round((Number / range) + 0.49)) * range
    End Function

    Public Function Num_En_US(ByVal NumberDecimal As Decimal) As String
        Dim us As New CultureInfo("en-US")
        Num_En_US = NumberDecimal.ToString("", us)
        Return Num_En_US
    End Function

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {" ", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}

        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " Belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " Puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " Seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " Ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " Seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Public Function Rep(ByVal Kata As String) As String
        Rep = Replace(Kata, "'", "''")
    End Function

End Module
