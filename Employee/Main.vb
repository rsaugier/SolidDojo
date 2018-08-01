Imports System.Data.SqlClient

Module Main

    Public Sub Main()
        Dim connectionString = "Data Source=localhost; Initial Catalog=SolidDojo; Integrated Security=SSPI;"

        Using connec As New SqlConnection(connectionString)
            connec.Open()
            Employee.RecreateTable(connec)
        End Using

        Console.WriteLine("Table created ... press a key!")
        Console.ReadKey()

        Dim joe As New Employee("Joe Duffy", 42)
        Using connec As New SqlConnection(connectionString)
            connec.Open()
            joe.Create(connec)
            joe.Age = 42
            joe.Update(connec)
        End Using

        Console.WriteLine("Joe created ... press a key!")
        Console.ReadKey()

        Using connec As New SqlConnection(connectionString)
            connec.Open()
            joe.Age = 43
            joe.Update(connec)
        End Using

        Console.WriteLine("Joe is now 43 ... press a key!")
        Console.ReadKey()

        Dim joe2 As Employee
        Using connec As New SqlConnection(connectionString)
            connec.Open()
            joe2 = Employee.Read(connec, joe.Id)
        End Using

        Console.WriteLine("Joe has been read : " & joe2.ToString)
        Console.WriteLine("Press a key!")
        Console.ReadKey()

        Using connec As New SqlConnection(connectionString)
            connec.Open()
            Employee.Delete(connec, joe.Id)
        End Using

        Console.WriteLine("Joe has been deleted ...")
        Console.WriteLine("Press a key!")
        Console.ReadKey()
    End Sub

End Module
