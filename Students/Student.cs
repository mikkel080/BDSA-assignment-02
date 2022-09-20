namespace Students;
public class Student
{
    public int _Id
    { get; init; }
    public string _GivenName
    { get; set; }
    public string _Surname
    { get; set; }
    public Status _Status {get => determineStatus();} 
    public DateTime _StartDate
    { get; set; } 
    public DateTime _EndDate 
    { get; set; }
    public DateTime _GraduationDate
    { get; set; }

    public Status determineStatus(){
        DateTime today = DateTime.Now;
        if (today < _StartDate){
            return Status.New;
        }
        else if (today >= _StartDate && today < _EndDate){
            return Status.Active;
        }
        else if (today >= _GraduationDate && _GraduationDate != DateTime.MinValue){
            return Status.Graduated;
        }
        else if (today > _EndDate && _GraduationDate == DateTime.MinValue){
            return Status.Dropout;
        }
        return Status.Undetermined;
    }


    public override string ToString(){
        if (_GraduationDate == DateTime.MinValue){
            return $"ID: {_Id}, Name: {_GivenName} {_Surname}, Status: {_Status}, StartDate: {_StartDate.ToString("MM/dd/yyyy")}, EndDate: {_EndDate.ToString("MM/dd/yyyy")}";
        }
        return $"ID: {_Id}, Name: {_GivenName} {_Surname}, Status: {_Status}, StartDate: {_StartDate.ToString("MM/dd/yyyy")}, EndDate: {_EndDate.ToString("MM/dd/yyyy")}, GraduationDate: {_GraduationDate.ToString("MM/dd/yyyy")}";
    }
}