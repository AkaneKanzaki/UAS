<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BK
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_SetelanPengguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Kasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_DatabaseManajemen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(775, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_SetelanPengguna, Me.MenuStrip_Logout, Me.MenuStrip_Keluar})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_Kasir, Me.MenuStrip_DatabaseManajemen})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ViewToolStripMenuItem.Text = "Master"
        '
        'MenuStrip_Kasir
        '
        Me.MenuStrip_Kasir.Name = "MenuStrip_Kasir"
        Me.MenuStrip_Kasir.Size = New System.Drawing.Size(237, 26)
        Me.MenuStrip_Kasir.Text = "Kasir"
        '
        'MenuStrip_DatabaseManajemen
        '
        Me.MenuStrip_DatabaseManajemen.Name = "MenuStrip_DatabaseManajemen"
        Me.MenuStrip_DatabaseManajemen.Size = New System.Drawing.Size(237, 26)
        Me.MenuStrip_DatabaseManajemen.Text = "Database Manajemen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 31)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Daftar Riwayat Pembelian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 58)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Kasirku"
        '
        'Form_BK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_BK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riwayat Pembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_SetelanPengguna As ToolStripMenuItem
    Friend WithEvents MenuStrip_Logout As ToolStripMenuItem
    Friend WithEvents MenuStrip_Keluar As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip_DatabaseManajemen As ToolStripMenuItem
    Friend WithEvents MenuStrip_Kasir As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
