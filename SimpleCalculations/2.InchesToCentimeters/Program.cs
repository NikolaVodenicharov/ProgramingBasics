using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter the the inches that you want to convert, Inches = ");
            double Inches = double.Parse(Console.ReadLine());
            double CalculationInchesToCentimeters = Inches * 2.54;
            Console.WriteLine(CalculationInchesToCentimeters);
        }
    }
}
