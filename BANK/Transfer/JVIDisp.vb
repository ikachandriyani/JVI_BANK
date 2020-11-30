Public Class JVIDisp
    Private Sub JIVDisp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = "SALDO ANDA AKAN BERKURANG DAN" & vbNewLine & "BERPINDAH KE REKENING PENERIMA"
        Label16.Text = rekJVI.MaskedTextBox1.Text
        Label12.Text = "RP   " & trfJIV.ToString(format := "###,###,###.00")
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        tunggu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        jumJVI.Show()
        Me.Close()
    End Sub
End Class