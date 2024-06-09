<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DBM
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_Kode = New System.Windows.Forms.TextBox()
        Me.Tb_Nama = New System.Windows.Forms.TextBox()
        Me.Tb_Jenis = New System.Windows.Forms.TextBox()
        Me.Tb_Stok = New System.Windows.Forms.TextBox()
        Me.Tb_Harga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Simpan = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Hapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tb_Cari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rb_Kode = New System.Windows.Forms.RadioButton()
        Me.Rb_Nama = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetelanPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseManajemenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOpnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kasirku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Database Management"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jenis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Stok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 258)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Harga"
        '
        'Tb_Kode
        '
        Me.Tb_Kode.Location = New System.Drawing.Point(139, 130)
        Me.Tb_Kode.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Kode.Name = "Tb_Kode"
        Me.Tb_Kode.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Kode.TabIndex = 1
        '
        'Tb_Nama
        '
        Me.Tb_Nama.Location = New System.Drawing.Point(139, 162)
        Me.Tb_Nama.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Nama.Name = "Tb_Nama"
        Me.Tb_Nama.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Nama.TabIndex = 2
        '
        'Tb_Jenis
        '
        Me.Tb_Jenis.Location = New System.Drawing.Point(139, 194)
        Me.Tb_Jenis.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Jenis.Name = "Tb_Jenis"
        Me.Tb_Jenis.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Jenis.TabIndex = 3
        '
        'Tb_Stok
        '
        Me.Tb_Stok.Location = New System.Drawing.Point(139, 226)
        Me.Tb_Stok.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Stok.Name = "Tb_Stok"
        Me.Tb_Stok.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Stok.TabIndex = 4
        '
        'Tb_Harga
        '
        Me.Tb_Harga.Location = New System.Drawing.Point(139, 258)
        Me.Tb_Harga.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Harga.Name = "Tb_Harga"
        Me.Tb_Harga.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Harga.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 94)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Data Barang"
        '
        'Btn_Simpan
        '
        Me.Btn_Simpan.Location = New System.Drawing.Point(27, 308)
        Me.Btn_Simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Simpan.Name = "Btn_Simpan"
        Me.Btn_Simpan.Size = New System.Drawing.Size(100, 28)
        Me.Btn_Simpan.TabIndex = 6
        Me.Btn_Simpan.Text = "SIMPAN"
        Me.Btn_Simpan.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(135, 308)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(100, 28)
        Me.Btn_Edit.TabIndex = 7
        Me.Btn_Edit.Text = "EDIT"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Hapus
        '
        Me.Btn_Hapus.Location = New System.Drawing.Point(243, 308)
        Me.Btn_Hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Hapus.Name = "Btn_Hapus"
        Me.Btn_Hapus.Size = New System.Drawing.Size(100, 28)
        Me.Btn_Hapus.TabIndex = 8
        Me.Btn_Hapus.Text = "HAPUS"
        Me.Btn_Hapus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(371, 94)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Search"
        '
        'Tb_Cari
        '
        Me.Tb_Cari.Location = New System.Drawing.Point(447, 93)
        Me.Tb_Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Cari.Name = "Tb_Cari"
        Me.Tb_Cari.Size = New System.Drawing.Size(95, 22)
        Me.Tb_Cari.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(371, 130)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Filter"
        '
        'Rb_Kode
        '
        Me.Rb_Kode.AutoSize = True
        Me.Rb_Kode.Location = New System.Drawing.Point(447, 129)
        Me.Rb_Kode.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb_Kode.Name = "Rb_Kode"
        Me.Rb_Kode.Size = New System.Drawing.Size(60, 20)
        Me.Rb_Kode.TabIndex = 11
        Me.Rb_Kode.TabStop = True
        Me.Rb_Kode.Text = "Kode"
        Me.Rb_Kode.UseVisualStyleBackColor = True
        '
        'Rb_Nama
        '
        Me.Rb_Nama.AutoSize = True
        Me.Rb_Nama.Location = New System.Drawing.Point(447, 157)
        Me.Rb_Nama.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb_Nama.Name = "Rb_Nama"
        Me.Rb_Nama.Size = New System.Drawing.Size(65, 20)
        Me.Rb_Nama.TabIndex = 12
        Me.Rb_Nama.TabStop = True
        Me.Rb_Nama.Text = "Nama"
        Me.Rb_Nama.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(375, 185)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(409, 278)
        Me.DataGridView1.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetelanPenggunaToolStripMenuItem, Me.MenuStrip_Logout, Me.MenuStrip_Keluar})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.PenggunaToolStripMenuItem.Text = "File"
        '
        'SetelanPenggunaToolStripMenuItem
        '
        Me.SetelanPenggunaToolStripMenuItem.Name = "SetelanPenggunaToolStripMenuItem"
        Me.SetelanPenggunaToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.SetelanPenggunaToolStripMenuItem.Text = "Setelan Pengguna"
        '
        'MenuStrip_Logout
        '
        Me.MenuStrip_Logout.Name = "MenuStrip_Logout"
        Me.MenuStrip_Logout.Size = New System.Drawing.Size(210, 26)
        Me.MenuStrip_Logout.Text = "Logout"
        '
        'MenuStrip_Keluar
        '
        Me.MenuStrip_Keluar.Name = "MenuStrip_Keluar"
        Me.MenuStrip_Keluar.Size = New System.Drawing.Size(210, 26)
        Me.MenuStrip_Keluar.Text = "Keluar"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseManajemenToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ViewToolStripMenuItem.Text = "Master"
        '
        'DatabaseManajemenToolStripMenuItem
        '
        Me.DatabaseManajemenToolStripMenuItem.Name = "DatabaseManajemenToolStripMenuItem"
        Me.DatabaseManajemenToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.DatabaseManajemenToolStripMenuItem.Text = "Database Manajemen"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockOpnameToolStripMenuItem, Me.BarangKeluarToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'StockOpnameToolStripMenuItem
        '
        Me.StockOpnameToolStripMenuItem.Name = "StockOpnameToolStripMenuItem"
        Me.StockOpnameToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.StockOpnameToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'Btn_Cari
        '
        Me.Btn_Cari.Location = New System.Drawing.Point(558, 94)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cari.TabIndex = 10
        Me.Btn_Cari.Text = "Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = True
        '
        'Form_DBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.Btn_Cari)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Rb_Nama)
        Me.Controls.Add(Me.Rb_Kode)
        Me.Controls.Add(Me.Btn_Hapus)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Simpan)
        Me.Controls.Add(Me.Tb_Harga)
        Me.Controls.Add(Me.Tb_Stok)
        Me.Controls.Add(Me.Tb_Jenis)
        Me.Controls.Add(Me.Tb_Nama)
        Me.Controls.Add(Me.Tb_Cari)
        Me.Controls.Add(Me.Tb_Kode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_DBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_DBM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Tb_Kode As TextBox
	Friend WithEvents Tb_Nama As TextBox
	Friend WithEvents Tb_Jenis As TextBox
	Friend WithEvents Tb_Stok As TextBox
	Friend WithEvents Tb_Harga As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Btn_Simpan As Button
	Friend WithEvents Btn_Edit As Button
	Friend WithEvents Btn_Hapus As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents Tb_Cari As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Rb_Kode As RadioButton
	Friend WithEvents Rb_Nama As RadioButton
	Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetelanPenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_Logout As ToolStripMenuItem
    Friend WithEvents MenuStrip_Keluar As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseManajemenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOpnameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Cari As Button
End Class
