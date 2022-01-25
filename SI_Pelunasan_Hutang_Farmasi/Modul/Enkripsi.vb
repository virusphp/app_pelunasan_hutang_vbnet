Module Enkripsi
    Function EncryptText(ByVal strText As String, ByVal strPwd As String)
        Dim i, C As Integer

        Dim strBuff As String
        strBuff = ""
        If strPwd <> "" And strText <> "" Then
            strPwd = UCase(strPwd)
            If Len(strPwd) Then
                For i = 1 To Len(strText)
                    C = Asc(Mid(strText, i, 1))
                    C = C + Asc(Mid(strPwd, (i Mod Len(strPwd)) + 1, 1))
                    strBuff = strBuff & ChrW(C And &HFF)
                Next
            Else
                strBuff = strText
            End If
            EncryptText = strBuff
        Else
            EncryptText = ""
        End If
    End Function

    Function DecryptText(strText, ByVal strPwd)
        Dim i, C
        Dim strBuff
        strBuff = ""
        If strPwd <> "" And strText <> "" Then
            strPwd = UCase(strPwd)
            If Len(strPwd) Then
                For i = 1 To Len(strText)
                    C = Asc(Mid(strText, i, 1))
                    C = C - Asc(Mid(strPwd, (i Mod Len(strPwd)) + 1, 1))
                    strBuff = strBuff & Chr(C And &HFF)
                Next
            Else
                strBuff = strText
            End If
            DecryptText = strBuff
        Else
            DecryptText = ""
        End If
    End Function

    Function Enkrip(pwd As String) As String
        Dim s As String
        s = ""
        For i = 1 To Len(pwd)
            s = s + Chr(Asc(Mid(pwd, i, 1)) + 32)
        Next i
        Enkrip = s
    End Function

    Function Dekrip(pwd As String) As String
        Dim s As String
        s = ""
        For i = 1 To Len(pwd)
            s = s + Chr(Asc(Mid(pwd, i, 1)) - 32)
        Next i
        Dekrip = s
    End Function

End Module
