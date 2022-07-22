using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class MyClass
    {
        static internal int id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.id = 90;
        }
    }
}
