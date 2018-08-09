Namespace Composition
    Class ThermicEngine
        Implements IEngine

        Public Sub Start() Implements IEngine.Start
            Warmup()
        End Sub

        Public Sub [Stop]() Implements IEngine.[Stop]
            StartCoolingFan()
        End Sub

        Private Sub StartCoolingFan()
            Console.WriteLine("Starting cooling fan")
        End Sub

        Private Sub Warmup()
            Console.WriteLine("Warming Up")
        End Sub
    End Class
End NameSpace