﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionH
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                a = 10;
                b = 0;
                c = a / b;
                OverflowException ex = new OverflowException("Content Overflow");
                throw ex;
                //Console.WriteLine("lkjhfjskdflhjasfl");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
