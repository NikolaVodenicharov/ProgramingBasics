using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", Name);
        }
    }
}
