public class Student: Person {
    private string grade;
    private string school;

    public Student(string title,string name,string surname,string age,string grade,string allergy,string religion,string school)
    : base(title,name,surname,age,allergy,religion,false,"","") {
        this.grade = grade;
        this.school = school;
    }
}