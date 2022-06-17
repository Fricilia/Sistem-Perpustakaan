<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAnggota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txttelepon = New System.Windows.Forms.TextBox()
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnoangggota = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtalamatt = New System.Windows.Forms.Label()
        Me.txtnimm = New System.Windows.Forms.Label()
        Me.txtnamaa = New System.Windows.Forms.Label()
        Me.txtnoanggotaa = New System.Windows.Forms.Label()
        Me.getTabelAnggota = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.getTabelAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKembali)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBersih)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.txtketerangan)
        Me.GroupBox1.Controls.Add(Me.txttelepon)
        Me.GroupBox1.Controls.Add(Me.txtkota)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.txtnim)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.txtnoangggota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtalamatt)
        Me.GroupBox1.Controls.Add(Me.txtnimm)
        Me.GroupBox1.Controls.Add(Me.txtnamaa)
        Me.GroupBox1.Controls.Add(Me.txtnoanggotaa)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Anggota"
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnKembali.Location = New System.Drawing.Point(305, 130)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(58, 30)
        Me.btnKembali.TabIndex = 19
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.Location = New System.Drawing.Point(241, 130)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(58, 30)
        Me.btnCari.TabIndex = 18
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.Location = New System.Drawing.Point(173, 130)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(58, 30)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBersih
        '
        Me.btnBersih.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBersih.Location = New System.Drawing.Point(305, 92)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(58, 30)
        Me.btnBersih.TabIndex = 16
        Me.btnBersih.Text = "Bersih"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUbah.Location = New System.Drawing.Point(241, 92)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(58, 30)
        Me.btnUbah.TabIndex = 15
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.Location = New System.Drawing.Point(173, 92)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(58, 30)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(275, 64)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(88, 18)
        Me.txtketerangan.TabIndex = 13
        '
        'txttelepon
        '
        Me.txttelepon.Location = New System.Drawing.Point(276, 39)
        Me.txttelepon.Multiline = True
        Me.txttelepon.Name = "txttelepon"
        Me.txttelepon.Size = New System.Drawing.Size(88, 18)
        Me.txttelepon.TabIndex = 12
        '
        'txtkota
        '
        Me.txtkota.Location = New System.Drawing.Point(79, 145)
        Me.txtkota.Multiline = True
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(88, 18)
        Me.txtkota.TabIndex = 11
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(79, 115)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(88, 18)
        Me.txtalamat.TabIndex = 10
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(79, 89)
        Me.txtnim.Multiline = True
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(88, 18)
        Me.txtnim.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(79, 64)
        Me.txtnama.Multiline = True
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(88, 18)
        Me.txtnama.TabIndex = 8
        '
        'txtnoangggota
        '
        Me.txtnoangggota.Location = New System.Drawing.Point(79, 39)
        Me.txtnoangggota.Multiline = True
        Me.txtnoangggota.Name = "txtnoangggota"
        Me.txtnoangggota.Size = New System.Drawing.Size(88, 18)
        Me.txtnoangggota.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(202, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(202, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Telepon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kota"
        '
        'txtalamatt
        '
        Me.txtalamatt.AutoSize = True
        Me.txtalamatt.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtalamatt.Location = New System.Drawing.Point(6, 118)
        Me.txtalamatt.Name = "txtalamatt"
        Me.txtalamatt.Size = New System.Drawing.Size(45, 15)
        Me.txtalamatt.TabIndex = 3
        Me.txtalamatt.Text = "Alamat"
        '
        'txtnimm
        '
        Me.txtnimm.AutoSize = True
        Me.txtnimm.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtnimm.Location = New System.Drawing.Point(6, 89)
        Me.txtnimm.Name = "txtnimm"
        Me.txtnimm.Size = New System.Drawing.Size(30, 15)
        Me.txtnimm.TabIndex = 2
        Me.txtnimm.Text = "NIM"
        '
        'txtnamaa
        '
        Me.txtnamaa.AutoSize = True
        Me.txtnamaa.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtnamaa.Location = New System.Drawing.Point(6, 64)
        Me.txtnamaa.Name = "txtnamaa"
        Me.txtnamaa.Size = New System.Drawing.Size(39, 15)
        Me.txtnamaa.TabIndex = 1
        Me.txtnamaa.Text = "Nama"
        '
        'txtnoanggotaa
        '
        Me.txtnoanggotaa.AutoSize = True
        Me.txtnoanggotaa.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtnoanggotaa.Location = New System.Drawing.Point(6, 39)
        Me.txtnoanggotaa.Name = "txtnoanggotaa"
        Me.txtnoanggotaa.Size = New System.Drawing.Size(67, 15)
        Me.txtnoanggotaa.TabIndex = 0
        Me.txtnoanggotaa.Text = "ID Anggota"
        '
        'getTabelAnggota
        '
        Me.getTabelAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.getTabelAnggota.Location = New System.Drawing.Point(19, 277)
        Me.getTabelAnggota.Name = "getTabelAnggota"
        Me.getTabelAnggota.RowHeadersWidth = 62
        Me.getTabelAnggota.RowTemplate.Height = 33
        Me.getTabelAnggota.Size = New System.Drawing.Size(370, 133)
        Me.getTabelAnggota.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(128, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Master Anggota"
        '
        'frmMAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(401, 422)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.getTabelAnggota)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMAnggota"
        Me.Text = "Master Anggota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.getTabelAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents getTabelAnggota As DataGridView
    Friend WithEvents txtalamatt As Label
    Friend WithEvents txtnimm As Label
    Friend WithEvents txtnamaa As Label
    Friend WithEvents txtnoanggotaa As Label
    Friend WithEvents txtnoangggota As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents txttelepon As TextBox
    Friend WithEvents txtkota As TextBox
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents btnHapus As Button
End Class
