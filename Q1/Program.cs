using System;
using System.Collections.Generic;

class Program
{
    static PersonList personList;
    static bool isLogin;
    public static void Main(string[] args)
    {
       isLogin = false;
        Console.Clear();
        Program.personList = new PersonList();
        checkLoginStatus();
    }
//-----------------------------------------MENU ZONE---------------[UnFin]
    public static void noLoginMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Idia CAMP 2022");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show all camper");
        Console.WriteLine("3 for Log in");
        Console.WriteLine("4 for Exit");

        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: {registerMenu();break;}
            case 2: {showAllCamper();break;}
            case 3: {loginMenu(); break;} 
            case 4: break;
            default:{Console.WriteLine("Error Command not found."); noLoginMenu();break;}
        }
    }
    public static void LoginMenu(){
        Console.Clear();
        Console.WriteLine("Welcome ADMIN!");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show all current students");
        Console.WriteLine("3 for Show all students");
        Console.WriteLine("4 for Show all teachers");
        Console.WriteLine("5 for log out");

        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: {registerMenu();break;}
            case 2: {printCamper(1);break;}
            case 3: {printCamper(2);break;} 
            case 4: {printCamper(3);break;} 
            case 5: {logoutMenu(); break;}
            default:{Console.WriteLine("Error Command not found."); noLoginMenu();break;}
        }
    }
    public static void checkLoginStatus(){
        if(isLogin){LoginMenu();}
        else{noLoginMenu();}
    }
//-----------------------------------------REGISTER ZONE---------------[Fin..For now]
    public static void registerMenu(){
        Console.Clear();
        Console.WriteLine("Please choose your type");
        Console.WriteLine("1 for Currunt student");
        Console.WriteLine("2 for Student");
        Console.WriteLine("3 for Teacher");

        int x = int.Parse(Console.ReadLine());
        if(x==1){InputNewCurrentStudent();}
        if(x==2){InputNewStudent();}
        if(x==3){InputNewTeacher();}
    }

    static void InputNewCurrentStudent() {
        Console.WriteLine("Register new Current student");
        Console.WriteLine("***************************");
        string title = selectTitle(); 
        Console.Write("Please input your name: ");
        string name = Console.ReadLine();
        Console.Write("Please input your surname: ");
        string surname = Console.ReadLine();
        
        if(personList.findPersonName(title,name,surname)){
            Console.WriteLine("************************");
            Console.WriteLine("User is already registered. Please try again.\n");
            Console.WriteLine("************************");
            InputNewCurrentStudent();
            return;
        }
        Console.Write("Please input your studentID: ");
        string studentID = Console.ReadLine();
        Console.Write("Please input your age: ");
        string age = Console.ReadLine();
        Console.Write("Please input your allergy: ");
        string allergy = Console.ReadLine();
        Console.Write("Please input your religion: ");
        string religion = Console.ReadLine();
        bool isAdmin=false;
        string mail ="",pass="";
        while(true){
            Console.WriteLine("Is you an Admin? (Y/N)");
            string x = Console.ReadLine();
            if(x=="Y"){isAdmin = true; break;}
            if(x=="N"){break;}
            Console.WriteLine("************************");
            Console.WriteLine("Error please try again\n");
            Console.WriteLine("************************");
        }
        if(isAdmin){
            Console.Write("Please input your Email: ");
            mail = Console.ReadLine();
            Console.Write("Please input your Password: ");
            pass = Console.ReadLine();
        }
        if(personList.findEmail(mail)){
            Console.WriteLine("************************");
            Console.WriteLine("Invalid email. Please try again.\n");
            Console.WriteLine("************************");
            InputNewCurrentStudent();
            return;
        }
            
        CurrStudent currstudent = new CurrStudent(title,name,surname,studentID,age,allergy,religion,isAdmin,mail,pass);

        Program.personList.AddNewPerson(currstudent);
                
        checkLoginStatus();
    }

    static void InputNewStudent() {
        Console.WriteLine("Register new Student");
        Console.WriteLine("***************************");
        string title = selectTitle(); 
        Console.Write("Please input your name: ");
        string name = Console.ReadLine();
        Console.Write("Please input your surname: ");
        string surname = Console.ReadLine();
        
        if(personList.findPersonName(title,name,surname)){
            Console.WriteLine("************************");
            Console.WriteLine("User is already registered. Please try again.\n");
            Console.WriteLine("************************");
            InputNewStudent();
            return;
        }
        string grade = selectGrade();
        Console.Write("Please input your age: ");
        string age = Console.ReadLine();
        Console.Write("Please input your allergy: ");
        string allergy = Console.ReadLine();
        Console.Write("Please input your religion: ");
        string religion = Console.ReadLine();
        Console.Write("Please input your school: ");
        string school = Console.ReadLine();
            
        Student student = new Student(title,name,surname,age,grade,allergy,religion,school);

        Program.personList.AddNewPerson(student);
                
        checkLoginStatus();
    }

    static void InputNewTeacher() {
        Console.WriteLine("Register new Teacher");
        Console.WriteLine("***************************");
        string title = selectTitle(); 
        Console.Write("Please input your name: ");
        string name = Console.ReadLine();
        Console.Write("Please input your surname: ");
        string surname = Console.ReadLine();
        
        if(personList.findPersonName(title,name,surname)){
            Console.WriteLine("************************");
            Console.WriteLine("User is already registered. Please try again.\n");
            Console.WriteLine("************************");
            InputNewTeacher();
            return;
        }
        Console.Write("Please input your age: ");
        string age = Console.ReadLine();
        string position = selectPosition();
        Console.Write("Please input your allergy: ");
        string allergy = Console.ReadLine();
        Console.Write("Please input your religion: ");
        string religion = Console.ReadLine();

        string car="";
        while(true){
            Console.WriteLine("Bring car? (Y/N)");
            string x = Console.ReadLine();
            if(x=="Y"){
                Console.Write("Please input car number: ");
                car = Console.ReadLine(); break;}
            if(x=="N"){break;}
            Console.WriteLine("************************");
            Console.WriteLine("Error please try again\n");
            Console.WriteLine("************************");
        }

        bool isAdmin=false;
        string mail ="",pass="";
        while(true){
            Console.WriteLine("Is you an Admin? (Y/N)");
            string x = Console.ReadLine();
            if(x=="Y"){isAdmin = true; break;}
            if(x=="N"){break;}
            Console.WriteLine("************************");
            Console.WriteLine("Error please try again\n");
            Console.WriteLine("************************");
        }
        if(isAdmin){
            Console.Write("Please input your Email: ");
            mail = Console.ReadLine();
            Console.Write("Please input your Password: ");
            pass = Console.ReadLine();
        }
        if(personList.findEmail(mail)){
            Console.WriteLine("************************");
            Console.WriteLine("Invalid email. Please try again.\n");
            Console.WriteLine("************************");
            InputNewTeacher();
            return;
        }
            
        Teacher teacher = new Teacher(title,name,surname,age,position,allergy,religion,car,isAdmin,mail,pass);

        Program.personList.AddNewPerson(teacher);
                
        checkLoginStatus();
    }
