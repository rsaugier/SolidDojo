Imports System.Reflection
Imports Animals
Imports FakeItEasy

<TestClass()>
Public MustInherit Class AnimalTest

    Protected MustOverride Function CreateAnimal() As Animal

    <TestMethod()>
    Public Sub Animal_WhenEating_ShouldIncreaseItsStamina()
        ' arrange
        Dim animal = CreateAnimal()
        Dim oldStamina = animal.Stamina
        Dim food = A.Fake(Of Food)
        A.CallTo(Function() food.Calories).Returns(10.0)

        ' act
        animal.Eat(food)

        ' assert
        Assert.IsTrue(animal.Stamina >= oldStamina)
    End Sub

    <TestMethod()>
    Public Sub Animal_WhenEatingAnyFood_ShouldIncreaseItsStamina()
        Dim foodTypes = Assembly.GetAssembly(GetType(Food)).GetTypes().
            Where(Function(x) x.IsSubclassOf(GetType(Food)))

        For Each foodType In foodTypes
            ' arrange
            Dim animal = CreateAnimal()
            Dim oldStamina = animal.Stamina
            Dim food = Activator.CreateInstance(foodType)

            ' act
            animal.Eat(food)

            ' assert
            Assert.IsTrue(animal.Stamina >= oldStamina, "failed for type " & foodType.Name)
        Next

    End Sub

    <TestMethod()>
    Public Sub Animal_WhenEatingChocolate_ShouldIncreaseItsStamina()
        ' arrange
        Dim animal = CreateAnimal()
        Dim oldStamina = animal.Stamina
        Dim food = New Chocolate()

        ' act
        animal.Eat(food)

        ' assert
        Assert.IsTrue(animal.Stamina >= oldStamina)
    End Sub

    <TestMethod()>
    Public Sub Animal_WhenEating_ShouldRaiseHasEaten()
        ' arrange
        Dim animal = CreateAnimal()
        Dim food = A.Fake(Of Food)
        Dim eventRaised As Boolean
        AddHandler animal.HasEaten, Sub(sender, args) eventRaised = True

        'act
        animal.Eat(food)

        ' assert
        Assert.IsTrue(eventRaised, NameOf(animal.HasEaten) & " has not been raised")
    End Sub

End Class