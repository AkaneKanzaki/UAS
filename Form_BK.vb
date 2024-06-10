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
        Tb_Cari.Clear()
    End Sub

    Private Sub Form_DBM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openconnection()
        Tampil()
    End Sub
End Class