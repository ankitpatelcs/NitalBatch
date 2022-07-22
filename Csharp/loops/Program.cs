using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====While loop=====");
            int i = 5;
            while (i<5)
            {
                Console.WriteLine("While-loop: {0}",i);
                i++;
            }

            Console.WriteLine("=====Do-While loop=====");
            i = 5;
            do
            {
                Console.WriteLine("Do-While-loop: {0}", i);
                i++;
            } while (i < 5);

            Console.WriteLine("=====for-loop=====");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("for-loop: "+i);
            }

            Console.Read();
        }
    }
}
