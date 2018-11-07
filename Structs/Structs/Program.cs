using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates c = new Coordinates();
            c.Longtitude = 34.34564;
            c.Latitude = 56.43344;
            Console.WriteLine("Coordinates before: ({0},{1})", c.Latitude, c.Longtitude);
            changeCoordinates(c);
            Console.WriteLine("Coordinates after: ({0},{1})", c.Latitude, c.Longtitude);


            Console.ReadKey();
        }

        //Structs are pass by value not reference, so there is no change in above coords
        private static void changeCoordinates(Coordinates c)
        {
            c.Longtitude = 0;
            c.Latitude = 0;

        }
    }
}
