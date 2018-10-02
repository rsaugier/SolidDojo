Imports LowLevelInterface

Public Class LowLevelService
    Implements ILowLevelService
    Public Sub DoStuff() Implements ILowLevelService.DoStuff
        Throw New NotImplementedException
    End Sub
End Class