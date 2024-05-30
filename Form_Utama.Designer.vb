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
        Me.MenuStrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_HargaBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_DataBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_DataPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_DataPegawai = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Kasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.ViewToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_Logout, Me.MenuStrip_Keluar})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.PenggunaToolStripMenuItem.Text = "File"
        '
        'MenuStrip_Logout
        '
        Me.MenuStrip_Logout.Name = "MenuStrip_Logout"
        Me.MenuStrip_Logout.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_Logout.Text = "Logout"
        '
        'MenuStrip_Keluar
        '
        Me.MenuStrip_Keluar.Name = "MenuStrip_Keluar"
        Me.MenuStrip_Keluar.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_Keluar.Text = "Keluar"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_HargaBarang, Me.MenuStrip_DataBarang, Me.MenuStrip_DataPelanggan, Me.MenuStrip_DataPegawai})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ViewToolStripMenuItem.Text = "Master"
        '
        'MenuStrip_HargaBarang
        '
        Me.MenuStrip_HargaBarang.Name = "MenuStrip_HargaBarang"
        Me.MenuStrip_HargaBarang.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_HargaBarang.Text = "Harga Barang"
        '
        'MenuStrip_DataBarang
        '
        Me.MenuStrip_DataBarang.Name = "MenuStrip_DataBarang"
        Me.MenuStrip_DataBarang.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_DataBarang.Text = "Data Barang"
        '
        'MenuStrip_DataPelanggan
        '
        Me.MenuStrip_DataPelanggan.Name = "MenuStrip_DataPelanggan"
        Me.MenuStrip_DataPelanggan.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_DataPelanggan.Text = "Data Pelanggan"
        '
        'MenuStrip_DataPegawai
        '
        Me.MenuStrip_DataPegawai.Name = "MenuStrip_DataPegawai"
        Me.MenuStrip_DataPegawai.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_DataPegawai.Text = "Data Pegawai"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_Stock, Me.MenuStrip_Kasir})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'MenuStrip_Stock
        '
        Me.MenuStrip_Stock.Name = "MenuStrip_Stock"
        Me.MenuStrip_Stock.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_Stock.Text = "Stock Opname"
        '
        'MenuStrip_Kasir
        '
        Me.MenuStrip_Kasir.Name = "MenuStrip_Kasir"
        Me.MenuStrip_Kasir.Size = New System.Drawing.Size(224, 26)
        Me.MenuStrip_Kasir.Text = "Kasir"
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_Logout As ToolStripMenuItem
    Friend WithEvents MenuStrip_Keluar As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_HargaBarang As ToolStripMenuItem
    Friend WithEvents MenuStrip_DataBarang As ToolStripMenuItem
    Friend WithEvents MenuStrip_DataPelanggan As ToolStripMenuItem
    Friend WithEvents MenuStrip_DataPegawai As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_Stock As ToolStripMenuItem
    Friend WithEvents MenuStrip_Kasir As ToolStripMenuItem
End Class
