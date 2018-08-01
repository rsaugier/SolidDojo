Public Class MainWindowViewModel

    Public ReadOnly Property ImageSource
    Private _bitmap As New RenderTargetBitmap(2000, 2000, 360, 360, PixelFormats.Pbgra32)

    Public Sub New()
        ImageSource = _bitmap
        Dim rect As New MyRectangle.MyRectangle(50, 50, 400, 200)
        rect.Draw(_bitmap)
    End Sub


End Class
