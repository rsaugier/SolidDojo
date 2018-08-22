Imports Animals

Public Class Human
    Inherits Animal

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Function Digest(food As Food) As Double
        Return food.Calories * 0.75
    End Function

End Class