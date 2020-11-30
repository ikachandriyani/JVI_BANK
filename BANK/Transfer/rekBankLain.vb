Public Class rekBankLain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If MaskedTextBox1.Text.Length < 10 Then
            Label6.Text = "**Masukkan 10 Digit Nomor Rekening Tujuan"
        Else 
            BCode = MaskedTextBox2.Text
            Select BCode
                Case "002"
                    BName = "BRI"
                Case "014"
                    BName = "BCA"
                Case "008"
                    BName = "Mandiri"
                Case "009"
                    BName = "BNI"
            End Select
            BLDisp.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MaskedTextBox1_Click(sender As Object, e As EventArgs) Handles MaskedTextBox1.Click
        BCode = MaskedTextBox2.Text
        If BCode.Length < 3
            Label6.Text = "**Masukkan Kode Bank Terlebih Dahulu"
        Else 
            Select BCode
                Case "002"
                    Label6.Text = "*Bank BRI"
                    Label3.Enabled = True
                Case "014"
                    Label6.Text = "*Bank BCA"
                    Label3.Enabled = True
                Case "008"
                    Label6.Text = "*Bank Mandiri"
                    Label3.Enabled = True
                Case "009"
                    Label6.Text = "*Bank BNI"
                    Label3.Enabled = True
                Case Else
                    Label6.Text = "**Kode Bank Tidak Terdaftar"
                    Label3.Enabled = False
            End Select
        End If
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        Label6.Text = ""
    End Sub


    Private Sub MaskedTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox2.TextChanged
        Label6.Text = ""
    End Sub

    Private Sub MaskedTextBox1_Resize(sender As Object, e As EventArgs) Handles MaskedTextBox1.Resize
        Label6.Text = ""
    End Sub
End Class