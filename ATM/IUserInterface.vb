Public Interface IUserInterface
    Function RequestDepositAmount() As Decimal
    Function RequestWithdrawalAmount() As Decimal
    Function RequestTransferAmount() As Decimal
    Sub InformInsufficientFunds()
End Interface