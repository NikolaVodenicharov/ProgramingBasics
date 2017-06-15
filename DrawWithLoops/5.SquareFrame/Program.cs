using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                if (r == 1 || r == n)
                {
                    Console.Write("+");
                    for (int c = 1; c <= (n-2); c++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" +");
                }
                else if (r > 1 && r < n)
                {
                    Console.Write("|");
                    for (int c = 1; c <= (n-2); c++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
    }
}
