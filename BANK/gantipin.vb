Public Class gantipin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If MaskedTextBox1.Text.Length < 6 Then
            Label1.Text = "**Masukkan 6 Digit PIN Anda"
        ElseIf MaskedTextBox1.Text <> pass Then
            Label1.Text = "**PIN salah"
        Else
            gantipin1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MaskedTextBox1.Text = ""
    End Sub
End Class