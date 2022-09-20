namespace Assignment2.Tests;

public class DelegatesTests
{
    void testDelegate(Delegate d)
    {
    }

    [Fact]
    public void reverse_given_string()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var toTest = "abcdefghijklmnopqrstuvxyz";

        //Act
        AnonymousFunctions.printReverse(toTest);

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("zyxvutsrqponmlkjihgfedcba");
    }

    [Fact]
    public void product_given_7_4_returns_28()
    {
        var output = AnonymousFunctions.product(7,4); 

        output.Should().Be(28);
    }

    [Fact]
    public void isEqual_given_0042_and_42_returns_true()
    {
        AnonymousFunctions.isEqual(" 0042", 42).Should().BeTrue();

    }

    [Fact]
    public void isEqual_returns_false()
    {
        AnonymousFunctions.isEqual(" 0041", 42).Should().BeFalse();

    }
}
