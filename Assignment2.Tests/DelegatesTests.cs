namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {
        //Arrange
        Action<string> reversePrint = (s) => {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));};

        //Act
        

        //Assert
        
        

    }

    [Fact]
    public void Test2()
    {
        //Arrange
        Func<decimal, decimal, decimal> product = (factor1, factor2) => factor1*factor2;

        //Act
        decimal result = product(5, 5);

        //Assert
        Assert.Equal(25, result);

    }

    [Fact]
    public void Test3()
    {
        //Arrange
        Func<string, int, bool> numEqual = (s, i) => int.TryParse(s, out i);

        //Act
        bool result = numEqual("5", 5);

        //Assert
        Assert.True(result);

    }
}
