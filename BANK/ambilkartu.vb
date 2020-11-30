Public Class ambilkartu
    Dim i As Integer = 0
    Private Sub Ambilkartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If (i = 5) Then
            Timer1.Stop()
            Me.Close()
        End If

    End Sub
End Class