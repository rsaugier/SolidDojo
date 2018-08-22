Namespace Inheritance

    Public Class ElectricalCar
        Inherits Car

        Protected Overrides Sub OnStartupEngine()
            CheckBatteryLevel()
        End Sub

        Protected Overrides Sub OnStopEngine()
        End Sub

        Protected Overrides Sub OnBrake()
        End Sub

        Protected Overrides Sub OnAccelerate()
        End Sub

        Private Sub CheckBatteryLevel()
            Console.WriteLine("Checking battery level")
        End Sub

    End Class
End Namespace