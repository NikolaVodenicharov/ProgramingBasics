using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegreesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the radians fo conversion: ");
            double Radians = Double.Parse(Console.ReadLine());
            double Degrees = Radians * (180 / Math.PI);
            Console.WriteLine(Math.Round(Degrees,0));
        }
    }
}
