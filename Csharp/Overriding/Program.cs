using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    abstract class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("Calling from Employee Class");
        }
    }
    class Payroll : Employee
    {
        override public void display()
        {
            Console.WriteLine("Calling from Payroll Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.display();

            Console.Read();
        }
    }
}
