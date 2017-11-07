Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblShowAnswer_Click(sender As Object, e As EventArgs) Handles lblShowAnswer.Click
        Label1.Text = "18 + 64=82"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
