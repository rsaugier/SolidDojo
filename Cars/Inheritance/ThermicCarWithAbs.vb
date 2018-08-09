Namespace Inheritance
    Public Class ThermicCarWithAbs
        Inherits ThermicCar

        Protected Overrides Sub OnBrake()
            ActivateAbs()
            MyBase.OnBrake()
        End Sub

        Private Sub ActivateAbs()
            Console.WriteLine("activating ABS")
        End Sub

    End Class
End Namespace