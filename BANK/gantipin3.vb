Public Class gantipin3
    Dim i As Integer
    Private Sub Gantipin3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If (i = 3) Then
            lagi.Show()
            Me.Close()
        End If
    End Sub
End Class