Imports System.Data.Odbc

Public Class Form_Utama
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
        DA = New OdbcDataAdapter("select*from tb_brg", Connection)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_brg")
        DataGridView1.DataSource = (DS.Tables("tb_brg"))
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
    End Sub

    Sub Bersih()
        Tb_FilterKode.Clear()
        Tb_FilterJumlah.Clear()
        Tb_Total.Clear()
        Tb_Bayar.Clear()
        Tb_Kembalian.Clear()
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

    Private Sub MenuStrip_BarangMasuk_Click(sender As Object, e As EventArgs) Handles MenuStrip_BarangMasuk.Click
        Form_BM.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip_BarangKeluar_Click(sender As Object, e As EventArgs) Handles MenuStrip_BarangKeluar.Click
        Form_BK.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Tambah_Click(sender As Object, e As EventArgs) Handles Btn_Tambah.Click
        Dim Pesan As Byte
        Dim HargaSatuan As Decimal
        Dim Jumlah As Integer
        Dim TotalHarga As Decimal
        Sql = "select*from tb_brg where kode = '" & Tb_FilterKode.Text & "'"
        Cmd = New OdbcCommand(Sql, Connection)
        DR = Cmd.ExecuteReader
        If DR.Read Then
            HargaSatuan = Convert.ToDecimal(DR("harga"))
            If Integer.TryParse(Tb_FilterJumlah.Text, Jumlah) Then
                TotalHarga = HargaSatuan * Jumlah
                Tb_Total.Text = TotalHarga.ToString("N0")
            Else
                Pesan = MsgBox("Masukkan jumlah barang yang valid!", vbOKOnly)
            End If
        Else
            Pesan = MsgBox("Data Tidak Ditemukan!", vbOKOnly)
        End If
    End Sub



    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Bersih()
    End Sub

    Private Sub Tb_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles Tb_Bayar.TextChanged
        Dim TotalHarga As Decimal
        Dim JumlahBayar As Decimal
        Dim Kembalian As Decimal

        ' Mendapatkan total harga dari TextBox
        If Decimal.TryParse(Tb_Total.Text, TotalHarga) AndAlso Decimal.TryParse(Tb_Bayar.Text, JumlahBayar) Then
            ' Menghitung kembalian
            Kembalian = JumlahBayar - TotalHarga
            Tb_Kembalian.Text = Kembalian.ToString("N0") ' Format angka sebagai integer tanpa desimal
        Else
            Tb_Kembalian.Text = "0"
        End If
    End Sub
End Class
