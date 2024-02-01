Public Class Form1
    Private Sub bAcceder_Click(sender As Object, e As EventArgs) Handles bAcceder.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub bAcceder_MouseHover(sender As Object, e As EventArgs) Handles bAcceder.MouseHover
        bAcceder.BackColor = Color.Aquamarine
    End Sub

    Private Sub bAcceder_MouseLeave(sender As Object, e As EventArgs) Handles bAcceder.MouseLeave
        bAcceder.BackColor = Color.LightGreen
    End Sub
End Class
