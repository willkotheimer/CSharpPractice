using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVars
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            Firstname = firstName;
            Lastname = lastName;
            _age = age;
        }

        public ref int GetAge()
        {
            return ref _age;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} / {_age}";
        }

    }
}
