Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Public Class MyRectangle

    Public Sub New(x1 As Double, y1 As Double, x2 As Double, y2 As Double)
        Me.X1 = x1
        Me.Y1 = y1
        Me.X2 = x2
        Me.Y2 = y2
    End Sub

    Public Property X1 As Double
    Public Property Y1 As Double
    Public Property X2 As Double
    Public Property Y2 As Double

    Public ReadOnly Property Area() As Double
        Get
            Return Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1)
        End Get
    End Property

    Public ReadOnly Property Perimeter() As Double
        Get
            Return Math.Abs(X2 - X1) * 2 + Math.Abs(Y2 - Y1) * 2
        End Get
    End Property

    Public Sub Translate(deltaX As Double, deltaY As Double)
        X1 += deltaX
        X2 += deltaX
        Y1 += deltaY
        Y2 += deltaY
    End Sub

    Public Sub Draw(bmp As RenderTargetBitmap)
        Dim visual As New DrawingVisual()

        Using r = visual.RenderOpen()
            Dim pen As New Pen(Brushes.Red, 2.0)
            r.DrawLine(pen, New Point(X1, Y1), New Point(X2, Y1))
            r.DrawLine(pen, New Point(X1, Y1), New Point(X1, Y2))
            r.DrawLine(pen, New Point(X1, Y2), New Point(X2, Y2))
            r.DrawLine(pen, New Point(X2, Y2), New Point(X2, Y1))
        End Using

        bmp.Render(visual)
    End Sub

End Class
