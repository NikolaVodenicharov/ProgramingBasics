using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int MaxDiff1 = 0;
            int MaxDiff2 = 0;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            sum1 = num1 + num2;

            for (int i = 1; i <= (n-1); i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                sum2 = num1 + num2;
                MaxDiff2 = Math.Abs(sum1 - sum2);
                if (MaxDiff2 > MaxDiff1)
                {
                    MaxDiff1 = MaxDiff2;
                }
                sum1 = sum2;
            }
            if (MaxDiff1 == 0)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={MaxDiff1}");
            }
        }
    }
}
