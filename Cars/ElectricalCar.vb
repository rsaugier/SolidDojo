Public Class ElectricalCar
    Inherits CarBase

    Protected Overrides Sub OnStartupEngine()
        CheckBatteryLevel()
    End Sub

    Protected Overrides Sub OnStopEngine()
        MyBase.OnStopEngine()
    End Sub
    
    Private Sub CheckBatteryLevel()
        ' do stuff
    End Sub
    
End Class