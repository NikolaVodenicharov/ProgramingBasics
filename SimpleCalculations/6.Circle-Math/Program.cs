using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Circle_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the radius of the circle, r = ");
            double r = Convert.ToDouble(Console.ReadLine());
            double AreaOfCircle = Math.PI * r * r;
            double PerimeterOfCirle = 2 * Math.PI * r;
            Console.WriteLine("Area of the circle is {0}", AreaOfCircle);
            Console.WriteLine("Perimeter of the circle is {0}", PerimeterOfCirle);
        }
    }
}
