using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Smith", 24);
            int age = p.GetAge();
            ref int ageRef = ref p.GetAge();
            age++; //doesn't incrememt object p
            Console.WriteLine(p);
            ageRef++; //increments because it created a reference to the original
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
