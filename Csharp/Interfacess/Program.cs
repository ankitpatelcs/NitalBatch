using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    interface IEmployee
    {
        void display();
        void show();
    }
    class Employee : IEmployee
    {
        public void display()
        {
            Console.WriteLine("Calling Display Function");
        }

        public void show()
        {
            Console.WriteLine("Calling Show Function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee e = new Employee();
            e.display();
            e.show();

            Console.Read();
        }
    }
}
