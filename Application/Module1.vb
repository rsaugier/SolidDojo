Imports Business
Imports LowLevel

Module Module1

    Sub Main()
        Dim business As New BusinessService(New LowLevelService)
        business.DoStuff()
    End Sub

End Module
