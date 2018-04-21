Public Class HocsinhDTO
    Private strMahocsinh As String
    Private strHotenhocsinh As String
    Private strGioitinh As String
    Private strDiachi As String
    Private strLop As String
    Private dateNgaysinh As DateTime
    'Private strKhoi As String
    Public Sub New()
    End Sub
    Public Sub New(strMahocsinh As Integer, strHotenhocsinh As String, strGioitinh As String, strDiachi As String, strLop As String, dateNgaysinh As Date)
        Me.strMahocsinh = strMahocsinh
        Me.strHotenhocsinh = strHotenhocsinh
        Me.strGioitinh = strGioitinh
        Me.strDiachi = strDiachi
        Me.strLop = strLop
        Me.dateNgaysinh = dateNgaysinh
        ' Me.strKhoi = strKhoi
    End Sub
    Property Mahocsinh() As String
        Get
            Return strMahocsinh
        End Get
        Set(ByVal Value As String)
            strMahocsinh = Value
        End Set
    End Property
    Property Hotenhocsinh() As String
        Get
            Return strHotenhocsinh
        End Get
        Set(ByVal Value As String)
            strHotenhocsinh = Value
        End Set
    End Property
    Property Gioitinh() As String
        Get
            Return strGioitinh
        End Get
        Set(ByVal value As String)
            strGioitinh = value
        End Set
    End Property
    Property Diachi() As String
        Get
            Return strDiachi
        End Get
        Set(ByVal value As String)
            strDiachi = value
        End Set
    End Property
    Property Lop() As String
        Get
            Return strLop
        End Get
        Set(ByVal value As String)
            strLop = value
        End Set
    End Property
    Property Ngaysinh() As Date
        Get
            Return dateNgaysinh
        End Get
        Set(ByVal value As Date)
            dateNgaysinh = value
        End Set
    End Property
    'Property Khoi() As String
    '    Get
    '        Return strKhoi
    '    End Get
    '    Set(ByVal value As String)
    '        strKhoi = value
    '    End Set
    'End Property
End Class
