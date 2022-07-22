using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(25);
            li.Add(36);
            li.Add(98);
            li.Add(71);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
