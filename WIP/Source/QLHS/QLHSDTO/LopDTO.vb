
Public Class LopDTO
    Private strMalop As String
    Private strTenlop As String
    Private iSolop As Integer
    Private strMakhoi As String
    Public Sub New()
    End Sub
    Public Sub New(strMalop As String, strTenlop As String, iSolop As Integer, strMakhoi As String)
        Me.strMalop = strMalop
        Me.strTenlop = strTenlop
        Me.iSolop = iSolop
        Me.strMakhoi = strMakhoi
    End Sub
    Property Malop() As String
        Get
            Return strMalop
        End Get
        Set(ByVal Value As String)
            strMalop = Value
        End Set
    End Property
    Property Tenlop() As String
        Get
            Return strTenlop
        End Get
        Set(ByVal Value As String)
            strTenlop = Value
        End Set
    End Property
    Property Solop() As String
        Get
            Return iSolop
        End Get
        Set(ByVal Value As String)
            iSolop = Value
        End Set
    End Property
    Property Khoi() As String
        Get
            Return strMakhoi
        End Get
        Set(ByVal Value As String)
            strMakhoi = Value
        End Set
    End Property
End Class
