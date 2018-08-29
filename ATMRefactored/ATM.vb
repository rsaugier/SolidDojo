Public Class ATM

    Public Sub New()
        Dim ui As New ScreenUI
        Dim deposit As New DepositTransaction(ui)
        deposit.Execute()
        Dim withdrawal As New WithdrawalTransaction(ui)
        withdrawal.Execute()
        Dim transfer As New TransferTransaction(ui)
        transfer.Execute()
    End Sub

End Class
