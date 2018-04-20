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
    Public Function isValidAge(hocsinh As HocsinhDTO) As Boolean
        Dim currentYear = DateTime.Now.Year
        If (currentYear - hocsinh.Ngaysinh.Year > 21 Or currentYear - hocsinh.Ngaysinh.Year < 14) Then
            Return False
        End If

        Return True
    End Function
    'Public Function isValidClass(hocsinh As HocsinhDTO) As Boolean
    '    If (hocsinh.Lop.Substring(2, hocsinh.Lop.Length - 2) = 10 Or hocsinh.Lop.Substring(2, hocsinh.Lop.Length - 2) = 11 Or hocsinh.Lop.Substring(2, hocsinh.Lop.Length - 2) = 12) Then
    '        Return True
    '    End If

    '    Return False
    'End Function
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
    'Public Function buildMahocsinh(ByRef nextMahocsinh As Integer) As Result
    '    Return HocsinhDAL.BuildMasohocsinh(nextMahocsinh)
    'End Function
End Class
