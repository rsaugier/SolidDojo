Public Class CarBase

#region "Public methods"
    Public Sub StartEngine()
        DisplayEngineIndicator()
        OnStartupEngine()
    End Sub

    Public Sub StopEngine()
        OnStopEngine()
        HideEngineIndicator()
    End Sub

    Public Sub Accelerate(amount As Double)
        OnAccelerate()
    End Sub
    
    Public Sub Brake()
        OnBrake()
    End Sub

    Protected Overridable Sub OnBrake()
    End Sub
    
    Protected Overridable Sub OnAccelerate()
    End Sub
    
    Protected Overridable Sub OnStartupEngine()
    End Sub
    
    Protected Overridable Sub OnStopEngine()
    End Sub

#end Region

#region "Private methods"
    Private Sub DisplayEngineIndicator()
        Throw New NotImplementedException
    End Sub
    
    Private Sub HideEngineIndicator()
        Throw New NotImplementedException
    End Sub
#end Region  
  
End Class

