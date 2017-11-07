Public Class form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBox Controls and the Lable.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtLastName.Text = String.Empty
        txtFirstName.Text = String.Empty
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Close the form
        Me.Close()
    End Sub

End Class


