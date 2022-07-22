using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    class MyClass<Type1,Type2>
    {
        Type1 id;
        Type2 name;
        public MyClass(Type1 i,Type2 n)
        {
            id = i;
            name = n;
        }

        internal void display()
        {
            Console.WriteLine("Value 1: {0}",id);
            Console.WriteLine("Value 2: {0}",name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int,string> m = new MyClass<int,string>(205,"Hrishikesh");
            m.display();

            MyClass<string, DateTime> m2 = new MyClass<string, DateTime>("Aayush",DateTime.Now);
            m2.display();

            Console.Read();
        }
    }
}
