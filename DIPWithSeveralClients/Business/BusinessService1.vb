Imports LowLevelInterface

Public Class BusinessService1

    Private ReadOnly _lowLevelService As ILowLevelService

    Public Sub New(lowLevelService As ILowLevelService)
        _lowLevelService = lowLevelService
    End Sub

    Public Sub DoStuff()
        _lowLevelService.DoStuff()
    End Sub

End Class
