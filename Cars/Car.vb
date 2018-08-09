Public Class Car
    
    Private EngineType As EngineType
    
    Public Sub StartEngine()
        If EngineType.Thermical
            Warmup()
        End If
    End Sub
    
    Public Sub StopEngine()
        
    End Sub

    Private Sub Warmup()
        'do stuff
    End Sub
    
    Public Sub Accelerate(amount As Double)
        
    End Sub
    
    Public Sub SteerWheelToPosition(wheelPosition As Double)
        
    End Sub
    
    Public Sub Brake()
        
    End Sub
End Class

Friend Enum EngineType
    Thermical
    Electrical
End Enum
