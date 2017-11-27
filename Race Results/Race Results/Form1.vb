Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxName1.Clear()
        txtboxName2.Clear()
        txtboxName3.Clear()
        txtboxTime1.Clear()
        txrboxTime2.Clear()
        txtboxTime3.Clear()
        lbl1st.Text = String.Empty
        lbl2nd.Text = String.Empty
        lbl3rd.Text = String.Empty
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtboxTime1.Text
        dblTime2 = txrboxTime2.Text
        dblTime3 = txtboxTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lbl1st.Text = txtboxName1.Text
            If dblTime2 < dblTime3 Then
                lbl2nd.Text = txtboxName2.Text
                lbl3rd.Text = txtboxName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lbl2nd.Text = txtboxName3.Text
                lbl3rd.Text = txtboxName2.Text

            End If
        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
            lbl1st.Text = txtboxName2.Text
            If dblTime2 < dblTime3 Then
                lbl2nd.Text = txtboxName2.Text
                lbl3rd.Text = txtboxName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lbl2nd.Text = txtboxName3.Text
                lbl3rd.Text = txtboxName2.Text

            End If
        End If
        If dblTime3 < dblTime1 And dblTime3 < dblTime2 Then
            lbl3rd.Text = txtboxName3.Text
        End If
    End Sub
End Class
