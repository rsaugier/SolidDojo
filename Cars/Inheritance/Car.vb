Namespace Inheritance

    Public MustInherit Class Car

#Region "Public methods"
        Public Sub StartEngine()
            Console.WriteLine("Displaying engine indicator")
            OnStartupEngine()
        End Sub

        Public Sub StopEngine()
            OnStopEngine()
            Console.WriteLine("Hiding engine indicator")
        End Sub

        Public Sub Accelerate(amount As Double)
            OnAccelerate()
            Console.WriteLine("Accelerating!")
        End Sub

        Public Sub Brake()
            OnBrake()
            Console.WriteLine("Braking!")
        End Sub

        Protected MustOverride Sub OnBrake()

        Protected MustOverride Sub OnAccelerate()

        Protected MustOverride Sub OnStartupEngine()

        Protected MustOverride Sub OnStopEngine()

#End Region

    End Class
End Namespace