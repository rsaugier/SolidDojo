Imports System.Data.SqlClient

Public Class EmployeeRepository

    Public ReadOnly Property Connection As SqlConnection

    Public Sub New(connection As SqlConnection)
        Me.Connection = connection
    End Sub

    Public Sub Create(employee As Employee)
        Dim command As New SqlCommand()
        command.Connection = Connection
        command.CommandText = "INSERT INTO Employee VALUES (@id, @name, @age)"
        command.Parameters.AddWithValue("@id", employee.Id)
        command.Parameters.AddWithValue("@name", employee.Name)
        command.Parameters.AddWithValue("@age", employee.Age)
        command.ExecuteNonQuery()
    End Sub

    Public Function Read(id As Guid) As Employee
        Dim command As New SqlCommand()
        command.Connection = Connection
        command.CommandText = "SELECT Name, Age FROM Employee WHERE Id = @id"
        command.Parameters.AddWithValue("@id", id)
        Using reader As SqlDataReader = command.ExecuteReader()
            reader.Read()
            Dim name As String = reader.GetString(0)
            Dim age As Integer = reader.GetInt32(1)
            Return New Employee(id, name, age)
        End Using
    End Function

    Public Sub Update(employee As Employee)
        Dim command As New SqlCommand()
        command.Connection = Connection
        command.CommandText = "UPDATE Employee SET Name = @name, Age = @age WHERE Id = @id"
        command.Parameters.AddWithValue("@id", employee.Id)
        command.Parameters.AddWithValue("@name", employee.Name)
        command.Parameters.AddWithValue("@age", employee.Age)
        command.ExecuteNonQuery()
    End Sub

    Public Sub Delete(id As Guid)
        Dim command As New SqlCommand()
        command.Connection = Connection
        command.CommandText = "DELETE Employee WHERE Id = @id"
        command.Parameters.AddWithValue("@id", id)
        command.ExecuteNonQuery()
    End Sub

    Public Sub RecreateTable(connection As SqlConnection)
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL DROP TABLE Employee" & Environment.NewLine &
                              "CREATE TABLE Employee (Id UNIQUEIDENTIFIER NOT NULL, Name NVARCHAR(MAX) NOT NULL, Age Integer NOT NULL)"
        command.ExecuteNonQuery()
    End Sub
End Class
