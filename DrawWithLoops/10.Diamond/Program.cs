using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part
            for (int r = 1; r <= ((n+1)/2); r++)
            {
                double outsideDash = ((n + 1) / 2) - r;
                double middleDash = n - 2 - 2*outsideDash;
                for (int i = 1; i <= outsideDash; i++)
                {
                    Console.Write("-");
                }
                if (middleDash < 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    for (int i = 1; i <= middleDash; i++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                }
                for (int i = 1; i <= outsideDash; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

            //down part
            for (int r = 1; r <= (n-1)/2; r++)
            {
                double outsideDash = r;
                double middleDash = n - 2 - 2 * outsideDash;
                for (int i = 1; i <= r; i++)
                {
                    Console.Write("-");
                }
                if (middleDash < 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    for (int i = 1; i <= middleDash; i++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                }
                for (int i = 1; i <= r; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

        }
    }
}
