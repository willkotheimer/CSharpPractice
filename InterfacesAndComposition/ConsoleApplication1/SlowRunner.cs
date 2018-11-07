using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComposition
{
    class SlowRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine("I run slow for {0} miles", distance);
        }
    }
}
