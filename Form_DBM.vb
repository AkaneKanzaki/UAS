Imports System.Data.Odbc
Public Class Form_DBM
    Public Connection As OdbcConnection
    Public Cmd As OdbcCommand
    Public DA As OdbcDataAdapter
    Public DS As New DataSet
    Public DR As OdbcDataReader
    Dim Str As String
    Dim Sql As String
    Public Sub openconnection()
        Str = "Driver={MySQL ODBC 3.51 Driver};database=db_kasir;server=localhost;uid=root"
        Connection = New OdbcConnection(str)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub tampil()
        da = New OdbcDataAdapter("select*from tb_brg", connection)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_brg")
        DataGridView1.DataSource = (ds.Tables("tb_brg"))
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
    End Sub

    Sub bersih()
        Tb_Kode.Clear()
        Tb_Nama.Clear()
        Tb_Jenis.Clear()
        Tb_Stok.Clear()
        Tb_Harga.Clear()
    End Sub

    Private Sub Form_DBM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
        tampil()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        sql = "insert into tb_brg (kode,nama,jenis,stok,harga) values" &
            "('" & Tb_Kode.Text &
            "','" & Tb_Nama.Text &
            "','" & Tb_Jenis.Text &
            "','" & Tb_Stok.Text &
            "','" & Tb_Harga.Text & "')"
        Cmd = New OdbcCommand(Sql, Connection)
        DR = Cmd.ExecuteReader
        bersih()
        tampil()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        sql = "update tb_brg set nama='" & Tb_Nama.Text &
            "', jenis = '" & Tb_Jenis.Text &
            "', stok = '" & Tb_Stok.Text &
            "', harga = '" & Tb_Harga.Text &
            "' where kode = '" & Tb_Kode.Text & "'"
        Cmd = New OdbcCommand(Sql, Connection)
        DR = Cmd.ExecuteReader
        tampil()
        bersih()
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles Tb_Kode.TextChanged

    End Sub

    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Kode.KeyPress
        Dim Pesan As Byte
        If e.KeyChar = Chr(13) Then
            Sql = "select*from tb_brg where kode = '" & Tb_Kode.Text & "'"
            Cmd = New OdbcCommand(Sql, Connection)
            DR = Cmd.ExecuteReader
            If DR.Read Then
                Tb_Nama.Text = DR(1)
                Tb_Jenis.Text = DR(2)
                Tb_Stok.Text = DR(3)
                Tb_Harga.Text = DR(4)
            Else
                Pesan = MsgBox("Data Tidak Ditemukan!", vbOKOnly)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount > 0 Then
            Dim Baris As Integer
            With DataGridView1
                Baris = .CurrentRow.Index
                Tb_Kode.Text = .Item(0, Baris).Value
                Tb_Nama.Text = .Item(1, Baris).Value
                Tb_Jenis.Text = .Item(2, Baris).Value
                Tb_Stok.Text = .Item(3, Baris).Value
                Tb_Harga.Text = .Item(4, Baris).Value
            End With
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click
        If Rb_Kode.Checked = True Then
            da = New OdbcDataAdapter("select*from tb_brg where kode like '%" & Tb_Cari.Text & "%'", connection)
        ElseIf Rb_Nama.Checked = True Then
            da = New OdbcDataAdapter("select*from tb_brg where nama like '%" & Tb_Cari.Text & "&'", connection)
        End If
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_brg")
        DataGridView1.DataSource = (ds.Tables("tb_brg"))
    End Sub


End Class