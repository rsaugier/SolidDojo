Imports System.Data.SqlClient

Public Class Employee

    Public Id As Guid
    Public Name As String
    Public Age As Integer

    Public Sub New(name As String, age As Integer)
        Me.Id = Guid.NewGuid()
        Me.Name = name
        Me.Age = age
    End Sub

    Friend Sub New(id As Guid, name As String, age As Integer)
        Me.Id = id
        Me.Name = name
        Me.Age = age
    End Sub

    Public Function HasExtraHolidays() As Boolean
        Return Age > 30
    End Function

    Public Overrides Function ToString() As String
        Return "(Id : " & Id.ToString & " Name : " & Name & " Age : " & Age.ToString & ")"
    End Function

End Class
