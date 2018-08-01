Imports Modem

Public Class Modem
    Implements IModem

    Public Sub Dial(number As String) Implements IModem.Dial
        Throw New NotImplementedException()
    End Sub

    Public Sub Hangup() Implements IModem.Hangup
        Throw New NotImplementedException()
    End Sub

    Public Sub Send(c As Char) Implements IModem.Send
        Throw New NotImplementedException()
    End Sub

    Public Function Receive() As Char Implements IModem.Receive
        Throw New NotImplementedException()
    End Function
End Class
