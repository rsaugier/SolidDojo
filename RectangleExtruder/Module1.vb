Imports MyRectangle

Module Module1

    Sub Main()
        Dim X1 As Double, X2 As Double, Y1 As Double, Y2 As Double
        Console.WriteLine("Please enter X1:")
        X1 = Double.Parse(Console.ReadLine())
        Console.WriteLine("Please enter Y1:")
        Y1 = Double.Parse(Console.ReadLine())
        Console.WriteLine("Please enter X2:")
        X2 = Double.Parse(Console.ReadLine())
        Console.WriteLine("Please enter Y2:")
        Y2 = Double.Parse(Console.ReadLine())

        Dim rect As New MyRectangle.MyRectangle(X1, Y1, X2, Y2)
        Console.WriteLine("Perimeter: {0}", rect.Perimeter)
        Console.WriteLine("Area: {0}", rect.Area)
        Console.ReadKey()
    End Sub

End Module
