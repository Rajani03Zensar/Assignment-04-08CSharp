using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringGenericCollections
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(string _fname, string _lname,int _age, string _city)
        {
            
            fname = _fname;
            lname = _lname;
            age = _age;
            city = _city;

        }
        public void DisplayPerson()
        {
            Console.WriteLine("Enter the details of the person in the order:");
            Console.WriteLine("Name:{0} {1}",fname,lname);
            Console.WriteLine("Age:{0}",age);
            Console.WriteLine("City:{0}",city);
        }

    }
    class ListAssignment
    {
        
        static void Main()
        {
            List<Person> person = new List<Person>();
            Person p1 = new Person("Will", "Smith", 36, "Amsterdam");
            Person p2 = new Person("David", "Jobb", 47, "Sydney");
            Person p3 = new Person("Prem","Gupta", 58, "Kolkata");
            Person p4 = new Person("Rajani", "Joshi", 22, "Jabalpur");
            Person p5 = new Person("Ratnesh", "Joshi", 19, "Kolhapur");
            person.Add(p1);
            person.Add(p2);
            person.Add(p3);
            person.Add(p4);
            person.Add(p5);

            foreach(Person p in person)
            {
                p.DisplayPerson();

            }

        }
    }
}
