using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)       //First and last row.
                {
                    for (int i = 0; i < (n*2); i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < (n * 2); i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (row > 1 && row < n)        //Middle rows.
                {
                    Console.Write("*");
                    for (int i = 0; i < (2*n - 2); i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    if (row == Math.Ceiling(n/2))     //Bridge.
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                    for (int i = 0; i < (2 * n - 2); i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
