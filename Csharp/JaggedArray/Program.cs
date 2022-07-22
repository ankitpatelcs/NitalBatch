using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 5,2,8,9 };
            arr[1] = new int[] { 7,4 };
            arr[2] = new int[] { 3,6,1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" {0}",arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
