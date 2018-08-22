Imports Animals

<TestClass>
Public Class AlienTest
    Inherits AnimalTest

    Protected Overrides Function CreateAnimal() As Animal
        Return New Alien("xyz12345")
    End Function
End Class