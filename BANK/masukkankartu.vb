Public Class masukkankartu
    Dim a As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        saldo = 14020128
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a += 1
        If (a = 5) Then
            Timer1.Stop()
            masukkanpin.Show()
            Me.Close()
        End If
    End Sub
End Class
