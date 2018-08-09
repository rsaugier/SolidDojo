Namespace Composition
    Public Class SpeedRegulator
        Implements ISpeedRegulator

        Public Sub OnAccelerate() Implements ISpeedRegulator.OnAccelerate
            Console.WriteLine("disabling Speed Regulator")
        End Sub
    End Class
End NameSpace