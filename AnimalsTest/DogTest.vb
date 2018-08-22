Imports Animals
Imports FakeItEasy

<TestClass()>
Public Class DogTest
    Inherits AnimalTest

    Protected Overrides Function CreateAnimal() As Animal
        Return New Dog("Spark")
    End Function

    <TestMethod()>
    Public Sub Dog_WhenWoofing_ShouldRaiseHasWoofed()
        ' arrange
        Dim dog = New Dog("Rex")
        Dim eventRaised As Boolean
        AddHandler dog.HasWoofed, Sub(sender, args) eventRaised = True

        'act
        dog.Woof()

        ' assert
        Assert.IsTrue(eventRaised, NameOf(dog.HasWoofed) & " has not been raised")
    End Sub

End Class