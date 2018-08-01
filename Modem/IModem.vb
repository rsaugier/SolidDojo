Public Interface IModem
    Sub Dial(number As String)
    Sub Hangup()
    Sub Send(c As Char)
    Function Receive() As Char
End Interface
