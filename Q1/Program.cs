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
        noLoginMenu();
    }
//-----------------------------------------MENU ZONE---------------[UnFin]
    public static void noLoginMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Idia CAMP 2022");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show camper");
        Console.WriteLine("3 for Log in");
        Console.WriteLine("Other for Exit");

        int x = int.Parse(Console.ReadLine());
        if(x==1){registerMenu();}
    }
    public static void LoginMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Idia CAMP 2022");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show camper");
        Console.WriteLine("3 for Log in");
        Console.WriteLine("Other for Exit");

        int x = int.Parse(Console.ReadLine());
        if(x==1){registerMenu();}
    }
//-----------------------------------------REGISTER ZONE---------------[UnFin]
    public static void registerMenu(){
        Console.Clear();
        Console.WriteLine("Please choose your type");
        Console.WriteLine("1 for Currunt student");
        Console.WriteLine("2 for Student");
        Console.WriteLine("3 for Teacher");

        int x = int.Parse(Console.ReadLine());
        if(x==1){InputNewCurrentStudent();}
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
            Console.WriteLine("Is you an Admin?");
            Console.Write("1 for Yes | 2 for No: ");
            int x = int.Parse(Console.ReadLine());
            if(x==1){isAdmin = true; break;}
            if(x==2){break;}
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
                
        if(isLogin){LoginMenu();}
        else{noLoginMenu();}
    }
//-----------------------------------------REGISTER COMMAND ZONE---------------
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
}