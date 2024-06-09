Imports System.Data.Odbc
Public Class Form_DBM
    Public connection As OdbcConnection
    Public cmmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public ds As New DataSet
    Public dreader As OdbcDataReader
    Dim str As String
    Dim sql As String
    Public Sub openconnection()
        str = "Driver={MySQL ODBC 3.51 Driver};database=db_kasir;server=localhost;uid=root"
        connection = New OdbcConnection(str)
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
        cmmd = New OdbcCommand(sql, connection)
        dreader = cmmd.ExecuteReader
        bersih()
        tampil()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        sql = "update tb_brg set nama='" & Tb_Nama.Text &
            "', jenis = '" & Tb_Jenis.Text &
            "', stok = '" & Tb_Stok.Text &
            "', harga = '" & Tb_Harga.Text &
            "' where kode = '" & Tb_Kode.Text & "'"
        cmmd = New OdbcCommand(sql, connection)
        dreader = cmmd.ExecuteReader
        tampil()
        bersih()
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles Tb_Kode.TextChanged

    End Sub

    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Kode.KeyPress
        Dim pesan As Byte
        If e.KeyChar = Chr(13) Then
            sql = "select*from tb_brg where kode = '" & Tb_Kode.Text & "'"
            cmmd = New OdbcCommand(sql, connection)
            dreader = cmmd.ExecuteReader
            If dreader.Read Then
                Tb_Nama.Text = dreader(1)
                Tb_Jenis.Text = dreader(2)
                Tb_Stok.Text = dreader(3)
                Tb_Harga.Text = dreader(4)
            Else
                pesan = MsgBox("Data Tidak Ditemukan!", vbOKOnly)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                Tb_Kode.Text = .Item(0, baris).Value
                Tb_Nama.Text = .Item(1, baris).Value
                Tb_Jenis.Text = .Item(2, baris).Value
                Tb_Stok.Text = .Item(3, baris).Value
                Tb_Harga.Text = .Item(4, baris).Value
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