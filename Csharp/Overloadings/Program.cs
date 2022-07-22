using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadings
{
    class Shape
    {
        internal void area(float r)
        {
            Console.WriteLine("Area Of Circle: {0}", 3.14 * r * r);
        }
        internal void area(double a)
        {
            Console.WriteLine("Area Of Square: {0}", a * a);
        }
        internal void area(int l, int b)
        {
            Console.WriteLine("Area Of Rectangle: {0}", l * b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {           
            Shape s = new Shape();
            s.area(10);
            s.area(10.5);
            s.area(7,8);

            Console.Read();
        }
    }
}
