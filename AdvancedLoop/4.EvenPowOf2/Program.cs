using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EvenPowOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n/2; i++)
            {
                Console.WriteLine(num);
                num = num* 4;
            }
        }
    }
}
