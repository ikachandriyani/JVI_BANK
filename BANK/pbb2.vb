Public Class pbb2
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Pbb2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = nop


    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        pbb.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        tunggu.Show()
        Me.Close()
    End Sub
End Class