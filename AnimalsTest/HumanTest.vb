Imports Animals

<TestClass()>
Public Class HumanTest
    Inherits AnimalTest

    Protected Overrides Function CreateAnimal() As Animal
        Return New Human("Jean Marcel")
    End Function

End Class