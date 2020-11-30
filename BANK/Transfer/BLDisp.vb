Public Class BLDisp
    Private Sub BLDisp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = "SALDO ANDA AKAN BERKURANG DAN" & vbNewLine & "BERPINDAH KE REKENING PENERIMA"
        Label16.Text = rekBankLain.MaskedTextBox1.Text
        Label11.Text = BName
        Label12.Text = "RP   " & trfBL.ToString(format := "###,###,###.00")
        Label20.Text = rekBankLain.MaskedTextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        tunggu.Show()
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        jumBankLain.Show()
        Me.Close()
    End Sub
End Class