Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
    Public var = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox3.Text += TextBox5.Text + var.ToString + TextBox4.Text
        var = var + 1
        If var = 500 Then Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.SetText(TextBox3.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = TextBox5.Text
    End Sub
End Class
