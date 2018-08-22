Imports Animals

Public Class Alien
    Inherits Animal

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Sub Eat(food As Food)
        Stamina += Digest(food)
    End Sub

    Public Overrides Function Digest(food As Food) As Double
        Return food.Calories * 42
    End Function
End Class