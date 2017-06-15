using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CelsiusToFahrenheitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the temperature in Celsius: ");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = ((Celsius * 9) / 5) + 32;
            Console.WriteLine(Fahrenheit);
        }
    }
}
