Namespace Inheritance
    Public Class ElectricalCarWithAbs
        Inherits ElectricalCar

        Protected Overrides Sub OnBrake()
            ActivateAbs()
            MyBase.OnBrake()
        End Sub

        Private Sub ActivateAbs()
            Console.WriteLine("activating ABS")
        End Sub

    End Class
End NameSpace