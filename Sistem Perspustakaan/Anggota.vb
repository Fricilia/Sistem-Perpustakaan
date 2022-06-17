Public Class frmMAnggota
    Private Sub frmMAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        getTabelAnggota.DataSource = getTabelAnggota()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles getTabelAnggota.CellContentClick
        txtnoanggotaa.Text = getTabelAnggota.Item(0, getTabelAnggota.CurrentRow.Index).Value.ToString
        txtnamaa.Text = getTabelAnggota.Item(1, getTabelAnggota.CurrentRow.Index).Value.ToString
        txtnimm.Text = getTabelAnggota.Item(2, getTabelAnggota.CurrentRow.Index).Value.ToString
        txtalamatt.Text = getTabelAnggota.Item(3, getTabelAnggota.CurrentRow.Index).Value.ToString
        txtkota.Text = getTabelAnggota.Item(4, getTabelAnggota.CurrentRow.Index).Value.ToString
        txttelepon.Text = getTabelAnggota.Item(5, getTabelAnggota.CurrentRow.Index).Value.ToString
        txtketerangan.Text = getTabelAnggota.Item(6, getTabelAnggota.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            tambah_menu2(txtnoanggota.Text, txtnama.Text, txtnim.Text, txtalamat.Text, txtkota.Text, txttelepon.Text, txtketerangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        getTabelAnggota.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try
            ubah_menu2(txtnoanggota.Text, txtnama.Text, txtnim.Text, txtalamat.Text, txtkota.Text, Integer.Parse(txttelepon.Text), txtketerangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        getTabelAnggota.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        bersih_menu2()
        getTabelAnggota.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus_menu2(txtnoanggota.Text)
        getTabelAnggota.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        getTabelAnggota.DataSource = getViewAnggota(txtnoanggota.Text)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        frmMenuUtama.Show()
    End Sub
End Class