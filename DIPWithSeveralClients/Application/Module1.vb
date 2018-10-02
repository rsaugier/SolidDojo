Imports Business1
Imports Business2
Imports LowLevel

Module Module1

    Sub Main()
        Dim business1 As New BusinessService1(New LowLevelService)
        Dim business2 As New BusinessService2(New LowLevelService)
    End Sub

End Module
