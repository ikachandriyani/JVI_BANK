Public Class rekJVI
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If MaskedTextBox1.Text.Length < 10 Then
            Label6.Text = "**Masukkan 10 Digit Nomor Rekening Tujuan"
        Else 
            JVIDisp.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MaskedTextBox1.Text = ""
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Label6.Text = ""
    End Sub
End Class