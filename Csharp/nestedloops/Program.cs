using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedloops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" {0}",num);
                    num++;
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
