using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string mobile { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid = 1, fname = "Nital", mobile = "6874586" });
            li.Add(new Employee { empid = 2, fname = "Aayush", mobile = "6874586" });
            li.Add(new Employee { empid = 3, fname = "Harshita", mobile = "6874586" });
            li.Add(new Employee { empid = 4, fname = "Narendra", mobile = "6874586" });

            foreach (var item in li)
            {
                Console.WriteLine("\nID: {0}",item.empid);
                Console.WriteLine("Name: {0}",item.fname);
                Console.WriteLine("Mobile: {0}",item.mobile);
            }

            Console.Read();
        }
    }
}
