Class MainWindow

    Protected Overrides Sub OnInitialized(e As EventArgs)
        MyBase.OnInitialized(e)
        DataContext = New MainWindowViewModel()
    End Sub

End Class
