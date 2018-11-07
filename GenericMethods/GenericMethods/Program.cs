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
            names.Push("Jack");
            names.Push("Bob");
            names.Push("Mary");

            while(!names.IsEmpty())
            {
                string name = names.Pop();
                Console.WriteLine(name);
            }


            Console.ReadKey();


        }
    }
}
