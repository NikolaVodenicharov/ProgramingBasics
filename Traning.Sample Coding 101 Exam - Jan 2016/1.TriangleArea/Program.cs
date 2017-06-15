using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            double a = Math.Abs(Math.Max(x2, x3) - Math.Min(x2, x3));
            double h = Math.Abs(Math.Max(y1, y2) - Math.Min(y1, y2));
            Console.WriteLine((a*h)/2.0);
        }
    }
}
