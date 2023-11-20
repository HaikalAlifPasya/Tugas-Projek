Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nama, JenisKelamin As String
        Dim usia, bonus, LamaKredit, LamaAngsuran As Integer
        Dim HargaMobil, UangMuka, JumlahPinjaman, PokokPinjaman, Angsuran, Bunga As Decimal
        Dim TanggalPinjaman, TanggalPelunasan As Date

        Nama = txtnama.Text
        usia = NumericUpDown1.Value
        LamaKredit = ComboBox1.SelectedValue
        TanggalPinjaman = DateTimePicker1.Value
        HargaMobil = Mobil.Text
        UangMuka = Muka.Text

        Select Case LamaKredit
            Case 1
                Bunga = 10 / 100
                LamaAngsuran = 12

            Case 2
                Bunga = 16 / 100
                LamaAngsuran = 24

            Case 3
                Bunga = 21 / 100
                LamaAngsuran = 36

        End Select

        TanggalPelunasan = DateAdd("m", LamaAngsuran, TanggalPinjaman)
        If RadioButton1.Checked = True Then
            JenisKelamin = "Bpk/Sdr"
        ElseIf RadioButton2.Checked = True Then
            JenisKelamin = "Ibu/Sdri"
        Else
            JenisKelamin = "Bpk/Sdr/Ibu/Sdri"
        End If

        If CheckBox1.Checked = True Then
            bonus = 1000000
        Else
            bonus = 0
        End If

        PokokPinjaman = HargaMobil - (UangMuka + bonus)
        JumlahPinjaman = Bunga + PokokPinjaman
        Angsuran = (PokokPinjaman + JumlahPinjaman) / LamaAngsuran

        MsgBox("Yth." & JenisKelamin & Nama & vbNewLine & vbNewLine & "berikut Simulasi Data Pinjaman Anda : " & vbNewLine & "Tanggal Mulai Kredit : " & TanggalPinjaman & vbNewLine & "Tanggal Pelunasan Kredit : " & TanggalPelunasan & vbNewLine & "Harga Mobil : Rp" & Format(HargaMobil, "Standard") & vbNewLine & "Uang Muka: Rp" & Format(UangMuka, "Standard") & vbNewLine & "Pokok Pinjaman : Rp" & Format(PokokPinjaman, "Standard") & vbNewLine & "Angsuran/bulan : Rp" & Format(Angsuran, "Standard") & vbNewLine & "Dapat Bonus Cashback : Rp" & Format(bonus, "Standard"))
    End Sub
End Class
