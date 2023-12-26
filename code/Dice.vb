Public Class Dice
    ' This will be the blueprint of a general dice. When instantiated, it takes '
    ' as input the number of sides (N_Sides) of the dice. It has a method .Roll() that returns '
    ' the rolled dice result. '

    ' Declare variables '
    Public N_Sides As Integer

    ' Declare methods '
    Public Function Roll() As Integer
        Dim DiceResult As Integer = CInt(Math.Ceiling(Rnd() * N_Sides)) + 1
        Return DiceResult
    End Function

    ' Constructor '
    Public Sub New(newN_Sides As Integer)
        N_Sides = newN_Sides
    End Sub
End Class
