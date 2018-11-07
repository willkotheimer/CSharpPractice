using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComposition
{
    class Dog : IRun
    {
        public string Name { get; set; }

        private IRun _runner;

        public Dog(string name, IRun runner)
        {
            Name = name;
            _runner = runner;
        }

        public virtual void sayHello()
        {
            Console.WriteLine("I'm a dog, bark bark and my name is " + Name);
        }

        public void Run(int distance)
        {
            _runner.Run(distance);
        }
    }
}
