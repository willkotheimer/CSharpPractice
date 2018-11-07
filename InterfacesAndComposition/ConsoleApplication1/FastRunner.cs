using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComposition
{
    class FastRunner : IRun
    {
      public void Run(int distance)
        {
            Console.WriteLine("I run fast for {0} miles", distance);
        }
    }
}
