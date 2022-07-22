using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Dharmesh");
            ar.Add(20);
            ar.Add(56000.5);
            ar.Add('M');

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
