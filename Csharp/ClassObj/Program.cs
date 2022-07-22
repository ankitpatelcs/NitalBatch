using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObj
{
    class Employee
    {
        int id;
        string name;

        internal void GetEmp(int id,string name)    // function definition
        {
            this.id = id;
            this.name = name;
        }

        internal void Showdata()
        {
            Console.WriteLine("Name: " + name + ", ID: " + id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.GetEmp();   // function call
            obj.Showdata();

            Console.Read();
        }
    }
}
