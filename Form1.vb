Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblVanilla As Double = 3.99
        Dim dblChocolate As Double = 3.99
        Dim dblStrawberru As Double = 3.99
        Dim dblOrangeSherbert As Double = 3.99
        Dim dblCarmel As Double = 0.75
        Dim dblHotFudge As Double = 1.0
        Dim dblSprinkles As Double = 0.25
        Dim dblWhipCream As Double = 0.5
        Dim dblExtraScoop As Double = 1.0
        Dim dblCandyBar As Double = 1.5
        Dim dblCookie As Double = 1.0
        Dim Total As Double

        If rdVanilla.Checked = True Then
            lblResult.Text = "You Selected Vanilla"
            Total = dblVanilla + total
        ElseIf rdChocolate.Checked = True Then
            lblResult.Text = "You selected Chocolate"
            Total = dblChocolate + total
        ElseIf rdStrawberry.Checked = True Then
            lblResult.Text = "You selected Strawberry"
            Total = dblStrawberru + total
        ElseIf rdOrangeSherbert.Checked = True Then
            lblResult.Text = "You selected Orange Sherbert"
            Total = dblOrangeSherbert + total
        End If
        If chkCarmel.Checked = True Then
            lblResult.Text &= ", and Carmel"
            Total = dblCarmel + total
        End If
        If chkHotFudge.Checked = True Then
            lblResult.Text &= ", and Hot fudge"
            Total = dblHotFudge + total
        End If
        If chkSprinkles.Checked = True Then
            lblResult.Text &= ", and Sprinkles"
            Total = dblSprinkles + total
        End If
        If chkWhipCream.Checked = True Then
            lblResult.Text &= ", and Whip Cream"
            Total = dblWhipCream + total
        End If

        If rdExtraScoop.Checked = True Then
            lblResult.Text &= ", and Extra Scoop"
            Total = dblExtraScoop + total
        ElseIf rdCandyBar.Checked = True Then
            lblResult.Text &= ", and Candy Bar"
            Total = dblCandyBar + total
        ElseIf rdCookie.Checked = True Then
            lblResult.Text &= ", and Cookie"
            Total = dblCookie + total
        End If
        lblTotal.Text = Total.ToString("c")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
