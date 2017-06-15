using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1;
            int num2;
            int sum1 = 1;
            int sum2 = 1;

            if (n > 1)
            {
                num1 = int.Parse(Console.ReadLine());

                for (int i = 0; i < n - 1; i++)
                {
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 > num1)
                    {
                        sum2++;
                    }
                    else if (num2 <= num1)
                    {
                        if (sum2 > sum1)
                        {
                            sum1 = sum2;
                        }
                        sum2 = 1;
                    }
                    num1 = num2;
                }
            }
            else if (n < 1)
            {
                sum1 = sum2 = 0;
            }   
            Console.WriteLine(Math.Max(sum1, sum2));
        }
    }
}
