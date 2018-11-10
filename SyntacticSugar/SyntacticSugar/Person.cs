using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticSugar
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public string FullName => $"{FirstName} {LastName}, Age: {Age}, Salary: {Salary}";

        public int _age;
        public double _salary;
        public int Age
        {
            get => _age;
            set => _age = value;
        }

      

        public Person() { }
        public Person(string firstName, string lastName, int _age, double _salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = _age;
            Salary = _salary;
        }
    }
}
