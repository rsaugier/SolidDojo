﻿Public Class WithdrawalTransaction
    Implements ITransaction

    Private ReadOnly _ui As IWithdrawalUserInterface

    Public Sub New(ui As IWithdrawalUserInterface)
        _ui = ui
    End Sub

    Public Sub Execute() Implements ITransaction.Execute
        Throw New NotImplementedException()
    End Sub

End Class