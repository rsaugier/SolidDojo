Imports System.Data.SqlClient

Module Main

    Public Sub Main()

        Using connec As New SqlConnection("Data Source=localhost; Initial Catalog=SolidDojo; Integrated Security=SSPI;")
            connec.Open()
            Dim repo As New EmployeeRepository(connec)
            repo.RecreateTable(connec)

            Console.WriteLine("Table created ... press a key!")
            Console.ReadKey()

            Dim joe As New Employee("Joe Duffy", 42)
            repo.Create(joe)

            Console.WriteLine("Joe created ... press a key!")
            Console.ReadKey()

            joe.Age = 43
            repo.Update(joe)

            Console.WriteLine("Joe is now 43 ... press a key!")
            Console.ReadKey()

            Dim joe2 As Employee = repo.Read(joe.Id)

            Console.WriteLine("Joe has been read : " & joe2.ToString)
            Console.WriteLine("Press a key!")
            Console.ReadKey()

            repo.Delete(joe.Id)

            Console.WriteLine("Joe has been deleted ...")
            Console.WriteLine("Press a key!")
            Console.ReadKey()
        End Using

    End Sub

End Module
