using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Rectangle_Abs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double a = x1 - x2;
            double b = y1 - y2;
            //a = Math.Max(x1, x2) - Math.Min(x1, x2);
            //b = Math.Max(y1, y2) - Math.Min(x1, x2);

            double PerimeterOfRectangle = (Math.Abs(a) + Math.Abs(b)) * 2;
            double AreaOfRectangle = Math.Abs(a * b);

            Console.WriteLine("The area of rectangle is {0}", AreaOfRectangle);
            Console.WriteLine("The perimeter of rectangle is {0}", PerimeterOfRectangle);
        }
    }
}
