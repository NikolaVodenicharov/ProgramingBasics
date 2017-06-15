using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 1;
            int num2 = 1;
            int num3 = 1;

            for (int i = 1; i < n; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine(num3);
        }
    }
}
