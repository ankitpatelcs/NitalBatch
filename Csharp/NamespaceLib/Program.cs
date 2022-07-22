using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfo;

namespace NamespaceLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Display();

            Console.Read();
        }
    }
}
