Public Class tunggu
    Dim t As Integer = 0

    Private Sub Tunggu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t += 1
        If (t = 3) Then
            Timer1.Stop()
            silahkanambil.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class