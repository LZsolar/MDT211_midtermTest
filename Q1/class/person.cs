public abstract class Person {
    private string title;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;
    private bool isAdmin;
    private string mail;
    private string pass;

    public Person(string title,string name,string surname,string age,string allergy,string religion,bool isAdmin,string mail,string pass) {
        this.title = title;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
        this.isAdmin = isAdmin;
        this.mail = mail;
        this.pass = pass;
    }
    public string GetTitle() {
        return this.title;
    }

    public string GetName() {
        return this.name;
    }
    public string GetSurame() {
        return this.surname;
    }

    public bool adminStatus() {
        return this.isAdmin;
    }
    public string GetEmail() {
        return this.mail;
    }
    public string GetPassword() {
        return this.pass;
    }
}