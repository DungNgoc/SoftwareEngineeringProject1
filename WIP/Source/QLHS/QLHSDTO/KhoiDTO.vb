Public Class KhoiDTO
    Private strMakhoi As String
    Private strTenkhoi As String
    Private iSokhoi As Integer
    Public Sub New()
    End Sub
    Public Sub New(strMakhoi As String, strTenkhoi As String, iSokhoi As Integer)
        Me.strMakhoi = strMakhoi
        Me.strTenkhoi = strTenkhoi
        Me.iSokhoi = iSokhoi
    End Sub

    Public Property Makhoi() As String
        Get
            Return strMakhoi
        End Get
        Set(value As String)
            strMakhoi = value
        End Set
    End Property

    Public Property Tenkhoi() As String
        Get
            Return strTenkhoi
        End Get
        Set(value As String)
            strTenkhoi = value
        End Set
    End Property

    Public Property Sokhoi() As Integer
        Get
            Return iSokhoi
        End Get
        Set(value As Integer)
            iSokhoi = value
        End Set
    End Property
End Class
