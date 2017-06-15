using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number");
            int Number = int.Parse(Console.ReadLine());
            double Calculation = Number % 2;
            if (Calculation == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
