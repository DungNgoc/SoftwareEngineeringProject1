Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmThemHocSinhvb

    Private HocsinhBUS As HocsinhBUS
    Private LopBUS As LopBUS
    Private result As Result
    Private KhoiBUS As KhoiBUS


    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim hocsinh As HocsinhDTO
        hocsinh = New HocsinhDTO()
        '1. Mapping data from GUI control
        hocsinh.Mahocsinh = txtMahocsinh.Text
        hocsinh.Hotenhocsinh = txtHotenhocsinh.Text
        hocsinh.Gioitinh = txtGioitinh.Text
        hocsinh.Ngaysinh = dtpNgaysinh.Value
        hocsinh.Diachi = txtDiachi.Text
        'Dim listLop = New LopDTO()
        'cbLop.DataSource = New BindingSource(listLop, String.Empty)
        'cbLop.DisplayMember = "Tenlop"
        'cbLop.ValueMember = "Malop"
        hocsinh.Lop = cbKhoi.SelectedValue
        ' hocsinh.Khoi = cbKhoi.Text

        '2. Business .....
        If (HocsinhBUS.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txtHotenhocsinh.Focus()
            Return
        End If
        If (HocsinhBUS.isValidAge(hocsinh) = False) Then
            MessageBox.Show("Không đúng tuổi qui định")
            dtpNgaysinh.Focus()
            Return
        End If
        'If (HocsinhBUS.isValidClass(hocsinh) = False) Then
        '    MessageBox.Show("Không đúng lớp qui định")
        '    txtLop.Focus()
        '    Return
        'End If
        '3. Insert to DB
        Dim result As Result
        result = HocsinhBUS.Themhocsinh(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            'Dim nextMahocsinh = "1"
            'result = HocsinhBUS.buildMahocsinh(nextMahocsinh)
            'If (result.FlagResult = False) Then
            '    MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If
            'txtMahocsinh.Text = nextMahocsinh
            'txtDiachi.Text = String.Empty
            'txtHotenhocsinh.Text = String.Empty

        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub
    Private Sub frmThemHocSinhvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HocsinhBUS = New HocsinhBUS()

        'Load LoaiHocSinh list
        'Dim listHocsinh = New List(Of HocsinhDTO)
        'Dim result As Result
        'result = HocsinhBUS.Chontatcahocsinh(listHocsinh)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If

        ' set MSSH auto
        'Dim nextMahocsinh = "1"
        'result = HocsinhBUS.buildMahocsinh(nextMahocsinh)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'txtMahocsinh.Text = nextMahocsinh

        Dim Tenlop = New LopBUS()


        ' Load LoaiHocSinh list
        Dim listLop = New List(Of LopDTO)
        Dim result As Result
        result = Tenlop.Chontatcalop(listLop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLop.DataSource = New BindingSource(listLop, String.Empty)
        cbLop.DisplayMember = "Tenlop"
        cbLop.ValueMember = "Malop"
        'cbLop.ValueMember = "Solop"

        Dim Tenkhoi = New KhoiBUS()
        Dim listKhoi = New List(Of KhoiDTO)
        'Dim result As Result
        result = Tenkhoi.Chontatcakhoi(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        cbKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoi.DisplayMember = "Tenkhoi"
        cbKhoi.ValueMember = "Makhoi"

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
        hocsinh.Lop = cbKhoi.SelectedValue
        ' hocsinh.Khoi = cbKhoi.Text

        '2. Business .....
        If (HocsinhBUS.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txtHotenhocsinh.Focus()
            Return
        End If
        If (HocsinhBUS.isValidAge(hocsinh) = False) Then
            MessageBox.Show("Không đúng tuổi qui định")
            dtpNgaysinh.Focus()
            Return
        End If
        'If (HocsinhBUS.isValidClass(hocsinh) = True) Then
        '    MessageBox.Show("Không đúng lớp qui định")
        '    txtLop.Focus()
        '    Return
        'End If
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

    'Private Sub cbKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoi.SelectedIndexChanged
    '    LopBUS = New LopBUS()
    '    Dim listlop = New List(Of LopDTO)
    '    Dim result2 As Result

    '    result2 = LopBUS.Chontatcalop(cbKhoi.SelectedIndex + 1, listlop)
    '    If (result2.FlagResult = False) Then
    '        MessageBox.Show("Lấy danh sách Lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result2.SystemMessage)
    '        Me.Close()
    '        Return
    '    End If
    '    cbLop.DataSource = New BindingSource(listlop, String.Empty)
    '    cbLop.DisplayMember = "TenLop"
    '    cbLop.ValueMember = "MaLop"
    'End Sub
End Class