Public Class ThermicCar
    Inherits CarBase

    Protected Overrides Sub OnStartupEngine()
        Warmup()
    End Sub

    Protected Overrides Sub OnStopEngine()
        StartCoolingFan()
    End Sub

    Private Sub StartCoolingFan()
        ' do stuff
    End Sub
    
    Private Sub Warmup()
        ' do stuff
    End Sub
End Class