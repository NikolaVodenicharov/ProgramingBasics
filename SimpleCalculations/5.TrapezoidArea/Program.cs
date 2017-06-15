using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter b1: ");
            double b1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double AreaOfTrapezoid = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area is: {0}", AreaOfTrapezoid);
        }
    }
}
