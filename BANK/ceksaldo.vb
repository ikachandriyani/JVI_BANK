Public Class ceksaldo

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        masukkanpin.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ambilkartu.Show()
        Me.Close()
    End Sub

    Private Sub Ceksaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = Label12.Text & saldo.ToString(format := "###,###,###.00")
    End Sub
End Class