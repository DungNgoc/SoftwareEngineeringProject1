<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemHocSinhvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.txtMahocsinh = New System.Windows.Forms.TextBox()
        Me.txtHotenhocsinh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGioitinh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btnNhapvadong = New System.Windows.Forms.Button()
        Me.dtpNgaysinh = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Học Sinh"
        '
        'txtMahocsinh
        '
        Me.txtMahocsinh.Location = New System.Drawing.Point(273, 67)
        Me.txtMahocsinh.Name = "txtMahocsinh"
        Me.txtMahocsinh.Size = New System.Drawing.Size(336, 22)
        Me.txtMahocsinh.TabIndex = 1
        Me.txtMahocsinh.Text = "16521576"
        '
        'txtHotenhocsinh
        '
        Me.txtHotenhocsinh.Location = New System.Drawing.Point(273, 95)
        Me.txtHotenhocsinh.Name = "txtHotenhocsinh"
        Me.txtHotenhocsinh.Size = New System.Drawing.Size(336, 22)
        Me.txtHotenhocsinh.TabIndex = 5
        Me.txtHotenhocsinh.Text = "Nguyen Ngoc Dung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Họ tên học sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ngày sinh"
        '
        'txtGioitinh
        '
        Me.txtGioitinh.Location = New System.Drawing.Point(273, 123)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Size = New System.Drawing.Size(336, 22)
        Me.txtGioitinh.TabIndex = 7
        Me.txtGioitinh.Text = "Nu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giới tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Lớp"
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(273, 179)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(336, 22)
        Me.txtDiachi.TabIndex = 11
        Me.txtDiachi.Text = "Dong Nai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Địa chỉ"
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(115, 283)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(100, 53)
        Me.btnNhap.TabIndex = 14
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'btnNhapvadong
        '
        Me.btnNhapvadong.Location = New System.Drawing.Point(465, 283)
        Me.btnNhapvadong.Name = "btnNhapvadong"
        Me.btnNhapvadong.Size = New System.Drawing.Size(144, 53)
        Me.btnNhapvadong.TabIndex = 16
        Me.btnNhapvadong.Text = "Nhập và đóng"
        Me.btnNhapvadong.UseVisualStyleBackColor = True
        '
        'dtpNgaysinh
        '
        Me.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaysinh.Location = New System.Drawing.Point(273, 151)
        Me.dtpNgaysinh.Name = "dtpNgaysinh"
        Me.dtpNgaysinh.Size = New System.Drawing.Size(336, 22)
        Me.dtpNgaysinh.TabIndex = 17
        Me.dtpNgaysinh.Value = New Date(1998, 12, 26, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Khối"
        '
        'cbLop
        '
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(273, 239)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(336, 24)
        Me.cbLop.TabIndex = 20
        '
        'cbKhoi
        '
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(273, 209)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(336, 24)
        Me.cbKhoi.TabIndex = 21
        '
        'frmThemHocSinhvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 468)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.cbLop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpNgaysinh)
        Me.Controls.Add(Me.btnNhapvadong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGioitinh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHotenhocsinh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMahocsinh)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmThemHocSinhvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmThemHocSinhvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents txtMahocsinh As TextBox
    Friend WithEvents txtHotenhocsinh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGioitinh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNhap As Button
    Friend WithEvents btnNhapvadong As Button
    Friend WithEvents dtpNgaysinh As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents cbKhoi As ComboBox
End Class
