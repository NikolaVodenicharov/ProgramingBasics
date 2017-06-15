using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Triangle_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a =  ");
            double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter h =  ");
            double h = Double.Parse(Console.ReadLine());
            double AreaOfTriangle = (a * h) / 2;
            Console.WriteLine(Math.Round(AreaOfTriangle, 2));
        }
    }
}
