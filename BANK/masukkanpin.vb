Public Class masukkanpin
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If MaskedTextBox1.Text.Length < 6 Then
            Label3.Text = "**Masukkan 6 Digit PIN Anda"
        Else
            pass = MaskedTextBox1.Text
            menuutama.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Label3.Text = ""
    End Sub
End Class