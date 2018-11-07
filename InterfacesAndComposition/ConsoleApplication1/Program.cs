using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComposition
{
    class InterfacesComposition
    {
        static void Main(string[] args)
        {

            Person slow = new Person("John", "Smith", 23, new SlowRunner());
            Person fast = new Person("Ann", "Smith", 23, new FastRunner());
            Dog doggie = new Dog("Spot", new FastRunner());

            //Isa
            slow.sayHello();
            //Hasa
            slow.Run(5);

            //Isa
            fast.sayHello();
            //HasA
            fast.Run(5);

            //Isa
            doggie.sayHello();
            //HasA
            doggie.Run(5);
            Console.ReadKey();

        }
    }
}
