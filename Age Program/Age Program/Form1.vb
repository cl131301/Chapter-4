﻿Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double

        Try
            intAge = txtUserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf intAge <= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf intAge >= 18 And intAge < 24 Then
                lblResult.Text = "You are less advanced then all of your peers."
            ElseIf intAge >= 24 And intAge < 30 Then
                lblResult.Text = "Get a job you deadbeat."
            ElseIf intAge >= 30 And intAge < 40 Then
                lblResult.Text = "You are slowly dying."
            ElseIf intAge >= 40 And intAge < 60 Then
                lblResult.Text = "Your grandkids don't love you."
            ElseIf intAge >= 60 Then
                lblResult.Text = "You have wrinkles."
            End If
        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserAgeInput.Clear()
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
