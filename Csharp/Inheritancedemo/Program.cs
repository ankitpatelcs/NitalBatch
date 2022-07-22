using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancedemo
{
    class Employee
    {
        int id;
        string name;
        protected void GetEmp()    // function definition
        {
            id = 90;
            name = "Aayush";
        }
        protected void Showdata()
        {
            Console.WriteLine("Name: " + name + ", ID: " + id);
        }
    }

    class Payroll : Employee
    {
        int salary;
        internal void getpayroll()
        {
            salary = 25000;
            GetEmp();
        }

        internal void showp()
        {
            Console.WriteLine(salary);
            Showdata();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.getpayroll();
            p.showp();

            Console.Read();

        }
    }
}
