Public Class ScreenUI
    Implements IUserInterface

    Public Sub InformInsufficientFunds() Implements IWithdrawalUserInterface.InformInsufficientFunds
        Throw New NotImplementedException()
    End Sub

    Public Function RequestDepositAmount() As Decimal Implements IDepositUserInterface.RequestDepositAmount
        Throw New NotImplementedException()
    End Function

    Public Function RequestWithdrawalAmount() As Decimal Implements IWithdrawalUserInterface.RequestWithdrawalAmount
        Throw New NotImplementedException()
    End Function

    Public Function RequestTransferAmount() As Decimal Implements ITransferUserInterface.RequestTransferAmount
        Throw New NotImplementedException()
    End Function
End Class