public class Teacher: Person {
    private string position;
    private string car;
    private Admin admin;

   public Teacher(string title,string name,string surname,string age,string position,string allergy,string religion,string car,bool isAdmin,string email,string pass)
    : base(title,name,surname,age,allergy,religion,isAdmin) {
        this.position = position;
        this.car = car;
        this.admin = new Admin(email,pass);
    }

    public string getEmail(){
        return this.admin.getEmail();
    }
}