Namespace Inheritance
    Public Class ElectricalCarWithSpeedRegulatorAndAbs
        Inherits ElectricalCarWithSpeedRegulator

        Protected Overrides Sub OnBrake()
            ActivateAbs()
            MyBase.OnBrake()
        End Sub

        Private Sub ActivateAbs()
            Console.WriteLine("activating ABS")
        End Sub

    End Class
End NameSpace