Imports Animals

Public Class Dog
    Inherits Animal

    Public Event HasWoofed As EventHandler

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Function Digest(food As Food) As Double
        If TypeOf (food) Is Chocolate Then
            Throw New InvalidOperationException("chocolate is poison for dogs!!!")
        Else
            Return food.Calories * 0.7
        End If
    End Function

    Public Sub Woof()
        RaiseEvent HasWoofed(Me, EventArgs.Empty)
    End Sub

End Class