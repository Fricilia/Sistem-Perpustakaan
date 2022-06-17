Public Class frmMBuku
    Private Sub frmMBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelBuku()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtnobuku.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtjudul.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtpengarang.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txttahun.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtpenerbit.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
        txtjumhal.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString
        txtketerangan.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            tambah_menu(Txtnobuku.Text, Txtjudul.Text, Txtpengarang.Text, Txttahun.Text, Txtpenerbit.Text, Integer.Parse(Txtjumhal.Text), Txtketerangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelBuku()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try
            ubah_menu(Txtnobuku.Text, Txtjudul.Text, Txtpengarang.Text, Txttahun.Text, Txtpenerbit.Text, Integer.Parse(Txtjumhal.Text), Txtketerangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelBuku()

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DataGridView1.DataSource = getViewBuku(Txtnobuku.Text)
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        bersih_menu()
        DataGridView1.DataSource = getTabelBuku()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus_menu(Txtnobuku.Text)
        DataGridView1.DataSource = getTabelBuku()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        frmMenuUtama.Show()
    End Sub
End Class
