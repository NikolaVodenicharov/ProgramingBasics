using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            //roof
            for (int r = 1; r <= ((n+1)/2); r++)
            {
                if (n % 2 == 1)
                {
                    for (int i = 1; i <= ((n+1)/2 - r); i++)
                    {
                        Console.Write("-");
                    }
                    for (int i = 1; i <= ((r*2) - 1); i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 1; i <= ((n + 1) / 2 - r); i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 1; i <= (n/2 - r); i++)
                    {
                        Console.Write("-");
                    }
                    for (int i = 1; i <= (r * 2); i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 1; i <= (n/2 - r); i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }

            //floor
            for (int r = 1; r <= (n/2); r++)
            {
                if (n % 2 == 1)
                {
                    Console.Write("|");
                    for (int i = 1; i <= (n - 2); i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }
                else
                {
                    Console.Write("|");
                    for (int i = 1; i <= (n - 2); i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
