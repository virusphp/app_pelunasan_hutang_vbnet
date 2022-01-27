Public Module ModulSession
    Public Structure session
        Public sesiUID As String
        Public sesiPWD As String
        Public sesiNIPUser As String
        Public sesiNamaUser As String
        Public sesiNamaUserTanpaGelar As String

        Public sesiVersiSIMRS As String
        Public sesiVersiCodeSIMRS As Integer
        Public sesiLamaAppEdit As Integer
        Public sesiNoAplikasi As String

        Public sesiAplikasi As String
        Public sesiNIK As String

        Public sesiKdSubUnit As String
        Public sesiNamaSubUnit As String
    End Structure

    Public sesiAplikasi As session
End Module
