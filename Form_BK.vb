Imports System.Data.Odbc

Public Class Form_BK
    Public Connection As OdbcConnection
    Public Cmd As OdbcCommand
    Public DA As OdbcDataAdapter
    Public DS As New DataSet
    Public DR As OdbcDataReader
    Dim Str As String
    Dim Sql As String

    Public Sub Openconnection()
        Str = "Driver={MySQL ODBC 3.51 Driver};database=db_kasir;server=localhost;uid=root"
        Connection = New OdbcConnection(Str)
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If
    End Sub

    Sub Tampil()
        DA = New OdbcDataAdapter("select * from tb_transaksi", Connection)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
    End Sub

    Private Sub Form_DBM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        Tampil()
    End Sub

    Private Sub MenuStrip_SetelanPengguna_Click(sender As Object, e As EventArgs) Handles MenuStrip_SetelanPengguna.Click

    End Sub

    Private Sub MenuStrip_Logout_Click(sender As Object, e As EventArgs) Handles MenuStrip_Logout.Click
        Dim FR_Login As New Form_Login
        FR_Login.Show()
        Me.Close()
    End Sub

    Private Sub MenuStrip_Keluar_Click(sender As Object, e As EventArgs) Handles MenuStrip_Keluar.Click
        Dim Pesan As Byte
        Pesan = MsgBox("Apakah anda ingin keluar dari aplikasi?", vbYesNo)
        If Pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub MenuStrip_DatabaseManajemen_Click(sender As Object, e As EventArgs) Handles MenuStrip_DatabaseManajemen.Click
        Form_DBM.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip_Kasir_Click_1(sender As Object, e As EventArgs) Handles MenuStrip_Kasir.Click
        Form_Utama.Show()
        Me.Hide()
    End Sub
End Class