<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BM
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
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Rb_Nama = New System.Windows.Forms.RadioButton()
        Me.Rb_Kode = New System.Windows.Forms.RadioButton()
        Me.Tb_Cari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Cari
        '
        Me.Btn_Cari.Location = New System.Drawing.Point(200, 9)
        Me.Btn_Cari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cari.TabIndex = 28
        Me.Btn_Cari.Text = "Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = True
        '
        'Rb_Nama
        '
        Me.Rb_Nama.AutoSize = True
        Me.Rb_Nama.Location = New System.Drawing.Point(157, 44)
        Me.Rb_Nama.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb_Nama.Name = "Rb_Nama"
        Me.Rb_Nama.Size = New System.Drawing.Size(65, 20)
        Me.Rb_Nama.TabIndex = 30
        Me.Rb_Nama.TabStop = True
        Me.Rb_Nama.Text = "Nama"
        Me.Rb_Nama.UseVisualStyleBackColor = True
        '
        'Rb_Kode
        '
        Me.Rb_Kode.AutoSize = True
        Me.Rb_Kode.Location = New System.Drawing.Point(89, 44)
        Me.Rb_Kode.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb_Kode.Name = "Rb_Kode"
        Me.Rb_Kode.Size = New System.Drawing.Size(60, 20)
        Me.Rb_Kode.TabIndex = 29
        Me.Rb_Kode.TabStop = True
        Me.Rb_Kode.Text = "Kode"
        Me.Rb_Kode.UseVisualStyleBackColor = True
        '
        'Tb_Cari
        '
        Me.Tb_Cari.Location = New System.Drawing.Point(89, 9)
        Me.Tb_Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Cari.Name = "Tb_Cari"
        Me.Tb_Cari.Size = New System.Drawing.Size(95, 22)
        Me.Tb_Cari.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Filter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 369)
        Me.DataGridView1.TabIndex = 31
        '
        'Form_BM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Cari)
        Me.Controls.Add(Me.Rb_Nama)
        Me.Controls.Add(Me.Rb_Kode)
        Me.Controls.Add(Me.Tb_Cari)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_BM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_BM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Cari As Button
	Friend WithEvents Rb_Nama As RadioButton
	Friend WithEvents Rb_Kode As RadioButton
	Friend WithEvents Tb_Cari As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
