Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub HồSơHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HồSơHọcToolStripMenuItem.Click

    End Sub

    Private Sub ThêmHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHọcSinhToolStripMenuItem.Click
        Dim frmhs As frmThemHocSinhvb = New frmThemHocSinhvb()
        frmhs.MdiParent = Me
        frmhs.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
End Class
