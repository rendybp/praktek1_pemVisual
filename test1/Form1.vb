Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        namaOutput.Text = namaInput.Text
        noDaftarOutput.Text = noDaftarInput.Text
        alamatOutput.Text = alamatInput.Text
        jenkelOutput.Text = jenkelInput.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        namaOutput.ForeColor = Color.Red
        noDaftarOutput.ForeColor = Color.Red
        alamatOutput.ForeColor = Color.Red
        jenkelOutput.ForeColor = Color.Red
        BackColor = Color.Aqua
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        namaOutput.ForeColor = Color.Blue
        noDaftarOutput.ForeColor = Color.Blue
        alamatOutput.ForeColor = Color.Blue
        jenkelOutput.ForeColor = Color.Blue
        BackColor = Color.LightPink
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        namaOutput.ForeColor = Color.Yellow
        noDaftarOutput.ForeColor = Color.Yellow
        alamatOutput.ForeColor = Color.Yellow
        jenkelOutput.ForeColor = Color.Yellow
        BackColor = Color.DarkGreen
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        namaOutput.ForeColor = Color.Green
        noDaftarOutput.ForeColor = Color.Green
        alamatOutput.ForeColor = Color.Green
        jenkelOutput.ForeColor = Color.Green
        BackColor = Color.DarkOrange
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        namaOutput.Font = New Font("microsoft sans serif", namaOutput.Font.Size, namaOutput.Font.Style Xor FontStyle.Bold)
        noDaftarOutput.Font = New Font("microsoft sans serif", noDaftarOutput.Font.Size, noDaftarOutput.Font.Style Xor FontStyle.Bold)
        alamatOutput.Font = New Font("microsoft sans serif", alamatOutput.Font.Size, alamatOutput.Font.Style Xor FontStyle.Bold)
        jenkelOutput.Font = New Font("microsoft sans serif", jenkelOutput.Font.Size, jenkelOutput.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        namaOutput.Font = New Font("microsoft sans serif", namaOutput.Font.Size, namaOutput.Font.Style Xor FontStyle.Italic)
        noDaftarOutput.Font = New Font("microsoft sans serif", noDaftarOutput.Font.Size, noDaftarOutput.Font.Style Xor FontStyle.Italic)
        alamatOutput.Font = New Font("microsoft sans serif", alamatOutput.Font.Size, alamatOutput.Font.Style Xor FontStyle.Italic)
        jenkelOutput.Font = New Font("microsoft sans serif", jenkelOutput.Font.Size, jenkelOutput.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        namaOutput.Font = New Font("microsoft sans serif", namaOutput.Font.Size, namaOutput.Font.Style Xor FontStyle.Underline)
        noDaftarOutput.Font = New Font("microsoft sans serif", noDaftarOutput.Font.Size, noDaftarOutput.Font.Style Xor FontStyle.Underline)
        alamatOutput.Font = New Font("microsoft sans serif", alamatOutput.Font.Size, alamatOutput.Font.Style Xor FontStyle.Underline)
        jenkelOutput.Font = New Font("microsoft sans serif", jenkelOutput.Font.Size, jenkelOutput.Font.Style Xor FontStyle.Underline)
    End Sub
End Class
