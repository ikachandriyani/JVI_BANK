Public Class token3
    Private Sub Token3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = idpel
        Label11.Text = "RP " & nominal.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        token.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        tunggu.Show()
        Me.Close()

    End Sub
End Class