namespace Students.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void student_is_dropout(){
        //Arrange
        var student = new ImmutableStudent(1, "Anders", "Arvesen", new DateTime(2020, 8, 28), new DateTime(2020, 9, 28), default);

        //Act

        //Assert
        Assert.Equal(Status.Dropout, student.Status);
    }

    [Fact]
    public void student_is_active(){
        //Arrange
        var student = new ImmutableStudent(1, "Anders", "Arvesen", new DateTime(2020, 8, 28),
        new DateTime(2023, 9, 28), default);

        //Act
        
        //Assert
        Assert.Equal(Status.Active, student.Status);
    }

    [Fact]
    public void student_is_new(){
        //Arrange
        var student = new ImmutableStudent(1, "Anders", "Arvesen", new DateTime(2023, 8, 28),
        new DateTime(2026, 9, 28), default);

        //Act
        
        //Assert
        Assert.Equal(Status.New, student.Status);
    }

    [Fact]

    public void toString_returns_all_properties(){
        //Arrange
        var student = new ImmutableStudent(1, "Anders", "Arvesen", new DateTime(2023, 8, 28),
        new DateTime(2026, 9, 28), default);

        //Act
        
        //Assert
        Assert.Equal("ImmutableStudent { Id = 1, GivenName = Anders, Surname = Arvesen, StartDate = 28.08.2023 00.00.00, EndDate = 28.09.2026 00.00.00, GraduationDate = 01.01.0001 00.00.00, Status = New }", student.ToString());
    }
}