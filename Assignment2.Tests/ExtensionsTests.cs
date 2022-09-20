namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_given_uri_returns_true()
    {
        //Arrange
        var uri = new Uri("https://learnit.itu.dk/my/");

        //Act
        var result = uri.IsSecure();

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsSecure_given_uri_returns_false()
    {
        //Arrange
        var uri = new Uri("http://www.google.com/");

        //Act
        var result = uri.IsSecure();

        //Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void WordCount_given_string_returns_7()
    {
        var toTest = "this is ,  a. string:; ; :; + which whould return 7";

        var result = toTest.WordCount();

        result.Should().Be(7);
    }
}
