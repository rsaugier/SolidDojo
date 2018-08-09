Namespace Composition
    Class ElectricalEngine
        Implements IEngine

        Public Sub Start() Implements IEngine.Start
            CheckBatteryLevel()
        End Sub

        Public Sub [Stop]() Implements IEngine.[Stop]
        End Sub

        Private Sub CheckBatteryLevel()
            Console.WriteLine("Checking battery level")
        End Sub
    End Class
End NameSpace