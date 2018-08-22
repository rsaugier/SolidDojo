Namespace Monolithic
    Public Class Client

        Public Sub TestDrive()
            Dim c = New Car(EngineType.Electrical, True, False)
            c.StartEngine()
            'c.StopEngine()
            c.Accelerate(15.0)
            c.Brake()
        End Sub

    End Class
End Namespace