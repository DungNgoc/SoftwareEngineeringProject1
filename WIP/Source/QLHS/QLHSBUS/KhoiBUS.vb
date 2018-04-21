Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class KhoiBUS
    Private KhoiDAL As KhoiDAL
    Public Sub New()
        KhoiDAL = New KhoiDAL()
    End Sub
    Public Sub New(connectionString As String)
        KhoiDAL = New KhoiDAL(connectionString)
    End Sub
    Public Function isValidGrade(khoi As KhoiDTO) As Boolean

        If (khoi.Sokhoi > 3 And khoi.Sokhoi < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function Chontatcakhoi(ByRef listKhoi As List(Of KhoiDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhoiDAL.Chontatcakhoi(listKhoi)
    End Function
    Public Function getKhoiketiep(ByRef nextKhoi As Integer) As Result
        Return KhoiDAL.getKhoiketiep(nextKhoi)
    End Function
End Class
