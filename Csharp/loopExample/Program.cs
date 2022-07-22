using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.Write("Enter Limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                sum += i;
            }
            
            Console.WriteLine("Addition : {0}",sum);
            Console.Read();
        }
    }
}
