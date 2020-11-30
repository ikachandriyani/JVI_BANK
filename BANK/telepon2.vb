Public Class telepon2
    Private Sub Telepon2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = telepon.MaskedTextBox1.Text
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        telepon.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        tunggu.Show()
        Me.Close()
    End Sub
End Class