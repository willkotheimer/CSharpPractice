using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAHasAClass
{
    class Student : Person
    {
        public String University { get; set; }
        public double AvgGrade { get; set;  }

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public override void sayHello()
        {
            Console.WriteLine("Hello I'm a student");
        }
    }
}
