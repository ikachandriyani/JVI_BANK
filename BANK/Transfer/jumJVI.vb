Public Class jumJVI
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Val(TextBox1.Text) < 10000 Then
            Label7.Text = "**Minimum Transfer 10000"
        Else
            trfJIV = TextBox1.Text
            rekJVI.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label7.Text = ""
    End Sub
End Class