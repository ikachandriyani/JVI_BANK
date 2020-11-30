Public Class penarikkantunai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        SetVal = 50
        penarikkantunai2.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        SetVal = 100
        penarikkantunai2.Show()
        Me.Close()
    End Sub
End Class