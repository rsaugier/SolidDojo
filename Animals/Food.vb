Public MustInherit Class Food
    Public ReadOnly Property Name As String
    Public Overridable ReadOnly Property Calories As Double

    Public Sub New(name As String, calories As Double)
        Me.Name = name
        Me.Calories = calories
    End Sub
End Class