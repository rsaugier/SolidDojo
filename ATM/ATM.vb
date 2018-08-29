Public Class ATM

    Public Sub New()
        Dim ui As New ScreenUI
        Dim transaction As New DepositTransaction(ui)
        transaction.Execute()
    End Sub

End Class