//-----------------------------------------REGISTER COMMAND ZONE---------------[FIN]
    static string selectTitle(){
        Console.WriteLine("Please choose your Title");
        Console.WriteLine("1 for Mr.");
        Console.WriteLine("2 for Ms.");
        Console.WriteLine("3 for Mrs.");
        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: return "Mr.";
            case 2: return "Ms.";
            case 3: return "Mrs.";
            default: {
                Console.WriteLine("************************");
                Console.WriteLine("Error,Please Try again\n"); 
                Console.WriteLine("************************");
                return selectTitle();} 
        }
    }

    static string selectReligion(){
        Console.WriteLine("*********************");
        Console.WriteLine("Please choose your Religion");
        Console.WriteLine("1 for Buddhism");
        Console.WriteLine("2 for Christianity");
        Console.WriteLine("3 for Islam");
        Console.WriteLine("4 for Other");
        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: return "Buddhism";
            case 2: return "Christianity";
            case 3: return "Islam";
            default: {Console.Write("Please input your religion: "); return Console.ReadLine();} 
        }
    }

    static string selectGrade(){
        Console.WriteLine("Please choose your Grade");
        Console.WriteLine("1 for M4");
        Console.WriteLine("2 for M5");
        Console.WriteLine("3 for M6");
        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: return "M4";
            case 2: return "M5";
            case 3: return "M6";
            default: {
                Console.WriteLine("************************");
                Console.WriteLine("Error,Please Try again\n"); 
                Console.WriteLine("************************");
                return selectGrade();} 
        }
    }

    static string selectPosition(){
        Console.WriteLine("Please choose your Title");
        Console.WriteLine("1 for Dean");
        Console.WriteLine("2 for Head of department");
        Console.WriteLine("3 for Permanent teacher");
        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: return "Dean";
            case 2: return "Head of department";
            case 3: return "Permanent teacher";
            default: {
                Console.WriteLine("************************");
                Console.WriteLine("Error,Please Try again\n"); 
                Console.WriteLine("************************");
                return selectPosition();} 
        }
    }
    //-----------------------------------------LOGIN ZONE---------------[FIN...For now]
    public static void loginMenu(){
        Console.WriteLine("Welcome to log in menu.");
        Console.WriteLine("You can type | exit | for return to main menu.");
        Console.Write("Please input email: ");
        string mail = Console.ReadLine();
        if(mail=="exit"){checkLoginStatus();return;}
        Console.Write("Please input password: ");
        string pass = Console.ReadLine();

        if(!personList.findEmail(mail)){
            Console.WriteLine("************************");
            Console.WriteLine("Incorrect email or password. Please try again.\n");
            Console.WriteLine("************************");
            loginMenu();
            return;
        }
        isLogin=true;
        checkLoginStatus();
    }
    public static void logoutMenu(){
        isLogin=false;
        checkLoginStatus();
    }
    //-----------------------------------------ข้อ1.4 ZONE---------------[UnTest]
    public static void showAllCamper(){
        personList.countAllPerson();
        Console.Write("Press Enter to continue.");
        Console.ReadLine();
        checkLoginStatus();
    }
    //-----------------------------------------ข้อ1.5-1.7 ZONE---------------[UnTest]
    public static void printCamper(int n){
        switch(n){
            case 1: {Console.WriteLine("----------List of current students--------");break;}
            case 2: {Console.WriteLine("--------------List of students------------");break;}
            case 3: {Console.WriteLine("--------------List of teachers------------");break;}
            default: break;
        }
        personList.printName(n);
        Console.WriteLine("------------------------------------------");
        Console.Write("Press Enter to continue.");
        Console.ReadLine();
        checkLoginStatus();
    }
}