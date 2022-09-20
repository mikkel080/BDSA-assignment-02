namespace Students;
public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, 
DateTime EndDate, DateTime GraduationDate){
    public Status Status {get => determineStatus();} 

    public Status determineStatus(){
        DateTime today = DateTime.Now;
        if (today < StartDate){
            return Status.New;
        }
        else if (today >= StartDate && today < EndDate){
            return Status.Active;
        }
        else if (today >= GraduationDate && GraduationDate != DateTime.MinValue){
            return Status.Graduated;
        }
        else if (today > EndDate && GraduationDate == DateTime.MinValue){
            return Status.Dropout;
        }
        return Status.Undetermined;
    }

    

}