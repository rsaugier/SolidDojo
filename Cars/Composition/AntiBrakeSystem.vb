Namespace Composition
    Public Class AntiBrakeSystem
        Implements IAntiBrakeSystem

        Public Sub OnBraking() Implements IAntiBrakeSystem.OnBraking
            Console.WriteLine("activating ABS")
        End Sub
    End Class
End NameSpace