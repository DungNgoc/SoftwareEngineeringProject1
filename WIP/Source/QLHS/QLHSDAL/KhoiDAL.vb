Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class KhoiDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getKhoiketiep(ByRef nextKhoi As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [Makhoi] "
        query &= "FROM [tblKhoi] "
        query &= "ORDER BY [Makhoi] DESC "

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
                            idOnDB = reader("Makhoi")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextKhoi = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextKhoi = 1
                    Return New Result(False, "Lấy ID kế tiếp của lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function Themkhoi(khoi As KhoiDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKhoi] ([Makhoi], [Tenkhoi],[Sokhoi])"
        query &= "VALUES (@Malop,@Tenlop,@Sokhoi)"

        'Dim nextMasohocsinh = "1"
        'BuildMasohocsinh(nextMasohocsinh)
        'hocsinh.Mahocsinh = nextMasohocsinh

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Makhoi", khoi.Makhoi)
                    .Parameters.AddWithValue("@Tenkhoi", khoi.Tenkhoi)
                    .Parameters.AddWithValue("@Sokhoi", khoi.Sokhoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function Chontatcakhoi(ByRef Listkhoi As List(Of KhoiDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [Makhoi], [Tenkhoi], [Sokhoi]"
        query &= "FROM [tblKhoi]"
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
                    If reader.HasRows = True Then
                        Listkhoi.Clear()
                        While reader.Read()
                            Listkhoi.Add(New KhoiDTO(reader("Makhoi"), reader("Tenkhoi"), reader("Sokhoi")))

                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
