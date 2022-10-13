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
            if(person.adminStatus()&&person.GetEmail()==mail){
                return true;
            }
        }
        return false;
    }

    /*public void FetchPersonList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Student) {
                Console.WriteLine("Name {0} \n Type: Student \n", person.GetName());
            } else if (person is Teacher) {
                Console.WriteLine("Name {0} \n Type: Teacher \n", person.GetName());
            }
        }
    }*/
}