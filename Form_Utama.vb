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

	Private Sub DatabaseManajemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseManajemenToolStripMenuItem.Click
		Form_DBM.Show()
	End Sub

	Private Sub StockOpnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOpnameToolStripMenuItem.Click
		Form_BM.Show()
	End Sub

	Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
		Form_BK.Show()
	End Sub

End Class
