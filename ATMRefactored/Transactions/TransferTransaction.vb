Imports ATM

Public Class TransferTransaction
    Implements ITransaction

    Private ReadOnly _ui As ITransferUserInterface

    Public Sub New(ui As ITransferUserInterface)
        _ui = ui
    End Sub

    Public Sub Execute() Implements ITransaction.Execute
        Throw New NotImplementedException()
    End Sub
End Class