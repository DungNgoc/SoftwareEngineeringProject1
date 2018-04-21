Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class LopDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getLopketiep(ByRef nextLop As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [Malop] "
        query &= "FROM [tblLop] "
        query &= "ORDER BY [Malop] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("Malop")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextLop = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextLop = 1
                    Return New Result(False, "Lấy ID kế tiếp của lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function Themlop(lop As LopDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLop] ([Malop], [Tenlop],[Solop],[Makhoi])"
        query &= "VALUES (@Malop,@Tenlop,@Solop,@Makhoi)"

        'Dim nextMasohocsinh = "1"
        'BuildMasohocsinh(nextMasohocsinh)
        'hocsinh.Mahocsinh = nextMasohocsinh

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Malop", lop.Malop)
                    .Parameters.AddWithValue("@Tenlop", lop.Tenlop)
                    .Parameters.AddWithValue("@Solop", lop.Solop)
                    .Parameters.AddWithValue("@Makhoi", lop.Khoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function Chontatcalop(ByRef Listlop As List(Of LopDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [Malop], [Tenlop], [Solop],[Makhoi]"
        query &= "FROM [tblLop]"
        ' query &= "WHERE"
        ' query &= "[Makhoi] =@Makhoi"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("Makhoi")
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        Listlop.Clear()
                        While reader.Read()
                            Listlop.Add(New LopDTO(reader("Malop"), reader("Tenlop"), reader("Solop"), reader("Makhoi")))

                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
