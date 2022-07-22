using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 89,b=20,c;
            Console.Write("Enter A: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.Write("Addition of {0} and {1} is {2}",a,b,c);
            Console.Read();
        }
    }
}
