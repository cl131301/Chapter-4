Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer
        If Integer.TryParse(TextBoxNumber.Text, intNumber) Then
            If intNumber = 1 Then
                lblAnswer.Text = "I"
            ElseIf intNumber = 2 Then
                lblAnswer.Text = "II"
            ElseIf intNumber = 3 Then
                lblAnswer.Text = "III"
            ElseIf intNumber = 4 Then
                lblAnswer.Text = "IV"
            ElseIf intNumber = 5 Then
                lblAnswer.Text = "V"
            ElseIf intNumber = 6 Then
                lblAnswer.Text = "VI"
            ElseIf intNumber = 7 Then
                lblAnswer.Text = "VII"
            ElseIf intNumber = 8 Then
                lblAnswer.Text = "VIII"
            ElseIf intNumber = 9 Then
                lblAnswer.Text = "IX"
            ElseIf intNumber = 10 Then
                lblAnswer.Text = "X"
            Else
                lblAnswer.Text = "Error Please enter a valid number 1-10 "
            End If
        End If
    End Sub
End Class
