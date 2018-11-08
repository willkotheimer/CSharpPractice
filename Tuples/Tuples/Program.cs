using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = Tuple.Create("Tesla Model S", 75000, "USD");
            Console.WriteLine($"The name of this car is {car.Item1}");
            Console.WriteLine($"The price of this car is {car.Item2}");
            Console.WriteLine($"The currency of this car is {car.Item3}");
            Console.ReadKey();
        }

       

        
    }
}
