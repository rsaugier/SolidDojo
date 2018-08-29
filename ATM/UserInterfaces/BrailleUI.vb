Imports ATM

Public Class BrailleUI
    Implements IUserInterface

    Public Sub InformInsufficientFunds() Implements IUserInterface.InformInsufficientFunds
        Throw New NotImplementedException()
    End Sub

    Public Function RequestDepositAmount() As Decimal Implements IUserInterface.RequestDepositAmount
        Throw New NotImplementedException()
    End Function

    Public Function RequestWithdrawalAmount() As Decimal Implements IUserInterface.RequestWithdrawalAmount
        Throw New NotImplementedException()
    End Function

    Public Function RequestTransferAmount() As Decimal Implements IUserInterface.RequestTransferAmount
        Throw New NotImplementedException()
    End Function
End Class