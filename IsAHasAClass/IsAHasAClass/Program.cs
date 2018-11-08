using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAHasAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John","Smith",50);

            Student std = new Student("Max", "Kellerman",21);
            std.University = "Harvard University";
            std.AvgGrade = 3.5;

            Console.WriteLine("{0} {1}, age:{2}",person.Firstname,person.Lastname, person.Age);
            Console.WriteLine(person);
           
            if(person.Age<Person.minAge)
            {
                Console.WriteLine("Not old enough");
            }else if(person.Age>Person.maxAge)
            {
                Console.WriteLine("Person is too old");
            } else
            {
                Console.WriteLine("Age is fine!");
            }

            std.sayHello();

            //If std is a student return "I am a student", if std is a person return "I'm a person"

            if(std is Student)
            {
                Console.WriteLine("{0} Is a student", std.Firstname);
            }

            if (std is Person)
            {
                Console.WriteLine("{0} Is a Person", std.Firstname);
            }
           
            Console.ReadKey();
        }
    }
}
