Namespace Inheritance

    Public Class ThermicCarWithSpeedRegulatorAndAbs
        Inherits ThermicCarWithSpeedRegulator

        Protected Overrides Sub OnBrake()
            ActivateAbs()
            MyBase.OnBrake()
        End Sub

        Private Sub ActivateAbs()
            Console.WriteLine("activating ABS")
        End Sub

    End Class
End Namespace