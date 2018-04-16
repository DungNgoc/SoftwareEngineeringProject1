Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class HocsinhBUS
    Private HocsinhDAL As HocsinhDAL
    Public Sub New()
        HocsinhDAL = New HocsinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        HocsinhDAL = New HocsinhDAL(connectionString)
    End Sub
    Public Function isValidName(hocsinh As HocsinhDTO) As Boolean

        If (hocsinh.Hotenhocsinh.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function Themhocsinh(hocsinh As HocsinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return HocsinhDAL.Themhocsinh(hocsinh)
    End Function
    Public Function Capnhathocsinh(hocsinh As HocsinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return HocsinhDAL.Capnhathocsinh(hocsinh)
    End Function
    Public Function Chontatcahocsinh(ByRef listHocsinh As List(Of HocsinhDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return HocsinhDAL.Chontatcahocsinh(listHocsinh)
    End Function
    Public Function buildMahocsinh(ByRef nextMahocsinh As Integer) As Result
        Return HocsinhDAL.BuildMasohocsinh(nextMahocsinh)
    End Function
End Class
