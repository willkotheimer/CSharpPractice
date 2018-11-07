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
            
            Console.WriteLine("{0} {1} - age: {2}", person.Firstname, person.Lastname, person.Age);
           
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
            Console.ReadKey();
        }
    }
}
