Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click

        ' 1. Declare dice number of sides based on selected choice from the -Select dice- list '
        ' (This basically extrapolates the number from the name, e.g. 20 from d20) '
        Dim N_Sides As Integer = CInt(cbxDices.Text.Substring(1, cbxDices.Text.Length - 1))

        ' 2. Determine how many times the chosen dice should be rolled, based on value
        ' from the -Insert quantity- numeric updown. If the value is less than 1 the subroutine
        ' is stopped and an error messagebox appears.'
        Dim Times As Integer = nudQuantity.Value

        If Times < 1 Then
            MessageBox.Show("Please insert valid value (only whole numbers from 1 upwards", "Error")
            Return
        End If

        ' 3. Roll selected dice. If dice is rolled multiple times, the different results are summed.
        ' After that the bonus points are summed. '
        Dim diceresults As New List(Of Integer)
        Dim BonusPoints As Integer = nudBonus.Value

        For time As Integer = 1 To Times
            diceresults.Add(New Dice(N_Sides).Roll())
        Next

        Dim DiceResult As Integer = diceresults.Sum()

        ' Display result in the Result TextBox '
        txtResults.Text &= CStr(Times) & "x" & cbxDices.Text & " = " & CStr(DiceResult) &
            Environment.NewLine &
            "+ " & CStr(BonusPoints) & " bonus points = " & CStr(DiceResult + BonusPoints) &
            Environment.NewLine
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This button clears the Result TextBox '
        txtResults.Text = ""
    End Sub
End Class
