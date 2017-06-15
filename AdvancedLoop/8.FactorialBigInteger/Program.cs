using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; //References > add references > Assemblies > Framework > numerics

namespace _8.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger sdgsdg = 0;

            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}
