Public Class Car
    
#region "Fields"
    Private _engineType As EngineType
    Private _hasAbs As Boolean
    Private _hasRegulator As Boolean
#end Region

#region "Public methods"
    Public Sub StartEngine()
        If EngineType.Thermical
            Warmup()
        Else If EngineType.Electrical
            CheckBatteryLevel()
        End If
    End Sub
    
    Public Sub StopEngine()
        If EngineType.Thermical
            StartCoolingFan()
        End If
    End Sub
    
    Public Sub Accelerate(amount As Double)
        If _hasRegulator
            DisableRegulator()
        End If
    End Sub
    
    Public Sub Brake()
        If _hasAbs Then
            ActivateAbs()
        End If
    End Sub
 #end Region

 #region "Private methods"
    Private Sub CheckBatteryLevel()
        ' whatever
    End Sub

    Private Sub StartCoolingFan()
        Throw New NotImplementedException
    End Sub

    Private Sub Warmup()
        'do stuff
    End Sub

    Private Sub DisableRegulator()
    End Sub

    Private Sub ActivateAbs()
        ' do stuff
    End Sub
#end Region  
  
End Class

Friend Enum EngineType
    Thermical
    Electrical
End Enum
