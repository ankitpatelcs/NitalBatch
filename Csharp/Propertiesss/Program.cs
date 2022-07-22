using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesss
{
    class MyClass
    {
        int id;
        public int Empid 
        {
            get 
            {
                return id;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            //m.Empid = 20;
            Console.WriteLine(m.Empid);

            Console.Read();
        }
    }
}
