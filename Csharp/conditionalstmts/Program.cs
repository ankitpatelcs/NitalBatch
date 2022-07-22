using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalstmts
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=80;
            // 1 4 8
            if (a>50)
            {
                if (a % 4 == 0)
                {
                    Console.WriteLine("A is >50 and divisible by 4");
                }
                else
                {
                    Console.WriteLine("A is >50 but NOT divisible by 4");
                }
            }
            else
            {
                Console.WriteLine("A is < 50");
            }

            Console.Read();
        }
    }
}
