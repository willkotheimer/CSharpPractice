using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> names = new MyStack<string>();
            //push adds to the back of the stack
            names.Push("Jack");
            names.Push("Bob");
            names.Push("Mary");

            // names.readList();

            //unshift adds to the front of the stack
            names.UnShift("Before names are below");
            names.UnShift("John");
            names.UnShift("Joan"); 

            while (!names.IsEmpty())
            {
                //shift takes from the front of the stack
                string name = names.Shift();
                Console.WriteLine(name);
            }
            Console.ReadKey();


        }
    }
}
