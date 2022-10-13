public class CurrStudent: Person {
    private string studentID;

    public CurrStudent(string title,string name,string surname,string studentID,string age,string allergy,string religion,bool isAdmin,string email,string pass)
    : base(title,name,surname,age,allergy,religion,isAdmin,email,pass) {
        this.studentID = studentID;
    }
}