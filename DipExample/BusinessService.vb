Public Class BusinessService

    Private ReadOnly _lowLevelService As LowLevelService

    Public Sub New()
        _lowLevelService = New LowLevelService()
    End Sub

    Public Sub DoStuff()
        _lowLevelService.DoStuff()
    End Sub

End Class
