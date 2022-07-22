using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    public delegate void firstDelegate();
    public delegate string ReturnTypeDelegate(string name, int salary);
    class MyClass
    {
        public void display()
        {
            Console.WriteLine("Calling display Function");
        }
        public void show()
        {
            Console.WriteLine("Calling show Function");
        }

        public string GetData(string name, int salary)
        {
            return $"Employee name: {name}, Salary: {salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            firstDelegate del1 = new firstDelegate(m.display);

            //multicasting
            del1 += new firstDelegate(m.show);
            del1.Invoke();

            del1 -= new firstDelegate(m.display);
            del1.Invoke();

            Console.WriteLine("=========Second delegate=============");
            ReturnTypeDelegate del2 = new ReturnTypeDelegate(m.GetData);
            string data= del2("Nital",78900);
            Console.WriteLine(data);

            Console.Read();
        }
    }
}
