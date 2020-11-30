Public Class pbb
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MaskedTextBox1.Text = ""
        Label4.Visible = False
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If MaskedTextBox1.Text.Length < 13 Then
            Label4.Visible = True
        Else
            nop = MaskedTextBox1.Text
            pbb1.Show()
            Me.Close()
        End If

    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Label4.Visible = False
    End Sub
End Class