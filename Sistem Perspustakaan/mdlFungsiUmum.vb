Imports MySql.Data.MySqlClient

Dim ConString = "server=localhost;user id=root;" &
                                "password=;database=sista"

Public db As New MySqlConnection(ConString)
Public myCommand As MySqlCommand
Public myAdapter As MySqlDataAdapter
Public myDataset As DataSet
Public myReader As MySqlDataReader
Public Sub bukaDB()
    Try
        tutupDB()
        db.Open()
        'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As MySqlException
        MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
End Sub

Public Sub tutupDB()
    If db.State = ConnectionState.Open Then
        db.Close()
    End If
End Sub

' Form Master Anggota
Public Function getTabelAnggota() As DataTable
    Dim myDataTable As DataTable

    Try
        bukaDB()
        myCommand = New MySqlCommand("SELECT * FROM anggota ORDER BY noanggota", db)
        myAdapter = New MySqlDataAdapter(myCommand)
        myDataset = New DataSet

        myAdapter.Fill(myDataset, "noanggota")
        myDataTable = myDataset.Tables(0)
        Return (myDataTable)

    Catch ex As Exception
        MsgBox(ex.Message)
        Return Nothing

    Finally
        tutupDB()

    End Try
End Function

Public Function getViewAnggota(ByVal noanggota As String) As DataTable
    Dim myViewTable As DataTable

    Try
        bukaDB()
        myCommand = New MySqlCommand("SELECT * FROM anggota WHERE noanggota = @noanggota", db)
        myCommand.Parameters.AddWithValue("@noanggota", noanggota)
        myAdapter = New MySqlDataAdapter(myCommand)
        myDataset = New DataSet

        myAdapter.Fill(myDataset, "noanggota")
        myViewTable = myDataset.Tables(0)
        Return (myViewTable)

    Catch ex As Exception
        MsgBox(ex.Message)
        Return Nothing

    Finally
        tutupDB()

    End Try
End Function

Public Sub tambah_menu2(ByVal noanggota As String, ByVal nama As String, ByVal nim As String, ByVal alamat As String, ByVal kota As String, ByVal telepon As String, ByVal keterangan As String)
    myCommand = New MySqlCommand
    myCommand.Connection = db
    myCommand.CommandText = "INSERT INTO anggota (noanggota, nama, nim, alamat, kota, telepon, keterangan) VALUES (@noanggota, @nama, @nim, @alamat, @kota, @telepon, @keterangan)"
    myCommand.Parameters.AddWithValue("@noanggota", noanggota)
    myCommand.Parameters.AddWithValue("@nama", nama)
    myCommand.Parameters.AddWithValue("@nim", nim)
    myCommand.Parameters.AddWithValue("@alamat", alamat)
    myCommand.Parameters.AddWithValue("@kota", kota)
    myCommand.Parameters.AddWithValue("@telepon", telepon)
    myCommand.Parameters.AddWithValue("@keterangan", keterangan)

    Try
        bukaDB()
        myCommand.ExecuteNonQuery()
        tutupDB()

    Catch ex As Exception
        MsgBox(ex.Message)
        MsgBox("Gagal dalam menyimpan data")

    Finally
        tutupDB()

    End Try
End Sub

Public Sub hapus_menu2(ByVal noanggota As String)
    myCommand = New MySqlCommand
    myCommand.Connection = db
    myCommand.CommandText = "DELETE FROM anggota WHERE noanggota = @noanggota"
    myCommand.Parameters.AddWithValue("@noanggota", noanggota)

    Try
        bukaDB()
        myCommand.ExecuteNonQuery()
        bersih_menu2()
        tutupDB()

    Catch ex As Exception
        MsgBox(ex.Message)
        MsgBox("Gagal menghapus data")

    Finally
        tutupDB()

    End Try
End Sub

Public Sub bersih_menu2()
    With frmMAnggota
        .txtnoanggota.Text = ""
        .txtnama.Text = ""
        .txtnim.Text = ""
        .txtalamat.Text = ""
        .txtkota.Text = ""
        .txttelepon.Text = ""
        .txtketerangan.Text = ""
    End With
End Sub

Public Sub ubah_menu2(ByVal noanggota As String, ByVal nama As String, ByVal nim As String, ByVal alamat As String, ByVal kota As String, ByVal telepon As String, ByVal keterangan As String)
    myCommand = New MySqlCommand
    myCommand.Connection = db
    myCommand.CommandText = "UPDATE anggota SET nama = @nama, nim = @nim, alamat = @alamat, kota = @kota, telepon = @telepon, keterangan = @keterangan WHERE noanggota = @noanggota"
    myCommand.Parameters.AddWithValue("@noanggota", noanggota)
    myCommand.Parameters.AddWithValue("@nama", nama)
    myCommand.Parameters.AddWithValue("@nim", nim)
    myCommand.Parameters.AddWithValue("@alamat", alamat)
    myCommand.Parameters.AddWithValue("@kota", kota)
    myCommand.Parameters.AddWithValue("@telepon", telepon)
    myCommand.Parameters.AddWithValue("@keterangan", keterangan)

    Try
        bukaDB()
        myCommand.ExecuteNonQuery()
        tutupDB()

    Catch ex As Exception
        MsgBox(ex.Message)
        MsgBox("Gagal dalam menyimpan data")

    Finally
        tutupDB()

    End Try
End Sub
