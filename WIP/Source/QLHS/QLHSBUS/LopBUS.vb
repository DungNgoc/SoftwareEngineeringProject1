Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class LopBUS
    Private LopDAL As LopDAL
    Public Sub New()
        LopDAL = New LopDAL()
    End Sub
    Public Sub New(connectionString As String)
        LopDAL = New LopDAL(connectionString)
    End Sub
    Public Function isValidClass(lop As LopDTO) As Boolean

        If (lop.Solop > 20 And lop.Solop < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function Chontatcalop(ByRef listLop As List(Of LopDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LopDAL.Chontatcalop(listLop)
    End Function
    Public Function getLopketiep(ByRef nextLop As Integer) As Result
        Return LopDAL.getLopketiep(nextLop)
    End Function
End Class
