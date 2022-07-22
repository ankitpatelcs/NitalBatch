using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aRRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter Array Values:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array Elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}",arr[i]);
            }

            Console.Read();
        }
    }
}
