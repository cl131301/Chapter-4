Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String 'Hold selected from list boxes

        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("select a color.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in EST was selceted.")
        End If

        strInput = listColor.SelectedItem.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all. It has " & listNumer.SelectedItem.ToString() &
            " " & listBodyPart.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " Shaped like a " &
            listNoun.SelectedItem.ToString() & ", it loves to eat " &
            listPluralnoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listBodyPart.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        listPluralnoun.SelectedIndex = -1
        listNumer.SelectedIndex = -1
    End Sub
End Class
