Namespace Monolithic

    Public Class Car

#Region "Fields"
        Private _engineType As EngineType
        Private _hasAbs As Boolean
        Private _hasSpeedRegulator As Boolean
#End Region

#Region "Constructor"
        Public Sub New(engineType As EngineType, hasAbs As Boolean, hasSpeedRegulator As Boolean)
            _engineType = engineType
            _hasAbs = hasAbs
            _hasSpeedRegulator = hasSpeedRegulator
        End Sub
#End Region

#Region "Public methods"
        Public Sub StartEngine()
            Console.WriteLine("Starting engine!")
            Console.WriteLine("Displaying engine indicator")
            If _engineType = EngineType.Thermical Then
                Warmup()
            ElseIf _engineType = EngineType.Electrical Then
                CheckBatteryLevel()
            End If
        End Sub

        Public Sub StopEngine()
            Console.WriteLine("Stoping engine!")
            If EngineType.Thermical Then
                StartCoolingFan()
            End If
            Console.WriteLine("Hiding engine indicator")
        End Sub

        Public Sub Accelerate(amount As Double)
            If _hasSpeedRegulator Then
                DisableRegulator()
            End If
            Console.WriteLine("Accelerating!")
        End Sub

        Public Sub Brake()
            If _hasAbs Then
                ActivateAbs()
            End If
            Console.WriteLine("Braking!")
        End Sub
#End Region

#Region "Private methods"
        Private Sub CheckBatteryLevel()
            Console.WriteLine("Checking battery level")
        End Sub

        Private Sub StartCoolingFan()
            Console.WriteLine("Starting cooling fan")
        End Sub

        Private Sub Warmup()
            Console.WriteLine("Warming Up")
        End Sub

        Private Sub DisableRegulator()
            Console.WriteLine("disabling Speed Regulator")
        End Sub

        Private Sub ActivateAbs()
            Console.WriteLine("activating ABS")
        End Sub
#End Region

    End Class
End Namespace
