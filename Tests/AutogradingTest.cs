namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Contain_A_Method_Named_AddHobbies_That_Takes_A_Variable_Number_Of_Strings()
    {
        var person = new Person(firstName: "mary", lastName: "smith");

        person.AddHobbies("first");
        Assert.Single(person.Hobbies);

        person.AddHobbies("second", "third");
        Assert.Equal(3, person.Hobbies.Length);
    }
}
