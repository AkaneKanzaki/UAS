<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_SetelanPengguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_DatabaseManajemen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_BarangMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_BarangKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_Bayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_Kembalian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tb_Kode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_JumlahBarang = New System.Windows.Forms.TextBox()
        Me.Btn_TambahBarang = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_Simpan = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_SetelanPengguna, Me.MenuStrip_Logout, Me.MenuStrip_Keluar})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.PenggunaToolStripMenuItem.Text = "File"
        '
        'MenuStrip_SetelanPengguna
        '
        Me.MenuStrip_SetelanPengguna.Name = "MenuStrip_SetelanPengguna"
        Me.MenuStrip_SetelanPengguna.Size = New System.Drawing.Size(210, 26)
        Me.MenuStrip_SetelanPengguna.Text = "Setelan Pengguna"
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_DatabaseManajemen, Me.MenuStrip_Transaksi})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(68, 26)
        Me.ViewToolStripMenuItem.Text = "Master"
        '
        'MenuStrip_DatabaseManajemen
        '
        Me.MenuStrip_DatabaseManajemen.Name = "MenuStrip_DatabaseManajemen"
        Me.MenuStrip_DatabaseManajemen.Size = New System.Drawing.Size(237, 26)
        Me.MenuStrip_DatabaseManajemen.Text = "Database Manajemen"
        '
        'MenuStrip_Transaksi
        '
        Me.MenuStrip_Transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_BarangMasuk, Me.MenuStrip_BarangKeluar})
        Me.MenuStrip_Transaksi.Name = "MenuStrip_Transaksi"
        Me.MenuStrip_Transaksi.Size = New System.Drawing.Size(237, 26)
        Me.MenuStrip_Transaksi.Text = "Transaksi"
        '
        'MenuStrip_BarangMasuk
        '
        Me.MenuStrip_BarangMasuk.Name = "MenuStrip_BarangMasuk"
        Me.MenuStrip_BarangMasuk.Size = New System.Drawing.Size(185, 26)
        Me.MenuStrip_BarangMasuk.Text = "Barang Masuk"
        '
        'MenuStrip_BarangKeluar
        '
        Me.MenuStrip_BarangKeluar.Name = "MenuStrip_BarangKeluar"
        Me.MenuStrip_BarangKeluar.Size = New System.Drawing.Size(185, 26)
        Me.MenuStrip_BarangKeluar.Text = "Barang Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kasirku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(704, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total"
        '
        'Tb_Total
        '
        Me.Tb_Total.Location = New System.Drawing.Point(545, 127)
        Me.Tb_Total.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Total.Multiline = True
        Me.Tb_Total.Name = "Tb_Total"
        Me.Tb_Total.Size = New System.Drawing.Size(237, 38)
        Me.Tb_Total.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Uang"
        '
        'Tb_Bayar
        '
        Me.Tb_Bayar.Location = New System.Drawing.Point(545, 215)
        Me.Tb_Bayar.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Bayar.Multiline = True
        Me.Tb_Bayar.Name = "Tb_Bayar"
        Me.Tb_Bayar.Size = New System.Drawing.Size(237, 38)
        Me.Tb_Bayar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(633, 274)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kembalian"
        '
        'Tb_Kembalian
        '
        Me.Tb_Kembalian.Location = New System.Drawing.Point(545, 309)
        Me.Tb_Kembalian.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Kembalian.Multiline = True
        Me.Tb_Kembalian.Name = "Tb_Kembalian"
        Me.Tb_Kembalian.Size = New System.Drawing.Size(237, 38)
        Me.Tb_Kembalian.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kode"
        '
        'Tb_Kode
        '
        Me.Tb_Kode.Location = New System.Drawing.Point(76, 90)
        Me.Tb_Kode.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Kode.Multiline = True
        Me.Tb_Kode.Name = "Tb_Kode"
        Me.Tb_Kode.Size = New System.Drawing.Size(121, 21)
        Me.Tb_Kode.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(477, 293)
        Me.DataGridView1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Jumlah"
        '
        'Tb_JumlahBarang
        '
        Me.Tb_JumlahBarang.Location = New System.Drawing.Point(285, 89)
        Me.Tb_JumlahBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_JumlahBarang.Multiline = True
        Me.Tb_JumlahBarang.Name = "Tb_JumlahBarang"
        Me.Tb_JumlahBarang.Size = New System.Drawing.Size(121, 21)
        Me.Tb_JumlahBarang.TabIndex = 2
        '
        'Btn_TambahBarang
        '
        Me.Btn_TambahBarang.Location = New System.Drawing.Point(416, 86)
        Me.Btn_TambahBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_TambahBarang.Name = "Btn_TambahBarang"
        Me.Btn_TambahBarang.Size = New System.Drawing.Size(88, 28)
        Me.Btn_TambahBarang.TabIndex = 3
        Me.Btn_TambahBarang.Text = "Tambah"
        Me.Btn_TambahBarang.UseVisualStyleBackColor = True
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Location = New System.Drawing.Point(545, 370)
        Me.Btn_Reset.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(88, 28)
        Me.Btn_Reset.TabIndex = 7
        Me.Btn_Reset.Text = "Reset"
        Me.Btn_Reset.UseVisualStyleBackColor = True
        '
        'Btn_Simpan
        '
        Me.Btn_Simpan.Location = New System.Drawing.Point(641, 370)
        Me.Btn_Simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Simpan.Name = "Btn_Simpan"
        Me.Btn_Simpan.Size = New System.Drawing.Size(144, 28)
        Me.Btn_Simpan.TabIndex = 8
        Me.Btn_Simpan.Text = "Simpan Transaksi"
        Me.Btn_Simpan.UseVisualStyleBackColor = True
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Simpan)
        Me.Controls.Add(Me.Btn_Reset)
        Me.Controls.Add(Me.Btn_TambahBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tb_Kembalian)
        Me.Controls.Add(Me.Tb_Bayar)
        Me.Controls.Add(Me.Tb_JumlahBarang)
        Me.Controls.Add(Me.Tb_Kode)
        Me.Controls.Add(Me.Tb_Total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Cashier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_Logout As ToolStripMenuItem
    Friend WithEvents MenuStrip_Keluar As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_DatabaseManajemen As ToolStripMenuItem
    Friend WithEvents MenuStrip_Transaksi As ToolStripMenuItem
    Friend WithEvents MenuStrip_BarangMasuk As ToolStripMenuItem
    Friend WithEvents MenuStrip_BarangKeluar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_Bayar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tb_Kembalian As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tb_Kode As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_JumlahBarang As TextBox
    Friend WithEvents Btn_TambahBarang As Button
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents Btn_Simpan As Button
    Friend WithEvents MenuStrip_SetelanPengguna As ToolStripMenuItem
End Class
