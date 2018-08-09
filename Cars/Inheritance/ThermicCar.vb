Namespace Inheritance

    Public Class ThermicCar
        Inherits Car

        Protected Overrides Sub OnStartupEngine()
            Warmup()
        End Sub

        Protected Overrides Sub OnStopEngine()
            StartCoolingFan()
        End Sub

        Private Sub StartCoolingFan()
            Console.WriteLine("Starting cooling fan")
        End Sub

        Private Sub Warmup()
            Console.WriteLine("Warming Up")
        End Sub
    End Class
End Namespace