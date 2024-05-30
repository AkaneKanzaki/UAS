Public Class Form_Utama

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

    Private Sub MenuStrip_HargaBarang_Click(sender As Object, e As EventArgs) Handles MenuStrip_HargaBarang.Click
        Dim FR_HargaBarang As New Form_HargaBarang
        FR_HargaBarang.Show()
    End Sub

    Private Sub MenuStrip_DataBarang_Click(sender As Object, e As EventArgs) Handles MenuStrip_DataBarang.Click
        Dim FR_DataBarang As New Form_DaftarBarang
        FR_DataBarang.Show()
    End Sub

    Private Sub MenuStrip_DataPelanggan_Click(sender As Object, e As EventArgs) Handles MenuStrip_DataPelanggan.Click
        Dim FR_DataPelanggan As New Form_DataPelanggan
        FR_DataPelanggan.Show()
    End Sub

    Private Sub MenuStrip_DataPegawai_Click(sender As Object, e As EventArgs) Handles MenuStrip_DataPegawai.Click
        Dim FR_DataPegawai As New Form_DataPegawai
        FR_DataPegawai.Show()
    End Sub

    Private Sub MenuStrip_Stock_Click(sender As Object, e As EventArgs) Handles MenuStrip_Stock.Click
        Dim FR_Stock As New Form_Stock
        FR_Stock.Show()
    End Sub

    Private Sub MenuStrip_Kasir_Click(sender As Object, e As EventArgs) Handles MenuStrip_Kasir.Click
        Dim FR_Kasir As New Form_Kasir
        FR_Kasir.Show()
    End Sub

End Class