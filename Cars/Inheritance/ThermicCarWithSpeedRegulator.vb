Namespace Inheritance
    Public Class ThermicCarWithSpeedRegulator
        Inherits ThermicCar

        Protected Overrides Sub OnAccelerate()
            DisableRegulator()
            MyBase.OnAccelerate()
        End Sub

        Private Sub DisableRegulator()
            Console.WriteLine("disabling Speed Regulator")
        End Sub
    End Class
End Namespace