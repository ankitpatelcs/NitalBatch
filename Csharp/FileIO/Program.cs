using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class MyClass
    {
        internal void WriteData(string file)
        {
            StreamWriter sw = File.CreateText(file);
            Console.Write("Enter Data: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("\nFile Write Success.");
        }
        internal void ReadData(string file)
        {
            StreamReader sr= File.OpenText(file);
            Console.WriteLine("Content From File: ");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("File Read Success.");
        }
        internal void AppendData(string file)
        {
            StreamWriter sw = File.AppendText(file);
            Console.Write("Enter Data to Append: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("\nFile Append Success.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Ankit Patel\Aayush.txt";
            MyClass m = new MyClass();
            m.WriteData(file);
            m.ReadData(file);

            m.AppendData(file);
            m.ReadData(file);

            Console.Read();
        }
    }
}
