Public Class isipulsa2
    Dim admin, total As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        tunggu.Show()
        Me.Close()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        isipulsa.Show()
        Me.Close()
    End Sub

    Private Sub Isipulsa2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label14.Text = hp
        Select Case jenis
            Case 1
                Label11.Text = "TELKOMSEL"
                admin = 1000
            Case 2
                Label11.Text = "INDOSAT"
                admin = 0
            Case 3
                Label11.Text = "XL"
                admin = 0
        End Select
        Label16.Text = "RP " & admin
        total = nominal + admin
        Label1.Text = "RP " & nominal.ToString
        Label12.Text = "RP " & total.ToString
    End Sub
End Class