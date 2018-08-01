Imports System.Data.SqlClient

Public Class Employee

    Public Id As Guid
    Public Name As String
    Public Age As Integer

    Private Sub New()
    End Sub

    Public Sub New(name As String, age As Integer)
        Me.Id = Guid.NewGuid()
        Me.Name = name
        Me.Age = age
    End Sub

    Public Function HasExtraHolidays() As Boolean
        Return Age > 30
    End Function

    Public Sub Create(connection As SqlConnection)
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "INSERT INTO Employee VALUES (@id, @name, @age)"
        command.Parameters.AddWithValue("@id", Id)
        command.Parameters.AddWithValue("@name", Name)
        command.Parameters.AddWithValue("@age", Age)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Function Read(connection As SqlConnection, id As Guid) As Employee
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT Name, Age FROM Employee WHERE Id = @id"
        command.Parameters.AddWithValue("@id", id)
        Dim employee As New Employee()
        Using reader As SqlDataReader = command.ExecuteReader()
            reader.Read()
            employee.Id = id
            employee.Name = reader.GetString(0)
            employee.Age = reader.GetInt32(1)
        End Using
        Return employee
    End Function

    Public Sub Update(connection As SqlConnection)
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "UPDATE Employee SET Name = @name, Age = @age WHERE Id = @id"
        command.Parameters.AddWithValue("@id", Id)
        command.Parameters.AddWithValue("@name", Name)
        command.Parameters.AddWithValue("@age", Age)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub Delete(connection As SqlConnection, id As Guid)
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "DELETE Employee WHERE Id = @id"
        command.Parameters.AddWithValue("@id", id)
        command.ExecuteNonQuery()
    End Sub

    Public Shared Sub RecreateTable(connection As SqlConnection)
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL DROP TABLE Employee" & Environment.NewLine &
                              "CREATE TABLE Employee (Id UNIQUEIDENTIFIER NOT NULL, Name NVARCHAR(MAX) NOT NULL, Age Integer NOT NULL)"
        command.ExecuteNonQuery()
    End Sub

    Public Overrides Function ToString() As String
        Return "(Id : " & Id.ToString & " Name : " & Name & " Age : " & Age.ToString & ")"
    End Function

End Class
