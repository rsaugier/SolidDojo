Public MustInherit Class Animal

    Public ReadOnly Property Name As String
    Public Property Stamina As Double
    Public Event HasEaten As EventHandler

    Public Sub New(name As String)
        Me.Name = name
        Me.Stamina = 50.0
    End Sub

    Public Overridable Sub Eat(food As Food)
        Stamina += Digest(food)
        RaiseEvent HasEaten(Me, EventArgs.Empty)
    End Sub

    Public MustOverride Function Digest(food As Food) As Double

End Class