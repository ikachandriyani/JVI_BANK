Public Class silahkanambil
    Dim sisa As Integer
    Dim t As Integer = 0

    Private Sub Silahkanambil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Select cetak
            Case 1
                Label7.Visible = False
                Label1.Text = Label1.Text & " UANG" & vbNewLine & "DAN STRUK ANDA"
            Case 2
                saldo = saldo - tarik
                Label7.Text = Label7.Text & saldo.ToString(format:="###,###,###.00")
                Label7.Visible = True
                Label1.Text = Label1.Text & " UANG" & vbNewLine & "ANDA"
            Case 3
                Label7.Visible = False
                Label1.Text = Label1.Text & " STRUK" & vbNewLine & "ANDA"
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t += 1
        If (t = 3) Then
            Timer1.Stop()
            lagi.Show()
            Me.Close()
        End If
    End Sub
End Class