using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace InterfacesComposition
    {
        class Person : IRun
        {
            //Basic class with getters and setters, constructor, and static variable in C#;

            private readonly string _firstname;
            private readonly string _lastname;
            private IRun _runner;

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

            public Person(string firstName, string lastName, int age,IRun runner)
            {
                _firstname = firstName;
                _lastname = lastName;
                Age = age;
                _runner = runner;
            }

            public virtual void sayHello()
            {
                Console.WriteLine("My name is "+ Firstname + " " + Lastname +
                    ",age: " + Age);
        }

            public override string ToString()
            {
                return Firstname + " " + Lastname + ",age: " + Age;
            }

        public void Run(int distance)
        {
            _runner.Run(distance);
        }
    }
    }
