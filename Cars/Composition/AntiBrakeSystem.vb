Namespace Composition
    Public Class AntiBrakeSystem
        Implements IAntiBrakeSystem

        Public Sub OnBraking() Implements IAntiBrakeSystem.OnBraking
            Console.WriteLine("activating ABS")
        End Sub
    End Class

    Public Class NullBrakeSystem
        Implements IAntiBrakeSystem

        Public Sub OnBraking() Implements IAntiBrakeSystem.OnBraking
        End Sub
    End Class

End NameSpace