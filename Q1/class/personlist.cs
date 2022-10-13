using System.Collections.Generic;
using System;
class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public bool findPersonName(string title,string name,string surname){
        foreach(Person person in this.personList) {
            if(person.GetTitle()==title&&person.GetName()==name&&person.GetSurame()==surname){
                return true;
            }
        }
        return false;
    }
    public bool findEmail(string mail){
        foreach(Person person in this.personList) {
            if (person.GetAdmin()){
                if(person is CurrStudent){
                    if(((CurrStudent)person).getEmail()==mail){return true;}
                }
                else if(person is Teacher){
                    if(((Teacher)person).getEmail()==mail){return true;}
                }
            }
        }
        return false;
    }
    public bool findEmail(string mail,string pass){
        foreach(Person person in this.personList) {
            if (person.GetAdmin()){
                if(person is CurrStudent){
                    if(((CurrStudent)person).getEmail()==mail&&((CurrStudent)person).getPassword()==pass){return true;}
                }
                else if(person is Teacher){
                    if(((Teacher)person).getEmail()==mail&&((Teacher)person).getPassword()==pass){return true;}
                }
            }
        }
        return false;
    }
    public void printAllcamper() {
        int teacher=0,student=0,currstudent=0,m4=0,m5=0,m6=0;
        foreach(Person person in this.personList) {
            if (person is Teacher) {teacher++;} 
            else if (person is Student) {
               student++;
               if(((Student)person).getGrade()=="M4"){m4++;}
               else if(((Student)person).getGrade()=="M5"){m5++;}
               else if(((Student)person).getGrade()=="M6"){m6++;}
            }
            else if (person is CurrStudent) {currstudent++;} 
        }

        Console.WriteLine("All Teachers is {0}",teacher);
        Console.WriteLine("All Students is {0}",student);
        Console.WriteLine("All Currunt Students is {0}",currstudent);
        Console.WriteLine("All M4 students is {0}",m4);
        Console.WriteLine("All M5 students is {0}",m5);
        Console.WriteLine("All M6 students is {0}",m6);
    }

    public void printName(int n){
          foreach(Person person in this.personList) {
            if (person is CurrStudent&&n==1) {
                Console.WriteLine("{0}{1} {2}",person.GetTitle(),person.GetName(),person.GetSurame());
            } 
            else if (person is Student&&n==2) {
                Console.WriteLine("{0}{1} {2}",person.GetTitle(),person.GetName(),person.GetSurame());
            } 
            else if (person is Teacher&&n==3) {
                Console.WriteLine("{0}{1} {2}",person.GetTitle(),person.GetName(),person.GetSurame());
            } 
        }
    }
}