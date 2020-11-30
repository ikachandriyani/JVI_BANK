Public Class cetakstruk
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        cetak = 1
        tunggu.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        cetak = 2
        tunggu.Show()
        Me.Close()
    End Sub
End Class