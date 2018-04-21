Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class HocsinhDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    'Public Function BuildMasohocsinh(ByRef nextMasohocsinh As String) As Result
    '    nextMasohocsinh = String.Empty
    '    Dim y = DateTime.Now.Year
    '    Dim x = y.ToString().Substring(2)
    '    nextMasohocsinh = x + "000000"
    '    Dim query As String = String.Empty
    '    query &= "SELECT TOP 1 [Masohocsinh]"
    '    query &= "FROM [tblHocsinh]"
    '    query &= "ORDER BY [Masohocsinh] DESC"
    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                Dim msOnDB As String
    '                msOnDB = Nothing
    '                If reader.HasRows = True Then
    '                    While reader.Read()
    '                        msOnDB = reader("Masohocsinh")
    '                    End While
    '                End If
    '                If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
    '                    Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
    '                    Dim icurrentYear = Integer.Parse(currentYear)
    '                    Dim currentYearOnDB = msOnDB.Substring(0, 2)
    '                    Dim iCurrentYearOnDB = Integer.Parse(currentYearOnDB)
    '                    Dim year = icurrentYear
    '                    If (year < iCurrentYearOnDB) Then
    '                        year = iCurrentYearOnDB
    '                    End If
    '                    nextMasohocsinh = year.ToString()
    '                    Dim v = msOnDB.Substring(2)
    '                    Dim convertDecimal = Convert.ToDecimal(v)
    '                    convertDecimal = convertDecimal + 1
    '                    Dim tmp = convertDecimal.ToString()
    '                    tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
    '                    nextMasohocsinh = nextMasohocsinh + tmp
    '                    System.Console.WriteLine(nextMasohocsinh)

    '                End If
    '            Catch ex As Exception
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True)
    'End Function
    Public Function Themhocsinh(hocsinh As HocsinhDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHocSinh] ([Mahocsinh], [Hotenhocsinh], [Gioitinh], [Ngaysinh], [Diachi],[Malop])"
        query &= "VALUES (@Mahocsinh,@Hotenhocsinh,@Gioitinh,@Ngaysinh,@Diachi,@Malop)"

        'Dim nextMasohocsinh = "1"
        'BuildMasohocsinh(nextMasohocsinh)
        'hocsinh.Mahocsinh = nextMasohocsinh

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Mahocsinh", hocsinh.Mahocsinh)
                    .Parameters.AddWithValue("@Hotenhocsinh", hocsinh.Hotenhocsinh)
                    .Parameters.AddWithValue("@Gioitinh", hocsinh.Gioitinh)
                    .Parameters.AddWithValue("@Ngaysinh", hocsinh.Ngaysinh)
                    .Parameters.AddWithValue("@Diachi", hocsinh.Diachi)
                    .Parameters.AddWithValue("@Malop", hocsinh.Lop)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'Public Function Chontatcahocsinh(ByRef Listhocsinh As List(Of HocsinhDTO)) As Result
    '    Dim query As String = String.Empty
    '    query &= "SELECT [Mahocsinh], [Hotenhocsinh], [Gioitinh], [Ngaysinh], [Diachi],[Lop]"
    '    query &= "FROM [tblHocsinh]"
    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                reader = comm.ExecuteReader()
    '                If reader.HasRows = True Then
    '                    Listhocsinh.Clear()
    '                    While reader.Read()
    '                        Listhocsinh.Add(New HocsinhDTO(reader("Mahocsinh"), reader("Hotenhocsinh"), reader("Gioitinh"), reader("Ngaysinh"), reader("Diachi"), reader("Lop")))

    '                    End While
    '                End If
    '            Catch ex As Exception
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Lấy tất cả Học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True)
    'End Function
    Public Function Capnhathocsinh(hocsinh As HocsinhDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblHocsinh] SET"
        query &= " [Hotenhocsinh] = @Hotenhocsinh "
        query &= " ,[Gioitinh] = @Gioitinh"
        query &= " ,[Ngaysinh] = @Ngaysinh"
        query &= " ,[Diachi] = @Diachi"
        query &= ",[Lop] = @Lop"
        query &= " WHERE "
        query &= " [Mahocsinh] = @Mahocsinh"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Hotenhocsinh", hocsinh.Hotenhocsinh)
                    .Parameters.AddWithValue("@Gioitinh", hocsinh.Gioitinh)
                    .Parameters.AddWithValue("@Ngaysinh", hocsinh.Ngaysinh)
                    .Parameters.AddWithValue("@Diachi", hocsinh.Diachi)
                    .Parameters.AddWithValue("@Lop", hocsinh.Lop)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function Xoahocsinh(Mahocsinh As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblHocsinh] "
        query &= " WHERE "
        query &= " [Mahocsinh] = @Mahocsinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Mahocsinh", Mahocsinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

End Class
