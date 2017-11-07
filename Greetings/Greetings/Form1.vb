Public Class Form1

    Private Sub lblShowGreetings_Click(sender As Object, e As EventArgs) Handles btnShowGreetings.Click
        lblGreetings.Text = "Hello " & txtUserName.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
