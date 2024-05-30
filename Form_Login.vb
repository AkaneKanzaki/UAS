Public Class Form_Login
    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        If tb_username.Text = "" Then
            MsgBox("User tidak dapat ditemukan!")
        ElseIf tb_password.Text = "" Then
            MsgBox("User tidak dapat ditemukan!")
        Else
            If tb_username.Text = "admin" And tb_password.Text = "admin" Then
                Dim FR_Utama As New Form_Utama
                FR_Utama.Show()
                Me.Hide()
            Else
                MsgBox("Username atau password salah!")
            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Dim Pesan As Byte
        Pesan = MsgBox("Apakah anda ingin keluar dari aplikasi?", vbYesNo)
        If Pesan = vbYes Then
            Close()
        End If
    End Sub
End Class
