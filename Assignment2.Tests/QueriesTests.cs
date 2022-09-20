namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void return_array_of_rowling_wizards_with_linq()
    {
        //Arrange
        
        //Act
        var result = Queries.LINQgetRowlingWizards();

        //Assert
        Assert.Equal(new string[]{"Harry Potter", "Dumbledore", "Voldemort"}, result);
    }

    [Fact]
    public void return_array_of_rowling_wizards_with_extensions()
    {
        //Arrange
        
        //Act
        var result = Queries.ExtensionGetRowlingWizards();

        //Assert
        Assert.Equal(new string[]{"Harry Potter", "Dumbledore", "Voldemort"}, result);
    }

    [Fact]
    public void return_year_of_first_darth_with_LINQ()
    {
        //Arrange
        
        //Act
        var result = Queries.LINQgetYearOfFirstSithLord();

        //Assert
        Assert.Equal(1977, result);
    }

    [Fact]
    public void return_year_of_first_darth_with_extensions()
    {
        //Arrange
        
        //Act
        var result = Queries.ExtensionGetYearOfFirstSithLord();

        //Assert
        Assert.Equal(1977, result);
    }

    [Fact]
    public void return_tuples_of_distinct_wizards_from_HP_with_LINQ()
    {
        //Arrange
        
        //Act
        var result = Queries.LINQgetHPWizardTuples();

        (string, int?)[] expected = {("Harry Potter", 1997),
            ("Dumbledore", 1997),
            ("Voldemort", 1997)};
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void return_tuples_of_distinct_wizards_from_HP_with_Extension()
    {
        //Arrange
        
        //Act
        var result = Queries.ExtensionsGetHPWizardTuples();

        (string, int?)[] expected = {("Harry Potter", 1997),
            ("Dumbledore", 1997),
            ("Voldemort", 1997)};
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void return_name_in_reverse_and_creator_in_reverse_group_by_creator()
    {
        //Arrange
        
        //Act
        var result = Queries.LINQGroupByNameInReverseThenCreator();

        string[] expected = {"Sauron", "Radagast", "Gandalf", "Voldemort", "Harry Potter", "Dumbledore", "Darth Vader", "Darth Maul"};
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        
        //Act
        var result = Queries.ExtensionGroupByNameInReverseThenCreator();

        string[] expected = {"Sauron", "Radagast", "Gandalf", "Voldemort", "Harry Potter", "Dumbledore", "Darth Vader", "Darth Maul"};
        //Assert
        Assert.Equal(expected, result);
    }

    
}
