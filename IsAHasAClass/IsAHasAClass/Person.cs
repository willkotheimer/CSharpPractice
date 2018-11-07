using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAHasAClass
{
    class Person
    {
        //Basic class with getters and setters, constructor, and static variable in C#;

        private readonly string _firstname;
        private readonly string _lastname;

        public static int minAge = 18;
        public static int maxAge = 70;

        public int Age { get; set; }

        private decimal _salary;

        public string Firstname
        {
            get
            {
                return _firstname;
            }

           
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }

           
        }


        public Person() { }

        public Person(string firstName, string lastName, int age, decimal salary = 44000)
        {
            _firstname = firstName;
            _lastname = lastName;
            Age = age;
            _salary = salary;
        }

    }
}
