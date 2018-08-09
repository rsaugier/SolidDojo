Namespace Inheritance

    Public Class Car

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

        Protected Overridable Sub OnBrake()
        End Sub

        Protected Overridable Sub OnAccelerate()
        End Sub

        Protected Overridable Sub OnStartupEngine()
        End Sub

        Protected Overridable Sub OnStopEngine()
        End Sub

#End Region

    End Class
End Namespace