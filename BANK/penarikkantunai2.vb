Public Class penarikkantunai2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Select Case SetVal
            Case 50
                If Val(TextBox1.Text) < 50000 Then
                    Label6.Text = "**Jumlah Uang Minimum 50000"
                ElseIf Val(TextBox1.Text) Mod 50000 <> 0 Then
                    Label6.Text = "**Jumlah Uang Kelipatan 50000"
                Else
                    tarik = Val(TextBox1.Text)
                    cetakstruk.Show()
                    Me.Close()
                End If
            Case 100
                If Val(TextBox1.Text) < 100000 Then
                    Label6.Text = "**Jumlah Uang Minimum 100000"
                ElseIf Val(TextBox1.Text) Mod 100000 <> 0 Then
                    Label6.Text = "**Jumlah Uang Kelipatan 100000"
                Else
                    tarik = Val(TextBox1.Text)
                    cetakstruk.Show()
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Text = ""
        Label6.Text = ""
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label6.Text = ""
    End Sub
End Class