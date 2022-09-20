namespace Students.Tests;

public class StudentTests
{
    [Fact]
    public void student_is_dropout(){
        //Arrange
        var student = new Student(){_Id = 1, _GivenName = "Anders", _Surname = "Arvesen", _StartDate = new DateTime(2020, 8, 28),
        _EndDate = new DateTime(2020, 9, 28)};

        //Act

        //Assert
        Assert.Equal(Status.Dropout, student._Status);
    }

    [Fact]
    public void student_is_active(){
        //Arrange
        var student = new Student(){_Id = 1, _GivenName = "Anders", _Surname = "Arvesen", _StartDate = new DateTime(2020, 8, 28),
        _EndDate = new DateTime(2023, 9, 28)};

        //Act
        
        //Assert
        Assert.Equal(Status.Active, student._Status);
    }

    [Fact]
    public void student_is_new(){
        //Arrange
        var student = new Student(){_Id = 1, _GivenName = "Anders", _Surname = "Arvesen", _StartDate = new DateTime(2023, 8, 28),
        _EndDate = new DateTime(2026, 9, 28)};

        //Act
        
        //Assert
        Assert.Equal(Status.New, student._Status);
    }

    [Fact]

    public void toString_returns_all_properties_except_graduation_date(){
        //Arrange
        var student = new Student(){_Id = 1, _GivenName = "Anders", _Surname = "Arvesen", _StartDate = new DateTime(2023, 8, 28),
        _EndDate = new DateTime(2026, 9, 28)};

        //Act
        
        //Assert
        Assert.Equal("ID: 1, Name: Anders Arvesen, Status: New, StartDate: 08.28.2023, EndDate: 09.28.2026", student.ToString());
    }

    [Fact]
    public void toString_returns_all_properties_plus_graduation_date(){
        //Arrange
        var student = new Student(){_Id = 1, _GivenName = "Anders", _Surname = "Arvesen", _StartDate = new DateTime(2023, 8, 28),
        _EndDate = new DateTime(2026, 9, 28), _GraduationDate = new DateTime(2026, 9, 28)};

        //Act
        
        //Assert
        Assert.Equal("ID: 1, Name: Anders Arvesen, Status: New, StartDate: 08.28.2023, EndDate: 09.28.2026, GraduationDate: 09.28.2026", student.ToString());


    }
}
