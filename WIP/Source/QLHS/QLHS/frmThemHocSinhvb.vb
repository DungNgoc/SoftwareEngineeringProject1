Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmThemHocSinhvb
    Private HocsinhBUS As HocsinhBUS
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim hocsinh As HocsinhDTO
        hocsinh = New HocsinhDTO()

        '1. Mapping data from GUI control
        hocsinh.Mahocsinh = txtMahocsinh.Text
        hocsinh.Hotenhocsinh = txtHotenhocsinh.Text
        hocsinh.Gioitinh = txtGioitinh.Text
        hocsinh.Ngaysinh = dtpNgaysinh.Value
        hocsinh.Diachi = txtDiachi.Text
        hocsinh.Lop = txtLop.Text

        '2. Business .....
        If (HocsinhBUS.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txtHotenhocsinh.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = HocsinhBUS.Themhocsinh(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMahocsinh = "1"
            result = HocsinhBUS.buildMahocsinh(nextMahocsinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMahocsinh.Text = nextMahocsinh
            txtDiachi.Text = String.Empty
            txtHotenhocsinh.Text = String.Empty

        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub
    Private Sub frmThemHocSinhvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HocsinhBUS = New HocsinhBUS()

        ' Load LoaiHocSinh list
        Dim listHocsinh = New List(Of HocsinhDTO)
        Dim result As Result
        'result = HocsinhBUS.Chontatcahocsinh(listHocsinh)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If

        'set MSSH auto
        Dim nextMahocsinh = "1"
        result = HocsinhBUS.buildMahocsinh(nextMahocsinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMahocsinh.Text = nextMahocsinh

    End Sub

    Private Sub btnNhapvadong_Click(sender As Object, e As EventArgs) Handles btnNhapvadong.Click
        Dim hocsinh As HocsinhDTO
        hocsinh = New HocsinhDTO()

        '1. Mapping data from GUI control
        hocsinh.Mahocsinh = txtMahocsinh.Text
        hocsinh.Hotenhocsinh = txtHotenhocsinh.Text
        hocsinh.Diachi = txtDiachi.Text
        hocsinh.Ngaysinh = dtpNgaysinh.Value
        hocsinh.Gioitinh = txtGioitinh.Text
        hocsinh.Lop = txtLop.Text

        '2. Business .....
        If (HocsinhBUS.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txtHotenhocsinh.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = HocsinhBUS.Themhocsinh(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class