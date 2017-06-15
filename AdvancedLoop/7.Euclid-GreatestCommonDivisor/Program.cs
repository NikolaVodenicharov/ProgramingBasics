using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Euclid_GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int divisor;

            do
            {
                divisor = a % b;
                if (divisor == 0)
                {
                    break;
                }
                a = b;
                b = divisor;
            } while (true);
            Console.WriteLine(b);
        }
    }
}
