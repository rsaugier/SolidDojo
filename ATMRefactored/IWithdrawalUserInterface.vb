Public Interface IWithdrawalUserInterface
    Function RequestWithdrawalAmount() As Decimal
    Sub InformInsufficientFunds()
End Interface