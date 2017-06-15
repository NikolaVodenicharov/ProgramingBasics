using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num2 == num1 + num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num3} + {num1} = {num2}");

                }
                else
                {
                    Console.WriteLine($"{num1} + {num3} = {num2}");

                }
            }
            else if (num3 == num1 + num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num2} + {num1} = {num3}");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {num3}");
                }
            }
            else if (num1 == num2 + num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num3} + {num2} = {num1}");
                }
                else
                {
                    Console.WriteLine($"{num2} + {num3} = {num1}");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
