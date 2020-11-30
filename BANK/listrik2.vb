Public Class listrik2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Listrik2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = listrik.MaskedTextBox1.Text
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        listrik.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        tunggu.Show()
        Me.Close()
    End Sub
End Class