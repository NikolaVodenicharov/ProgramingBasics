using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the amount of USD that you want to convert: ");
            double USD = Convert.ToDouble(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine(Math.Round(BGN, 2));
        }
    }
}
