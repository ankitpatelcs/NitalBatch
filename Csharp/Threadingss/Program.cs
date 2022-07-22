using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threadingss
{
    class MyClass
    {
        public void display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\tThread: {0} : {1}",Thread.CurrentThread.Name,i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Parent Thread";
            MyClass m = new MyClass();

            Thread t = new Thread(new ThreadStart(m.display));
            t.Name = "Child Thread";
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: {0} : {1}", Thread.CurrentThread.Name, i);
            }

            Console.Read();
        }
    }
}
