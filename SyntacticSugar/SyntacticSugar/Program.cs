using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticSugar
{
    class Program
    {


        static void Main(string[] args)
        {

            //Underscores useful for separators of numbers

            double number = 125_250.00;

            Person p = new Person("John", "Smith", 23,number);

            //Expression bodied method => found in Person class
            Console.WriteLine(p.FullName);
            

            //Program to show how we can use out variables with inline declarations in the signature
            calculate(8, 2, out int sum, out int diff);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Diff: {diff}");
            Console.ReadKey();



        }
        private static void calculate(int a,int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b; 
        }

        
    }
}
