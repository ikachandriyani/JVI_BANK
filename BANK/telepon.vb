Public Class telepon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If (MaskedTextBox1.Text.Length < 12) Then
            Label6.Text = "**Masukkan no.telepon dengan benar"
        Else
            telepon2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MaskedTextBox1.Text = ""
        Label6.Text = " "
    End Sub


    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Label6.Text = " "
    End Sub
End Class