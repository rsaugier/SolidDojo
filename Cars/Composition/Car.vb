Imports Cars.Monolithic

Namespace Composition

    Public Class Car

#Region "Fields"
        Private ReadOnly _engine As IEngine
        Private ReadOnly _abs As IAntiBrakeSystem
        Private ReadOnly _speedRegulator As ISpeedRegulator
#End Region

#Region "Constructor"
        Public Sub New(engine As IEngine, abs As IAntiBrakeSystem, speedRegulator As ISpeedRegulator)
            If engine Is Nothing Then
                Throw New ArgumentNullException(NameOf(engine))
            End If

            _engine = engine
            _abs = abs
            _speedRegulator = speedRegulator
        End Sub
#End Region

#Region "Public methods"
        Public Sub StartEngine()
            Console.WriteLine("Starting engine!")
            Console.WriteLine("Displaying engine indicator")
            _engine.Start()
        End Sub

        Public Sub StopEngine()
            Console.WriteLine("Stoping engine!")
            _engine.Stop()
            Console.WriteLine("Hiding engine indicator")
        End Sub

        Public Sub Accelerate(amount As Double)
            _speedRegulator?.OnAccelerate()
            Console.WriteLine("Accelerating!")
        End Sub

        Public Sub Brake()
            _abs?.OnBraking()
            Console.WriteLine("Braking!")
        End Sub
#End Region

    End Class

End Namespace
