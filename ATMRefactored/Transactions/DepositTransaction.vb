Imports ATM

Public Class DepositTransaction
    Implements ITransaction

    Private ReadOnly _ui As IDepositUserInterface

    Public Sub New(ui As IDepositUserInterface)
        _ui = ui
    End Sub

    Public Sub Execute() Implements ITransaction.Execute
        _ui.RequestDepositAmount()
    End Sub
End Class