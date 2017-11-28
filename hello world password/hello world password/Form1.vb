Public Class Form1

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtboxPassword.Text = "Lewis123" Then
            MessageBox.Show("Good Morning World!")
        Else
            MessageBox.Show("Incorrect assword, please enter valid password")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
