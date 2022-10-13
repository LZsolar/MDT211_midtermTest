public class CurrStudent: Person {
    private string studentID;
    private Admin admin;
    public CurrStudent(string title,string name,string surname,string studentID,string age,string allergy,string religion,bool isAdmin,string email,string pass)
    : base(title,name,surname,age,allergy,religion,isAdmin) {
        this.studentID = studentID;
        this.admin =new Admin(email,pass);
    }

    public string getEmail(){
        return this.admin.getEmail();
    }

}