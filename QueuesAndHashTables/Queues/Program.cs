using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesandHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queues");

            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach(Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("1st object dequeued: {0}",qt.Dequeue());

            Console.WriteLine("The queue now contains {0} elements", qt.Count);

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }

          

            Console.WriteLine("Now for the Hash/:");

            Hashtable ht = new Hashtable();

            ht.Add("000", ".Net");
            ht.Add("001", "C#");
            ht.Add("003", "Asp.Net");
            ICollection keys = ht.Keys;

            foreach(String k in keys)
            {
                Console.WriteLine($"{k}:{ht[k]}");
            }

            Console.ReadKey();
        }
    }
}
